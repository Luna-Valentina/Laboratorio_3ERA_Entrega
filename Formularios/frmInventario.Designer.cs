namespace Laboratorio_3ERA_Entrega
{
    partial class frmInventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.btnReposicion = new System.Windows.Forms.Button();
            this.btnListadoDescripcion = new System.Windows.Forms.Button();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.btnStockTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColModificar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 292);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColModificar
            // 
            this.ColModificar.HeaderText = "Modificar";
            this.ColModificar.MinimumWidth = 6;
            this.ColModificar.Name = "ColModificar";
            this.ColModificar.ReadOnly = true;
            this.ColModificar.Text = "Editar";
            this.ColModificar.UseColumnTextForButtonValue = true;
            this.ColModificar.Width = 125;
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.Location = new System.Drawing.Point(340, 9);
            this.lblNumeroVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(362, 25);
            this.lblNumeroVenta.TabIndex = 45;
            this.lblNumeroVenta.Text = "STOCK CRITICO DE PRODUCTOS";
            // 
            // btnReposicion
            // 
            this.btnReposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReposicion.Location = new System.Drawing.Point(28, 438);
            this.btnReposicion.Name = "btnReposicion";
            this.btnReposicion.Size = new System.Drawing.Size(200, 67);
            this.btnReposicion.TabIndex = 47;
            this.btnReposicion.Text = "Articulos a Reponer";
            this.btnReposicion.UseVisualStyleBackColor = true;
            this.btnReposicion.Click += new System.EventHandler(this.btnReposicion_Click);
            // 
            // btnListadoDescripcion
            // 
            this.btnListadoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoDescripcion.Location = new System.Drawing.Point(769, 455);
            this.btnListadoDescripcion.Name = "btnListadoDescripcion";
            this.btnListadoDescripcion.Size = new System.Drawing.Size(131, 32);
            this.btnListadoDescripcion.TabIndex = 48;
            this.btnListadoDescripcion.Text = "Filtrar";
            this.btnListadoDescripcion.UseVisualStyleBackColor = true;
            this.btnListadoDescripcion.Click += new System.EventHandler(this.btnListadoDescripcion_Click);
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(283, 461);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(455, 22);
            this.txtInformacion.TabIndex = 49;
            // 
            // btnStockTotal
            // 
            this.btnStockTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockTotal.Location = new System.Drawing.Point(12, 36);
            this.btnStockTotal.Name = "btnStockTotal";
            this.btnStockTotal.Size = new System.Drawing.Size(200, 29);
            this.btnStockTotal.TabIndex = 53;
            this.btnStockTotal.Text = "Stock Actual";
            this.btnStockTotal.UseVisualStyleBackColor = true;
            this.btnStockTotal.Click += new System.EventHandler(this.btnStockTotal_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1085, 531);
            this.Controls.Add(this.btnStockTotal);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.btnListadoDescripcion);
            this.Controls.Add(this.btnReposicion);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTARIO - STOCK";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Button btnReposicion;
        private System.Windows.Forms.Button btnListadoDescripcion;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Button btnStockTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColModificar;
    }
}