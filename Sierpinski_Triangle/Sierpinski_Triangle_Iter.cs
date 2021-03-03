using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fractals_2D
{
    public partial class Sierpinski_Triangle_Iter : Form
    {
        public Sierpinski_Triangle_Iter()
        {
            InitializeComponent();
        }

        private void Sierpinski_Triangle_Iter_Load(object sender, EventArgs e)
        {
            labelDepth.Text = $"Глубина: {trackBarDepth.Value}";
            comboBoxColor.SelectedIndex = 0;
        }


        private void DrawTriangle(Graphics gr, int depthLevel, PointF topPoint, PointF leftPoint, PointF rightPoint, string color = "red")
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromName(color));
            if (depthLevel == 0)
            {
                PointF[] points =
                {
            topPoint, rightPoint, leftPoint
                };
                gr.FillPolygon(solidBrush, points);
            }
            else
            {
                PointF left_mid = new PointF(
                    (topPoint.X + leftPoint.X) / 2f,
                    (topPoint.Y + leftPoint.Y) / 2f);
                PointF right_mid = new PointF(
                    (topPoint.X + rightPoint.X) / 2f,
                    (topPoint.Y + rightPoint.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (leftPoint.X + rightPoint.X) / 2f,
                    (leftPoint.Y + rightPoint.Y) / 2f);

                DrawTriangle(gr, depthLevel - 1,
                    topPoint, left_mid, right_mid, color);
                DrawTriangle(gr, depthLevel - 1,
                    left_mid, leftPoint, bottom_mid, color);
                DrawTriangle(gr, depthLevel - 1,
                    right_mid, bottom_mid, rightPoint, color);
            }
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void Sierpinski_Triangle_Iter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.Clear(this.BackColor);
                DrawTriangle(gr, trackBarDepth.Value, new PointF(pictureBoxScreen.Width/2,0), new PointF(0, pictureBoxScreen.Height), new PointF(pictureBoxScreen.Width, pictureBoxScreen.Height), comboBoxColor.SelectedItem.ToString());
            }
        }

        private void trackBarDepth_Scroll(object sender, EventArgs e)
        {
            labelDepth.Text = $"Глубина: {trackBarDepth.Value}";
        }
    }
}
