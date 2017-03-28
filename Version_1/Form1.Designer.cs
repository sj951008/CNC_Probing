namespace Version_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxSerialPortSetup = new System.Windows.Forms.GroupBox();
            this.cbbComPort = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.txtXCurrentPos = new System.Windows.Forms.TextBox();
            this.lblXpos = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.txtYCurrentPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZCurrentPos = new System.Windows.Forms.TextBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.txtPosT1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btJogZNeg = new System.Windows.Forms.Button();
            this.btJogZPos = new System.Windows.Forms.Button();
            this.btJogXNeg = new System.Windows.Forms.Button();
            this.btJogXPos = new System.Windows.Forms.Button();
            this.btJogYNeg = new System.Windows.Forms.Button();
            this.txtFeedRate = new System.Windows.Forms.TextBox();
            this.btHome = new System.Windows.Forms.Button();
            this.lblFeedRate = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.btJogYPos = new System.Windows.Forms.Button();
            this.cbbResolution = new System.Windows.Forms.ComboBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.gbFirstStage = new System.Windows.Forms.GroupBox();
            this.btSaveStage1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosY1 = new System.Windows.Forms.TextBox();
            this.txtPosX1 = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSaveStage3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosY3 = new System.Windows.Forms.TextBox();
            this.txtPosX3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPosT3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSaveStage2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPosY2 = new System.Windows.Forms.TextBox();
            this.txtPosX2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPosT2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosZ3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPosZ1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPosZ2 = new System.Windows.Forms.TextBox();
            this.groupBoxSerialPortSetup.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbFirstStage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 250000;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_Received);
            // 
            // groupBoxSerialPortSetup
            // 
            this.groupBoxSerialPortSetup.Controls.Add(this.cbbComPort);
            this.groupBoxSerialPortSetup.Controls.Add(this.btConnect);
            this.groupBoxSerialPortSetup.Controls.Add(this.textBox);
            this.groupBoxSerialPortSetup.Location = new System.Drawing.Point(249, 630);
            this.groupBoxSerialPortSetup.Name = "groupBoxSerialPortSetup";
            this.groupBoxSerialPortSetup.Size = new System.Drawing.Size(206, 62);
            this.groupBoxSerialPortSetup.TabIndex = 4;
            this.groupBoxSerialPortSetup.TabStop = false;
            this.groupBoxSerialPortSetup.Text = "Station Port Setup";
            // 
            // cbbComPort
            // 
            this.cbbComPort.FormattingEnabled = true;
            this.cbbComPort.Location = new System.Drawing.Point(11, 25);
            this.cbbComPort.Name = "cbbComPort";
            this.cbbComPort.Size = new System.Drawing.Size(61, 21);
            this.cbbComPort.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(77, 25);
            this.btConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(59, 21);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(145, 22);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(37, 24);
            this.textBox.TabIndex = 5;
            this.textBox.Visible = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(356, 725);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtXCurrentPos
            // 
            this.txtXCurrentPos.BackColor = System.Drawing.SystemColors.Control;
            this.txtXCurrentPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXCurrentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtXCurrentPos.Location = new System.Drawing.Point(76, 36);
            this.txtXCurrentPos.Name = "txtXCurrentPos";
            this.txtXCurrentPos.Size = new System.Drawing.Size(79, 24);
            this.txtXCurrentPos.TabIndex = 7;
            this.txtXCurrentPos.Text = "0.00";
            this.txtXCurrentPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXpos
            // 
            this.lblXpos.AutoSize = true;
            this.lblXpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblXpos.Location = new System.Drawing.Point(45, 36);
            this.lblXpos.Name = "lblXpos";
            this.lblXpos.Size = new System.Drawing.Size(27, 26);
            this.lblXpos.TabIndex = 8;
            this.lblXpos.Text = "X";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblYPos.Location = new System.Drawing.Point(45, 62);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(28, 26);
            this.lblYPos.TabIndex = 10;
            this.lblYPos.Text = "Y";
            // 
            // txtYCurrentPos
            // 
            this.txtYCurrentPos.BackColor = System.Drawing.SystemColors.Control;
            this.txtYCurrentPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYCurrentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtYCurrentPos.Location = new System.Drawing.Point(76, 62);
            this.txtYCurrentPos.Name = "txtYCurrentPos";
            this.txtYCurrentPos.Size = new System.Drawing.Size(79, 24);
            this.txtYCurrentPos.TabIndex = 9;
            this.txtYCurrentPos.Text = "0.00";
            this.txtYCurrentPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z";
            // 
            // txtZCurrentPos
            // 
            this.txtZCurrentPos.BackColor = System.Drawing.SystemColors.Control;
            this.txtZCurrentPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZCurrentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtZCurrentPos.Location = new System.Drawing.Point(76, 90);
            this.txtZCurrentPos.Name = "txtZCurrentPos";
            this.txtZCurrentPos.Size = new System.Drawing.Size(79, 24);
            this.txtZCurrentPos.TabIndex = 11;
            this.txtZCurrentPos.Text = "0.00";
            this.txtZCurrentPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.txtXCurrentPos);
            this.gbPosition.Controls.Add(this.label3);
            this.gbPosition.Controls.Add(this.lblXpos);
            this.gbPosition.Controls.Add(this.txtZCurrentPos);
            this.gbPosition.Controls.Add(this.txtYCurrentPos);
            this.gbPosition.Controls.Add(this.lblYPos);
            this.gbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbPosition.Location = new System.Drawing.Point(13, 472);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(197, 124);
            this.gbPosition.TabIndex = 13;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Current Position";
            // 
            // txtPosT1
            // 
            this.txtPosT1.Location = new System.Drawing.Point(29, 98);
            this.txtPosT1.Name = "txtPosT1";
            this.txtPosT1.Size = new System.Drawing.Size(79, 20);
            this.txtPosT1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "T1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btJogXNeg);
            this.groupBox3.Controls.Add(this.btJogXPos);
            this.groupBox3.Controls.Add(this.btJogYNeg);
            this.groupBox3.Controls.Add(this.txtFeedRate);
            this.groupBox3.Controls.Add(this.btHome);
            this.groupBox3.Controls.Add(this.lblFeedRate);
            this.groupBox3.Controls.Add(this.lblResolution);
            this.groupBox3.Controls.Add(this.btJogYPos);
            this.groupBox3.Controls.Add(this.cbbResolution);
            this.groupBox3.Location = new System.Drawing.Point(249, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 211);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btJogZNeg);
            this.groupBox4.Controls.Add(this.btJogZPos);
            this.groupBox4.Location = new System.Drawing.Point(99, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 83);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Z AXIS";
            // 
            // btJogZNeg
            // 
            this.btJogZNeg.Location = new System.Drawing.Point(8, 48);
            this.btJogZNeg.Name = "btJogZNeg";
            this.btJogZNeg.Size = new System.Drawing.Size(75, 23);
            this.btJogZNeg.TabIndex = 18;
            this.btJogZNeg.Text = "NEG -";
            this.btJogZNeg.UseVisualStyleBackColor = true;
            this.btJogZNeg.Click += new System.EventHandler(this.btJogZNeg_Click);
            // 
            // btJogZPos
            // 
            this.btJogZPos.Location = new System.Drawing.Point(8, 19);
            this.btJogZPos.Name = "btJogZPos";
            this.btJogZPos.Size = new System.Drawing.Size(75, 23);
            this.btJogZPos.TabIndex = 17;
            this.btJogZPos.Text = "POS +";
            this.btJogZPos.UseVisualStyleBackColor = true;
            this.btJogZPos.Click += new System.EventHandler(this.btJogZPos_Click);
            // 
            // btJogXNeg
            // 
            this.btJogXNeg.Location = new System.Drawing.Point(18, 50);
            this.btJogXNeg.Name = "btJogXNeg";
            this.btJogXNeg.Size = new System.Drawing.Size(53, 23);
            this.btJogXNeg.TabIndex = 16;
            this.btJogXNeg.Text = "NEG -";
            this.btJogXNeg.UseVisualStyleBackColor = true;
            this.btJogXNeg.Click += new System.EventHandler(this.btJogXNeg_Click);
            // 
            // btJogXPos
            // 
            this.btJogXPos.Location = new System.Drawing.Point(136, 50);
            this.btJogXPos.Name = "btJogXPos";
            this.btJogXPos.Size = new System.Drawing.Size(53, 23);
            this.btJogXPos.TabIndex = 3;
            this.btJogXPos.Text = "POS +";
            this.btJogXPos.UseVisualStyleBackColor = true;
            this.btJogXPos.Click += new System.EventHandler(this.btJogXPos_Click);
            // 
            // btJogYNeg
            // 
            this.btJogYNeg.Location = new System.Drawing.Point(76, 79);
            this.btJogYNeg.Name = "btJogYNeg";
            this.btJogYNeg.Size = new System.Drawing.Size(53, 23);
            this.btJogYNeg.TabIndex = 2;
            this.btJogYNeg.Text = "NEG -";
            this.btJogYNeg.UseVisualStyleBackColor = true;
            this.btJogYNeg.Click += new System.EventHandler(this.btJogYNeg_Click);
            // 
            // txtFeedRate
            // 
            this.txtFeedRate.Location = new System.Drawing.Point(17, 135);
            this.txtFeedRate.Name = "txtFeedRate";
            this.txtFeedRate.Size = new System.Drawing.Size(64, 20);
            this.txtFeedRate.TabIndex = 21;
            this.txtFeedRate.TabStop = false;
            this.txtFeedRate.Text = "1500";
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(76, 50);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(53, 23);
            this.btHome.TabIndex = 1;
            this.btHome.Text = "HOME";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblFeedRate
            // 
            this.lblFeedRate.AutoSize = true;
            this.lblFeedRate.Location = new System.Drawing.Point(15, 118);
            this.lblFeedRate.Name = "lblFeedRate";
            this.lblFeedRate.Size = new System.Drawing.Size(57, 13);
            this.lblFeedRate.TabIndex = 20;
            this.lblFeedRate.Text = "Feed Rate";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(15, 160);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(57, 13);
            this.lblResolution.TabIndex = 19;
            this.lblResolution.Text = "Resolution";
            // 
            // btJogYPos
            // 
            this.btJogYPos.Location = new System.Drawing.Point(76, 19);
            this.btJogYPos.Name = "btJogYPos";
            this.btJogYPos.Size = new System.Drawing.Size(53, 23);
            this.btJogYPos.TabIndex = 0;
            this.btJogYPos.Text = "POS +";
            this.btJogYPos.UseVisualStyleBackColor = true;
            this.btJogYPos.Click += new System.EventHandler(this.btJogYPos_Click);
            // 
            // cbbResolution
            // 
            this.cbbResolution.FormattingEnabled = true;
            this.cbbResolution.Items.AddRange(new object[] {
            "0.1",
            "1",
            "10",
            "100"});
            this.cbbResolution.Location = new System.Drawing.Point(17, 176);
            this.cbbResolution.Name = "cbbResolution";
            this.cbbResolution.Size = new System.Drawing.Size(64, 21);
            this.cbbResolution.TabIndex = 18;
            this.cbbResolution.Text = "1";
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(275, 725);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 16;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(9, 602);
            this.txtSave.Multiline = true;
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(201, 142);
            this.txtSave.TabIndex = 22;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1,
            this.rectangleShape});
            this.shapeContainer1.Size = new System.Drawing.Size(475, 756);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.Lime;
            this.lineShape8.BorderWidth = 5;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 229;
            this.lineShape8.X2 = 259;
            this.lineShape8.Y1 = 74;
            this.lineShape8.Y2 = 74;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.Lime;
            this.lineShape7.BorderWidth = 5;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 226;
            this.lineShape7.X2 = 256;
            this.lineShape7.Y1 = 209;
            this.lineShape7.Y2 = 209;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.Lime;
            this.lineShape6.BorderWidth = 5;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 227;
            this.lineShape6.X2 = 257;
            this.lineShape6.Y1 = 343;
            this.lineShape6.Y2 = 343;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Lime;
            this.lineShape3.BorderWidth = 5;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 113;
            this.lineShape3.X2 = 230;
            this.lineShape3.Y1 = 359;
            this.lineShape3.Y2 = 343;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Lime;
            this.lineShape2.BorderWidth = 5;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 114;
            this.lineShape2.X2 = 230;
            this.lineShape2.Y1 = 105;
            this.lineShape2.Y2 = 74;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Lime;
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 114;
            this.lineShape1.X2 = 229;
            this.lineShape1.Y1 = 231;
            this.lineShape1.Y2 = 209;
            // 
            // ovalShape3
            // 
            this.ovalShape3.FillColor = System.Drawing.Color.Honeydew;
            this.ovalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape3.Location = new System.Drawing.Point(83, 78);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(57, 53);
            // 
            // ovalShape2
            // 
            this.ovalShape2.FillColor = System.Drawing.Color.Honeydew;
            this.ovalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape2.Location = new System.Drawing.Point(86, 330);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(57, 53);
            // 
            // ovalShape1
            // 
            this.ovalShape1.FillColor = System.Drawing.Color.Honeydew;
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(84, 203);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(57, 53);
            // 
            // rectangleShape
            // 
            this.rectangleShape.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.rectangleShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape.Location = new System.Drawing.Point(9, 7);
            this.rectangleShape.Name = "rectangleShape";
            this.rectangleShape.Size = new System.Drawing.Size(200, 450);
            // 
            // gbFirstStage
            // 
            this.gbFirstStage.Controls.Add(this.label6);
            this.gbFirstStage.Controls.Add(this.txtPosZ1);
            this.gbFirstStage.Controls.Add(this.btSaveStage1);
            this.gbFirstStage.Controls.Add(this.label2);
            this.gbFirstStage.Controls.Add(this.label1);
            this.gbFirstStage.Controls.Add(this.txtPosY1);
            this.gbFirstStage.Controls.Add(this.txtPosX1);
            this.gbFirstStage.Controls.Add(this.label5);
            this.gbFirstStage.Controls.Add(this.txtPosT1);
            this.gbFirstStage.Controls.Add(this.shapeContainer2);
            this.gbFirstStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFirstStage.Location = new System.Drawing.Point(256, 142);
            this.gbFirstStage.Name = "gbFirstStage";
            this.gbFirstStage.Size = new System.Drawing.Size(199, 128);
            this.gbFirstStage.TabIndex = 24;
            this.gbFirstStage.TabStop = false;
            this.gbFirstStage.Text = "First Stage";
            // 
            // btSaveStage1
            // 
            this.btSaveStage1.Location = new System.Drawing.Point(114, 19);
            this.btSaveStage1.Name = "btSaveStage1";
            this.btSaveStage1.Size = new System.Drawing.Size(75, 99);
            this.btSaveStage1.TabIndex = 28;
            this.btSaveStage1.Text = "Save Position";
            this.btSaveStage1.UseVisualStyleBackColor = true;
            this.btSaveStage1.Click += new System.EventHandler(this.btSaveStage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Y1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "X1";
            // 
            // txtPosY1
            // 
            this.txtPosY1.Location = new System.Drawing.Point(29, 46);
            this.txtPosY1.Name = "txtPosY1";
            this.txtPosY1.Size = new System.Drawing.Size(79, 20);
            this.txtPosY1.TabIndex = 27;
            // 
            // txtPosX1
            // 
            this.txtPosX1.Location = new System.Drawing.Point(29, 19);
            this.txtPosX1.Name = "txtPosX1";
            this.txtPosX1.Size = new System.Drawing.Size(79, 20);
            this.txtPosX1.TabIndex = 25;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer2.Size = new System.Drawing.Size(193, 109);
            this.shapeContainer2.TabIndex = 29;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -42;
            this.lineShape4.X2 = 0;
            this.lineShape4.Y1 = 47;
            this.lineShape4.Y2 = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPosZ3);
            this.groupBox1.Controls.Add(this.btSaveStage3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPosY3);
            this.groupBox1.Controls.Add(this.txtPosX3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPosT3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(256, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 129);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Third Stage";
            // 
            // btSaveStage3
            // 
            this.btSaveStage3.Location = new System.Drawing.Point(114, 19);
            this.btSaveStage3.Name = "btSaveStage3";
            this.btSaveStage3.Size = new System.Drawing.Size(75, 99);
            this.btSaveStage3.TabIndex = 27;
            this.btSaveStage3.Text = "Save Position";
            this.btSaveStage3.UseVisualStyleBackColor = true;
            this.btSaveStage3.Click += new System.EventHandler(this.btSaveStage3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Y3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "X3";
            // 
            // txtPosY3
            // 
            this.txtPosY3.Location = new System.Drawing.Point(29, 46);
            this.txtPosY3.Name = "txtPosY3";
            this.txtPosY3.Size = new System.Drawing.Size(79, 20);
            this.txtPosY3.TabIndex = 27;
            // 
            // txtPosX3
            // 
            this.txtPosX3.Location = new System.Drawing.Point(29, 19);
            this.txtPosX3.Name = "txtPosX3";
            this.txtPosX3.Size = new System.Drawing.Size(79, 20);
            this.txtPosX3.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "T3";
            // 
            // txtPosT3
            // 
            this.txtPosT3.Location = new System.Drawing.Point(29, 98);
            this.txtPosT3.Name = "txtPosT3";
            this.txtPosT3.Size = new System.Drawing.Size(79, 20);
            this.txtPosT3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPosZ2);
            this.groupBox2.Controls.Add(this.btSaveStage2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPosY2);
            this.groupBox2.Controls.Add(this.txtPosX2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPosT2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(256, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 131);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Stage";
            // 
            // btSaveStage2
            // 
            this.btSaveStage2.Location = new System.Drawing.Point(114, 19);
            this.btSaveStage2.Name = "btSaveStage2";
            this.btSaveStage2.Size = new System.Drawing.Size(75, 99);
            this.btSaveStage2.TabIndex = 28;
            this.btSaveStage2.Text = "Save Position";
            this.btSaveStage2.UseVisualStyleBackColor = true;
            this.btSaveStage2.Click += new System.EventHandler(this.btSaveStage2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Y2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "X2";
            // 
            // txtPosY2
            // 
            this.txtPosY2.Location = new System.Drawing.Point(29, 46);
            this.txtPosY2.Name = "txtPosY2";
            this.txtPosY2.Size = new System.Drawing.Size(79, 20);
            this.txtPosY2.TabIndex = 27;
            // 
            // txtPosX2
            // 
            this.txtPosX2.Location = new System.Drawing.Point(29, 19);
            this.txtPosX2.Name = "txtPosX2";
            this.txtPosX2.Size = new System.Drawing.Size(79, 20);
            this.txtPosX2.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "T2";
            // 
            // txtPosT2
            // 
            this.txtPosT2.Location = new System.Drawing.Point(29, 98);
            this.txtPosT2.Name = "txtPosT2";
            this.txtPosT2.Size = new System.Drawing.Size(79, 20);
            this.txtPosT2.TabIndex = 7;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(245, 699);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(210, 20);
            this.txtDirectory.TabIndex = 27;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Z3";
            // 
            // txtPosZ3
            // 
            this.txtPosZ3.Location = new System.Drawing.Point(29, 72);
            this.txtPosZ3.Name = "txtPosZ3";
            this.txtPosZ3.Size = new System.Drawing.Size(79, 20);
            this.txtPosZ3.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Z1";
            // 
            // txtPosZ1
            // 
            this.txtPosZ1.Location = new System.Drawing.Point(29, 72);
            this.txtPosZ1.Name = "txtPosZ1";
            this.txtPosZ1.Size = new System.Drawing.Size(79, 20);
            this.txtPosZ1.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Z2";
            // 
            // txtPosZ2
            // 
            this.txtPosZ2.Location = new System.Drawing.Point(29, 72);
            this.txtPosZ2.Name = "txtPosZ2";
            this.txtPosZ2.Size = new System.Drawing.Size(79, 20);
            this.txtPosZ2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 756);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFirstStage);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPosition);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBoxSerialPortSetup);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WinnerPrototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.groupBoxSerialPortSetup.ResumeLayout(false);
            this.groupBoxSerialPortSetup.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gbFirstStage.ResumeLayout(false);
            this.gbFirstStage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBoxSerialPortSetup;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox cbbComPort;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txtXCurrentPos;
        private System.Windows.Forms.Label lblXpos;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.TextBox txtYCurrentPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZCurrentPos;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.TextBox txtPosT1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btJogXNeg;
        private System.Windows.Forms.Button btJogXPos;
        private System.Windows.Forms.Button btJogYNeg;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btJogYPos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btJogZNeg;
        private System.Windows.Forms.Button btJogZPos;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.ComboBox cbbResolution;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblFeedRate;
        private System.Windows.Forms.TextBox txtFeedRate;
        private System.Windows.Forms.TextBox txtSave;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.GroupBox gbFirstStage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosY1;
        private System.Windows.Forms.TextBox txtPosX1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosY3;
        private System.Windows.Forms.TextBox txtPosX3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPosT3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPosY2;
        private System.Windows.Forms.TextBox txtPosX2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPosT2;
        private System.Windows.Forms.Button btSaveStage3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private System.Windows.Forms.Button btSaveStage1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Button btSaveStage2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPosZ1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosZ3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPosZ2;
    }
}

