using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3ERA_Entrega
{
    public class VentasDAO
    {


        public int ID_Venta { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_FormaPago { get; set; }
        public int ID_CuentaBancaria { get; set; }
        public int IdReceta { get; set; }
        public bool EntregaPropia { get; set; }
        public int nro_venta { get; set; }

        public List<DetalleVentasDAO> detalleVentas { get; set; }


        public VentasDAO()
        {
            this.nro_venta = UltimoNumeroVenta();
            this.Fecha = DateTime.Now;
            this.ID_Empleado = 1;
            detalleVentas = new List<DetalleVentasDAO>();
        }

        private int UltimoNumeroVenta()
        {
            SqlCommand cmd = dbHelper.ObtenerInstancia().InstanciaCommando("prUltimoNumeroVenta");
            SqlParameter resultado = new SqlParameter("@Numero", DbType.Int32);
            cmd.CommandType = CommandType.StoredProcedure;
            resultado.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(resultado);
            try
            {
                cmd.ExecuteNonQuery();
                this.nro_venta = (int)resultado.Value;
                if ((int)resultado.Value == -1)
                {
                    resultado.Value = 1;
                }
                return (int)resultado.Value;
            }
            catch
            {
                return 1;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public void AgregarDetalle(DetalleVentasDAO detalle)
        {
            detalleVentas.Add(detalle);
        }

        public bool YaTieneProducto(int idProducto, VentasDAO venta)
        {
            bool boResultado = false;
            if (venta.detalleVentas != null)
            {
                List<DetalleVentasDAO> de = venta.detalleVentas;
                foreach (DetalleVentasDAO detalle in de)
                {
                    if (detalle.ID_Producto.Equals(idProducto))
                    {
                        boResultado = true;
                        break;
                    }
                }
            }
            return boResultado;
        }

        public void GrabarVentas(VentasDAO NuevaVenta)
        {
            try
            {
                dbHelper.ObtenerInstancia().GrabarVentas(NuevaVenta);

                MessageBox.Show("Nueva Venta grabada con Exito!");
                return;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error durante el procedimiento de inserccion. Detalles tecnicos:" + ex.Message);
            }
        }

        internal string TotalVenta()
        {
            float resultado = 0;
            foreach (DetalleVentasDAO item in detalleVentas)
            {
                resultado = item.Cantidad * (item.PrecioVenta);
            }
            return resultado.ToString();
        }


    }
}
