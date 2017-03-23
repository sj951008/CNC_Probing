using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Version_1
{
    public partial class Form1 : Form
    {
        bool flagbtConnectStationClick = false;
        bool flagPositionRead = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void read_position()
        {
            serialPort.DiscardInBuffer();
            serialPort.NewLine = "\n";
            serialPort.WriteLine("M114");
            flagPositionRead = true;
            System.Threading.Thread.Sleep(100);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                flagbtConnectStationClick = !flagbtConnectStationClick;
                if (flagbtConnectStationClick == true)
                {
                    btConnect.Text = "Close";
                    serialPort.PortName = cbbComPort.SelectedItem.ToString();
                    serialPort.Open();
                    serialPort.NewLine = "\n";
                    serialPort.WriteLine("G91");
                    serialPort.WriteLine("G91");
                }
                else
                {
                    btConnect.Text = "Connect";
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string strName = null;
            saveFileDialog.Filter = "Comma Seperate Files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                strName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(strName, txtSave.Text);
                txtDirectory.Text = strName;
            }
        }

        private void btJogYPos_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.NewLine = "\n";
                serialPort.WriteLine("G91");
                string str = "G1 Y" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
                serialPort.WriteLine(str);
                System.Threading.Thread.Sleep(100);
                read_position();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btJogYNeg_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.NewLine = "\n";
                serialPort.WriteLine("G91");
                string str = "G1 Y-" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
                serialPort.WriteLine(str);
                System.Threading.Thread.Sleep(100);
                read_position();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btJogXPos_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.NewLine = "\n";
                serialPort.WriteLine("G91");
                string str = "G1 X" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
                serialPort.WriteLine(str);
                System.Threading.Thread.Sleep(100);
                read_position();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btJogXNeg_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.NewLine = "\n";
                serialPort.WriteLine("G91");
                string str = "G1 X-" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
                serialPort.WriteLine(str);
                System.Threading.Thread.Sleep(100);
                read_position();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.WriteLine("G28");
                System.Threading.Thread.Sleep(100);
                //read_position();
                txtXCurrentPos.Text = "0.00";
                txtYCurrentPos.Text = "0.00";
                txtZCurrentPos.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort_Received(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new System.IO.Ports.SerialDataReceivedEventHandler(serialPort_Received), new object[] { sender, e });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //error_handle();
                }
            }
            else
            {
                try
                {
                    serialPort.NewLine = "\n";
                    string strData = String.Empty;
                    //strData = serialPort.ReadLine();
                    strData = serialPort.ReadExisting();
                    if(flagPositionRead)
                    {
                        //strData = serialPort.ReadExisting();
                        flagPositionRead = false;
                        string[] split_newline = strData.Split(new char[] { 'o'});
                        //split_newline[0] = split_newline[0].Trim( new Char[] { 'Y', 'Z', 'E' } );
                        var charsToRemove = new string[] { "Y", "Z", "E" };
                        foreach (var c in charsToRemove)
                        {
                            split_newline[0] = split_newline[0].Replace(c, string.Empty);
                        }
                        /*byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(split_newline[0]);
                        char[] charArray = ASCIIEncoding.ASCII.GetChars(byteArray);*/

                        string[] split_space = split_newline[0].Split(new char[] { ':' });
                        if (split_space[0] == "X")
                        {
                            txtXCurrentPos.Text = split_space[1].ToString();
                            txtYCurrentPos.Text = split_space[2].ToString();
                            txtZCurrentPos.Text = split_space[3].ToString();
                            //txtSave.Text = split_newline[0];

                            txtPosX1.Text = txtXCurrentPos.Text;
                            txtPosX2.Text = txtXCurrentPos.Text;
                            txtPosX3.Text = txtXCurrentPos.Text;

                            txtPosY1.Text = txtYCurrentPos.Text;
                            txtPosY2.Text = txtYCurrentPos.Text;
                            txtPosY3.Text = txtYCurrentPos.Text;

                        }
                        //System.Threading.Thread.Sleep(1000);
                        /*
                        for (int i = 0; i < split_newline[0].Length; i++)
                        {
                            if (charArray[i] == 'X')
                            {

                            }
                        }*/
                    }                  
                    //textBox.Text += strData + "\r\n";
                }
                catch (Exception ex)
                {
                    if (ex.Message == "The operation has timed out.")
                    {
                        //textBox.Text = serialPort.ReadLine();
                    }

                    if (ex.Message == "Index was outside the bounds of the array.")
                    {
                        goto exit;
                    }
                    
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //error_handle();
                exit: ;//Do nothing
                }
            }
        }

        private void btJogZPos_Click(object sender, EventArgs e)
        {
            serialPort.NewLine = "\n";
            serialPort.WriteLine("G91");
            string str = "G1 Z" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
            serialPort.WriteLine(str);
            System.Threading.Thread.Sleep(100);
        }

        private void btJogZNeg_Click(object sender, EventArgs e)
        {
            serialPort.NewLine = "\n";
            serialPort.WriteLine("G91");
            string str = "G1 Z-" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
            serialPort.WriteLine(str);
            System.Threading.Thread.Sleep(100);
        }

        private void btSaveStage1_Click(object sender, EventArgs e)
        {
            txtPosX1.Enabled = false;
            txtPosY1.Enabled = false;
            txtPosT1.Enabled = false;

            txtSave.Text += "S1," + txtPosX1.Text + ',' + txtPosY1.Text + ',' + txtPosT1.Text + "\r\n";
        }

        private void btSaveStage2_Click(object sender, EventArgs e)
        {
            txtPosX2.Enabled = false;
            txtPosY2.Enabled = false;
            txtPosT2.Enabled = false;

            txtSave.Text += "S2," + txtPosX2.Text + ',' + txtPosY2.Text + ',' + txtPosT2.Text + "\r\n";
        }

        private void btSaveStage3_Click(object sender, EventArgs e)
        {
            txtPosX3.Enabled = false;
            txtPosY3.Enabled = false;
            txtPosT3.Enabled = false;

            txtSave.Text += "S3," + txtPosX3.Text + ',' + txtPosY3.Text + ',' + txtPosT3.Text + "\r\n";
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            string strName = null;
            string strData = null;
            openFileDialog.Filter = "Comma Seperate Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strName = openFileDialog.FileName;
                strData = System.IO.File.ReadAllText(strName);
            }
            string[] split_newline = strData.Split(new string[] { "\r\n" } , StringSplitOptions.RemoveEmptyEntries);
            string[] splitTemp = null;
            splitTemp = split_newline[0].Split(new char[] { ',' });
            txtPosX1.Text = splitTemp[1];
            txtPosY1.Text = splitTemp[2];
            txtPosT1.Text = splitTemp[3];

            splitTemp = null;
            splitTemp = split_newline[1].Split(new char[] { ',' });
            txtPosX2.Text = splitTemp[1];
            txtPosY2.Text = splitTemp[2];
            txtPosT2.Text = splitTemp[3];

            splitTemp = null;
            splitTemp = split_newline[2].Split(new char[] { ',' });
            txtPosX3.Text = splitTemp[1];
            txtPosY3.Text = splitTemp[2];
            txtPosT3.Text = splitTemp[3];
        }
    }
}
