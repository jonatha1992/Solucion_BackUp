using ClosedXML.Excel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Clases
{
    public class Informe : IComparable<Informe>
    {
        public int Id { get; set; }
        public string NroAsunto { get; set; }
        public int? NroOrden { get; set; }
        public int Ano { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string TipoSolicitud { get; set; }
        public string NroSolicitud { get; set; }
        public string Solicitante { get; set; }
        public string NroCausa { get; set; }
        public string Caratula { get; set; }
        public DateTime? FechaHecho { get; set; }
        public string TipoDelito { get; set; }
        public Destino Dependecia { get; set; }
        public string NroDVD { get; set; }
        public string NroInforme { get; set; }
        public string NroElevacion { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Retirado { get; set; }
        public string Organismo { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public DateTime? Creado { get; set; }
        public DateTime? Modificado { get; set; }
        public User Usuario { get; set; } = new User();

        string filePath = "BASE.xlsx";
        string Hoja = "REGISTRO";
        public int CompareTo(Informe other)
        {
            if (this.FechaIngreso < other.FechaIngreso)
            {
                return 1;
            }
            else if (this.FechaIngreso > other.FechaIngreso)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        private List<Informe> GetRegisterExcel()
        {
            try
            {
                var Informes = new List<Informe>();
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
                            informe.TipoSolicitud = row.Cell(6).IsEmpty() ? null : row.Cell(6).GetString();
                            informe.NroSolicitud = row.Cell(7).IsEmpty() ? null : row.Cell(7).GetString();
                            informe.Solicitante = row.Cell(8).IsEmpty() ? null : row.Cell(8).GetString();
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
                return Informes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool Add(Informe newInforme)
        {
            try
            {
                var informes = GetRegisterExcel();
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);

                    // Encuentra la última fila con datos en la columna A
                    int lastRow = worksheet.LastCellUsed().Address.RowNumber;

                    // Asegúrate de que el nuevo registro no exista ya en el Excel antes de agregarlo
                    if (!informes.Any(r => r.Id == newInforme.Id))
                    {
                        // Agrega el nuevo registro al final del Excel
                        worksheet.Cell(lastRow + 1, 1).Value = newInforme.Id;
                        worksheet.Cell(lastRow + 1, 2).Value = newInforme.NroAsunto;
                        worksheet.Cell(lastRow + 1, 3).Value = newInforme.NroOrden;
                        worksheet.Cell(lastRow + 1, 4).Value = newInforme.Ano;
                        worksheet.Cell(lastRow + 1, 5).Value = newInforme.FechaIngreso;
                        worksheet.Cell(lastRow + 1, 6).Value = newInforme.TipoSolicitud;
                        worksheet.Cell(lastRow + 1, 7).Value = newInforme.NroSolicitud;
                        worksheet.Cell(lastRow + 1, 8).Value = newInforme.Solicitante;
                        worksheet.Cell(lastRow + 1, 9).Value = newInforme.NroCausa;
                        worksheet.Cell(lastRow + 1, 10).Value = newInforme.Caratula;
                        worksheet.Cell(lastRow + 1, 11).Value = newInforme.FechaHecho;
                        worksheet.Cell(lastRow + 1, 12).Value = newInforme.TipoDelito;
                        worksheet.Cell(lastRow + 1, 13).Value = newInforme.Dependecia?.Nombre; // Asumiendo que Nombre es una propiedad de Destino
                        worksheet.Cell(lastRow + 1, 14).Value = newInforme.NroDVD;
                        worksheet.Cell(lastRow + 1, 15).Value = newInforme.NroInforme;
                        worksheet.Cell(lastRow + 1, 16).Value = newInforme.NroElevacion;
                        worksheet.Cell(lastRow + 1, 17).Value = newInforme.FechaSalida;
                        worksheet.Cell(lastRow + 1, 18).Value = newInforme.Retirado;
                        worksheet.Cell(lastRow + 1, 19).Value = newInforme.Organismo;
                        worksheet.Cell(lastRow + 1, 20).Value = newInforme.Estado;
                        worksheet.Cell(lastRow + 1, 21).Value = newInforme.Observacion;
                        worksheet.Cell(lastRow + 1, 22).Value = newInforme.Creado;
                        worksheet.Cell(lastRow + 1, 23).Value = newInforme.Modificado;
                        worksheet.Cell(lastRow + 1, 24).Value = newInforme.Usuario?.NombreUsuario; // Asumiendo que NombreUsuario es una propiedad de User

                        // Guarda los cambios en el archivo Excel
                        workbook.SaveAs(filePath);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"Ya existe un registro con Id {newInforme.Id} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar en Excel: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(Informe informeUpdate)
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
                                        return cellValue == informeUpdate.Id;
                                    }
                                    return false;
                                });

                    if (cell != null)
                    {
                        var row = cell.WorksheetRow();
                        row.Cell(1).Value = informeUpdate.Id;
                        row.Cell(2).Value = informeUpdate.NroAsunto;
                        row.Cell(3).Value = informeUpdate.NroOrden;
                        row.Cell(4).Value = informeUpdate.Ano;
                        row.Cell(5).Value = informeUpdate.FechaIngreso;
                        row.Cell(6).Value = informeUpdate.TipoSolicitud;
                        row.Cell(7).Value = informeUpdate.NroSolicitud;
                        row.Cell(8).Value = informeUpdate.Solicitante;
                        row.Cell(9).Value = informeUpdate.NroCausa;
                        row.Cell(10).Value = informeUpdate.Caratula;
                        row.Cell(11).Value = informeUpdate.FechaHecho;
                        row.Cell(12).Value = informeUpdate.TipoDelito;
                        row.Cell(13).Value = informeUpdate.Dependecia?.Nombre;
                        row.Cell(14).Value = informeUpdate.NroDVD;
                        row.Cell(15).Value = informeUpdate.NroInforme;
                        row.Cell(16).Value = informeUpdate.NroElevacion;
                        row.Cell(17).Value = informeUpdate.FechaSalida;
                        row.Cell(18).Value = informeUpdate.Retirado;
                        row.Cell(19).Value = informeUpdate.Organismo;
                        row.Cell(20).Value = informeUpdate.Estado;
                        row.Cell(21).Value = informeUpdate.Observacion;
                        row.Cell(22).Value = informeUpdate.Creado;
                        row.Cell(23).Value = informeUpdate.Modificado;
                        row.Cell(24).Value = informeUpdate.Usuario?.NombreUsuario;

                        workbook.SaveAs(filePath);
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró el registro con Id {informeUpdate.Id} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public bool Delete(Informe registroEliminado)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(Hoja);

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
                        MessageBox.Show($"No se encontró el registro con Id {registroEliminado.Id} en el archivo Excel.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
