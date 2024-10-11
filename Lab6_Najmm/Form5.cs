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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Start();
            //timer1.Enabled = true;
        }

        int Minite = 0, Houre = 0, Second = 0;

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Second++;
            if (Second < 10)
                labSecond.Text = "0" + Second.ToString();
            else
                labSecond.Text = Second.ToString();
            if (Second >= 59)
            {
                Second = 0;
                Minite++;
                if (Minite < 10)
                    labMinute.Text = "0" + Minite.ToString();
                else
                    labMinute.Text = Minite.ToString();
            }
            if (Minite >= 59)
            {
                Minite = 0;
                Houre++;
                if (Houre < 10)
                    labHoure.Text = "0" + Houre.ToString();
                else
                    labHoure.Text = Houre.ToString();
            }

        }
    }
}
