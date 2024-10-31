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
    public partial class Pagos : Form
    {
        private List<Pago> pagos = new List<Pago>();
        public Pagos()
        {
            InitializeComponent();
            pagos = new List<Pago>();
        }
        private void LoadData()
        {
            dataGridViewPagos.DataSource = null;
            dataGridViewPagos.DataSource = pagos; 
        }
        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            string tipoPago = cmbTipoPago.SelectedItem.ToString();
            decimal monto;
          

            if (decimal.TryParse(txtMontoPago.Text, out monto))
            {
                pagos.Add(new Pago(monto, tipoPago));
                MessageBox.Show("Pago registrado con éxito.");
                txtMontoPago.Clear();
                cmbTipoPago.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
            }
            LoadData();
        }
        public class Pago
        {
            public decimal Monto { get; set; }
            public string TipoPago { get; set; }

            public Pago(decimal monto, string tipoPago, string comentario)
            {
                Monto = monto;
                TipoPago = tipoPago;
              
            }

            public Pago(decimal monto, string tipoPago)
            {
                Monto = monto;
                TipoPago = tipoPago;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


