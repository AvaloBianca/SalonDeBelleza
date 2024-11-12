using SalonBelleza.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonBelleza.FE
{
    public partial class FRMSalonBelleza : Form
    {
        public Listados Listados = new Listados();
        public FRMSalonBelleza()
        {
            InitializeComponent();

            CargarCombos();
            
            DGV.DataSource = Listados.Lista;
           
            LimpiaTxt();
        }

        public void CargarCombos()
        {
            cbxservicio.Items.Add("MANICURA");
            cbxservicio.Items.Add("PESTAÑAS");
            
            cbxdia.Items.Add("LUNES");
            cbxdia.Items.Add("MARTES");
            cbxdia.Items.Add("MIERCOLES");
            cbxdia.Items.Add("JUEVES");

            cbxturno.Items.Add("MAÑANA");
            cbxturno.Items.Add("TARDE");
        }


        private void btagendar_Click(object sender, EventArgs e)
        {
            bool agendar = true;

            string dia = cbxdia.SelectedItem.ToString();
            string turno = cbxturno.SelectedItem.ToString();
            string horario = cbxhorario.SelectedItem.ToString();

            while (agendar)
            {

                if (dia != null && turno != null && horario != null)
                {
                    string mensaje = "SU TURNO QUEDO AGENDADO";
                    MessageBox.Show(mensaje);
                    agendar = false;

                }
                
            }
            
            cbxdia.Text = "";
            cbxhorario.Text = "";
            cbxturno.Text = "";
            cbxservicio.Text = "";

            Turnero nuevoTurno = new Turnero(txtnombre.Text, dia, horario);
            Listado Listado = new Listado(txtnombre.Text, txtapellido.Text, txtcelular.Text);
            Listados.Insert(Listado);


        }


        private void LimpiaTxt()
        {
            txtnombre.Text = " ";
            txtcelular.Text = " ";
            txtapellido.Text = " ";
            txtnombre.Focus();
            
        }

        private void cbxturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turnoSeleccionado = cbxturno.SelectedItem.ToString();

            if (turnoSeleccionado == "MAÑANA")
            {
                cbxhorario.Items.Add("08:00 hs");
                cbxhorario.Items.Add("09:00 hs");
                cbxhorario.Items.Add("10:00 hs");

            }
            else if (turnoSeleccionado == "TARDE")
            {
                cbxhorario.Items.Add("17:00 hs");
                cbxhorario.Items.Add("18:00 hs");
                cbxhorario.Items.Add("19:00 hs");
                cbxhorario.Items.Add("20:00 hs");

            }
        }

        private void btverlista_Click(object sender, EventArgs e)
        {
            Listado Listado = new Listado(txtnombre.Text, txtapellido.Text, txtcelular.Text);
            Listados.Insert(Listado);

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            DGV.Rows.Remove(DGV.CurrentRow);


        }

        

    }
}
