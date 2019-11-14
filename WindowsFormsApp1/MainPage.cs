using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

//EMGU
//using Emgu.CV;
//using Emgu.CV.Structure;
//using Emgu.Util;
//using Emgu.CV.CvEnum;
//OpenCVSharp



namespace ArduinoInterface
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            //  serialPort1.Open();
        }

        //Collects all data recieved from COMport
        public static string[] dataRecieved = new string[inputs];
        int count = 0;
        //Number of different incoming data sources
        const int inputs = 3;
        const int inputsCheck = (inputs - 1);

        enum Data { potData, tempData, humData }

        SystemInfo _systemInfo = new SystemInfo();

        List<string> potDataList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Makes a thread safe call to text from data recieved
        delegate void SetTextCallback(string text);
        delegate void SetIntCallback(int num);

        #region Callbacks for multithreading
        public void SetTextPot(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextPot);
                Invoke(d, new object[] { text });
            }
            else
            {
                textBox1.Text = text + " " + "%";
            }
        }
        public void SetInt(int num)
        {
            if (potChaser.InvokeRequired)
            {
                SetIntCallback d = new SetIntCallback(SetInt);
                Invoke(d, new object[] { num });
            }
            else
            {
                potChaser.Value = num;
            }
        }
        public void SetTextTemp(string text)
        {

            if (textBox2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextTemp);
                Invoke(d, new object[] { text });
            }
            else
            {
                textBox2.Text = text + " " + "C";
            }
        }
        public void SetTextHumid(string text)
        {

            if (textBox3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextHumid);
                Invoke(d, new object[] { text });
            }
            else
            {
                textBox3.Text = text + " " + "%";

            }
        }
        #endregion

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // all strings from ardiuno end with \r (no space)
            Graph graph = new Graph();
            string s = serialPort1.ReadLine();

            dataRecieved[count] = s;
            count++;
            if (count > inputsCheck)
            {
                potFunction(dataRecieved[(int)Data.potData]);
                tempFunction(dataRecieved[(int)Data.tempData]);
                humidFunction(dataRecieved[(int)Data.humData]);
                for (int i = count; count < 2; i++)
                {
                    Console.Write(dataRecieved[i] + "\t");
                }
                count = 0;
            }
        }

        #region Calls to Sensors
        public void potFunction(string result)
        {
            int num = 0;

            SetTextPot(result.ToString());
            num = int.Parse(result);
            potDataList.Add(result);
            SetInt(num);
        }
        public void tempFunction(string result)
        {
            SetTextTemp(result.ToString());
        }
        public void humidFunction(string result)
        {
            SetTextHumid(result.ToString());
        }
        #endregion

        private void drawGraph()
        {
            Graph graph = new Graph();
            string s = dataRecieved[(int)Data.potData];
            Console.WriteLine(s);

            potDataList.Add(s);
            string[] array = potDataList.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                chartPotDraw.Series[0].Points.AddXY(i, array[i]);
                chartPotDraw.Series[0].ChartType = SeriesChartType.Line;
            }
        }
        
        private void sendTxtButton_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            serialPort1.Write(s);
        }

        private void getPCButton_Click(object sender, EventArgs e)
        {
            string s = _systemInfo.GetCoreTemp();
            textBox5.Text = s;
        }
        private void getTimeButton_Click(object sender, EventArgs e)
        {
            //timer1.Tick += new EventHandler(timer1_Tick);
            string time = DateTime.Now.ToLongTimeString();
            //serialPort1.Write(time);

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortTimeString();
            serialPort1.Write(time);
            timeTextBox.Text = time;
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawGraph();
        }
               
        
        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.ShowDialog();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JumpGame jump = new JumpGame();
            jump.ShowDialog();
        }
    }
}




