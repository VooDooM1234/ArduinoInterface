namespace ArduinoInterface
{
    partial class Camera
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
            this.pictureBoxNormal = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxCanny = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxBrowseImage = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(260, 270);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNormal.TabIndex = 0;
            this.pictureBoxNormal.TabStop = false;
            // 
            // pictureBoxCanny
            // 
            this.pictureBoxCanny.Location = new System.Drawing.Point(312, 12);
            this.pictureBoxCanny.Name = "pictureBoxCanny";
            this.pictureBoxCanny.Size = new System.Drawing.Size(260, 270);
            this.pictureBoxCanny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCanny.TabIndex = 1;
            this.pictureBoxCanny.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Image Manipulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxBrowseImage
            // 
            this.pictureBoxBrowseImage.Location = new System.Drawing.Point(593, 12);
            this.pictureBoxBrowseImage.Name = "pictureBoxBrowseImage";
            this.pictureBoxBrowseImage.Size = new System.Drawing.Size(251, 270);
            this.pictureBoxBrowseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBrowseImage.TabIndex = 3;
            this.pictureBoxBrowseImage.TabStop = false;
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Location = new System.Drawing.Point(497, 288);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseImage.TabIndex = 4;
            this.buttonBrowseImage.Text = "Browse";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 569);
            this.Controls.Add(this.buttonBrowseImage);
            this.Controls.Add(this.pictureBoxBrowseImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxCanny);
            this.Controls.Add(this.pictureBoxNormal);
            this.Name = "Camera";
            this.Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxNormal;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxCanny;
        private System.Windows.Forms.Button button1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxBrowseImage;
        private System.Windows.Forms.Button buttonBrowseImage;
    }
}