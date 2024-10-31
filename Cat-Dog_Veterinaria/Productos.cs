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
    public partial class Productos : Form
    {
        private List<Producto> productos = new List<Producto>();
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtProducto.Text;
            int cantidad;
            decimal precio;

            if (int.TryParse(txtCantidad.Text, out cantidad) && decimal.TryParse(txtPrecio.Text, out precio))
            {
                productos.Add(new Producto(nombre, cantidad, precio));
                MessageBox.Show("Producto registrado con éxito.");
                txtProducto.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para cantidad y precio.");
            }
        }
        public class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }

            public Producto(string nombre, int cantidad, decimal precio)
            {
                Nombre = nombre;
                Cantidad = cantidad;
                Precio = precio;
            }
        }
    }
}


