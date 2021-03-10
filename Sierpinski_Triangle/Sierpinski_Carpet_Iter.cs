using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace fractals_2D
{
    public partial class Sierpinski_Carpet_Iter : Form
    {
        public Sierpinski_Carpet_Iter()
        {
            InitializeComponent();
        }

        private void SierpinskiCarpet_Load(object sender, EventArgs e)
        {
            trackBar1_Scroll(sender, e);
            pictureBoxScreen.Width = pictureBoxScreen.Height;
            comboBoxColor.SelectedIndex = 0;
            comboBoxResolution.SelectedIndex = 0;
        }

        private void CarpetDraw(Graphics gr, int depthLevel, RectangleF rect, string color = "black")
        {
            
            SolidBrush solidBrush = new SolidBrush(Color.FromName(color));
            if (depthLevel == 0)
            {
                gr.FillRectangle(solidBrush, rect);
            }
            else
            {
                
                float Width = rect.Width / 3f;
                float x0 = rect.Left;
                float x1 = x0 + Width;
                float x2 = x0 + Width * 2f;

                float Height = rect.Height / 3f;
                float y0 = rect.Top;
                float y1 = y0 + Height;
                float y2 = y0 + Height * 2f;


                CarpetDraw(gr, depthLevel - 1, new RectangleF(x0, y0, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x1, y0, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x2, y0, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x0, y1, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x2, y1, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x0, y2, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x1, y2, Width, Height), color);
                CarpetDraw(gr, depthLevel - 1, new RectangleF(x2, y2, Width, Height), color);
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

        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Graphics gr = pictureBoxScreen.CreateGraphics()) 
            {
                gr.Clear(this.BackColor);
            }

            switch (comboBoxResolution.SelectedIndex)
            {
                case 0:
                    pictureBoxScreen.Size = new Size(500,500);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
                case 1:
                    pictureBoxScreen.Size = new Size(600, 600);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
                case 2:
                    pictureBoxScreen.Size = new Size(700, 700);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
                case 3:
                    pictureBoxScreen.Size = new Size(700, 700);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
                case 4:
                    pictureBoxScreen.Size = new Size(800, 800);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
                case 5:
                    pictureBoxScreen.Size = new Size(900, 900);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
                case 6:
                    pictureBoxScreen.Size = new Size(1000, 1000);
                    this.Size = new Size(pictureBoxScreen.Width + 300, pictureBoxScreen.Size.Height + 40);
                    break;
            }
        }

        private void Sierpinski_Carpet_Iter_ResizeEnd(object sender, EventArgs e)
        {
            comboBoxResolution_SelectedIndexChanged(sender, e);
        }
    }
}
