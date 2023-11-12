using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3ERA_Entrega
{
    public class FormasPagoDAO
    {


        public int ID_FormaPago { get; set; }
        public string Descripcion { get; set; }
        public int ID_CuentaBancaria { get; set; }

        public static DataTable ListaFormasDePago()
        {
            DataTable dt = dbHelper.ObtenerInstancia().Consultar("select ID_FormaPago, descripcion, ID_CuentaBancaria from FormasPagos Order By Descripcion");
            return dt;
        }


    }
}
