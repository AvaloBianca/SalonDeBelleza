using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBelleza.BA
{
    public class Turnero
    {
        public string Nombre { get; set; }

        public string Dia { get; set; }

        public string Horario { get; set; }

        public Turnero(string nombre, string dia, string horario)
        {
            Nombre = nombre;
            Dia = dia;
            Horario = horario;
        }




    }
}
