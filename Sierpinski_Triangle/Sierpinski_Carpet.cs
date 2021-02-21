using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace fractals_2D
{
    public partial class Sierpinski_Carpet : Form
    {

        public Sierpinski_Carpet()
        {
            InitializeComponent();
        }

        private void SierpinskiCarpet_Load(object sender, EventArgs e)
        {
            trackBar1_Scroll(sender, e);
            pictureBoxScreen.Width = pictureBoxScreen.Height;
            comboBoxColor.SelectedIndex = 2;
        }

        private void CarpetDraw(Graphics gr, int depthLevel, RectangleF rect, string color = "blue")
        {
            
            SolidBrush solidBrush = new SolidBrush(Color.FromName(color));
            if (depthLevel == 0)
            {
                gr.FillRectangle(solidBrush, rect);
            }
            else
            {
                
                float width = rect.Width / 3f;
                float x0 = rect.Left;
                float x1 = x0 + width;
                float x2 = x0 + width * 2f;

                float height = rect.Height / 3f;
                float y0 = rect.Top;
                float y1 = y0 + height;
                float y2 = y0 + height * 2f;


                CarpetDraw(gr, depthLevel - 1, new RectangleF(x0, y0, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x1, y0, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x2, y0, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x0, y1, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x2, y1, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x0, y2, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x1, y2, width, height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x2, y2, width, height), color);
            }
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelDepth.Text = $"Глубина: {trackBarDepth.Value}";
        }

        private void SierpinskiCarpet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.Clear(this.BackColor);
                CarpetDraw(gr, trackBarDepth.Value, new RectangleF(0, 0, pictureBoxScreen.Height, pictureBoxScreen.Width), comboBoxColor.SelectedItem.ToString());
            }
        }
    }
}
