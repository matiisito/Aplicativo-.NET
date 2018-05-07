using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tecnogas2._1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVendidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalles d = new Detalles();
            d.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaStock T = new TablaStock();
            T.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cajero c = new Cajero();
            c.Show();
        }
    }
}
