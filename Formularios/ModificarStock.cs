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
    public partial class ModificarStock : Form
    {
        public int id_producto;
        public string descripcion;
        public int stockActual;

        dbHelper ayudante;

        public ModificarStock()
        {
            InitializeComponent();
            ayudante = new dbHelper();


        }

        private void ModificarStock_Load(object sender, EventArgs e)
        {
            txtID.Text = id_producto.ToString();
            txtProducto.Text = descripcion.ToString();
            txtStockActual.Text = stockActual.ToString();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ayudante.EditarStock(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtStockActual.Text));
            MessageBox.Show("Se modificó el stock existosamenrte","OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
