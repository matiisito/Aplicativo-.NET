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
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.PRODUCTO_MAS_VENDIDO' Puede moverla o quitarla según sea necesario.
            this.PRODUCTO_MAS_VENDIDOTableAdapter.Fill(this.DataSet1.PRODUCTO_MAS_VENDIDO);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }
    }
}
