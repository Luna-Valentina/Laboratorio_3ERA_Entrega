using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3ERA_Entrega
{
    public partial class FrmPrincipal : Form
    {

        FrmVentas ventas;
        FrmClientes ConsultaClientesDescuentoOB;

        frmInventario inventario;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventas = new FrmVentas();

            ventas.Show();

         

        }

        private void btnCliente_obs_Click(object sender, EventArgs e)
        {
            ConsultaClientesDescuentoOB = new FrmClientes();
            ConsultaClientesDescuentoOB.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            inventario = new frmInventario();

            inventario.Show();
        }
    }
}
