using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Gray);
            Pen drawPen = new Pen(Color.Yellow, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawEllipse(drawPen, 300, 90, 200, 200);
            g.FillEllipse(drawBrush, 300, 90, 200, 200);
            Font drawFont = new Font("Futura", 16, FontStyle.Bold);
            SolidBrush drawyellowbrush = new SolidBrush(Color.Yellow);
            g.DrawString("Twenty One Pilots", drawFont, drawBrush, 50, 40);
            g.DrawRectangle(drawPen, 300, 150, 105, 30);
        }
    }
}
