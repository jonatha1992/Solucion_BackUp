using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace Presentacion
{
    public class Destino:ICloneable
    {
        public string Nombre { get; set; }

        public Destino() { }

        public Destino(string text)
        {
            Nombre = text;
        }

        static public List<Destino> ListarDestinos()
        {

            XDocument doc = XDocument.Load("datos.xml");

            var Destinos = from oficial in doc.Descendants("Destino")
                           select new Destino()
                           {
                               Nombre = oficial.Element("Nombre").Value,
                           };
            if (Destinos == null)
            {
                return null;
            }

            return Destinos.ToList();
        }

        //Todo: Agregar detino a xml
        static public void AgregaDestino(Destino Destino)
        {

            if (!String.IsNullOrEmpty(Destino.Nombre))
            {
                XDocument doc = XDocument.Load("datos.xml");
                bool existeDestino = doc.Descendants("Destino").Any(o => (string)o.Element("Nombre") == Destino.Nombre.ToString());
                if (!existeDestino)
                {

                    XElement nuevoDestino = new XElement("Destino",
                    new XElement("Nombre", Destino.Nombre));
                    doc.Root.Element("Destinos").Add(nuevoDestino);
                    doc.Save("datos.xml");

                }
            }

        }
        public override string ToString()
        {
            return Nombre;
        }

        public object Clone()
        {
            return new Destino
            {
                Nombre = this.Nombre,
            };
        }
    }


}