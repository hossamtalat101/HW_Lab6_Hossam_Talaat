using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Najmm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pictureBox1.Image = Properties.Resources.Boy;
                label1.Text = "Boy".ToString();
            }
            if (i == 1)
            {
                pictureBox1.Image = Properties.Resources.Girl;
                label1.Text = "Girl".ToString();
            }
            if (i == 2)
            {
                pictureBox1.Image = Properties.Resources.Book;
                label1.Text = "Book".ToString();
            }
            if (i == 3)
            {
                pictureBox1.Image = Properties.Resources.Pen;
                label1.Text = "Pen".ToString();
            }
            i++;
            if (i == 4)
                i = 0;
            //i++;
            //if (i <= 5)
            //{
            //    pictureBox1.Image = Image.FromFile(@"C:\Users\pc\Pictures\Photo\" + i.ToString() + ".png");
            //}
            //else
            //{
            //    i = 1;
            //    pictureBox1.Image = Image.FromFile(@"C:\Users\pc\Pictures\Photo\" + i.ToString() + ".png");
            //}
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Interval = 500;
        }
    }
}
