using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3ERA_Entrega
{
    public class EmpleadosDAO
    {

        public int ID_Empleado { get; set; }
        public int ID_Persona { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo { get; set; }
        public float Salario { get; set; }
        public int ID_Rol { get; set; }
        public int ID_Sucursal { get; set; }

        public static DataTable CargarVendedor()
        {

            DataTable dt = dbHelper.ObtenerInstancia().Consultar("select trim(cast(E.ID_Empleado as char)) 'ID', P.nombre+' '+P.apellido+' : '+R.Rol as Empleado\r\nfrom Empleados E\r\njoin Personas P ON P.ID_persona = e.ID_Persona\r\njoin barrios B ON b.ID_Barrio = p.ID_Barrio\r\nJoin Sucursales S on S.ID_Sucursal = e.ID_Sucursal\r\njoin roles R on R.ID_Rol = E.ID_Rol\r\nwhere E.Activo = 1\r\nand e.id_rol = 2\r\n");
            return dt;
            /*
                        string query = "select trim(cast(E.ID_Empleado as char))+' - '+P.nombre+' '+P.apellido+' : '+R.Rol as Empleado\r\nfrom Empleados E\r\njoin Personas P ON P.ID_persona = e.ID_Persona\r\njoin barrios B ON b.ID_Barrio = p.ID_Barrio\r\nJoin Sucursales S on S.ID_Sucursal = e.ID_Sucursal\r\njoin roles R on R.ID_Rol = E.ID_Rol\r\nwhere E.Activo = 1\r\nand e.id_rol = 2\r\n";
                        SqlConnection con = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=TP_LabII_GRUPO16;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        string resultado;
                        resultado = cmd.ExecuteScalar().ToString();
                        con.Close();
                        con.Dispose();
                        cmd.Dispose();
                        return resultado;
            */
        }



    }
}
