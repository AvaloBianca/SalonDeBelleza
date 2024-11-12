using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBelleza.BA
{
    public class Listados
    {
        private List<Turnero> turnos;
        private DataTable tabla;
        public DataTable Lista { get; set; }

        public Listados()
        {
            Lista = new DataTable();
            Lista.TableName = "Listados";
            Lista.Columns.Add("Nombre");
            Lista.Columns.Add("Apellido");
            Lista.Columns.Add("Celular");
           
            LeerArchivo();
        }

        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Listados.xml"))
            {
                Lista.ReadXml("Listados.xml");
            }
        }

        public void Insert(Listado listado)
        {
            Lista.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Nombre"] = listado.Nombre;
            Lista.Rows[NuevoRenglon]["Apellido"] = listado.Apellido;
            Lista.Rows[NuevoRenglon]["Celular"] = listado.Celular;
           ;

            //tabla en el archivo
            Lista.WriteXml("Listados.xml");
        }
        




        

    }
}
