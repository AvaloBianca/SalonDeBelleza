using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBelleza.BA
{
    public class Listado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }

        


        public Listado(string nombre, string apellido, string celular)
        {
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            
        }

        public override string ToString()
        {
            return $"{Celular} - {Nombre} - {Apellido} ";
        }



    }
}
