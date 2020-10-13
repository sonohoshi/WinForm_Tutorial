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
            bulletList.Add(MakeBullet(e.X, e.Y));
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
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            var random = new Random();
            foreach (var picture in this.pictureBox2)
            {
                picture.Top += random.Next(1,10);
            }
        }
    }
}