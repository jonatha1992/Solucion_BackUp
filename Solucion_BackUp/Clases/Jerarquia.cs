using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Presentacion
{
    public class Jerarquia : ICloneable
    {
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }

        public Jerarquia() { }
        public Jerarquia(string jerar, string Abre)
        {
            Nombre = jerar;
            Abreviatura = Abre;
        }

        public static List<Jerarquia> ListarJeraquias()
        {
            try
            {
                XDocument doc = XDocument.Load("datos.xml");

                var jerarquias = from jerar in doc.Descendants("Jerarquia")
                                 select new Jerarquia
                                 {
                                     Nombre = jerar.Element("Nombre").Value,
                                     Abreviatura = jerar.Element("Abreviatura").Value
                                 };

                if (jerarquias == null)
                {
                    return null;
                }   
                return jerarquias.ToList();
            }
            catch (Exception )
            {

                throw new Exception("Error al obtener la base");
            }
        }
        public override string ToString()
        {
            return Nombre;
        }

        public object Clone()
        {
            return new Jerarquia
            {
                Nombre = this.Nombre,
                Abreviatura = this.Abreviatura
            };
        }
    }

}
