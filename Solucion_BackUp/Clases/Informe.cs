using System;


namespace Presentacion.Clases
{
    public class Informe : IComparable<Informe>
    {
        public int Id { get; set; }
        public string  NroAsunto { get; set; } 
        public int? NroOrden { get; set; } 
        public int Ano { get; set; } 
        public DateTime? FechaIngreso { get; set; } 
        public string TipoSolicitud { get; set; } 
        public string NroSolicitud { get; set; } 
        public string Solicitante { get; set; } 
        public string NroCausa{ get; set; }     
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
        public DateTime? Creado{ get; set; }
        public DateTime? Modificado{ get; set; }
        public User Usuario { get; set; } = new User();


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

    }
}
