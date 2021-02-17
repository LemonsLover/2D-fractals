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
            new Sierpinski_Triangle().Show();
            this.Hide();
        }

        private void buttonToCarpet_Click(object sender, EventArgs e)
        {
            new Sierpinski_Carpet().Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
