using ClosedXML.Excel;
using Microsoft.Win32;
using Presentacion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Form_Registro : Form
    {
        public Form_Registro(User usuario = null)
        {

            InitializeComponent();

            if (usuario != null) { user = usuario; }
        }



        User user;
        string filePath = "BASE.xlsx";
        string Hoja = "REGISTRO";
        List<Informe> Informes = new List<Informe>();
        Informe informeSeleccionado;
        List<string> SugerenciasNroAsunto = new List<string>();
        List<string> SugerenciaTipoDelito = new List<string>();
        List<string> SugerenciaNroSolicitud = new List<string>();
        List<string> SugerenciaSolicitante = new List<string>();
        List<string> SugerenciasCausa = new List<string>();
        List<string> SugerenciasDVD = new List<string>();
        List<string> SugerenciasCaratula = new List<string>();
        List<string> SugerenciaDependecia = new List<string>();
        List<string> SugerenciaInforme = new List<string>();
        List<string> SugerenciaActaElevacion = new List<string>();
        List<string> SugerenciaRetirado = new List<string>();
        List<string> SugerenciaOrganismo = new List<string>();



        private void Form_BackUp_Load(object sender, EventArgs e)
        {
            try
            {
                GetRegisterExcel();
                GetSuggestionExcel();
                LoadGrid(Informes);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"error {ex.Message}");
            }

        }

        private void GetRegisterExcel()
        {
            try
            {

                Informes = new List<Informe>();

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
                        try
                        {

                            // Si llegamos a este punto, la primera celda tiene información, así que podemos procesar la fila
                            Informe informe = new Informe();

                            informe.Id = row.Cell(1).IsEmpty() ? 0 : row.Cell(1).GetValue<int>();
                            informe.NroAsunto = row.Cell(2).IsEmpty() ? null : row.Cell(2).GetString();
                            informe.NroOrden = row.Cell(3).IsEmpty() ? 0 : row.Cell(3).GetValue<int>();
                            informe.Ano = row.Cell(4).IsEmpty() ? 0 : row.Cell(4).GetValue<int>();
                            informe.FechaIngreso = row.Cell(5).IsEmpty() ? (DateTime?)null : row.Cell(5).GetDateTime();
                            informe.TipoDelito = row.Cell(6).IsEmpty() ? null : row.Cell(6).GetString();
                            informe.Solicitante = row.Cell(7).IsEmpty() ? null : row.Cell(7).GetString();
                            informe.NroSolicitud = row.Cell(8).IsEmpty() ? null : row.Cell(8).GetString();
                            informe.NroCausa = row.Cell(9).IsEmpty() ? null : row.Cell(9).GetString();
                            informe.Caratula = row.Cell(10).IsEmpty() ? null : row.Cell(10).GetString();
                            informe.FechaHecho = row.Cell(11).IsEmpty() ? (DateTime?)null : row.Cell(11).GetDateTime();
                            informe.TipoDelito = row.Cell(12).IsEmpty() ? null : row.Cell(12).GetString();
                            informe.Dependecia = row.Cell(13).IsEmpty() ? null : new Destino(row.Cell(13).GetString());
                            informe.NroDVD = row.Cell(14).IsEmpty() ? null : row.Cell(14).GetString();
                            informe.NroInforme = row.Cell(15).IsEmpty() ? null : row.Cell(15).GetString();
                            informe.NroElevacion = row.Cell(16).IsEmpty() ? null : row.Cell(16).GetString();
                            informe.FechaSalida = row.Cell(17).IsEmpty() ? (DateTime?)null : row.Cell(17).GetDateTime();
                            informe.Retirado = row.Cell(18).IsEmpty() ? null : row.Cell(18).GetString();
                            informe.Organismo = row.Cell(19).IsEmpty() ? null : row.Cell(19).GetString();
                            informe.Estado = row.Cell(20).IsEmpty() ? null : row.Cell(20).GetString();
                            informe.Observacion = row.Cell(21).IsEmpty() ? null : row.Cell(21).GetString();
                            informe.Creado = row.Cell(22).IsEmpty() ? (DateTime?)null : row.Cell(22).GetDateTime();
                            informe.Modificado = row.Cell(23).IsEmpty() ? (DateTime?)null : row.Cell(23).GetDateTime();
                            informe.Usuario = row.Cell(24).IsEmpty() ? null : new User(row.Cell(24).GetString());

                            // Agregar el objeto Registro a la lista
                            Informes.Add(informe);
                        }
                        catch (Exception ex)
                        {
                            string mensaje = $"Error en la fila {row.RowNumber()}: {ex.Message} ";
                            // Obtener la referencia a la celda que causó la excepción
                            throw new Exception(mensaje);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}", "Error"); ;
            }

        }


        private void GetSuggestionExcel()
        {

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
                    string Asunto = row.Cell(2).GetString().Trim();
                    if (!SugerenciasNroAsunto.Exists(X => X == Asunto))
                    {
                        SugerenciasCausa.Add(Asunto);
                    }

                    string NroSolicitud = row.Cell(8).GetString().Trim();
                    if (!SugerenciaNroSolicitud.Exists(X => X == NroSolicitud))
                    {
                        SugerenciaNroSolicitud.Add(NroSolicitud);
                    }

                    // Si llegamos a este punto, la primera celda tiene información, así que podemos procesar la fila

                    string Solicitante = row.Cell(7).GetString().Trim();
                    if (!SugerenciaSolicitante.Exists(X => X == Solicitante))
                    {
                        SugerenciaSolicitante.Add(Solicitante);
                    }

                    string Causa = row.Cell(9).GetString().Trim();
                    if (!SugerenciasCausa.Exists(X => X == Causa))
                    {
                        SugerenciasCausa.Add(Causa);
                    }
                
                    string Caratula = row.Cell(10).GetString().Trim();
                    if (!SugerenciasCaratula.Exists(X => X == Caratula))
                    {
                        SugerenciasCaratula.Add(Caratula);
                    }


                    string Dependencia = row.Cell(13).GetString().Trim();
                    if (!SugerenciaDependecia.Exists(X => X == Dependencia))
                    {
                        SugerenciaDependecia.Add(Dependencia);
                    }

                    string DVD = row.Cell(14).GetString().Trim();
                    if (!SugerenciasDVD.Exists(X => X == DVD))
                    {
                        SugerenciasDVD.Add(DVD);
                    }

                    string informe = row.Cell(15).GetString().Trim();
                    if (!SugerenciaInforme.Exists(X => X == informe))
                    {
                        SugerenciaInforme.Add(informe);
                    }

                    string Elevacion = row.Cell(16).GetString().Trim();
                    if (!SugerenciaActaElevacion.Exists(X => X == Elevacion))
                    {
                        SugerenciaActaElevacion.Add(Elevacion);
                    }
                    string retirado = row.Cell(18).GetString().Trim();
                    if (!SugerenciaRetirado.Exists(X => X == retirado))
                    {
                        SugerenciaRetirado.Add(retirado);
                    }

                    string organismo = row.Cell(19).GetString().Trim();
                    if (!SugerenciaOrganismo.Exists(X => X == organismo))
                    {
                        SugerenciaOrganismo.Add(organismo);
                    }
                }

            }

            textBoxNroAsunto.AutoCompleteCustomSource.AddRange(SugerenciasNroAsunto.ToArray());
            comboBoxSolicitante.AutoCompleteCustomSource.AddRange(SugerenciaSolicitante.ToArray());
            textBoxCausa_Prevencion.AutoCompleteCustomSource.AddRange(SugerenciasCausa.ToArray());
            textBoxCaratula.AutoCompleteCustomSource.AddRange(SugerenciasCaratula.ToArray());
            textBoxNroSolicitud.AutoCompleteCustomSource.AddRange(SugerenciaNroSolicitud.ToArray());
            textBoxNroInforme.AutoCompleteCustomSource.AddRange(SugerenciaInforme.ToArray());
            comboBoxDependencia.AutoCompleteCustomSource.AddRange(SugerenciaDependecia.ToArray());
            comboBoxTipoDelito.AutoCompleteCustomSource.AddRange(SugerenciaTipoDelito.ToArray());
            textBoxRetirado.AutoCompleteCustomSource.AddRange(SugerenciaRetirado.ToArray());
            comboBoxOrganismo.AutoCompleteCustomSource.AddRange(SugerenciaOrganismo.ToArray());
        }
        public bool ValidarControles()
        {

            if (string.IsNullOrEmpty(textBoxNroAsunto.Text))
            {
                MessageBox.Show("Debe ingresar un número de Asunto válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validar NroOrden
            if (numericUpDownOrden.Value < 1)
            {
                MessageBox.Show("Debe ingresar un número de Orden válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validar nro solicitud
            if (string.IsNullOrEmpty(textBoxNroSolicitud.Text))
            {
                MessageBox.Show("Debe ingresar un número de Solicitud válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //validar combosolicitante
            if (string.IsNullOrEmpty(comboBoxSolicitante.Text))
            {
                MessageBox.Show("Debe seleccionar el campo solicitante", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            // Validar Nro causa prevencion
            if (string.IsNullOrEmpty(textBoxCausa_Prevencion.Text))
            {
                MessageBox.Show("Debe ingresar una causa prevención válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxCaratula.Text))
            {
                MessageBox.Show("Debe ingresar el numero de la Caratula", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCausa_Prevencion.Text))
            {
                MessageBox.Show("Debe ingresar una caratula válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxNroInforme.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad confeccionada válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Informes.Exists(x => x.NroSolicitud == textBoxNroSolicitud.Text ))
            {
                MessageBox.Show($"El Nro Solicitud {textBoxNroSolicitud.Text} ya fue ingresado ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Informes.Exists(x => x.Ano == dateTimePickerFechaIngreso.Value.Year && x.NroOrden == numericUpDownOrden.Value ))
            {
                MessageBox.Show($"El Nro Solicitud {textBoxNroSolicitud.Text} ya fue ingresado ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }


        private Informe CrearRegistro()
        {
            Informe newinforme = new Informe();
            newinforme.NroAsunto = textBoxNroAsunto.Text;
            newinforme.NroOrden = Convert.ToInt32(numericUpDownOrden.Value) + DateTime.Now.Year;
            newinforme.TipoSolicitud = comboBoxTipoSolicitud.Text.Trim();
            newinforme.FechaIngreso = dateTimePickerFechaIngreso.Value.Date;
            newinforme.NroSolicitud = textBoxNroSolicitud.Text.Trim();
            newinforme.Solicitante = comboBoxSolicitante.Text.Trim();
            newinforme.NroCausa = textBoxCausa_Prevencion.Text.Trim();
            newinforme.Caratula = textBoxCaratula.Text.Trim();
            newinforme.FechaHecho = dateTimePickerFechaRegistro.Value.Date;
            newinforme.TipoDelito = comboBoxTipoDelito.Text.Trim();
            newinforme.Dependecia = new Destino(comboBoxDependencia.Text.Trim());
            newinforme.NroDVD = textBoxNroDvd.Text.Trim();
            newinforme.NroInforme = textBoxNroInforme.Text.Trim();
            newinforme.NroElevacion = textBoxNroActa_elevacion.Text.Trim();
            newinforme.FechaSalida = dateTimePickerFechaSalida.Value.Date;
            newinforme.Retirado = textBoxRetirado.Text.Trim();
            newinforme.Organismo = comboBoxOrganismo.Text.Trim();
            newinforme.Estado = textBoxNroActa_elevacion.Text.Trim();
            newinforme.Observacion = comboBoxEstado.Text.Trim();
            newinforme.Usuario = user;

            //SugerenciasDVD.Add(textBoxNroSolicitud.Text);
            //SugerenciasConfeccionado.Add(textBoxNroInforme.Text);
            //SugerenciasCaratula.Add(textBoxCausa_Prevencion.Text);

            return newinforme;


        }

        void LoadGrid(List<Informe> lista)
        {
            dgvInformes.DataSource = null;
            lista.Sort();
            dgvInformes.DataSource = lista;
            dgvInformes.Columns["Id"].Width = 30;
            dgvInformes.Columns["Ano"].Visible = false;
            dgvInformes.Columns["Ano"].HeaderText = "Año";
            dgvInformes.Columns["Creado"].Width = 90;
            dgvInformes.Columns["Modificado"].Width = 90;
            dgvInformes.Columns["Creado"].Visible = user.Rol == "ADMIN" ? true : false;
            dgvInformes.Columns["Modificado"].Visible = user.Rol == "ADMIN" ? true : false;
            dgvInformes.Columns["Usuario"].Visible = user.Rol == "ADMIN" ? true : false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Comprobar si la celda es válida
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    informeSeleccionado = dgvInformes.Rows[e.RowIndex].DataBoundItem as Informe;
                    textBoxNroAsunto.Text = informeSeleccionado?.NroAsunto != "" ? informeSeleccionado.NroAsunto : "";
                    numericUpDownOrden.Value = informeSeleccionado?.NroOrden != 0 ? Convert.ToInt32(informeSeleccionado.NroOrden) : 0;
                    dateTimePickerFechaIngreso.Value = informeSeleccionado?.FechaIngreso != null ? Convert.ToDateTime(informeSeleccionado.FechaIngreso) : DateTime.Now;
                    comboBoxTipoSolicitud.Text = informeSeleccionado?.TipoSolicitud != "" ? informeSeleccionado.TipoSolicitud : "";
                    textBoxNroSolicitud.Text = informeSeleccionado?.NroSolicitud != "" ? informeSeleccionado.NroSolicitud : "";
                    comboBoxSolicitante.Text = informeSeleccionado?.Solicitante != "" ? informeSeleccionado.Solicitante : "";
                    textBoxCausa_Prevencion.Text = informeSeleccionado?.NroCausa != "" ? informeSeleccionado.NroCausa : "";
                    textBoxCaratula.Text = informeSeleccionado?.Caratula != "" ? informeSeleccionado.Caratula : "";
                    comboBoxTipoDelito.Text = informeSeleccionado?.TipoDelito != "" ? informeSeleccionado.TipoDelito : "";
                    textBoxNroDvd.Text = informeSeleccionado?.NroDVD != "" ? informeSeleccionado.NroDVD : "";
                    textBoxNroInforme.Text = informeSeleccionado?.NroInforme != "" ? informeSeleccionado.NroInforme : "";
                    textBoxRetirado.Text = informeSeleccionado?.Retirado != "" ? informeSeleccionado.Retirado : "";
                    comboBoxOrganismo.Text = informeSeleccionado?.Organismo != "" ? informeSeleccionado.Organismo : "";
                    textBoxNroActa_elevacion.Text = informeSeleccionado?.NroElevacion != "" ? informeSeleccionado.NroElevacion : "";
                    dateTimePickerFechaSalida.Value = informeSeleccionado?.FechaSalida != null ? Convert.ToDateTime(informeSeleccionado.FechaSalida) : DateTime.Now;
                    comboBoxDependencia.Text = informeSeleccionado?.Dependecia != null ? informeSeleccionado.Dependecia.Nombre : "";
                    textBoxObservacion.Text = informeSeleccionado?.Observacion != "" ? informeSeleccionado.Observacion : "";
                    comboBoxEstado.Text = informeSeleccionado?.Estado != "" ? informeSeleccionado.Estado : "";

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

                Informe registroABuscar = CrearRegistro();

                List<Informe> registroBuscados = new List<Informe>();

                if (!string.IsNullOrEmpty(registroABuscar.NroAsunto))
                {
                    registroBuscados.AddRange(Informes.Where(x => x.NroAsunto == registroABuscar.NroAsunto));
                }

                //if (!string.IsNullOrEmpty(registroABuscar.ParteBackUp))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.ParteBackUp == registroABuscar.ParteBackUp));
                //}
                //if (!string.IsNullOrEmpty(registroABuscar.FechaBackUP))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.FechaBackUP == registroABuscar.FechaBackUP));
                //}
                //if (!string.IsNullOrEmpty(registroABuscar.DVD))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.DVD.Contains(registroABuscar.DVD)));
                //}
                //if (!string.IsNullOrEmpty(registroABuscar.ParteDVD))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.ParteDVD == registroABuscar.ParteDVD));
                //}
                //if (!string.IsNullOrEmpty(registroABuscar.Caratula))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.Caratula.Contains(registroABuscar.Caratula)));
                //}
                //if (registroABuscar.Fecha_Registro.Value.Date != DateTime.Now.Date)
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.Fecha_Registro.HasValue && x.Fecha_Registro.Value.Date == registroABuscar.Fecha_Registro.Value.Date));
                //}
                //if (!string.IsNullOrEmpty(registroABuscar.Confeccionado))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.Confeccionado.Contains(registroABuscar.Confeccionado)));
                //}
                //if (!string.IsNullOrEmpty(registroABuscar.Observacion))
                //{
                //    registroBuscados.AddRange(registros.Where(x => x.Observacion.Contains(registroABuscar.Observacion)));
                //}

                LoadGrid(registroBuscados);
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
                informeSeleccionado = null;
                numericUpDownOrden.Value = 0;
                comboBoxTipoSolicitud.Text = "";
                dateTimePickerFechaIngreso.Value = DateTime.Now;
                textBoxNroSolicitud.Text = "";
                comboBoxSolicitante.Text = "";
                dateTimePickerFechaRegistro.Value = DateTime.Now;
                textBoxNroInforme.Text = "";
                textBoxObservacion.Text = "";
                textBoxCausa_Prevencion.Text = "";
                HabilitarRegistro();
                GetRegisterExcel();
                LoadGrid(Informes);
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
                    //AgregarRegistro(nuevo);
                    GetRegisterExcel();
                    //CargarGrilla(registros);
                    HabilitarRegistro();
                    buttonLimpiar_Click(null, null);


                    //MessageBox.Show($"Se registro el backup  {nuevo.NroBackUp} parte {nuevo.ParteBackUp} ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
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
                if (informeSeleccionado != null)
                {
                    var result = MessageBox.Show($"¿Seguro que desea borrar el registro del back-Up {informeSeleccionado.Caratula}?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        //EliminarRegistro(informeSeleccionado);
                        MessageBox.Show($"Se elimino el registro del back-Up {informeSeleccionado.Caratula}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (informeSeleccionado != null)
                {
                    var nuevoRegistro = CrearRegistro();
                    nuevoRegistro.Id = informeSeleccionado.Id;
                    nuevoRegistro.Creado = informeSeleccionado.Creado;
                    nuevoRegistro.Modificado = DateTime.Now;
                    //ActualizarRegistro(nuevoRegistro);

                    GetRegisterExcel();
                    //CargarGrilla(registros);

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
                    //nuevoRegistro.Id = registros.Max(x => x.Id) + 1;

                    // Asegúrate de que el nuevo registro no exista ya en el Excel antes de agregarlo
                    //if (!registros.Any(r => r.Id == nuevoRegistro.Id))
                    //{
                    //    // Agrega el nuevo registro al final del Excel
                    //    worksheet.Cell(lastRow + 1, 1).Value = nuevoRegistro.Id;
                    //    worksheet.Cell(lastRow + 1, 2).Value = nuevoRegistro.NroBackUp;
                    //    worksheet.Cell(lastRow + 1, 3).Value = nuevoRegistro.ParteBackUp;
                    //    worksheet.Cell(lastRow + 1, 4).Value = nuevoRegistro.FechaBackUP;
                    //    worksheet.Cell(lastRow + 1, 5).Value = nuevoRegistro.DVD;
                    //    worksheet.Cell(lastRow + 1, 6).Value = nuevoRegistro.ParteDVD;
                    //    worksheet.Cell(lastRow + 1, 7).Value = nuevoRegistro.Caratula;
                    //    worksheet.Cell(lastRow + 1, 8).Value = nuevoRegistro.Fecha_Registro;
                    //    worksheet.Cell(lastRow + 1, 9).Value = nuevoRegistro.Peso;
                    //    worksheet.Cell(lastRow + 1, 10).Value = nuevoRegistro.Confeccionado;
                    //    worksheet.Cell(lastRow + 1, 11).Value = nuevoRegistro.Observacion;
                    //    worksheet.Cell(lastRow + 1, 12).Value = nuevoRegistro.Creado;
                    //    worksheet.Cell(lastRow + 1, 13).Value = nuevoRegistro.Modificado;
                    //    worksheet.Cell(lastRow + 1, 14).Value = nuevoRegistro.Usuario.Nombre;

                    //    // Guarda los cambios en el archivo Excel
                    //    workbook.SaveAs(filePath);
                    //}
                    //else
                    //{
                    //    MessageBox.Show($"Ya existe un registro con NroBackUp {nuevoRegistro.NroBackUp} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return false;
                    //}
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


        private void checkBoxEntrega_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEntrega.Enabled = checkBoxEntrega.Checked;
        }
    }
}
