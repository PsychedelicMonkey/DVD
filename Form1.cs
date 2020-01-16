using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVD
{
    public partial class Form1 : Form
    {
        private double speedX = 2.5, speedY = 2.5;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Start();

            dvd.Left = rand.Next(0, this.Width - dvd.Width);
            dvd.Top = rand.Next(0, this.Height - dvd.Height - 5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dvd.Top -= (int) speedY;
            dvd.Left -= (int) speedX;

            if (dvd.Top < 0 || dvd.Bottom >= this.Height - 30)
            {
                speedY *= -1;
            }
            if (dvd.Left < 0 || dvd.Right >= this.Width - 10)
            {
                speedX *= -1;
            }
        }
    }
}
