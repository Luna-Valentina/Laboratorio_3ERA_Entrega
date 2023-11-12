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

namespace Laboratorio_3ERA_Entrega
{
    public partial class FrmConsultarProductosDescuentos : Form
    {

        dbHelper ob;
        public string ID_Persona;
        string cadena_conexion = @"Data Source=VALEN\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando = new SqlCommand();

        public FrmConsultarProductosDescuentos()
        {
            InitializeComponent();
            ob = new dbHelper();
            conexion = new SqlConnection(cadena_conexion);

        }

        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;

        }
        public void Desconectar()
        {
            conexion.Close();
        }

        private void FrmConsultarProductosDescuentos_Load(object sender, EventArgs e)
        {

            cargarProductos(cboProductos);
            cboProductos.SelectedIndex = -1;
            txtboxIDPERSONA.Text = ID_Persona.ToString();
        }

        public DataTable cargarProductos(ComboBox cbo)
        {
            DataTable tabla = ob.consultaSQL("sp_cargar_medicamentos");

            cboProductos.ValueMember = "ID_Producto";
            cboProductos.DisplayMember = "Descripcion";
            cboProductos.DataSource = tabla;

            return tabla;

        }

        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un producto");
                return;
            }

            if (numericUpDownCantidad.Value == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a 0");
                return;
            }

            Conectar();

           // SqlParameter parameter = new SqlParameter();

            comando.CommandText = "sp_consulta_descuento_medicamento";
            comando.Parameters.AddWithValue("@id_persona", txtboxIDPERSONA.Text);
            comando.Parameters.AddWithValue("@producto", cboProductos.Text);
            comando.Parameters.AddWithValue("@cantidad", numericUpDownCantidad.Value);

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@valorfinal";
            outputParameter.SqlDbType = SqlDbType.Float;
            outputParameter.Direction = ParameterDirection.Output;
            comando.Parameters.Add(outputParameter);

            comando.ExecuteNonQuery();

            float valorFinal = Convert.ToSingle(outputParameter.Value);

            Desconectar();

            txtboxTotal.Text = valorFinal.ToString();


        }



    }
}
