using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad;

namespace Presentacion
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public User Usuario = new User(true);
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            } 
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        public bool Verificar()
        {
            try
            {
                if (Validar.SoloContraseña(textBoxUsuario.Text))
                {
                    if (Validar.SoloContraseña(textBoxPassword.Text))
                    {
                       var User = Usuario.ControlPasswword(textBoxUsuario.Text.Trim(), Encriptacion.Encriptar(textBoxPassword.Text.Trim()));
                        if (User != null)
                        {
                            Usuario = User;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No coinciden la contraseña o Usuario");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo alfabetico sin espacios");
                        textBoxPassword.Text = String.Empty;
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Solo alfabetico sin espacios");
                    textBoxUsuario.Text = String.Empty;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }


    

    
        private void Form_Login_Load(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonIngresar_Click(null, null);
            }
        }
    }
}
