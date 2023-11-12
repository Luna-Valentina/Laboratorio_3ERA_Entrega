namespace Laboratorio_3ERA_Entrega
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxFacturacion = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grpBoxObrasSociales = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCliente_obs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.grpBoxFacturacion.SuspendLayout();
            this.grpBoxObrasSociales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nueva Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBoxFacturacion
            // 
            this.grpBoxFacturacion.Controls.Add(this.button2);
            this.grpBoxFacturacion.Controls.Add(this.button1);
            this.grpBoxFacturacion.Location = new System.Drawing.Point(710, 23);
            this.grpBoxFacturacion.Name = "grpBoxFacturacion";
            this.grpBoxFacturacion.Size = new System.Drawing.Size(200, 116);
            this.grpBoxFacturacion.TabIndex = 2;
            this.grpBoxFacturacion.TabStop = false;
            this.grpBoxFacturacion.Text = "FACTURACION";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nota Credito";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpBoxObrasSociales
            // 
            this.grpBoxObrasSociales.Controls.Add(this.button4);
            this.grpBoxObrasSociales.Controls.Add(this.btnCliente_obs);
            this.grpBoxObrasSociales.Location = new System.Drawing.Point(710, 154);
            this.grpBoxObrasSociales.Name = "grpBoxObrasSociales";
            this.grpBoxObrasSociales.Size = new System.Drawing.Size(200, 109);
            this.grpBoxObrasSociales.TabIndex = 3;
            this.grpBoxObrasSociales.TabStop = false;
            this.grpBoxObrasSociales.Text = "OBRAS SOCIALES";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Reintegros";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCliente_obs
            // 
            this.btnCliente_obs.Location = new System.Drawing.Point(45, 26);
            this.btnCliente_obs.Name = "btnCliente_obs";
            this.btnCliente_obs.Size = new System.Drawing.Size(90, 33);
            this.btnCliente_obs.TabIndex = 0;
            this.btnCliente_obs.Text = "Cliente";
            this.btnCliente_obs.UseVisualStyleBackColor = true;
            this.btnCliente_obs.Click += new System.EventHandler(this.btnCliente_obs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratorio_3ERA_Entrega.Properties.Resources.FARMACIA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(755, 323);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(97, 33);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 449);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.grpBoxObrasSociales);
            this.Controls.Add(this.grpBoxFacturacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.grpBoxFacturacion.ResumeLayout(false);
            this.grpBoxObrasSociales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxFacturacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpBoxObrasSociales;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCliente_obs;
        private System.Windows.Forms.Button btnInventario;
    }
}

