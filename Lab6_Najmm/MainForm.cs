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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form3();
            frm3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
