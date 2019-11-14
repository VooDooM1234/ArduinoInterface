using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoInterface
{
    public partial class JumpGame : Form
    {
        bool left = false;
        bool right = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int moveSpeed = 5;
        int force = 8;
        int score = 0;

        public JumpGame()
        {
            InitializeComponent();
        }

        private void JumpGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                left = true;
                player.Left -= moveSpeed;
            }
            if(e.KeyCode == Keys.Right)
            {
                right = true;
                player.Left += moveSpeed;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                player.Top += jumpSpeed;
            }
        }
               
        private void JumpGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (left)
            {
                player.Left -= moveSpeed;
            }
            if (right)
            {
                player.Left += moveSpeed; 
            }
            if(jumping == false)
            {
                player.Top -= force;
            }
        }
    }
}
