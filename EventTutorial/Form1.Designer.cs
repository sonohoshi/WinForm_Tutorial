﻿using System.Windows.Forms;

namespace EventTutorial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
        }
        
        private System.Timers.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBox[] pictureBox2;

        #endregion
        
        void MakePictureBoxArray(int count)
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox[count];
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            for (int i = 0; i < count; i++)
            {
                this.pictureBox2[i] = new PictureBox();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox2[i])).BeginInit();
                // 
                // pictureBox2
                // 
                this.pictureBox2[i].Load(@"C:\Users\82108\WorkSpace\WinForm_Tutorial\EventTutorial\Resources\char.gif");
                this.pictureBox2[i].Location = new System.Drawing.Point(581 - i * 80, 158);
                this.pictureBox2[i].Name = $"this.pictureBox2[{i}]Box2";
                this.pictureBox2[i].Size = new System.Drawing.Size(80, 80);
                this.pictureBox2[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pictureBox2[i].TabIndex = 3;
                this.pictureBox2[i].TabStop = false;
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox2[i])).EndInit();
                this.Controls.Add(this.pictureBox2[i]);
            }
        }

        private PictureBox MakeBullet(int x,int y)
        {
            System.Windows.Forms.PictureBox pictureBox3;
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (pictureBox3)).BeginInit();
            pictureBox3.Load(@"C:\Users\82108\WorkSpace\WinForm_Tutorial\EventTutorial\Resources\bullet.png");
            pictureBox3.Location = new System.Drawing.Point(x, y);
            pictureBox3.Name = "pictureBox2";
            pictureBox3.Size = new System.Drawing.Size(39, 37);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            this.Controls.Add(pictureBox3);
            ((System.ComponentModel.ISupportInitialize) (pictureBox3)).EndInit();
            return pictureBox3;
        }
    }
}