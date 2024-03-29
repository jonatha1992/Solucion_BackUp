﻿using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using Presentacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Form_BackUp : Form
    {
        public Form_BackUp(User usuario = null)
        {

            InitializeComponent();
            comboBoxMedida.DataSource = new List<string> { "GB", "MB", "KB", "TB" };

            if (usuario != null) { user = usuario; }
        }



        User user;
        string filePath = "BASE.xlsx";
        string Hoja = "BACKUP";
        List<Registro> registros = new List<Registro>();
        Registro registroSeleccionado;
        List<string> SugerenciasDVD = new List<string>();
        List<string> SugerenciasConfeccionado = new List<string>();
        List<string> SugerenciasCaratula = new List<string>();



        private void Form_BackUp_Load(object sender, EventArgs e)
        {
            try
            {
                ObtenerRegistrosExcel();
                ObtenerSugerenciasExcel();
                CargarGrilla(registros);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"error {ex.Message}");
            }

        }

        private void ObtenerRegistrosExcel()
        {
            registros = new List<Registro>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(Hoja); // Obtener la primera hoja del libro

                // Iterar a través de las filas del archivo Excel
                foreach (var row in worksheet.RowsUsed().Skip(1)) // Skip(1) para omitir la primera fila (encabezados)
                {

                    if (row.Cell(1).IsEmpty())
                    {
                        break; // Salir completamente del bucle
                    }
                    // Si llegamos a este punto, la primera celda tiene información, así que podemos procesar la fila
                    Registro registro = new Registro();
                    registro.Id = row.Cell(1).GetValue<int>();
                    registro.NroBackUp = row.Cell(2).GetValue<int>();
                    registro.ParteBackUp = row.Cell(3).GetString();
                    registro.FechaBackUP = row.Cell(4).GetString();
                    registro.DVD = row.Cell(5).GetString();
                    registro.ParteDVD = row.Cell(6).GetString();
                    registro.Caratula = row.Cell(7).GetString();
                    registro.Peso = row.Cell(9).GetString();
                    registro.Confeccionado = row.Cell(10).GetString();
                    registro.Observacion = row.Cell(11).GetString();


                    if (!row.Cell(8).IsEmpty()) registro.Fecha_Registro = row.Cell(8).GetDateTime();
                    if (!row.Cell(12).IsEmpty()) registro.Creado = row.Cell(12).GetDateTime();
                    if (!row.Cell(13).IsEmpty()) registro.Modificado = row.Cell(13).GetDateTime();
                    if (!row.Cell(14).IsEmpty()) registro.Usuario.NombreUsuario = row.Cell(14).GetString();
                    else { registro.Usuario = new User("Sin asignar"); }

                    // Agregar el objeto Registro a la lista
                    registros.Add(registro);
                }

            }
            registros.Sort();

        }


        private void ObtenerSugerenciasExcel()
        {

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("BACKUP"); // Obtener la primera hoja del libro

                // Iterar a través de las filas del archivo Excel
                foreach (var row in worksheet.RowsUsed().Skip(1)) // Skip(1) para omitir la primera fila (encabezados)
                {

                    if (row.Cell(1).IsEmpty())
                    {
                        break; // Salir completamente del bucle
                    }
                    // Si llegamos a este punto, la primera celda tiene información, así que podemos procesar la fila
                    string DVD = row.Cell(5).GetString().Trim();
                    if (!SugerenciasDVD.Exists(X => X == DVD))
                    {
                        SugerenciasDVD.Add(DVD);
                    }

                    string Caratula = row.Cell(7).GetString().Trim();
                    if (!SugerenciasCaratula.Exists(X => X == Caratula))
                    {
                        SugerenciasCaratula.Add(Caratula);
                    }

                    string Confeccionado = row.Cell(7).GetString().Trim();
                    if (!SugerenciasConfeccionado.Exists(X => X == Confeccionado))
                    {
                        SugerenciasCaratula.Add(Confeccionado);
                    }
                }

            }

            textBoxCaratula.AutoCompleteCustomSource.AddRange(SugerenciasCaratula.ToArray());
            textBoxDvDs.AutoCompleteCustomSource.AddRange(SugerenciasDVD.ToArray());
            textBoxConfeccionado.AutoCompleteCustomSource.AddRange(SugerenciasConfeccionado.ToArray());
        }
        public bool ValidarControles()
        {
            // Validar NroBackUp
            if (numericUpDownBackUp.Value < 1)
            {
                MessageBox.Show("Debe ingresar un número de Backup válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validar ParteBackUp
            if (string.IsNullOrEmpty(comboBoxParteBackUp.Text))
            {
                MessageBox.Show("Debe seleccionar una parte de Backup", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar DVD
            if (string.IsNullOrEmpty(textBoxDvDs.Text))
            {
                MessageBox.Show("Debe ingresar un número de DVD válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar ParteDVD
            if (string.IsNullOrEmpty(comboBoxParteDVD.Text))
            {
                MessageBox.Show("Debe seleccionar una parte de DVD", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCaratula.Text))
            {
                MessageBox.Show("Debe ingresar una caratula válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validar Peso
            if (numericUpDownPeso.Value == 0)
            {
                MessageBox.Show("Debe ingresar un peso válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxMedida.Text == "")
            {
                MessageBox.Show("Debe seleccionar la medidad del peso válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validar Confeccionado
            if (string.IsNullOrEmpty(textBoxConfeccionado.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad confeccionada válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (registros.Exists(x => x.DVD.ToUpper() == textBoxDvDs.Text && x.ParteDVD == comboBoxParteDVD.Text))
            {
                MessageBox.Show($"El DVD: {textBoxDvDs.Text} Parte {comboBoxParteDVD.Text} ya fue ingresado ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private Registro CrearRegistro()
        {
            Registro registro = new Registro();
            registro.NroBackUp = Convert.ToInt32(numericUpDownBackUp.Value);
            registro.ParteBackUp = comboBoxParteBackUp.Text.Trim();
            registro.FechaBackUP = dateTimePickerMes.Text.ToUpper();
            registro.DVD = textBoxDvDs.Text.Trim();
            registro.ParteDVD = comboBoxParteDVD.Text.Trim();
            registro.Caratula = textBoxCaratula.Text.Trim();
            registro.Fecha_Registro = dateTimePickerFechaRegistro.Value.Date;
            registro.Peso = numericUpDownPeso.Value.ToString() + " " + comboBoxMedida.Text;
            registro.Confeccionado = textBoxConfeccionado.Text.Trim();
            registro.Observacion = textBoxObservacion.Text.Trim();
            registro.Usuario = user;

            SugerenciasDVD.Add(textBoxDvDs.Text);
            SugerenciasConfeccionado.Add(textBoxConfeccionado.Text);
            SugerenciasCaratula.Add(textBoxCaratula.Text);

            return registro;


        }
        private void dgvBack_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dgvBack.Columns[e.ColumnIndex];
            string nombreColumna = column.Name;

            List<Registro> list = dgvBack.DataSource as List<Registro>;

            if (column.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                //registros = registros.OrderByDescending(x => x.GetType().GetProperty(nombreColumna).GetValue(x, null)).ToList();
                //CargarGrilla(registros, nombreColumna , SortOrder.Descending);
                list = list.OrderByDescending(x => x.GetType().GetProperty(nombreColumna).GetValue(x, null)).ToList();
                CargarGrilla(list, nombreColumna, SortOrder.Descending);

            }
            else
            {
                //registros = registros.OrderBy(x => x.GetType().GetProperty(nombreColumna).GetValue(x, null)).ToList();
                //CargarGrilla(registros, nombreColumna , SortOrder.Ascending);
                list = list.OrderBy(x => x.GetType().GetProperty(nombreColumna).GetValue(x, null)).ToList();
                CargarGrilla(list, nombreColumna, SortOrder.Ascending);
            }

        }


        void CargarGrilla(List<Registro> registros, string columna = "", SortOrder sortoder = SortOrder.Ascending)
        {
            dgvBack.DataSource = null;
            dgvBack.DataSource = registros;
            dgvBack.Columns["Id"].Width = 30;
            dgvBack.Columns["NroBackUp"].HeaderText = "Nro BackUp";
            dgvBack.Columns["NroBackUp"].Width = 60;
            dgvBack.Columns["ParteBackUp"].HeaderText = "Parte Backup";
            dgvBack.Columns["ParteBackUp"].Width = 60;
            dgvBack.Columns["FechaBackUp"].HeaderText = "Fecha Backup";
            dgvBack.Columns["FechaBackUp"].Width = 80;
            dgvBack.Columns["ParteDVD"].HeaderText = "Parte DVD";
            dgvBack.Columns["ParteDVD"].Width = 60;
            dgvBack.Columns["Fecha_Registro"].HeaderText = "Fecha Registro";
            dgvBack.Columns["Fecha_Registro"].Width = 60;
            dgvBack.Columns["Peso"].Width = 60;
            //dgvBack.Columns["Confeccionado"].Width = 100;
            dgvBack.Columns["Confeccionado"].Visible = true;
            dgvBack.Columns["Creado"].Width = 90;
            dgvBack.Columns["Modificado"].Width = 90;
            dgvBack.Columns["Usuario"].Width = 90;
            dgvBack.Columns["Creado"].Visible = user.Rol == "ADMIN" || user.Rol == "SUPERVISOR" ? true : false;
            dgvBack.Columns["Modificado"].Visible = user.Rol == "ADMIN" || user.Rol == "SUPERVISOR" ? true : false;
            dgvBack.Columns["Usuario"].Visible = user.Rol == "ADMIN" || user.Rol == "SUPERVISOR" ? true : false;


            DataGridViewColumn columnaOrdenada = dgvBack.Columns[columna];
            if (columnaOrdenada != null)
            {
                columnaOrdenada.HeaderCell.SortGlyphDirection = sortoder;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Comprobar si la celda es válida
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    registroSeleccionado = dgvBack.Rows[e.RowIndex].DataBoundItem as Registro;
                    numericUpDownBackUp.Value = registroSeleccionado?.NroBackUp != 0 ? Convert.ToInt32(registroSeleccionado.NroBackUp) : 0;
                    comboBoxParteBackUp.Text = registroSeleccionado.ParteBackUp != "" ? registroSeleccionado.ParteBackUp : "";
                    dateTimePickerMes.Text = registroSeleccionado.FechaBackUP != "" ? registroSeleccionado.FechaBackUP : DateTime.Now.ToString("MMMM/yyyy");
                    textBoxDvDs.Text = registroSeleccionado.DVD != null ? registroSeleccionado.DVD : "";
                    comboBoxParteDVD.Text = registroSeleccionado.ParteDVD != null ? registroSeleccionado.ParteDVD : "";
                    textBoxCaratula.Text = registroSeleccionado.Caratula != null ? registroSeleccionado.Caratula : "";
                    dateTimePickerFechaRegistro.Value = registroSeleccionado.Fecha_Registro != null ? Convert.ToDateTime(registroSeleccionado.Fecha_Registro) : DateTime.Now;
                    numericUpDownPeso.Value = registroSeleccionado.Peso != "" ? Convert.ToDecimal(registroSeleccionado.Peso.Split(' ')[0].Replace('.', ',')) : 0;
                    comboBoxMedida.Text = registroSeleccionado.Peso != "" ? registroSeleccionado.Peso.Split(' ')[1] : "";
                    textBoxConfeccionado.Text = registroSeleccionado.Confeccionado != null ? registroSeleccionado.Confeccionado : "";
                    textBoxObservacion.Text = registroSeleccionado.Observacion != null ? registroSeleccionado.Observacion : "";
                    HabilitarActualizacion();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void HabilitarRegistro()
        {
            buttonRegistrar.Visible = true;
            buttonActualizar.Visible = false;
            buttonEliminar.Visible = false;
        }
        void HabilitarActualizacion()
        {
            buttonRegistrar.Visible = false;
            buttonActualizar.Visible = true;
            buttonEliminar.Visible = user.Rol == "ADMIN" ? true : false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Registro registroABuscar = CrearRegistro();

                List<Registro> registroBuscados = new List<Registro>();

                if (registroABuscar.NroBackUp > 0)
                {
                    registroBuscados.AddRange(registros.Where(x => x.NroBackUp == registroABuscar.NroBackUp));
                }

                if (!string.IsNullOrEmpty(registroABuscar.ParteBackUp))
                {
                    registroBuscados.AddRange(registros.Where(x => x.ParteBackUp == registroABuscar.ParteBackUp));
                }
                if (!string.IsNullOrEmpty(registroABuscar.FechaBackUP))
                {
                    registroBuscados.AddRange(registros.Where(x => x.FechaBackUP == registroABuscar.FechaBackUP));
                }
                if (!string.IsNullOrEmpty(registroABuscar.DVD))
                {
                    registroBuscados.AddRange(registros.Where(x => x.DVD.Contains(registroABuscar.DVD)));
                    registroBuscados.RemoveAll(x => !x.DVD.Contains(registroABuscar.DVD));
                }
                if (!string.IsNullOrEmpty(registroABuscar.ParteDVD))
                {
                    registroBuscados.AddRange(registros.Where(x => x.ParteDVD == registroABuscar.ParteDVD));
                }
                if (!string.IsNullOrEmpty(registroABuscar.Caratula))
                {
                    registroBuscados.AddRange(registros.Where(x => x.Caratula.Contains(registroABuscar.Caratula)));
                    registroBuscados.RemoveAll(x => !x.DVD.Contains(registroABuscar.Caratula));
                }
                if (registroABuscar.Fecha_Registro.Value.Date != DateTime.Now.Date)
                {
                    registroBuscados.AddRange(registros.Where(x => x.Fecha_Registro.HasValue && x.Fecha_Registro.Value.Date == registroABuscar.Fecha_Registro.Value.Date));
                }
                if (!string.IsNullOrEmpty(registroABuscar.Confeccionado))
                {
                    registroBuscados.AddRange(registros.Where(x => x.Confeccionado.Contains(registroABuscar.Confeccionado)));
                }
                if (!string.IsNullOrEmpty(registroABuscar.Observacion))
                {
                    registroBuscados.AddRange(registros.Where(x => x.Observacion.Contains(registroABuscar.Observacion)));
                }

                CargarGrilla(registroBuscados);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                registroSeleccionado = null;
                numericUpDownBackUp.Value = 0;
                comboBoxParteBackUp.Text = "";
                dateTimePickerMes.Value = DateTime.Now;
                textBoxDvDs.Text = "";
                comboBoxParteDVD.Text = "";
                dateTimePickerFechaRegistro.Value = DateTime.Now;
                numericUpDownPeso.Value = 0;
                comboBoxMedida.Text = "GB";
                textBoxConfeccionado.Text = "";
                textBoxObservacion.Text = "";
                textBoxCaratula.Text = "";
                HabilitarRegistro();
                ObtenerRegistrosExcel();
                CargarGrilla(registros);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarControles())
                {
                    var nuevo = CrearRegistro();
                    nuevo.Creado = DateTime.Now;
                    AgregarRegistro(nuevo);
                    ObtenerRegistrosExcel();
                    CargarGrilla(registros);
                    HabilitarRegistro();
                    buttonLimpiar_Click(null, null);


                    MessageBox.Show($"Se registro el backup  {nuevo.NroBackUp} parte {nuevo.ParteBackUp} ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (registroSeleccionado != null)
                {
                    var result = MessageBox.Show($"¿Seguro que desea borrar el registro del back-Up {registroSeleccionado.Caratula}?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        EliminarRegistro(registroSeleccionado);
                        MessageBox.Show($"Se elimino el registro del back-Up {registroSeleccionado.Caratula}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonLimpiar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (registroSeleccionado != null)
                {
                    var nuevoRegistro = CrearRegistro();
                    nuevoRegistro.Id = registroSeleccionado.Id;
                    nuevoRegistro.Creado = registroSeleccionado.Creado;
                    nuevoRegistro.Modificado = DateTime.Now;
                    ActualizarRegistro(nuevoRegistro);

                    ObtenerRegistrosExcel();
                    CargarGrilla(registros);

                    MessageBox.Show($"Se modifico el archivo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AgregarRegistro(Registro nuevoRegistro)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);

                    // Encuentra la última fila con datos en la columna A
                    int lastRow = worksheet.LastCellUsed().Address.RowNumber;
                    nuevoRegistro.Id = registros.Max(x => x.Id) + 1;

                    // Asegúrate de que el nuevo registro no exista ya en el Excel antes de agregarlo
                    if (!registros.Any(r => r.Id == nuevoRegistro.Id))
                    {
                        // Agrega el nuevo registro al final del Excel
                        worksheet.Cell(lastRow + 1, 1).Value = nuevoRegistro.Id;
                        worksheet.Cell(lastRow + 1, 2).Value = nuevoRegistro.NroBackUp;
                        worksheet.Cell(lastRow + 1, 3).Value = nuevoRegistro.ParteBackUp;
                        worksheet.Cell(lastRow + 1, 4).Value = nuevoRegistro.FechaBackUP;
                        worksheet.Cell(lastRow + 1, 5).Value = nuevoRegistro.DVD;
                        worksheet.Cell(lastRow + 1, 6).Value = nuevoRegistro.ParteDVD;
                        worksheet.Cell(lastRow + 1, 7).Value = nuevoRegistro.Caratula;
                        worksheet.Cell(lastRow + 1, 8).Value = nuevoRegistro.Fecha_Registro;
                        worksheet.Cell(lastRow + 1, 9).Value = nuevoRegistro.Peso;
                        worksheet.Cell(lastRow + 1, 10).Value = nuevoRegistro.Confeccionado;
                        worksheet.Cell(lastRow + 1, 11).Value = nuevoRegistro.Observacion;
                        worksheet.Cell(lastRow + 1, 12).Value = nuevoRegistro.Creado;
                        worksheet.Cell(lastRow + 1, 13).Value = nuevoRegistro.Modificado;
                        worksheet.Cell(lastRow + 1, 14).Value = nuevoRegistro.Usuario.NombreUsuario;

                        // Guarda los cambios en el archivo Excel
                        workbook.SaveAs(filePath);
                    }
                    else
                    {
                        MessageBox.Show($"Ya existe un registro con NroBackUp {nuevoRegistro.NroBackUp} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar en Excel: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
        private bool ActualizarRegistro(Registro registroActualizado)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);


                    var cell = worksheet.CellsUsed(c => c.WorksheetRow().RowNumber() >= 2)
                               .FirstOrDefault(c =>
                               {
                                   if (int.TryParse(c.GetString(), out int cellValue))
                                   {
                                       return cellValue == registroActualizado.Id;
                                   }
                                   return false;
                               });

                    // Si encuentra la celda, actualiza los valores en esa fila
                    if (cell != null)
                    {
                        var row = cell.WorksheetRow();
                        row.Cell(2).Value = registroActualizado.NroBackUp;
                        row.Cell(3).Value = registroActualizado.ParteBackUp;
                        row.Cell(4).Value = registroActualizado.FechaBackUP;
                        row.Cell(5).Value = registroActualizado.DVD;
                        row.Cell(6).Value = registroActualizado.ParteDVD;
                        row.Cell(7).Value = registroActualizado.Caratula;
                        row.Cell(8).Value = registroActualizado.Fecha_Registro;
                        row.Cell(9).Value = registroActualizado.Peso;
                        row.Cell(10).Value = registroActualizado.Confeccionado;
                        row.Cell(11).Value = registroActualizado.Observacion;
                        row.Cell(12).Value = registroActualizado.Creado;
                        row.Cell(13).Value = registroActualizado.Modificado;
                        row.Cell(14).Value = registroActualizado.Usuario.NombreUsuario;

                        // Guarda los cambios en el archivo Excel
                        workbook.SaveAs(filePath);
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró el registro con NroBackUp {registroActualizado.NroBackUp}, ParteBackUp {registroActualizado.ParteBackUp} y FechaBackUP {registroActualizado.FechaBackUP} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar en Excel: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool EliminarRegistro(Registro registroEliminado)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet("BACKUP");

                    var cell = worksheet.CellsUsed(c => c.WorksheetRow().RowNumber() >= 2)
                                .FirstOrDefault(c =>
                                {
                                    if (int.TryParse(c.GetString(), out int cellValue))
                                    {
                                        return cellValue == registroEliminado.Id;
                                    }
                                    return false;
                                });

                    // Si encuentra la celda, elimina la fila
                    if (cell != null)
                    {
                        var row = cell.WorksheetRow();
                        row.Delete();

                        // Guarda los cambios en el archivo Excel
                        workbook.SaveAs(filePath);
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró el registro con NroBackUp {registroEliminado.NroBackUp}, ParteBackUp {registroEliminado.ParteBackUp} y FechaBackUP {registroEliminado.FechaBackUP} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar en Excel: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
