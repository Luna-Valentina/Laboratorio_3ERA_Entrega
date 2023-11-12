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
    public partial class FrmVentas : Form
    {

        /* CONSTANTES DE COLUMNAS*/
        const int IDPRODUCTO = 0;
        const int DESCRIPCION = 1;
        const int PRECIOUNITARIO = 2;
        const int DESCUENTO = 3;
        const int BONIFICACION = 4;
        const int CANTIDAD = 5;
        const int SUBTOTAL = RECETA;
        const int RECETA = 7;
        /*************************/

        //Enlacador para carga de combos
        DataTable dtProductos = ProductosDAO.ListaDeProductos();
        DataTable dtClientes = ClientesDAO.ListaDeClientes();
        DataTable dtFormasDePago = FormasPagoDAO.ListaFormasDePago();
        DataTable dtVenddor = EmpleadosDAO.CargarVendedor();

        VentasDAO NuevaVenta = new VentasDAO();

        public FrmVentas()
        {
            InitializeComponent();
            CargarProductos();
            CargaClientes();
            CargarFormasPago();
            CargarVendedores();

            lblNumeroVenta.Text = "Venta N°: " + NuevaVenta.nro_venta.ToString();
            mskFecha.Text = DateTime.Now.ToString();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {


        }



        private void CargarProductos()
        {
            cbArticulos.DataSource = dtProductos;
            cbArticulos.DisplayMember = "Descripcion";
            cbArticulos.ValueMember = "ID_Producto";
            cbArticulos.SelectedIndex = -1;
        }
        private void CargaClientes()
        {
            cbClientes.DataSource = dtClientes;
            cbClientes.DisplayMember = "Cliente";
            cbClientes.ValueMember = "ID_Cliente";
            cbClientes.SelectedIndex = -1;
        }
        private void CargarFormasPago()
        {
            cbFormasPago.DataSource = dtFormasDePago;
            cbFormasPago.DisplayMember = "descripcion";
            cbFormasPago.ValueMember = "ID_FormaPago";
            cbFormasPago.SelectedIndex = 2;
        }
        private void CargarVendedores()
        {
            cbVendedores.DataSource = dtVenddor;
            cbVendedores.DisplayMember = "Empleado";
            cbVendedores.ValueMember = "ID";
            cbVendedores.SelectedIndex = 0;
        }

        private void prRecargarForm()
        {
            NuevaVenta = null;
            NuevaVenta = new VentasDAO();
            lblNumeroVenta.Text = "Venta N°: " + NuevaVenta.ID_Venta.ToString();
            mskFecha.Text = DateTime.Now.ToString();
            cbArticulos.SelectedIndex = -1;
            cbClientes.SelectedIndex = -1;
            cbFormasPago.SelectedIndex = -1;
            GrillaVenta.Rows.Clear();
            cbArticulos.SelectedIndex = -1;
            txtCantidad.Clear();
            cbArticulos.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccion producto alguno.");
                cbArticulos.Focus();
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar cantidades del items a Agregar.");
                txtCantidad.Focus();
                return;
            }
            if (NuevaVenta.YaTieneProducto(Convert.ToInt32(((DataRowView)cbArticulos.SelectedItem).Row.ItemArray[0]), NuevaVenta))
            {
                MessageBox.Show("Producto: " + cbArticulos.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DetalleVentasDAO Detalle = new DetalleVentasDAO();
                DataRowView producto = (DataRowView)cbArticulos.SelectedItem;
                Detalle.Nro_venta = NuevaVenta.nro_venta.ToString();
                Detalle.ID_Producto = Convert.ToInt32(producto.Row.ItemArray[0]);
                //Detalle.ID_Descuento = (float)producto.Row.ItemArray[11];
                Detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Detalle.PrecioVenta = (float)((float)Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30);
                NuevaVenta.AgregarDetalle(Detalle);

                GrillaVenta.DataSource = null;
                GrillaVenta.Rows.Add(new object[] {
                            producto.Row.ItemArray[IDPRODUCTO],//ID_Producto
                            producto.Row.ItemArray[DESCRIPCION], //Descripcion
                            (Convert.ToDouble( producto.Row.ItemArray[PRECIOUNITARIO] )
                             - ( (Convert.ToDouble( producto.Row.ItemArray[PRECIOUNITARIO] ) * Convert.ToDouble( producto.Row.ItemArray[11] )) / 100)
                            * 1.30 ).ToString(), //Precio Unitario

                            //(Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30 ).ToString(), //Precio Unitario
                            producto.Row.ItemArray[11].ToString(), // Descuento
                            txtCantidad.Text,         //Cantidad
                            0,                                          //Bonificacion
                            (Convert.ToInt32(txtCantidad.Text) * (Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30 ) ).ToString(),//Sub-Total
                            });
                cbArticulos.SelectedIndex = -1;
                txtCantidad.Clear();
                prCaclularTotales();
            }
        }

        private void cbArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.Equals(Keys.Enter)) && (cbArticulos.SelectedIndex != 0))
            {
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            try
            {
                int resultado = int.Parse(txtCantidad.Text);
            }
            catch { txtCantidad.Text = ""; }
        }

        private void OKVenta_Click(object sender, EventArgs e)
        {
            if (NuevaVenta.detalleVentas.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos 1 producto");
                return;
            }
            if (cbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el proveedor");
                cbClientes.Focus();
                return;
            }
            if (cbVendedores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el vendedor");
                cbVendedores.Focus();
                return;
            }
            try
            {
                NuevaVenta.GrabarVentas(NuevaVenta);
                prRecargarForm();
                DialogResult Mensaje = MessageBox.Show("El procedimiento fue un Exito!", "¿Desea Imprimir El Comprobante?", MessageBoxButtons.YesNo);
                switch (Mensaje)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex != -1)
            {
                DataRowView cliente = (DataRowView)cbClientes.SelectedItem;
                NuevaVenta.ID_Cliente = Convert.ToInt32(cliente.Row.ItemArray[0]);
            }
        }

        private void cbFormasPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFormasPago.SelectedIndex != -1)
            {
                DataRowView formaPago = (DataRowView)cbFormasPago.SelectedItem;
                NuevaVenta.ID_FormaPago = Convert.ToInt32(formaPago.Row.ItemArray[0]);
                NuevaVenta.ID_CuentaBancaria = Convert.ToInt32(formaPago.Row.ItemArray[2]);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r') && txtCantidad.Text != "")
            {
                if (cbArticulos.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar articulo");
                    cbArticulos.Focus();
                    return;
                }
                else
                {
                    btnAgregar.Focus();
                }
            }
        }

        private void GrillaVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (GrillaVenta.Rows[e.RowIndex].Cells[IDPRODUCTO].Value != null)
                {
                    if (e.ColumnIndex == RECETA)
                    {
                        NuevaVenta.detalleVentas.RemoveAt(GrillaVenta.CurrentRow.Index);
                        GrillaVenta.Rows.RemoveAt(GrillaVenta.CurrentRow.Index);
                    }
                }
            }
        }

        private void prCaclularTotales()
        {
            lblTotal.Text = "Total: $" + NuevaVenta.TotalVenta();
        }

        private void cbVendedores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbVendedores.SelectedIndex != -1)
            {
                DataRowView vendedor = (DataRowView)cbVendedores.SelectedItem;
                NuevaVenta.ID_Empleado = Convert.ToInt32(vendedor.Row.ItemArray[0]);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (cbArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccion producto alguno.");
                cbArticulos.Focus();
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar cantidades del items a Agregar.");
                txtCantidad.Focus();
                return;
            }
            if (NuevaVenta.YaTieneProducto(Convert.ToInt32(((DataRowView)cbArticulos.SelectedItem).Row.ItemArray[0]), NuevaVenta))
            {
                MessageBox.Show("Producto: " + cbArticulos.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DetalleVentasDAO Detalle = new DetalleVentasDAO();
                DataRowView producto = (DataRowView)cbArticulos.SelectedItem;
                Detalle.Nro_venta = NuevaVenta.nro_venta.ToString();
                Detalle.ID_Producto = Convert.ToInt32(producto.Row.ItemArray[0]);
                //Detalle.ID_Descuento = (float)producto.Row.ItemArray[11];
                Detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Detalle.PrecioVenta = (float)((float)Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30);
                NuevaVenta.AgregarDetalle(Detalle);

                GrillaVenta.DataSource = null;
                GrillaVenta.Rows.Add(new object[] {
                            producto.Row.ItemArray[IDPRODUCTO],//ID_Producto
                            producto.Row.ItemArray[DESCRIPCION], //Descripcion
                            (Convert.ToDouble( producto.Row.ItemArray[PRECIOUNITARIO] )
                             - ( (Convert.ToDouble( producto.Row.ItemArray[PRECIOUNITARIO] ) * Convert.ToDouble( producto.Row.ItemArray[11] )) / 100)
                            * 1.30 ).ToString(), //Precio Unitario

                            //(Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30 ).ToString(), //Precio Unitario
                            producto.Row.ItemArray[11].ToString(), // Descuento
                            txtCantidad.Text,         //Cantidad
                            0,                                          //Bonificacion
                            (Convert.ToInt32(txtCantidad.Text) * (Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30 ) ).ToString(),//Sub-Total
                            });
                cbArticulos.SelectedIndex = -1;
                txtCantidad.Clear();
                prCaclularTotales();
            }
        }

        private void OKVenta_Click_1(object sender, EventArgs e)
        {

            /*
            if (cbArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccion producto alguno.");
                cbArticulos.Focus();
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar cantidades del items a Agregar.");
                txtCantidad.Focus();
                return;
            }
            */

            
                DetalleVentasDAO Detalle = new DetalleVentasDAO();
                DataRowView producto = (DataRowView)cbArticulos.SelectedItem;
                Detalle.Nro_venta = NuevaVenta.nro_venta.ToString();
                Detalle.ID_Producto = Convert.ToInt32(producto.Row.ItemArray[0]);
                //Detalle.ID_Descuento = (float)producto.Row.ItemArray[11];
                Detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Detalle.PrecioVenta = (float)((float)Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30);
                NuevaVenta.AgregarDetalle(Detalle);

                GrillaVenta.DataSource = null;
                GrillaVenta.Rows.Add(new object[] {
                            producto.Row.ItemArray[IDPRODUCTO],//ID_Producto
                            producto.Row.ItemArray[DESCRIPCION], //Descripcion
                            (Convert.ToDouble( producto.Row.ItemArray[PRECIOUNITARIO] )
                             - ( (Convert.ToDouble( producto.Row.ItemArray[PRECIOUNITARIO] ) * Convert.ToDouble( producto.Row.ItemArray[11] )) / 100)
                            * 1.30 ).ToString(), //Precio Unitario

                            //(Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30 ).ToString(), //Precio Unitario
                            producto.Row.ItemArray[11].ToString(), // Descuento
                            txtCantidad.Text,         //Cantidad
                            0,                                          //Bonificacion
                            (Convert.ToInt32(txtCantidad.Text) * (Convert.ToDouble(producto.Row.ItemArray[PRECIOUNITARIO]) * 1.30 ) ).ToString(),//Sub-Total
                            });
                cbArticulos.SelectedIndex = -1;
                txtCantidad.Clear();
                prCaclularTotales();
            
        }
    }
}
