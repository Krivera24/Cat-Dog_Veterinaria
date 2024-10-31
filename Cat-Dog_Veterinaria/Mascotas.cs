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
    public partial class Mascotas : Form
    {
        private List<Mascota> mascotas = new List<Mascota>();
        public Mascotas()
        {
            InitializeComponent();
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMascota.Text;
            string tipo = txtTipoMascota.Text;
            string dueño = txtNombreDueño.Text;
            mascotas.Add(new Mascota(nombre, tipo, dueño));
            MessageBox.Show("Mascota registrada con éxito.");
            txtNombreMascota.Clear();
            txtTipoMascota.Clear();
            txtNombreDueño.Clear();
            LoadData();
        }
        public class Mascota
        {
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public string Dueño { get; set; }

            public Mascota(string nombre, string tipo, string dueño)
            {
                Nombre = nombre;
                Tipo = tipo;
                Dueño = dueño;
            }
        }
        private void LoadData()
        {
            dataGridViewMascotas.DataSource = null;
            dataGridViewMascotas.DataSource = mascotas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

