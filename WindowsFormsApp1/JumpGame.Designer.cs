namespace ArduinoInterface
{
    partial class JumpGame
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
            this.platform = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform.Location = new System.Drawing.Point(1, 499);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(483, 50);
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Blue;
            this.player.Location = new System.Drawing.Point(219, 386);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(23, 38);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JumpGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform);
            this.Name = "JumpGame";
            this.Text = "JumpGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JumpGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.JumpGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
    }
}