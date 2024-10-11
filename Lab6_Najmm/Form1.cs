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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\pc\desktop\Images\Boy.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width  = 300;
            pictureBox1.Height = 280;
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            toolTip1.SetToolTip(pictureBox1, "Image Booy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
