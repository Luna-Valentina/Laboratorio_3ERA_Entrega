using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3ERA_Entrega
{
    public class ProductosDAO
    {

        int ID_Producto { get; set; }
        String Descripcion { get; set; }
        float PrecioUnitario { get; set; }
        bool estado { get; set; }
        DateTime Fec_Vencimiento { get; set; }
        int StockActual { get; set; }
        int StockMinimo { get; set; }
        String CodigoBarra { get; set; }
        bool BajoReceta { get; set; }
        int ID_Unidad { get; set; }
        int ID_TipoProducto { get; set; }
        float Descuento_producto { get; set; }


        public static DataTable ListaDeProductos()
        {
            DataTable dt = dbHelper.ObtenerInstancia().Consultar("select * from Productos order by Descripcion");
            return dt;
        }


    }
}
