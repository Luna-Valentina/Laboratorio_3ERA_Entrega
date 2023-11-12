namespace Laboratorio_3ERA_Entrega
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbVendedores = new System.Windows.Forms.ComboBox();
            this.cbFormasPago = new System.Windows.Forms.ComboBox();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.GrillaVenta = new System.Windows.Forms.DataGridView();
            this.ColIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OKVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVendedores
            // 
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(95, 67);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(4);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(445, 24);
            this.cbVendedores.TabIndex = 53;
            // 
            // cbFormasPago
            // 
            this.cbFormasPago.FormattingEnabled = true;
            this.cbFormasPago.Location = new System.Drawing.Point(668, 125);
            this.cbFormasPago.Margin = new System.Windows.Forms.Padding(4);
            this.cbFormasPago.Name = "cbFormasPago";
            this.cbFormasPago.Size = new System.Drawing.Size(239, 24);
            this.cbFormasPago.TabIndex = 38;
            // 
            // cbArticulos
            // 
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Location = new System.Drawing.Point(16, 177);
            this.cbArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(524, 24);
            this.cbArticulos.TabIndex = 39;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(16, 125);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(524, 24);
            this.cbClientes.TabIndex = 37;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(16, 71);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(67, 16);
            this.lblVendedor.TabIndex = 52;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(971, 539);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "Total:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(551, 129);
            this.lblFormaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(104, 16);
            this.lblFormaPago.TabIndex = 50;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(975, 125);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(169, 74);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(971, 41);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 49;
            this.lblFecha.Text = "Fecha";
            // 
            // mskFecha
            // 
            this.mskFecha.Enabled = false;
            this.mskFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFecha.Location = new System.Drawing.Point(1041, 38);
            this.mskFecha.Margin = new System.Windows.Forms.Padding(4);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(101, 26);
            this.mskFecha.TabIndex = 48;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(551, 155);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(64, 16);
            this.lblcantidad.TabIndex = 47;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(549, 178);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 22);
            this.txtCantidad.TabIndex = 40;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(16, 105);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 46;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(12, 155);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(62, 17);
            this.lblArticulo.TabIndex = 45;
            this.lblArticulo.Text = "Articulos";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.Location = new System.Drawing.Point(13, 23);
            this.lblNumeroVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(112, 25);
            this.lblNumeroVenta.TabIndex = 44;
            this.lblNumeroVenta.Text = "Venta N°: ";
            // 
            // GrillaVenta
            // 
            this.GrillaVenta.AllowUserToAddRows = false;
            this.GrillaVenta.AllowUserToResizeRows = false;
            this.GrillaVenta.BackgroundColor = System.Drawing.SystemColors.Info;
            this.GrillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDProducto,
            this.ColProducto,
            this.ColPrecioVenta,
            this.ColDescuento,
            this.ColCantidad,
            this.ColBonificacion,
            this.ColPrecioTotal,
            this.ColBorrar});
            this.GrillaVenta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrillaVenta.Location = new System.Drawing.Point(16, 208);
            this.GrillaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaVenta.MultiSelect = false;
            this.GrillaVenta.Name = "GrillaVenta";
            this.GrillaVenta.ReadOnly = true;
            this.GrillaVenta.RowHeadersWidth = 51;
            this.GrillaVenta.RowTemplate.Height = 17;
            this.GrillaVenta.Size = new System.Drawing.Size(1128, 316);
            this.GrillaVenta.TabIndex = 42;
            // 
            // ColIDProducto
            // 
            this.ColIDProducto.Frozen = true;
            this.ColIDProducto.HeaderText = "ID";
            this.ColIDProducto.MinimumWidth = 6;
            this.ColIDProducto.Name = "ColIDProducto";
            this.ColIDProducto.ReadOnly = true;
            this.ColIDProducto.Width = 40;
            // 
            // ColProducto
            // 
            this.ColProducto.Frozen = true;
            this.ColProducto.HeaderText = "Descricpion";
            this.ColProducto.MinimumWidth = 6;
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 200;
            // 
            // ColPrecioVenta
            // 
            this.ColPrecioVenta.Frozen = true;
            this.ColPrecioVenta.HeaderText = "Precio Unitario";
            this.ColPrecioVenta.MinimumWidth = 6;
            this.ColPrecioVenta.Name = "ColPrecioVenta";
            this.ColPrecioVenta.ReadOnly = true;
            this.ColPrecioVenta.Width = 150;
            // 
            // ColDescuento
            // 
            this.ColDescuento.HeaderText = "Descuento";
            this.ColDescuento.MinimumWidth = 6;
            this.ColDescuento.Name = "ColDescuento";
            this.ColDescuento.ReadOnly = true;
            this.ColDescuento.Width = 80;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 125;
            // 
            // ColBonificacion
            // 
            this.ColBonificacion.HeaderText = "Boni %";
            this.ColBonificacion.MinimumWidth = 6;
            this.ColBonificacion.Name = "ColBonificacion";
            this.ColBonificacion.Width = 50;
            // 
            // ColPrecioTotal
            // 
            this.ColPrecioTotal.HeaderText = "Sub Total";
            this.ColPrecioTotal.MinimumWidth = 6;
            this.ColPrecioTotal.Name = "ColPrecioTotal";
            this.ColPrecioTotal.ReadOnly = true;
            this.ColPrecioTotal.Width = 120;
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "Borrar";
            this.ColBorrar.MinimumWidth = 6;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            this.ColBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBorrar.Width = 50;
            // 
            // OKVenta
            // 
            this.OKVenta.BackColor = System.Drawing.SystemColors.Highlight;
            this.OKVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKVenta.ForeColor = System.Drawing.Color.Black;
            this.OKVenta.Location = new System.Drawing.Point(16, 531);
            this.OKVenta.Margin = new System.Windows.Forms.Padding(4);
            this.OKVenta.Name = "OKVenta";
            this.OKVenta.Size = new System.Drawing.Size(947, 34);
            this.OKVenta.TabIndex = 43;
            this.OKVenta.Text = "Confirmar Venta";
            this.OKVenta.UseVisualStyleBackColor = false;
            this.OKVenta.Click += new System.EventHandler(this.OKVenta_Click_1);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 591);
            this.Controls.Add(this.cbVendedores);
            this.Controls.Add(this.cbFormasPago);
            this.Controls.Add(this.cbArticulos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.GrillaVenta);
            this.Controls.Add(this.OKVenta);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVendedores;
        private System.Windows.Forms.ComboBox cbFormasPago;
        private System.Windows.Forms.ComboBox cbArticulos;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.DataGridView GrillaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.Button OKVenta;
    }
}