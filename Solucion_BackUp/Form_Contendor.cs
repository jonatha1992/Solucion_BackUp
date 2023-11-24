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


        Usuario Usuario = null;
        Form_Login _Login = null;
        Form_BackUp _BackUp = null;
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
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
        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _BackUp = new Form_BackUp(Usuario);
            _BackUp.ShowDialog();
            this.Show();

        }

        private void HashStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CustodiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }
    }
}
