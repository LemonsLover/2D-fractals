using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sierpinski_Triangle
{
    public partial class mainScreen : Form
    {
        public float dotWidth;
        public double dotAmount = 0;
        public int dotATick;

        public mainScreen()
        {
            InitializeComponent();
        }


        List<PointF> Corners;

        PointF LastPoint;

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            DefineCorners();
            if (numericUpDownDotAmount.Value == 0)
                timerDraw.Enabled = true;
            else
                timerDraw_Tick(sender, e);
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
            Pen pen = new Pen(Color.Brown, dotWidth);
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y, dotWidth, dotWidth);
            }
        }

        private void DefineCorners()
        {
            Random rand = new Random();
            Corners = new List<PointF>();
            Corners.Add(new PointF(pictureBoxScreen.Width / 2, 10));
            Corners.Add(new PointF(10, pictureBoxScreen.Height - 10));
            Corners.Add(new PointF(pictureBoxScreen.Width - 10, pictureBoxScreen.ClientSize.Height - 10));

            if (!checkBoxRndFirstDot.Checked)
                LastPoint = Corners[0];
            else if(checkBoxRndFirstDot.Checked)
                LastPoint = new PointF(rand.Next(0, pictureBoxScreen.Width/2), rand.Next(0, pictureBoxScreen.Height/2));
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            DefineCorners();
            numericUpDownDotSpeed_ValueChanged(sender, e);
            comboBoxColor.SelectedIndex = 0;
            dotAmount = 0;
            if (checkBoxOneATick.Checked)
                dotATick = 1;
            else
                dotATick = 1000;
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            if (checkBoxOneATick.Checked)
                dotATick = 1;
            else
                dotATick = 1000;
            Random rand = new Random();
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                Pen pen;
                if (numericUpDownDotAmount.Value == 0)
                    for (int i = 1; i <= dotATick; i++)
                    {
                    int j = rand.Next(0, 3);
                    LastPoint = new PointF(
                        (LastPoint.X + Corners[j].X) / 2,
                        (LastPoint.Y + Corners[j].Y) / 2);
                        if (!checkBoxRndColors.Checked)
                            pen = new Pen(Color.FromName(comboBoxColor.SelectedItem.ToString()), dotWidth);
                        else
                            pen = new Pen(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)), dotWidth);
                        gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y,
                        dotWidth, dotWidth);
                        dotAmount ++;
                        this.Text = $"Треугольник Серпинского(Точек на экране: {dotAmount})";
                    }
                else
                    for (int i = 1; i <= numericUpDownDotAmount.Value; i++)
                    {
                        int j = rand.Next(0, 3);
                        LastPoint = new PointF(
                            (LastPoint.X + Corners[j].X) / 2,
                            (LastPoint.Y + Corners[j].Y) / 2);
                        if (!checkBoxRndColors.Checked)
                            pen = new Pen(Color.FromName(comboBoxColor.SelectedItem.ToString()), dotWidth);
                        else
                            pen = new Pen(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)), dotWidth);
                        gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y,
                            dotWidth, dotWidth);
                        dotAmount++;
                        this.Text = $"Треугольник Серпинского(Точек на экране: {dotAmount})";
                    }
            }
        }

        private void pictureBoxScreen_Resize(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
            DefineCorners();

            //using (Graphics gr = pictureBoxScreen.CreateGraphics())
            //{
            //    gr.Clear(this.BackColor);
            //}
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.Clear(this.BackColor);
            }
            timerDraw.Enabled = false;
            dotAmount = 0;
            this.Text = $"Треугольник Серпинского(Точек на экране: {dotAmount})";
        }

        private void numericUpDownDotSpeed_ValueChanged(object sender, EventArgs e)
        {
            timerDraw.Interval = Convert.ToInt16(numericUpDownDotSpeed.Value);
        }

        private void numericUpDownDotWidth_ValueChanged(object sender, EventArgs e)
        {
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
        }
    }
}
