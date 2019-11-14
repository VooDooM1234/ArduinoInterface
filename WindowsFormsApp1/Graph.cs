using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArduinoInterface
{
    public partial class Graph : Form
    {
        string value;
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            string s = MainPage.dataRecieved[0];
            Console.WriteLine(s);

            List<string> list = new List<string>();
            list.Add(s);

            for (int i = -15; i < 2; i++)
            {
                chartPotDrawing.Series[0].Points.AddXY(i, s);
                chartPotDrawing.Series[0].ChartType = SeriesChartType.Line;

            }
        }

        public void DataRecieved()
        {
                
        }

        double function(double x)
        {
            return (Math.Pow(x, 2) + 2 * Math.Sin(2 * x));
        }


        public string getData
        {
            get
            {
                return value;
            }
        }
    }
}
