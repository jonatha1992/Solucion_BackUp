using ClosedXML.Excel;
using Presentacion.Clases;
using System.Collections.Generic;
using System.Linq;

namespace Presentacion
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        string filePath = "BASE.xlsx";

        public Usuario() {  }
        public Usuario(string nombre) { Nombre = nombre;  }
        public Usuario( bool obtenerExcel ) { ObtenerUsuariosExcel(); }

        public  Usuario ControlPasswword(string user, string pass)
        {
            var usuario = Usuarios.Find(x => x.Nombre == user && x.Contraseña == pass);
            if (usuario == null)
            {
                return null;

            }
            else { return usuario; }
        }


        private void ObtenerUsuariosExcel()
        {

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
                    Usuario User = new Usuario();
                    User.Id = row.Cell(1).GetValue<int>();
                    User.Nombre = row.Cell(2).GetString();
                    User.Contraseña = row.Cell(3).GetString();
                    User.Rol = row.Cell(4).GetString();

                    // Agregar el objeto Registro a la lista
                    Usuarios.Add(User);
                }

            }

        }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}
