using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3ERA_Entrega
{
    public class DetalleVentasDAO
    {


        public int ID_DetalleVenta { get; set; }
        public string Nro_venta { get; set; }
        public int ID_Descuento { get; set; }
        public int ID_Producto { get; set; }
        public float PrecioVenta { get; set; }
        public float Cantidad { get; set; }
       // public RecetasDAO Recetas { get; set; }


        public DetalleVentasDAO()
        {
           // RecetasDAO Receta = new RecetasDAO();
        }

        internal static bool EsArticuloBajoReceta(DataRowView seleccionado)
        {
            SqlConnection conn = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select dbo.fxProducotBajoReceta(@IDProducto)", conn);
            //            SqlParameter parametro = new SqlParameter("@IDProducto", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@IDProducto", seleccionado.Row.ItemArray[0].ToString());
            //            parametro.Value = parametro;
            var resultado = cmd.ExecuteScalar();
            conn.Close();
            return (bool)resultado;
        }


    }
}
