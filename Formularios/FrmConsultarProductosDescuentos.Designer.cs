namespace Laboratorio_3ERA_Entrega
{
    partial class FrmConsultarProductosDescuentos
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
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblIDPERSONA = new System.Windows.Forms.Label();
            this.lblmedicamentos = new System.Windows.Forms.Label();
            this.txtboxIDPERSONA = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtboxTotal = new System.Windows.Forms.TextBox();
            this.btnCalcularDescuento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(154, 125);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(263, 24);
            this.cboProductos.TabIndex = 0;
            // 
            // lblIDPERSONA
            // 
            this.lblIDPERSONA.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblIDPERSONA.AutoSize = true;
            this.lblIDPERSONA.Location = new System.Drawing.Point(23, 54);
            this.lblIDPERSONA.Name = "lblIDPERSONA";
            this.lblIDPERSONA.Size = new System.Drawing.Size(89, 16);
            this.lblIDPERSONA.TabIndex = 1;
            this.lblIDPERSONA.Text = "ID PERSONA";
            // 
            // lblmedicamentos
            // 
            this.lblmedicamentos.AutoSize = true;
            this.lblmedicamentos.Location = new System.Drawing.Point(23, 128);
            this.lblmedicamentos.Name = "lblmedicamentos";
            this.lblmedicamentos.Size = new System.Drawing.Size(116, 16);
            this.lblmedicamentos.TabIndex = 2;
            this.lblmedicamentos.Text = "MEDICAMENTOS";
            // 
            // txtboxIDPERSONA
            // 
            this.txtboxIDPERSONA.Enabled = false;
            this.txtboxIDPERSONA.Location = new System.Drawing.Point(154, 48);
            this.txtboxIDPERSONA.Name = "txtboxIDPERSONA";
            this.txtboxIDPERSONA.Size = new System.Drawing.Size(63, 22);
            this.txtboxIDPERSONA.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 197);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 16);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(154, 191);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownCantidad.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(93, 311);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "TOTAL $";
            // 
            // txtboxTotal
            // 
            this.txtboxTotal.Location = new System.Drawing.Point(211, 314);
            this.txtboxTotal.Name = "txtboxTotal";
            this.txtboxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtboxTotal.TabIndex = 7;
            // 
            // btnCalcularDescuento
            // 
            this.btnCalcularDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDescuento.Location = new System.Drawing.Point(154, 234);
            this.btnCalcularDescuento.Name = "btnCalcularDescuento";
            this.btnCalcularDescuento.Size = new System.Drawing.Size(131, 50);
            this.btnCalcularDescuento.TabIndex = 8;
            this.btnCalcularDescuento.Text = "Calcular";
            this.btnCalcularDescuento.UseVisualStyleBackColor = true;
            this.btnCalcularDescuento.Click += new System.EventHandler(this.btnCalcularDescuento_Click);
            // 
            // FrmConsultarProductosDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 384);
            this.Controls.Add(this.btnCalcularDescuento);
            this.Controls.Add(this.txtboxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtboxIDPERSONA);
            this.Controls.Add(this.lblmedicamentos);
            this.Controls.Add(this.lblIDPERSONA);
            this.Controls.Add(this.cboProductos);
            this.Name = "FrmConsultarProductosDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarProductosDescuentos";
            this.Load += new System.EventHandler(this.FrmConsultarProductosDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label lblIDPERSONA;
        private System.Windows.Forms.Label lblmedicamentos;
        private System.Windows.Forms.TextBox txtboxIDPERSONA;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtboxTotal;
        private System.Windows.Forms.Button btnCalcularDescuento;
    }
}