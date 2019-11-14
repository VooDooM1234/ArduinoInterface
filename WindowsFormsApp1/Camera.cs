using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.ML;

namespace ArduinoInterface
{
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles basic image data
        /// </summary>
        private void ImageHandler()
        {
            string imagePath = "Image/feelsgoodman.jpg";
            Mat source = new Mat(imagePath, ImreadModes.Color);
            Mat grayFiltered = new Mat(imagePath, ImreadModes.GrayScale);
           // Mat ClearEdge = new Mat(imagePath, ImreadModes.AnyColor);
           // Mat filtered = new Mat();
            Mat Canny = new Mat();

            Cv2.Canny(source, Canny, 32, 192);
            
            pictureBoxNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCanny.SizeMode = PictureBoxSizeMode.StretchImage;

            Cv2.Rectangle(source, new Point(2, 2), new Point(52, 52), new Scalar(75, 0, 130), 2, LineTypes.Link8, 0);

            pictureBoxNormal.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(source);
            pictureBoxCanny.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Canny);


            Cv2.WaitKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageHandler();
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                pictureBoxBrowseImage.Image = System.Drawing.Image.FromFile(opf.FileName);
            }
        }
    }
}
