using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace fractals_2D
{
    public partial class Sierpinski_Triangle : Form
    {
        private Random rand = new Random();
        private float dotWidth;
        private double dotAmount = 0;
        private int dotPerTick;

        public Sierpinski_Triangle()
        {
            InitializeComponent();
        }


        List<PointF> Corners;

        PointF LastPoint;

        private void DefineCorners()
        {
            Corners = new List<PointF>();
            Corners.Add(new PointF(pictureBoxScreen.Width / 2, 10));
            Corners.Add(new PointF(10, pictureBoxScreen.Height - 10));
            Corners.Add(new PointF(pictureBoxScreen.Width - 10, pictureBoxScreen.ClientSize.Height - 10));

            if (!checkBoxRndFirstDot.Checked)
                LastPoint = Corners[0];
            else if (checkBoxRndFirstDot.Checked)
                LastPoint = new PointF(rand.Next(0, pictureBoxScreen.Width / 2), rand.Next(0, pictureBoxScreen.Height / 2));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DefineCorners();
            numericUpDownDotSpeed_ValueChanged(sender, e);
            comboBoxColor.SelectedIndex = 0;
            dotAmount = 0;
            if (checkBoxOnePerTick.Checked)
                dotPerTick = 1;
            else
                dotPerTick = 1000;
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            if (checkBoxOnePerTick.Checked)
                dotPerTick = 1;
            else
                dotPerTick = 1000;
            
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                Pen pen;
                if (numericUpDownDotAmount.Value == 0)
                    for (int i = 1; i <= dotPerTick; i++)
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
        private void numericUpDownDotSpeed_ValueChanged(object sender, EventArgs e)
        {
            timerDraw.Interval = Convert.ToInt16(numericUpDownDotSpeed.Value);
        }

        private void numericUpDownDotWidth_ValueChanged(object sender, EventArgs e)
        {
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            buttonToMenu.Enabled = false;
            if (numericUpDownDotAmount.Value == 0)
                timerDraw.Enabled = true;
            else
                timerDraw_Tick(sender, e);
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
            if(dotAmount == 1){
                Pen pen = new Pen(Color.Brown, dotWidth);
                using (Graphics gr = pictureBoxScreen.CreateGraphics())
                {
                    gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y, dotWidth, dotWidth);
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
            buttonToMenu.Enabled = true;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            DefineCorners();
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.Clear(this.BackColor);
            }
            timerDraw.Enabled = false;
            buttonToMenu.Enabled = true;
            dotAmount = 0;
            this.Text = $"Треугольник Серпинского(Точек на экране: {dotAmount})";
        }

        private void Sierpinski_Triangle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
