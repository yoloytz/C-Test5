using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Rectangle rect = new Rectangle(50,50,500,500);
            LinearGradientBrush brush1 =
                    new LinearGradientBrush(rect,Color.Red,Color.Green,LinearGradientMode.Vertical);

            Font font1 = new Font("Times New Roman", 24);
            string s = "今天是星期二";
            FontFamily[] fontfamily1 = FontFamily.Families;
            int y = 0;
            for(int i = 20; i < 200; i += 20)
            {
                FontFamily famlily = fontfamily1[i];
                Font font2 = new Font(famlily, 20);
                g.DrawString(s, font2, brush1, new PointF(70, y));
                y += 10;
            }
            
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.YellowGreen);
            Graphics g = this.CreateGraphics();
        }
    }
}
