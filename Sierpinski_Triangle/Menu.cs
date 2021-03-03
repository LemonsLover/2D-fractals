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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonToTriangle_Click(object sender, EventArgs e)
        {
            new Sierpinski_Triangle_Chaos().Show();
            this.Hide();
        }

        private void buttonToCarpet_Click(object sender, EventArgs e)
        {
            new Sierpinski_Carpet_Iter().Show();
            this.Hide();
        }

        private void buttonToCarpetChaos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке !");
        }

        private void buttonToTriangleIter_Click(object sender, EventArgs e)
        {
            new Sierpinski_Triangle_Iter().Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
