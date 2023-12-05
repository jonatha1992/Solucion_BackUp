﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Form_Hash : Form
    {
        List<string> NombreArchivos = new List<string>();
        List<string> RutaArchivos = new List<string>();
        Formulario_Hash formulario_hash = new Formulario_Hash();
        List<Oficial> listaOficiales = new List<Oficial>();
        List<Jerarquia> listaJerarquias = Jerarquia.ListarJeraquias();
        List<Destino> listaDestinos = Destino.ListarDestinos();
        User User; 

        string carpetaSeleccionada;



        public Form_Hash(User usuario )
        {
            InitializeComponent();

            try
            {
                ObternerSugerencias();
                labelPesoTotal.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObternerSugerencias()
        {
            comboBoxJerarquiaRecibe.DataSource = listaJerarquias;
            comboBoxJerarquiaEntrega.DataSource = listaJerarquias?.ConvertAll(item => (Jerarquia)item.Clone());

            comboBoxDestRecibe.DataSource = listaDestinos;
            comboBoxDestEntrega.DataSource = listaDestinos?.ConvertAll(item => (Destino)item.Clone());

            listaOficiales = Oficial.ObtenerOficiales();



            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (Oficial oficial in listaOficiales)
            {
                source.Add(oficial.NombreCompleto);
            }
            textBoxNomEntrega.AutoCompleteCustomSource = source;
            textBoxNomEntrega.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxNomEntrega.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxNomOfRecibe.AutoCompleteCustomSource = source;
            textBoxNomOfRecibe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxNomOfRecibe.AutoCompleteSource = AutoCompleteSource.CustomSource;



            AutoCompleteStringCollection source2 = new AutoCompleteStringCollection();
            textBoxDescripcion.AutoCompleteCustomSource = source2;
            textBoxDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private string calcularHash(string rutaArchivo)
        {
            string hash = "";
            long fileSize = new FileInfo(rutaArchivo).Length;
            long totalBytesRead = 0;
            using (var stream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 1048576, FileOptions.SequentialScan))
            {
                using (var sha = SHA256.Create())
                {
                    byte[] buffer = new byte[1048576];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        sha.TransformBlock(buffer, 0, bytesRead, buffer, 0);

                        totalBytesRead += bytesRead;
                    }
                    sha.TransformFinalBlock(buffer, 0, 0);
                    byte[] hashBytes = sha.Hash;
                    hash = BitConverter.ToString(hashBytes).Replace("-", "");
                }
            }
            return hash;
        }
        private void buttonCarpetaSeleccionada_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialogoSeleccionCarpeta = new FolderBrowserDialog();
                dialogoSeleccionCarpeta.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult resultado = dialogoSeleccionCarpeta.ShowDialog();

                // Verificar si el usuario seleccionó una carpeta
                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(dialogoSeleccionCarpeta.SelectedPath))
                {
                    // La carpeta seleccionada por el usuario
                    carpetaSeleccionada = dialogoSeleccionCarpeta.SelectedPath;

                    MostrarSpriner();

                    RutaArchivos.Clear();   
                    RutaArchivos.AddRange(Directory.GetFiles(carpetaSeleccionada, "*", SearchOption.AllDirectories));

                    int totalArchivos = RutaArchivos.Count;
                    circularProgressBar1.Maximum = totalArchivos;
                    int archivosProcesados = 0;


                    // Mostrar los nombres de los archivos en la consola
                    foreach (string archivo in RutaArchivos)
                    {
                        Archivo archivo1 = new Archivo(archivo);
                        archivo1.Hash = calcularHash(archivo);

                        archivo1.Nro_Orden = formulario_hash.ListaArchivos.Count + 1;
                    
                        formulario_hash.ListaArchivos.Add(archivo1);
                        NombreArchivos.Add(archivo1.Nombre);

                        archivosProcesados++;
                        circularProgressBar1.Value = archivosProcesados;
                        circularProgressBar1.Text = $"{(int)((archivosProcesados / (double)totalArchivos) * 100)}%";
                    }
                    OcultarSpriner();
                    Actualizar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void MostrarSpriner()
        {
            circularProgressBar1.Text = "0%";
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Visible = true;
        }
        public void OcultarSpriner()
        {
            circularProgressBar1.Visible = false;

        }
        private void Actualizar()
        {
            formulario_hash.Contar();
            lblAudio.Text = formulario_hash.Texto.ToString();
            lblClip.Text = formulario_hash.Clips.ToString();
            lblAudio.Text = formulario_hash.Audio.ToString();
            lblImg.Text = formulario_hash.Imagenes.ToString();
            lblVarios.Text = formulario_hash.Varios.ToString();


            DgvElementos.DataSource = null;
            DgvElementos.DataSource = formulario_hash.ListaArchivos;
            DgvElementos.Columns["Nro_Orden"].HeaderText = "Nro Orden";
            DgvElementos.Columns["PesoArchivo"].HeaderText = "Peso";
            DgvElementos.Columns["Hash"].HeaderText = "Hash SHA 256";
            DgvElementos.Columns["SI"].Visible = false;
            DgvElementos.Columns["Extension"].HeaderText = "Ext.";
            DgvElementos.Columns["Nro_Orden"].Width = 40;
            DgvElementos.Columns["Extension"].Width = 35;
            DgvElementos.Columns["PesoArchivo"].Width = 65;
            DgvElementos.Columns["Peso"].Visible = false;
            labelPesoTotal.Text = formulario_hash.pesototal;

        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var elementosSeleccioados = DgvElementos.SelectedRows  ;

                foreach (DataGridViewRow item in elementosSeleccioados)
                {
                    Archivo archivo = item.DataBoundItem as Archivo;  
                    NombreArchivos.Remove(NombreArchivos.Find(x=>x.Contains(archivo.Nombre)));
                    formulario_hash.ListaArchivos.Remove(formulario_hash.ListaArchivos.Find(x => x.Nombre.Contains(archivo.Nombre)));
                }
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxNomOfRecibe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var oficial = listaOficiales.Find(X => X.NombreCompleto == textBoxNomOfRecibe.Text);

                if (oficial != null)
                {
                    numericUpDownRecibe.Value = oficial.Legajo;
                    comboBoxJerarquiaRecibe.Text = oficial.Jerarquia.Nombre;
                    comboBoxDestRecibe.Text = oficial.Destino.Nombre;

                }
            }
        }

        private void textBoxNomEntrega_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var oficial = listaOficiales.Find(X => X.NombreCompleto == textBoxNomEntrega.Text);

                if (oficial != null)
                {
                    numericUpDownEntrega.Value = oficial.Legajo;
                    comboBoxJerarquiaEntrega.Text = oficial.Jerarquia.Nombre;
                    comboBoxDestEntrega.Text = oficial.Destino?.Nombre;
                }
            }
        }

        private bool CargarFormularioHash()
        {
            try
            {

                formulario_hash.Nro_Hash = (int)numericUpDownHash.Value;
                formulario_hash.Descripcion = textBoxDescripcion.Text;
                formulario_hash.OfEntrega = new Oficial(Convert.ToInt32(numericUpDownEntrega.Value), textBoxNomEntrega.Text);
                formulario_hash.OfEntrega.Jerarquia = (Jerarquia)comboBoxJerarquiaEntrega.SelectedItem;
                formulario_hash.OfEntrega.Destino = new Destino(comboBoxDestEntrega.Text);
                Destino.AgregaDestino(formulario_hash.OfEntrega.Destino);
                Oficial.AgregarOficial(formulario_hash.OfEntrega);

                if (checkBoxRecibe.Checked)
                {
                    formulario_hash.OfRecibe = new Oficial(Convert.ToInt32(numericUpDownRecibe.Value), textBoxNomOfRecibe.Text);
                    formulario_hash.OfRecibe.Jerarquia = (Jerarquia)comboBoxJerarquiaRecibe.SelectedItem;
                    formulario_hash.OfRecibe.Destino = new Destino(comboBoxDestRecibe.Text);
                    Oficial.AgregarOficial(formulario_hash.OfRecibe);
                    Destino.AgregaDestino(formulario_hash.OfRecibe.Destino);
                }
                else
                {
                    formulario_hash.OfRecibe = null;
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private void buttonImprimirHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CargarFormularioHash();

                    if ( DgvElementos.DataSource != null && DgvElementos.Rows?.Count > 0)
                    {
                        Form_Impresion form_Impresion = new Form_Impresion(formulario_hash);
                        form_Impresion.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Falta informacion para realizar el Hash", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var oficial = listaOficiales.Find(X => X.Legajo == Convert.ToInt32(numericUpDownEntrega.Value));

                if (oficial != null)
                {
                    textBoxNomEntrega.Text = oficial.NombreCompleto;
                    comboBoxJerarquiaEntrega.Text = oficial.Jerarquia.Nombre;
                    comboBoxDestEntrega.Text = oficial.Destino.Nombre;

                }
            }
        }

        private void numericUpDownRecibe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var oficial = listaOficiales.Find(X => X.Legajo == Convert.ToInt32(numericUpDownRecibe.Value));

                if (oficial != null)
                {
                    textBoxNomOfRecibe.Text = oficial.NombreCompleto;
                    comboBoxJerarquiaRecibe.Text = oficial.Jerarquia.Nombre;
                    comboBoxDestRecibe.Text = oficial.Destino.Nombre;

                }
            }
        }



        private bool Validar()
        {
            bool camposDiferentes = textBoxNomEntrega.Text != textBoxNomOfRecibe.Text ||
                                   numericUpDownEntrega.Value != numericUpDownRecibe.Value;
            if (camposDiferentes)
            {
                if (checkBoxRecibe.Checked)
                {
                    return ValidarRecibe();
                }
                else
                {
                    return ValidarEntrega();
                }
            }
            return false;
        }

        private bool ValidarEntrega()
        {
            return !string.IsNullOrWhiteSpace(textBoxNomEntrega.Text) &&
                   numericUpDownEntrega.Value != 0 &&
                   !string.IsNullOrWhiteSpace(comboBoxDestEntrega.Text);
        }

        private bool ValidarRecibe()
        {
            return !string.IsNullOrWhiteSpace(textBoxNomOfRecibe.Text) &&
                   numericUpDownRecibe.Value != 0 &&
                   !string.IsNullOrWhiteSpace(comboBoxDestRecibe.Text);
        }


   
        private void checkBoxRecibe_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNomOfRecibe.Enabled = checkBoxRecibe.Checked;
            comboBoxJerarquiaRecibe.Enabled = checkBoxRecibe.Checked;
            numericUpDownRecibe.Enabled = checkBoxRecibe.Checked;
            comboBoxDestRecibe.Enabled = checkBoxRecibe.Checked;
        }

        private void DgvElementos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvElementos.SelectedRows.Count > 0)
            {
                buttonEliminar.Visible = true;
            }
            else
            {
                buttonEliminar.Visible = false;
            }
        }
    }
}



