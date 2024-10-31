using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat_Dog_Veterinaria
{
    public partial class Citas : Form
    {
        private List<Cita> citas = new List<Cita>();
        public Citas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mascota = txtNombreMascotaCita.Text;
            DateTime fechaCita = dtpFechaCita.Value;

            citas.Add(new Cita(mascota, fechaCita));
            MessageBox.Show($"Cita registrada para {mascota} en la fecha {fechaCita.ToShortDateString()}.");
            txtNombreMascotaCita.Clear();
        }
        public class Cita
        {
            public string Mascota { get; set; }
            public DateTime Fecha { get; set; }

            public Cita(string mascota, DateTime fecha)
            {
                Mascota = mascota;
                Fecha = fecha;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


