namespace Laboratorio_3ERA_Entrega
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colPrecio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblClientesConsulta = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtboxCliente_desc = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrecio});
            this.dataGridView1.Location = new System.Drawing.Point(59, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "CALCULAR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrecio.HeaderText = "Consultar Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Text = "Consultar";
            this.colPrecio.UseColumnTextForButtonValue = true;
            this.colPrecio.Width = 125;
            // 
            // lblClientesConsulta
            // 
            this.lblClientesConsulta.AutoSize = true;
            this.lblClientesConsulta.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.lblClientesConsulta.Location = new System.Drawing.Point(310, 22);
            this.lblClientesConsulta.Name = "lblClientesConsulta";
            this.lblClientesConsulta.Size = new System.Drawing.Size(428, 27);
            this.lblClientesConsulta.TabIndex = 2;
            this.lblClientesConsulta.Text = "CLIENTES / DESCUENTO OBRA SOCIAL";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(100, 72);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(106, 16);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre Cliente: ";
            // 
            // txtboxCliente_desc
            // 
            this.txtboxCliente_desc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtboxCliente_desc.Location = new System.Drawing.Point(230, 69);
            this.txtboxCliente_desc.Name = "txtboxCliente_desc";
            this.txtboxCliente_desc.Size = new System.Drawing.Size(548, 22);
            this.txtboxCliente_desc.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(801, 68);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(104, 23);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(446, 107);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(130, 23);
            this.btnMostrarTodos.TabIndex = 6;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1027, 464);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtboxCliente_desc);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblClientesConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblClientesConsulta;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtboxCliente_desc;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridViewButtonColumn colPrecio;
    }
}