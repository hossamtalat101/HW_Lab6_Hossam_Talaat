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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 5)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\pc\Pictures\Photo\"+i.ToString()+".png");
            }
            else
            {
                i = 0;
                //pictureBox1.Image = Image.FromFile(@"C:\Users\pc\Pictures\Photo\" + i.ToString() + ".png");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 0)
                i = 5;
            pictureBox1.Image = Image.FromFile(@"C:\Users\pc\Pictures\Photo\" + i.ToString() + ".png");


        }
    }
}
