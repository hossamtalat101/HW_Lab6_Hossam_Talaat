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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string temp = textBox1.Text;
            if (textBox1.Text.Trim() != "")
                pictureBox1.Image = Image.FromFile(textBox1.Text);
            else
            {
                MessageBox.Show("ادخل المسار");
                textBox1.Focus();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
