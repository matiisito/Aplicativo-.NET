using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Tecnogas2._1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Usuario");
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese Contraseña");
            }
            else
            {
                string query = "SELECT COUNT(*) FROM USUARIO WHERE NOMBRE_USUARIO='" + txtUsuario.Text + "' AND CLAVE_USUARIO ='" + txtContraseña.Text + "'";
                Conecta c = new Conecta();
                DataSet ds = c.AterrizaResultadoConsulta(query, "USUARIO");
                if(ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Menu m = new Menu();
                    m.Show();
                }
                else
                {  
                MessageBox.Show("Usuario o contraseña Incorrecto");
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingrese Usuario");
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Ingrese Contraseña");
                }
                else
                {
                    string query = "SELECT COUNT(*) FROM USUARIO WHERE NOMBRE_USUARIO='" + txtUsuario.Text + "' AND CLAVE_USUARIO ='" + txtContraseña.Text + "'";
                    Conecta c = new Conecta();
                    DataSet ds = c.AterrizaResultadoConsulta(query, "USUARIO");
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Menu m = new Menu();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña Incorrecto");
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
