using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_3ERA_Entrega
{
    public class dbHelper
    {
        string cadena_conexion = @"Data Source=VALEN\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando = new SqlCommand();
        private static readonly dbHelper instancia;

        public dbHelper()
        {
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

        public DataTable ConsultarSP_DescClientOB(string cliente)
        {
            SqlParameter param = new SqlParameter();
            Conectar();

            comando.CommandText = "sp_cliente_obra_social";
            comando.Parameters.AddWithValue("@cliente_nombre", cliente);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Desconectar();

            return dataTable;

        }

        public DataTable ListadoTotal() //SP_Agus
        {
            Conectar();
            comando.CommandText = "SP_STOCK_CRITICO_TODOS";
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Desconectar();
            return dataTable;
        }

        public DataTable ListadoResposicion() //SP_Agus
        {
            Conectar();
            comando.CommandText = "SP_STOCK_CRITICO_TODOS_DIFERENCIA_NEGATIVA";
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Desconectar();
            return dataTable;
        }

        public DataTable ListadoCriticoDescipcion(string producto) //SP_Agus
        {
            SqlParameter param = new SqlParameter();
            Conectar();

            comando.CommandText = "SP_STOCK_CRITICO_DESCRIPION_DIFERENCIA_NEGATIVA";
            comando.Parameters.AddWithValue("@DESCRI_INGRESO", "%"+producto+"%");
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Desconectar();

            return dataTable;

        }

        public DataTable EditarStock(int id_producto, int stockActual ) //SP_Agus
        {
            SqlParameter param = new SqlParameter();
            Conectar();

            comando.CommandText = "SP_STOCK_EDICION";
            comando.Parameters.AddWithValue("@ID_PROD_INGRESADO", id_producto);
            comando.Parameters.AddWithValue("@CANTIDAD_FISICA", stockActual);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Desconectar();

            return dataTable;

        }








        public DataTable ConsultarSP_DescClientOBTODOS()
        {
            SqlParameter param = new SqlParameter();
            Conectar();

            comando.CommandText = "sp_descuentotodos";
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Desconectar();

            return dataTable;

        }

        public DataTable consultaSQL(string consulta)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;

        }


        public DataTable Consultar(string Query, List<Parametros> parametros = null)
        {
            DataTable dtTabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand(Query, conexion);
            if (parametros != null)
            {
                foreach (Parametros p in parametros)
                {
                    comando.Parameters.AddWithValue(p.Key, p.Valor);
                }
            }
            dtTabla.Load(comando.ExecuteReader());
            Desconectar();
            return dtTabla;
        }

        public static dbHelper ObtenerInstancia()
        {
            return instancia ?? new dbHelper();
        }

        public SqlCommand InstanciaCommando(string Query)
        {
            Conectar();
            SqlCommand comando = new SqlCommand(Query, conexion);
            return comando;
        }

        public void GrabarVentas(VentasDAO Nuevaventa)
        {
            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();
            SqlCommand cmVenta = new SqlCommand("prInsertarVentas", conexion);
            cmVenta.CommandType = CommandType.StoredProcedure;
            cmVenta.Transaction = transaccion;
            try
            {
                //NUEVA VENTA
                cmVenta.Parameters.AddWithValue("@nroVenta", Nuevaventa.nro_venta);
                cmVenta.Parameters.AddWithValue("@IdCliente", Nuevaventa.ID_Cliente);
                cmVenta.Parameters.AddWithValue("@IDEmpleado", Nuevaventa.ID_Empleado);
                cmVenta.Parameters.AddWithValue("@IDFormaPago", Nuevaventa.ID_FormaPago);
                cmVenta.Parameters.AddWithValue("@EntregaPropia", Nuevaventa.EntregaPropia);
                cmVenta.ExecuteNonQuery();

                //new SqlCommand("prInserccionDetalleVentas", conexion);
                SqlCommand cmdDetalle = new SqlCommand("prInserccionDetalleVentas", conexion);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Transaction = transaccion;
                //DETALLES VENTA
                foreach (DetalleVentasDAO detalle in Nuevaventa.detalleVentas)
                {
                    cmdDetalle.Parameters.AddWithValue("@IdProducto", detalle.ID_Producto);
                    cmdDetalle.Parameters.AddWithValue("@PrecioVenta", detalle.PrecioVenta);
                    cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion?.Rollback();
                throw ex;
            }
            finally
            {
                Desconectar();
            }
        }


    }
}
