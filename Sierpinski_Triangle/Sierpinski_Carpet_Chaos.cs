using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace fractals_2D
{
    public partial class Sierpinski_Carpet_Chaos : Form
    {
        private Random rand = new Random();
        private float dotWidth;
        private double dotAmount = 0;
        private int dotPerTick;
        private Pen pen;

        public Sierpinski_Carpet_Chaos()
        {
            InitializeComponent();
        }


        List<PointF> Corners;

        PointF LastPoint;

        private void DefineCorners()
        {
            Corners = new List<PointF>();
            Corners.Add(new PointF(0, 0));
            Corners.Add(new PointF(pictureBoxScreen.Width * 2 , 0));
            Corners.Add(new PointF(0, pictureBoxScreen.Height * 2));
            Corners.Add(new PointF(pictureBoxScreen.Width * 2, pictureBoxScreen.Height * 2));

            Corners.Add(new PointF(pictureBoxScreen.Width, 0));
            Corners.Add(new PointF(pictureBoxScreen.Width * 2, pictureBoxScreen.Height));
            Corners.Add(new PointF(pictureBoxScreen.Width, pictureBoxScreen.Height * 2));
            Corners.Add(new PointF(0, pictureBoxScreen.Height));
            
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

            comboBoxColor.ForeColor = Color.FromName(comboBoxColor.SelectedItem.ToString());
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                if (checkBoxOnePerTick.Checked)
                {
                    int j = rand.Next(0, Corners.Count);
                    LastPoint = new PointF(
                        (LastPoint.X + Corners[j].X) / 3,
                        (LastPoint.Y + Corners[j].Y) / 3);
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
                {
                    for (int i = 1; i <= numericUpDownDotAmount.Value; i++)
                    {
                        int j = rand.Next(0, Corners.Count);
                        LastPoint = new PointF(
                             (LastPoint.X + Corners[j].X)  / 3 ,
                             (LastPoint.Y + Corners[j].Y) / 3);
                        if (!checkBoxRndColors.Checked)
                            pen = new Pen(Color.FromName(comboBoxColor.SelectedItem.ToString()), dotWidth);
                        else
                            pen = new Pen(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)), dotWidth);
                        gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y,
                            dotWidth, dotWidth);
                        dotAmount++;
                        this.Text = $"Треугольник Серпинского(Точек на экране: {dotAmount})";
                    }
                    checkBoxOnePerTick.Enabled = true;
                    buttonToMenu.Enabled = true;
                }
            }
        }

        private void pictureBoxScreen_Resize(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
            DefineCorners();
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
            checkBoxOnePerTick.Enabled = false;
            if (checkBoxOnePerTick.Checked)
                timerDraw.Enabled = true;
            else
                timerDraw_Tick(sender, e);
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
            if(dotAmount == 1){
                pen = new Pen(Color.Brown, dotWidth);
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
            checkBoxOnePerTick.Enabled = true;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            DefineCorners();
            timerDraw.Enabled = false;
            buttonToMenu.Enabled = true;
            checkBoxOnePerTick.Enabled = true;
            dotAmount = 0;
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.Clear(this.BackColor);
            }
            this.Text = $"Треугольник Серпинского(Точек на экране: {dotAmount})";
        }

        private void Sierpinski_Triangle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxColor_Enter(object sender, EventArgs e)
        {
            comboBoxColor.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void comboBoxColor_Leave(object sender, EventArgs e)
        {
            comboBoxColor.ForeColor = Color.FromName(comboBoxColor.SelectedItem.ToString());
        }

        private void checkBoxRndColors_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxColor.Enabled = !checkBoxRndColors.Checked;
        }

        private void checkBoxOnePerTick_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDotSpeed.Enabled = checkBoxOnePerTick.Checked;
            numericUpDownDotAmount.Enabled = !checkBoxOnePerTick.Checked;
            if (!checkBoxOnePerTick.Checked)
                MessageBox.Show("Для установки количества точек используется цикл который приостанавливет роботу программи. Не ставте большое количесто точек !", "Предупреждение !");
        }
    }
}
