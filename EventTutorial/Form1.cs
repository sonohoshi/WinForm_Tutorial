using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.Y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pictureBox1.Top -= 5;
                    break;
                case Keys.S:
                    pictureBox1.Top += 5;
                    break;
                case Keys.A:
                    pictureBox1.Left -= 5;
                    break;
                case Keys.D:
                    pictureBox1.Left += 5;
                    break;
            }
        }
    }
}