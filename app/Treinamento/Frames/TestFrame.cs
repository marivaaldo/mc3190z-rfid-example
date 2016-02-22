using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Treinamento.Frames
{
    public partial class TestFrame : Form
    {
        private readonly string[] imgs = 
        { 
            @"\Imgs\flash.jpg", 
            @"\Imgs\arrow.jpg", 
            @"\Imgs\batman.jpg", 
            @"\Imgs\ironman.jpg", 
            @"\Imgs\homemaranha.jpg"
        };

        private int index = 0;

        public TestFrame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (index == imgs.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }

            SetImage(imgs[index]);
        }

        private void SetImage(string path)
        {
            Bitmap bmp = new Bitmap(path);

            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Show();
        }

        private void TestFrame_Activated(object sender, EventArgs e)
        {
            index = 0;
            SetImage(imgs[0]);
        }
    }
}