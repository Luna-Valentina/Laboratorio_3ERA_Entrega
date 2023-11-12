using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Laboratorio_3ERA_Entrega.Formularios;

namespace Laboratorio_3ERA_Entrega
{
    public partial class FrmClientes : Form
    {
        dbHelper dbHelper;
        

        FrmConsultarProductosDescuentos descuento;
        public List<Clientes> clientes { get; set; }

        public Clientes c;


        public FrmClientes()
        {
            InitializeComponent();
            dbHelper = new dbHelper();
            c = new Clientes();
           

        }

      



        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxCliente_desc.Text))
            {
                MessageBox.Show("Debe ingresar un nombre o un apellido de un cliente para poder" +
                    " buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dataTable = dbHelper.ConsultarSP_DescClientOB(txtboxCliente_desc.Text);
                dataGridView1.DataSource = dataTable;
            }





        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {

            DataTable dataTable = dbHelper.ConsultarSP_DescClientOBTODOS();
            dataGridView1.DataSource = dataTable;



        }

        //clic consultar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            descuento = new FrmConsultarProductosDescuentos();
            DataGridViewRow fila = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
            descuento.ID_Persona = fila.Cells[6].Value.ToString();
            descuento.ShowDialog();
        }
    }
}
