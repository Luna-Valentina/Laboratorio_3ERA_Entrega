using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3ERA_Entrega
{
    internal class ClientesDAO
    {

        public int ID_Cliente { get; set; }
        public int ID_Persona { get; set; }
        public int ID_condicion_iva { get; set; }
        public int ID_ObraSocial { get; set; }


        public static DataTable ListaDeClientes()
        {
            DataTable dt = dbHelper.ObtenerInstancia().Consultar("Select C.ID_Cliente, P.nombre+' '+P.apellido+' - '+I.condicion_iva as Cliente, I.condicion_iva\r\nfrom clientes C\r\nJoin Personas P ON p.ID_persona = C.ID_persona\r\nJoin Condiciones_iva I ON I.id_condicion_iva = C.id_condicion_iva");
            return dt;
        }

    }
}
