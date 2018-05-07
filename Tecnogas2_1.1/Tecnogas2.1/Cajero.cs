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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.CANTIDAD_DE_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.CANTIDAD_DE_PRODUCTOSTableAdapter.Fill(this.DataSet1.CANTIDAD_DE_PRODUCTOS);

            this.reportViewer1.RefreshReport();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }
    }
}
