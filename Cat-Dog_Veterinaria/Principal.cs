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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var clientesForm = new Clientes();
            clientesForm.Show();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            var mascotasForm = new Mascotas();
            mascotasForm.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            var citasForm = new Citas();
            citasForm.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            var pagosForm = new Pagos();
            pagosForm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var productosForm = new Productos();
            productosForm.Show();
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar este formulario?",
                                   "Confirmar cierre",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
