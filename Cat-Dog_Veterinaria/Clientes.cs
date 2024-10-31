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
    public partial class Clientes : Form
    {
        private List<Cliente> clientes; // Lista para almacenar clientes
        public Clientes()
        {
            InitializeComponent();
            clientes = new List<Cliente>(); // Inicializar la lista

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTeléfono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTeléfono.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear nuevo cliente y agregarlo a la lista
            Cliente nuevoCliente = new Cliente(nombre, telefono);
            clientes.Add(nuevoCliente);
            MessageBox.Show("Cliente registrado con éxito.");

            // Limpiar los campos de texto
            txtNombre.Clear();
            txtTeléfono.Clear();
            LoadData();
        }
        public class Cliente
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }

            public Cliente(string nombre, string telefono)
            {
                Nombre = nombre;
                Telefono = telefono;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = clientes;
        }
    }
}  
