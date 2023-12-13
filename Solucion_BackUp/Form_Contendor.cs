using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form_Contenedor : Form
    {
        public Form_Contenedor()
        {
            InitializeComponent();
        }


        User Usuario = null;
        Form_Login _Login = null;
        Form_Hash _Hash = null;
        Form_Informe _Registro = null;
        Form_BackUp _BackUp = null;
        Form_Contraseña _Contrasena = null;
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario = null;
            _Login = new Form_Login();
            var result = _Login.ShowDialog();
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                this.Usuario = _Login.Usuario;
                _Login = null;
            }
            toolStripStatusLabel1.Text = $"Usuario: " + this.Usuario.NombreUsuario;

        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usuario.NombreUsuario != null)
            {
                this.Hide();
                _Registro = new Form_Informe(Usuario);
                _Registro.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existe ningun usuario logueado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Usuario.NombreUsuario != null)
            {
                this.Hide();
                _BackUp = new Form_BackUp(Usuario);
                _BackUp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existe ningun usuario logueado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HashStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usuario.NombreUsuario != null)
            {
                this.Hide();
                _Hash = new Form_Hash(Usuario);
                _Hash.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existe ningun usuario logueado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CustodiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente");
        }

        private void Form_Contenedor_Load(object sender, EventArgs e)
        {
            _Login = new Form_Login();
            var result = _Login.ShowDialog();

            if (result == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                this.Usuario = _Login.Usuario;
                _Login = null;
            }
            toolStripStatusLabel1.Text = $"Usuario: " + this.Usuario.NombreUsuario;


        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usuario.NombreUsuario != null)
            {
                this.Hide();
                _Contrasena = new Form_Contraseña(Usuario);
                _Contrasena.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existe ningun usuario logueado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
