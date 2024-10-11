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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            int x = 0, y = 0;
            Bitmap mybitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (x = 0; x < 100; x++)
            {
                y = x;
                mybitmap.SetPixel(x, y, Color.Red);
            }
            pictureBox1.Image = mybitmap;
            for (x = 0; x < 200; x++)
            {
                y = 10;
                mybitmap.SetPixel(x, 1, Color.Red);
            }
            pictureBox1.Image = mybitmap;
            // Draw a vertical line
            for (x = 0; x < 100; x++)
            {
                for (y = 0; y < 100; y++)
                {
                    mybitmap.SetPixel(200 - 1 - x, x, Color.Red);
                }
            }
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            SizeF StringSize = grfx.MeasureString("Hossam Talaat Al-Mikhlafe",this.Font);

            grfx.DrawString("Hossam Talaat Al-Mikhlafe",this.Font,
                Brushes.Red,
                (this.ClientSize.Width-StringSize.Width) /2,
                (this.ClientSize.Height-StringSize.Height)/2);

            Pen P = new Pen(Color.Turquoise, 20);
            grfx.DrawRectangle(P, 100,200,100,10);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
