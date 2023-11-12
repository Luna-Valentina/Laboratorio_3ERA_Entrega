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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

       

        private void textBoxNombreCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nombreCliente = txtBoxCliente.Text;
               // ObtenerIDCliente(nombreCliente); //SP
            }
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            dtpFechaFactura.Value = DateTime.Today;
        }

       
    }
}
