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
    public partial class TablaStock : Form
    {
        public TablaStock()
        {
            InitializeComponent();
        }

        private void TablaStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.STOCK' Puede moverla o quitarla según sea necesario.
            this.STOCKTableAdapter.Fill(this.DataSet1.STOCK);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.PRODUCTOTableAdapter.Fill(this.DataSet1.PRODUCTO);

            this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
