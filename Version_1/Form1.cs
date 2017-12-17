using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Version_1
{
    public partial class Form1 : Form
    {
        bool flagbtConnectStationClick = false;
        bool flagPositionRead = false;
        bool blMovingTick = false;
        bool blMovingToggle = false;
        bool blWaitingToggle = false;
        int intMovingInterval = 0;
        int intMovingIntervalCount = 0;
        int intWaitingInterval = 0;
        bool flagTopDelay, flagMediumDelay, flagBottomDelay, flagMoving, flagWaiting, flagAutorun;
        
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
                    string[] split_newline = cbbComPort.SelectedItem.ToString().Split(new char[] { ',' });
                    serialPort.PortName = split_newline[0];
                    serialPort.Open();
                    serialPort.NewLine = "\n";
                    serialPort.WriteLine("G90");
                    //serialPort.WriteLine("G91");
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
                flagAutorun = false;
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

        private void btJogYNeg_Click(object sender, EventArgs e)
        {
            try
            {
                flagAutorun = false;
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

        private void btJogXPos_Click(object sender, EventArgs e)
        {
            try
            {
                flagAutorun = false;
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

        private void btJogXNeg_Click(object sender, EventArgs e)
        {
            try
            {
                flagAutorun = false;
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

        private void btHome_Click(object sender, EventArgs e)
        {
            try
            {
                backward();
                serialPort.WriteLine("G28");
                System.Threading.Thread.Sleep(100);
                read_position();
                //txtXCurrentPos.Text = "0.00";
                //txtYCurrentPos.Text = "0.00";
                //txtZCurrentPos.Text = "0.00";
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
                            if (!flagAutorun) //if operate in autorum mode loop is not execute
                            {
                                txtPosX0.Text = txtXCurrentPos.Text;
                                txtPosX1.Text = txtXCurrentPos.Text;
                                txtPosX2.Text = txtXCurrentPos.Text;
                                txtPosX3.Text = txtXCurrentPos.Text;

                                txtPosY0.Text = txtYCurrentPos.Text;
                                txtPosY1.Text = txtYCurrentPos.Text;
                                txtPosY2.Text = txtYCurrentPos.Text;
                                txtPosY3.Text = txtYCurrentPos.Text;

                                txtPosZ0.Text = txtZCurrentPos.Text;
                                txtPosZ1.Text = txtZCurrentPos.Text;
                                txtPosZ2.Text = txtZCurrentPos.Text;
                                txtPosZ3.Text = txtZCurrentPos.Text;     
                            }
                            
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
            flagAutorun = false;
            serialPort.NewLine = "\n";
            serialPort.WriteLine("G91");
            string str = "G1 Z" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
            serialPort.WriteLine(str);
            System.Threading.Thread.Sleep(100);
            read_position();
        }

        private void btJogZNeg_Click(object sender, EventArgs e)
        {
            flagAutorun = false;
            serialPort.NewLine = "\n";
            serialPort.WriteLine("G91");
            string str = "G1 Z-" + cbbResolution.SelectedItem.ToString() + " " + 'F' + txtFeedRate.Text;
            serialPort.WriteLine(str);
            System.Threading.Thread.Sleep(100);
            read_position();
        }

        private void btSaveStage0_Click(object sender, EventArgs e)
        {
            txtPosX0.Enabled = false;
            txtPosY0.Enabled = false;
            txtPosZ0.Enabled = false;
            //txtPosT0.Enabled = false;
            txtSave.Text += "S0," + txtPosX0.Text + ',' + txtPosY0.Text + ',' + txtPosZ0.Text+ "\r\n";
        }

        private void btSaveStage1_Click(object sender, EventArgs e)
        {
            txtPosX1.Enabled = false;
            txtPosY1.Enabled = false;
            txtPosZ1.Enabled = false;
            //txtPosT1.Enabled = false;
            txtSave.Text += "S1," + txtPosX1.Text + ',' + txtPosY1.Text + ',' + txtPosZ1.Text + "\r\n";
        }

        private void btSaveStage2_Click(object sender, EventArgs e)
        {
            txtPosX2.Enabled = false;
            txtPosY2.Enabled = false;
            txtPosZ2.Enabled = false;
           // txtPosT2.Enabled = false;
            txtSave.Text += "S2," + txtPosX2.Text + ',' + txtPosY2.Text + ',' + txtPosZ2.Text + "\r\n";
        }

        private void btSaveStage3_Click(object sender, EventArgs e)
        {
            txtPosX3.Enabled = false;
            txtPosY3.Enabled = false;
            txtPosZ3.Enabled = false;
            //txtPosT3.Enabled = false;
            txtSave.Text += "S3," + txtPosX3.Text + ',' + txtPosY3.Text + ',' + txtPosZ3.Text + "\r\n";
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
                txtDirectory.Text = strName;
                txtSave.Text = strData;
            }
            string[] split_newline = strData.Split(new string[] { "\r\n" } , StringSplitOptions.RemoveEmptyEntries);
            //string[] splitTemp = null;
            //splitTemp = split_newline[0].Split(new char[] { ',' });

            for(int i = 0; i < split_newline.Length; i++)
            {
                string[] splitTemp = split_newline[i].Split(new char[] { ',' });

                //reference stage data load
                if (splitTemp[0] == "S0")
                {
                    txtPosX0.Text = splitTemp[1];
                    txtPosY0.Text = splitTemp[2];
                    txtPosZ0.Text = splitTemp[3];
                    //txtPosT0.Text = splitTemp[4];
                }

                //stage 1 data load
                if (splitTemp[0] == "S1")
                {
                    txtPosX1.Text = splitTemp[1];
                    txtPosY1.Text = splitTemp[2];
                    txtPosZ1.Text = splitTemp[3];
                    //txtPosT1.Text = splitTemp[4];
                }

                //stage 2 data load
                if (splitTemp[0] == "S2")
                {
                    txtPosX2.Text = splitTemp[1];
                    txtPosY2.Text = splitTemp[2];
                    txtPosZ2.Text = splitTemp[3];
                    //txtPosT2.Text = splitTemp[4];
                }

                //stage 3 data load
                if (splitTemp[0] == "S3")
                {
                    txtPosX3.Text = splitTemp[1];
                    txtPosY3.Text = splitTemp[2];
                    txtPosZ3.Text = splitTemp[3];
                    //txtPosT3.Text = splitTemp[4];
                }
            }
           
            /*txtPosX1.Text = splitTemp[1];
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
             */
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> serialAvailable = new List<string>();
            //serialAvailable = FindComPorts();
            //PortInfo portInfo = new PortInfo();
            List<PortInfo> portInfo = new List<PortInfo>();
            portInfo = FindComPorts();
            for (int i = 0; i < portInfo.Count; i++)
            {
                cbbComPort.Items.Add(portInfo[i].Name + ", " + portInfo[i].Description);
            }
        }

        // Class to contain the port info.
        public class PortInfo
        {
            public string Name;
            public string Description;
        }

        // Method to prepare the WMI query connection options.
        public static ConnectionOptions PrepareOptions()
        {
            ConnectionOptions options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.Authentication = AuthenticationLevel.Default;
            options.EnablePrivileges = true;
            return options;
        }

        // Method to prepare WMI query management scope.
        public static ManagementScope PrepareScope(string machineName, ConnectionOptions options, string path)
        {
            ManagementScope scope = new ManagementScope();
            scope.Path = new ManagementPath(@"\\" + machineName + path);
            scope.Options = options;
            scope.Connect();
            return scope;
        }

        // Method to retrieve the list of all COM ports.
        public static List<PortInfo> FindComPorts()
        {
            List<PortInfo> portList = new List<PortInfo>();
            ConnectionOptions options = PrepareOptions();
            ManagementScope scope = PrepareScope(Environment.MachineName, options, @"\root\CIMV2");

            // Prepare the query and searcher objects.
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
            ManagementObjectSearcher portSearcher = new ManagementObjectSearcher(scope, objectQuery);

            using (portSearcher)
            {
                string caption = null;
                // Invoke the searcher and search through each management object for a COM port.
                foreach (ManagementObject currentObject in portSearcher.Get())
                {
                    if (currentObject != null)
                    {
                        object currentObjectCaption = currentObject["Caption"];
                        if (currentObjectCaption != null)
                        {
                            caption = currentObjectCaption.ToString();
                            if (caption.Contains("(COM"))
                            {
                                PortInfo portInfo = new PortInfo();
                                portInfo.Name = caption.Substring(caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty);
                                portInfo.Description = caption;
                                portList.Add(portInfo);
                            }
                        }
                    }
                }
            }
            return portList;
        }

        private void btAtRun_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("G90");
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.RunWorkerAsync();

            //backward 
        }

        private void backward()
        {
            //avoid crashing the oven.
            double backPos = double.Parse(txtFeedRate.Text) - 40.0;

            string str = "G0 Y-"+ backPos + 'F' + txtFeedRate.Text;
            serialPort.WriteLine(str);
            moving_indicator(Convert.ToString(20.000), Convert.ToString(0.000));
        }

        private bool moving_indicator(string destination, string Origin)
        {
            double distance = double.Parse(destination) - double.Parse(Origin);
            if (distance > 0)
            {
                double resolution = double.Parse(txtFeedRate.Text) / 60000.000;
                intMovingInterval = (int)(distance / resolution);
                Moving_Interval.Interval = intMovingInterval;
                Moving_Interval.Enabled = true;
                flagMoving = true;
            }
            else
            {
                flagMoving = false;
            }
 
            return true;
        }

        private int moving_delay(string destination, string Origin)
        {
            double distance = double.Parse(destination) - double.Parse(Origin);
            double resolution = double.Parse(txtFeedRate.Text) / 60000.000;
            return Math.Abs((int)(distance / resolution));
        }

        private bool waiting_indicator(int intInterval)
        {
            intWaitingInterval = intInterval;
            //Waiting_Interval.Interval = intInterval;
            Waiting_Interval.Enabled = true;
            flagWaiting = true;
            return true;
        }

        private void Moving_Tick(object sender, EventArgs e)
        {
            /*int intInterval100 = intMovingInterval / Moving_Interval.Interval;
            if (intMovingIntervalCount < intInterval100)
            {
                intMovingIntervalCount++;
                if(blMovingToggle) ovalMoving.FillColor = System.Drawing.Color.Black;
                else ovalMoving.FillColor = System.Drawing.Color.Red;

                blMovingToggle = !blMovingToggle;
            }

            if (intMovingIntervalCount > intInterval100)
            {
                intMovingIntervalCount = 0;
                ovalMoving.FillColor = System.Drawing.Color.Red;
                Moving_Interval.Enabled = false;
                flagMoving = false;
            }*/
            flagMoving = false;
            Moving_Interval.Enabled = false;

        }

        int intWaitingIntervalCount = 0;

        private void Waiting_Interval_Tick(object sender, EventArgs e)
        {
            int intInterval100 = intWaitingInterval / Waiting_Interval.Interval;
            if (intWaitingIntervalCount < intInterval100)
            {
                intWaitingIntervalCount++;
                //if (blWaitingToggle) //ovalWaiting.FillColor = System.Drawing.Color.LightSteelBlue;
                //else ovalWaiting.FillColor = System.Drawing.Color.Blue;

                blWaitingToggle = !blWaitingToggle;
            }

            if (intWaitingIntervalCount > intInterval100)
            {
                intMovingIntervalCount = 0;
                //ovalWaiting.FillColor = System.Drawing.Color.Blue;
                Waiting_Interval.Enabled = false;
                flagWaiting = false;
            }
        }

        /*private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            flagAutorun = true;
            //top position
            int intTopStageDelay = Int32.Parse(txtPosT3.Text);
            read_position();
            System.Threading.Thread.Sleep(10);

            serialPort.WriteLine("G1 X" + txtPosX3.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosX3.Text, txtXCurrentPos.Text);
            System.Threading.Thread.Sleep(moving_delay(txtPosX3.Text, txtXCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G1 Z" + txtPosZ3.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosZ3.Text, txtZCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
           // while (flagMoving) continue;

            serialPort.WriteLine("G1 Y" + txtPosY3.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosY3.Text, txtYCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            //while (flagMoving) continue;

            waiting_indicator(intTopStageDelay);
            //while (flagWaiting) continue;


            //Medium position
            int intMediumStageDelay = Int32.Parse(txtPosT1.Text);
            read_position();
            System.Threading.Thread.Sleep(10);

            serialPort.WriteLine("G1 X" + txtPosX1.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosX1.Text, txtXCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            while (flagMoving) continue;

            serialPort.WriteLine("G1 Z" + txtPosZ1.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosZ1.Text, txtZCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            while (flagMoving) continue;

            serialPort.WriteLine("G1 Y" + txtPosY1.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosY1.Text, txtYCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            while (flagMoving) continue;

            waiting_indicator(intMediumStageDelay);
            while (flagWaiting) continue;

            //Bottom position
            int intBottomStageDelay = Int32.Parse(txtPosT1.Text);
            read_position();
            System.Threading.Thread.Sleep(10);

            serialPort.WriteLine("G1 X" + txtPosX2.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosX2.Text, txtXCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            while (flagMoving) continue;

            serialPort.WriteLine("G1 Z" + txtPosZ2.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosZ2.Text, txtZCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            while (flagMoving) continue;

            serialPort.WriteLine("G1 Y" + txtPosY2.Text + " F" + txtFeedRate.Text);
            moving_indicator(txtPosY2.Text, txtYCurrentPos.Text);
            System.Threading.Thread.Sleep(10);
            while (flagMoving) continue;

            waiting_indicator(intMediumStageDelay);
            while (flagWaiting) continue;
            flagAutorun = false;
            
        }*/

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            flagAutorun = true;
            //top position
            //int intTopStageDelay = Int32.Parse(txtPosT3.Text);
            read_position();
            System.Threading.Thread.Sleep(100);

            serialPort.WriteLine("G0 X" + txtPosX3.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosX3.Text, txtXCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosX3.Text, txtXCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G0 Z" + txtPosZ3.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosZ3.Text, txtZCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosZ3.Text, txtZCurrentPos.Text));
            // while (flagMoving) continue;

            serialPort.WriteLine("G0 Y" + txtPosY3.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosY3.Text, txtYCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosY3.Text, txtYCurrentPos.Text));
            //while (flagMoving) continue;

            //waiting_indicator(intTopStageDelay);
            //while (flagWaiting) continue;

            MessageBox.Show("TOP", "Waiting", MessageBoxButtons.OK);


            //Medium position
            //int intMediumStageDelay = Int32.Parse(txtPosT1.Text);
            read_position();
            backward();
            System.Threading.Thread.Sleep(100);

            serialPort.WriteLine("G0 X" + txtPosX1.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosX1.Text, txtXCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosX1.Text, txtXCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G0 Z" + txtPosZ1.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosZ1.Text, txtZCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosZ1.Text, txtZCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G0 Y" + txtPosY1.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosY1.Text, txtYCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosY1.Text, txtYCurrentPos.Text));
            //while (flagMoving) continue;

            //waiting_indicator(intMediumStageDelay);
            //while (flagWaiting) continue;

            MessageBox.Show("Medium", "Waiting", MessageBoxButtons.OK);

            //Bottom position
            //int intBottomStageDelay = Int32.Parse(txtPosT1.Text);
            read_position();
            backward();
            System.Threading.Thread.Sleep(100);

            serialPort.WriteLine("G0 X" + txtPosX2.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosX2.Text, txtXCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosX2.Text, txtXCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G0 Z" + txtPosZ2.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosZ2.Text, txtZCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosZ2.Text, txtZCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G0 Y" + txtPosY2.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosY2.Text, txtYCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosY2.Text, txtYCurrentPos.Text));
            //while (flagMoving) continue;

            //waiting_indicator(intMediumStageDelay);
            //while (flagWaiting) continue;
            //flagAutorun = false;
            read_position();
            MessageBox.Show("Completed", "Completed", MessageBoxButtons.OK);
        }


        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btHome_Click(null, null);
        }

        private void btRef_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("G90");
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            read_position();
            backward();
            System.Threading.Thread.Sleep(100);

            serialPort.WriteLine("G0 X" + txtPosX0.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosX0.Text, txtXCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosX0.Text, txtXCurrentPos.Text));
            //while (flagMoving) continue;

            serialPort.WriteLine("G0 Z" + txtPosZ0.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosZ0.Text, txtZCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosZ0.Text, txtZCurrentPos.Text));
            // while (flagMoving) continue;

            serialPort.WriteLine("G0 Y" + txtPosY0.Text + " F" + txtFeedRate.Text);
            //moving_indicator(txtPosY0.Text, txtYCurrentPos.Text);
            //System.Threading.Thread.Sleep(moving_delay(txtPosY0.Text, txtYCurrentPos.Text));
            //while (flagMoving) continue;

            //waiting_indicator(intTopStageDelay);
            //while (flagWaiting) continue;
            read_position();
            MessageBox.Show("Reference", "Waiting", MessageBoxButtons.OK);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btHome_Click(null, null);
        }
    }
}
