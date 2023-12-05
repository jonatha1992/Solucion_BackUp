using ClosedXML.Excel;
using Presentacion.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public class User
    {
        public int Id { get; set; }
        public string Contraseña { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }

        string filePath = "BASE.xlsx";
        string hoja = "LOGIN";


        public User() { }
        public User(string nombre) { NombreUsuario = nombre; }
        public User(bool obtenerExcel) { ObtenerUsuariosExcel(); }

        public User ControlPasswword(string user, string pass)
        {
            List<User> Usuarios = ObtenerUsuariosExcel();    
            var usuario = Usuarios.Find(x => x.NombreUsuario == user && x.Contraseña == pass);
            if (usuario == null)
            {
                return null;

            }
            else { return usuario; }
        }


        public List<User> ObtenerUsuariosExcel()
        {
            var usuarios = new List<User>(); 
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("LOGIN"); // Obtener la primera hoja del libro

                // Iterar a través de las filas del archivo Excel
                foreach (var row in worksheet.RowsUsed().Skip(1)) // Skip(1) para omitir la primera fila (encabezados)
                {
                    if (row.Cell(1).IsEmpty())
                    {
                        break; // Salir completamente del bucle
                    }
                    // Si llegamos a este punto, la primera celda tiene información, así que podemos procesar la fila
                    User User = new User();
                    User.Id = row.Cell(1).GetValue<int>();
                    User.NombreUsuario = row.Cell(2).GetString();
                    User.Contraseña = row.Cell(3).GetString();
                    User.Rol = row.Cell(4).GetString();
                    User.NombreCompleto = row.Cell(5).GetString();

                    // Agregar el objeto Registro a la lista
                    usuarios.Add(User);
                }

            }
            return usuarios;
        }

        public bool UpdateUser(User pusuario)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(hoja); // Obtener la primera hoja del libro

                // Iterar a través de las filas del archivo Excel

                var cell = worksheet.CellsUsed(c => c.WorksheetRow().RowNumber() >= 2)
                         .FirstOrDefault(c =>
                         {
                             if (int.TryParse(c.GetString(), out int cellValue))
                             {
                                 return cellValue == pusuario.Id;
                             }
                             return false;
                         });
                if (cell != null)
                {
                    var row = cell.WorksheetRow();
                    row.Cell(2).Value = pusuario.NombreUsuario;
                    row.Cell(3).Value = pusuario.Contraseña;
                    row.Cell(4).Value = pusuario.Rol;
                    row.Cell(5).Value = pusuario.NombreCompleto;
                    // Guarda los cambios en el archivo Excel
                    workbook.SaveAs(filePath);
                }
                else
                {
                    return false;
                }
                // Si llegamos a este punto, la primera celda tiene información, así que podemos procesar la fila
                return true;
            }
        }

        public bool AddUser(User pusuario)
        {
            try
            {
                var usuarios = ObtenerUsuariosExcel();

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(hoja);

                    // Encuentra la última fila con datos en la columna A
                    int lastRow = worksheet.LastCellUsed().Address.RowNumber;
                    pusuario.Id = usuarios.Max(x => x.Id) + 1;

                    // Asegúrate de que el nuevo registro no exista ya en el Excel antes de agregarlo
                    if (!usuarios.Any(r => r.Id == pusuario.Id))
                    {
                        // Agrega el nuevo registro al final del Excel
                        worksheet.Cell(lastRow + 1, 1).Value = pusuario.Id;
                        worksheet.Cell(lastRow + 1, 2).Value = pusuario.NombreUsuario;
                        worksheet.Cell(lastRow + 1, 3).Value = pusuario.Contraseña;
                        worksheet.Cell(lastRow + 1, 4).Value = pusuario.Rol;
                        worksheet.Cell(lastRow + 1, 5).Value = pusuario.NombreCompleto;

                        // Guarda los cambios en el archivo Excel
                        workbook.SaveAs(filePath);
                    }
                    else
                        return false;
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar en Excel: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
        public bool DeleteUser(User user)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(hoja);
                    var cell = worksheet.CellsUsed(c => c.WorksheetRow().RowNumber() >= 2)
                                .FirstOrDefault(c =>
                                {
                                    if (int.TryParse(c.GetString(), out int cellValue))
                                    {
                                        return cellValue ==user.Id;
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
        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
