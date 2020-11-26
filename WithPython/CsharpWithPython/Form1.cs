using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWithPython
{
    public partial class Form1 : Form
    {
        private ProcessStartInfo startInfo = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) return;
            try
            {
                string file = "test.py";
                
                startInfo = new ProcessStartInfo("python.exe");
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;

                System.IO.File.WriteAllText(file, textBox1.Text, Encoding.UTF8);
                
                startInfo.Arguments = file;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
                StreamReader reader = process.StandardError;
                MessageBox.Show(reader.ReadToEnd());
                reader = process.StandardOutput;
                MessageBox.Show(reader.ReadToEnd());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}