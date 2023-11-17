using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Clases
{
    public class Registro : IComparable<Registro>
    {
        public int Id { get; set; }
        public int? NroBackUp { get; set; } 
        public string FechaBackUP { get; set; } = null;
        public string ParteBackUp { get; set; } = null;
        public string DVD { get; set; } = null;
        public string ParteDVD { get; set; } = null;    
        public string Caratula { get; set; } = null;
        public DateTime? Fecha_Registro { get; set; }
        public string Peso { get; set; } = null;
        public string Confeccionado { get; set; } = null;
        public string Observacion { get; set; } = null;
        public DateTime? Creado{ get; set; }
        public DateTime? Modificado{ get; set; }


        public int CompareTo(Registro other)
        {
            if (this.Fecha_Registro < other.Fecha_Registro)
            {
                return 1;
            }
            else if (this.Fecha_Registro > other.Fecha_Registro)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
