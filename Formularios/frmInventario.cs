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
    public partial class frmInventario : Form       
    {

        ModificarStock frmmodificarstock;

        dbHelper ayudante;

      

        public frmInventario()
        {
            InitializeComponent();
            ayudante = new dbHelper();
        }

        private void btnReposicion_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ayudante.ListadoResposicion();
            dataGridView1.DataSource = dataTable;
            
        }

        private void btnStockTotal_Click(object sender, EventArgs e)
        { 
            DataTable dataTable = ayudante.ListadoTotal(); 
            dataGridView1.DataSource = dataTable;    
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnListadoDescripcion_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ayudante.ListadoCriticoDescipcion(txtInformacion.Text);
            dataGridView1.DataSource = dataTable;
   
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmmodificarstock = new ModificarStock();

            frmmodificarstock = new ModificarStock();

            DataGridViewRow fila = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
            frmmodificarstock.id_producto = Convert.ToInt32(fila.Cells[1].Value.ToString());
            frmmodificarstock.descripcion = fila.Cells[2].Value.ToString();
            frmmodificarstock.stockActual = Convert.ToInt32(fila.Cells[3].Value.ToString());
            frmmodificarstock.ShowDialog();

        }
    }
}
