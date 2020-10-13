using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EventTutorial
{
    public partial class Form1 : Form
    {
        private List<PictureBox> bulletList;
        
        public Form1()
        {
            InitializeComponent();
            MakePictureBoxArray(10);
            bulletList = new List<PictureBox>();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.Y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.Top -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBox1.Top += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                pictureBox1.Left -= 10;
            }
            if(e.KeyCode == Keys.D)
            {
                pictureBox1.Left += 10;
            }

            if (e.KeyCode == Keys.Space)
            {
                var left = pictureBox1.Left;
                var y = pictureBox1.Top + 30;
                var right = pictureBox1.Right;
                var x = (left + right) / 2;
                bulletList.Add(MakeBullet(x, y));
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            var random = new Random();
            var removeList = new List<PictureBox>();
            foreach (var picture in this.pictureBox2)
            {
                picture.Top += random.Next(1,10);
            }

            foreach (var bullet in this.bulletList)
            {
                bullet.Top -= 15;
                if (bullet.Top + bullet.Height < 0)
                {
                    removeList.Add(bullet);
                }
            }

            foreach (var removePicture in removeList)
            {
                bulletList.Remove(removePicture);
                this.Controls.Remove(removePicture);
            }
        }
    }
}