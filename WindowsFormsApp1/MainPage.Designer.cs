namespace ArduinoInterface
{
    partial class MainPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.potChaser = new System.Windows.Forms.ProgressBar();
            this.PotLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.TempOutput = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendTxtButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.getTimeButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.txtSendLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.getPCButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPlotData = new System.Windows.Forms.Button();
            this.chartPotDraw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPotDraw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(48, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // potChaser
            // 
            this.potChaser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.potChaser.Location = new System.Drawing.Point(48, 79);
            this.potChaser.Name = "potChaser";
            this.potChaser.Size = new System.Drawing.Size(100, 23);
            this.potChaser.TabIndex = 3;
            // 
            // PotLabel
            // 
            this.PotLabel.AutoSize = true;
            this.PotLabel.Location = new System.Drawing.Point(65, 44);
            this.PotLabel.Name = "PotLabel";
            this.PotLabel.Size = new System.Drawing.Size(61, 13);
            this.PotLabel.TabIndex = 4;
            this.PotLabel.Text = "Pot Postion";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Location = new System.Drawing.Point(234, 44);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(61, 13);
            this.TempLabel.TabIndex = 5;
            this.TempLabel.Text = "Tempreture";
            // 
            // TempOutput
            // 
            this.TempOutput.AutoSize = true;
            this.TempOutput.BackColor = System.Drawing.Color.Gray;
            this.TempOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempOutput.Location = new System.Drawing.Point(234, 79);
            this.TempOutput.Name = "TempOutput";
            this.TempOutput.Size = new System.Drawing.Size(0, 19);
            this.TempOutput.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(188, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 177);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(31, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(33, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Humidity";
            // 
            // sendTxtButton
            // 
            this.sendTxtButton.Location = new System.Drawing.Point(31, 156);
            this.sendTxtButton.Name = "sendTxtButton";
            this.sendTxtButton.Size = new System.Drawing.Size(100, 26);
            this.sendTxtButton.TabIndex = 12;
            this.sendTxtButton.Text = "Send";
            this.sendTxtButton.UseVisualStyleBackColor = true;
            this.sendTxtButton.Click += new System.EventHandler(this.sendTxtButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // getTimeButton
            // 
            this.getTimeButton.Location = new System.Drawing.Point(31, 32);
            this.getTimeButton.Name = "getTimeButton";
            this.getTimeButton.Size = new System.Drawing.Size(100, 26);
            this.getTimeButton.TabIndex = 14;
            this.getTimeButton.Text = "Get Time";
            this.getTimeButton.UseVisualStyleBackColor = true;
            this.getTimeButton.Click += new System.EventHandler(this.getTimeButton_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(9, 64);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(135, 26);
            this.timeTextBox.TabIndex = 15;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSendLabel
            // 
            this.txtSendLabel.AutoSize = true;
            this.txtSendLabel.Location = new System.Drawing.Point(35, 114);
            this.txtSendLabel.Name = "txtSendLabel";
            this.txtSendLabel.Size = new System.Drawing.Size(96, 13);
            this.txtSendLabel.TabIndex = 16;
            this.txtSendLabel.Text = "Enter Text to Send";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendTxtButton);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.txtSendLabel);
            this.groupBox3.Controls.Add(this.getTimeButton);
            this.groupBox3.Controls.Add(this.timeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 198);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(359, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 177);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // getPCButton
            // 
            this.getPCButton.Location = new System.Drawing.Point(239, 201);
            this.getPCButton.Name = "getPCButton";
            this.getPCButton.Size = new System.Drawing.Size(100, 26);
            this.getPCButton.TabIndex = 17;
            this.getPCButton.Text = "Get PC";
            this.getPCButton.UseVisualStyleBackColor = true;
            this.getPCButton.Click += new System.EventHandler(this.getPCButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.AcceptsReturn = true;
            this.textBox5.AcceptsTab = true;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(186, 233);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 184);
            this.textBox5.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonPlotData
            // 
            this.buttonPlotData.Location = new System.Drawing.Point(1101, 58);
            this.buttonPlotData.Name = "buttonPlotData";
            this.buttonPlotData.Size = new System.Drawing.Size(75, 23);
            this.buttonPlotData.TabIndex = 0;
            this.buttonPlotData.Text = "Plot Data";
            this.buttonPlotData.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartPotDraw
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPotDraw.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPotDraw.Legends.Add(legend5);
            this.chartPotDraw.Location = new System.Drawing.Point(563, 44);
            this.chartPotDraw.Name = "chartPotDraw";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartPotDraw.Series.Add(series5);
            this.chartPotDraw.Size = new System.Drawing.Size(638, 415);
            this.chartPotDraw.TabIndex = 18;
            this.chartPotDraw.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1263, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.cameraToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonPlotData);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.getPCButton);
            this.Controls.Add(this.TempOutput);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.PotLabel);
            this.Controls.Add(this.potChaser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chartPotDraw);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Arduino Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPotDraw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ProgressBar potChaser;
        private System.Windows.Forms.Label PotLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label TempOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendTxtButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button getTimeButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label txtSendLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button getPCButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPlotData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPotDraw;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
    }
}

