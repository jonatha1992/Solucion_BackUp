
using Seguridad;
using Solucion_BackUp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form_Contraseña : Form
    {
        public Form_Contraseña(User pusuario)
        {
            InitializeComponent();

            if (pusuario != null) { eUsuario = pusuario; }

            roles = new List<string> { "ADMIN", "USUARIO", "SUPERVISOR" };
            Usuarios = eUsuario.ObtenerUsuariosExcel();
        }


        User eUsuario;
        List<string> roles;
        List<User> Usuarios;

        private void FormPermisos_Load(object sender, EventArgs e)
        {
            comboBoxUsuario.DataSource = Usuarios;
            comboBoxRol.DataSource = roles;

            CompleteFields(eUsuario);
            Enable();
            SucribirEventos();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Llamar a MESA DE NO AYUDA", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            e.Cancel = true;
        }
        private void SucribirEventos()
        {
            pictureBoxEyeContra1.Tag = textBoxContra1;
            pictureBoxEyeContra2.Tag = textBoxContra2;
            pictureBoxEyeContra2.Click += pictureBox1raContrasena_Click;
            pictureBoxEyeContra1.Click += pictureBox1raContrasena_Click;
            // Asocia el manejador de eventos al clic del botón de ayuda
            this.HelpButtonClicked += Form1_HelpButtonClicked;
        }

        private void Enable()
        {
            textBoxNombre.Enabled = eUsuario.Rol == "ADMIN" ? true : false;
            textBoxUsuario.Enabled = eUsuario.Rol == "ADMIN" ? true : false;
            comboBoxRol.Enabled = eUsuario.Rol == "ADMIN" ? true : false;
            comboBoxUsuario.Visible = eUsuario.Rol == "ADMIN" ? true : false;
            buttonEliminar.Visible = eUsuario.Rol == "ADMIN" ? true : false;
            buttonNuevo.Visible = eUsuario.Rol == "ADMIN" ? true : false;
            buttonLimpiar.Visible = eUsuario.Rol == "ADMIN" ? true : false;
            labelUsuarios.Visible = eUsuario.Rol == "ADMIN" ? true : false;

           
        }

        private void CompleteFields(User puser)
        {
            textBoxUsuario.Text = puser.NombreUsuario;
            textBoxNombre.Text = puser.NombreCompleto;
            comboBoxRol.Text = puser.Rol;
            textBoxContra1.Text = Encriptacion.Desencriptar(puser.Contraseña);
            textBoxContra2.Text = Encriptacion.Desencriptar(puser.Contraseña);
        }

        private void pictureBox1raContrasena_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                if (pictureBox.Tag is TextBox textBox)
                {
                    // Cambiar la visibilidad de la contraseña en el TextBox
                    textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar;

                    // Cambiar la imagen del PictureBox según la visibilidad del TextBox
                    pictureBox.Image = textBox.UseSystemPasswordChar
                        ? Resources.hide
                        : Resources.eye;
                }
            }
        }



        bool VerficarCamposUsuario()
        {
            if (textBoxContra1.Text != textBoxContra2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxContra1.Text == "" || textBoxContra2.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!roles.Exists(x => x == comboBoxRol.Text))
            {
                MessageBox.Show("No existe ese rol asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {

            if (VerficarCamposUsuario())
            {
                eUsuario.NombreUsuario = textBoxUsuario.Text;
                eUsuario.NombreCompleto = textBoxNombre.Text;
                eUsuario.Rol = comboBoxRol.Text;
                eUsuario.Contraseña = Encriptacion.Encriptar(textBoxContra1.Text);
                if (eUsuario.UpdateUser(eUsuario))
                {
                    MessageBox.Show("!Se cambio la contraseña correctamente¡", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo cambiar la contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (VerficarCamposUsuario())
            {
                if (Usuarios.Exists(x => x.NombreUsuario == textBoxUsuario.Text))
                {
                    User nuevo_user = CrearUser();

                    if (nuevo_user.AddUser(nuevo_user))
                    {
                        MessageBox.Show("!Se agrego el usuario correctamente¡", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show("El usuario ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private User CrearUser()
        {
            var nuevo_user = new User();
            nuevo_user.NombreUsuario = textBoxUsuario.Text.Trim();
            nuevo_user.NombreCompleto = textBoxNombre.Text.Trim();
            nuevo_user.Rol = comboBoxRol.Text.Trim();
            nuevo_user.Contraseña = Encriptacion.Encriptar(textBoxContra1.Text.Trim());
            return nuevo_user;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxUsuario.Text = "";
            comboBoxRol.Text = "";
            textBoxContra1.Text = "";
            textBoxContra2.Text = "";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            if (VerficarCamposUsuario())
            {
                if (!Usuarios.Exists(x => x.NombreUsuario == textBoxUsuario.Text))
                {
                    var user = comboBoxUsuario.SelectedItem as User;
                    user.NombreUsuario = textBoxUsuario.Text.Trim();
                    user.NombreCompleto = textBoxNombre.Text.Trim();
                    user.Rol = comboBoxRol.Text.Trim();
                    user.Contraseña = Encriptacion.Encriptar(textBoxContra1.Text.Trim());

                    if (eUsuario.AddUser(user))
                    {
                        MessageBox.Show("!Se agrego el usuario correctamente¡", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show("El usuario ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (eUsuario != null)
            {
                eUsuario.DeleteUser(eUsuario);
            }
            
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuario.SelectedIndex != -1)
            {
                var user = comboBoxUsuario.SelectedItem as User;
                CompleteFields(user);
            }
        }
    }
}
