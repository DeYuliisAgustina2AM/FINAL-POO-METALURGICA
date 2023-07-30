namespace Metalurgica
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 139);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comercialización de Productos Metalúrgicos y Siderúrgicos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Métallon s.r.l";
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.Gray;
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.Image = global::Metalurgica.Properties.Resources.Proveedores1;
            this.BtnProveedores.Location = new System.Drawing.Point(227, 318);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(120, 120);
            this.BtnProveedores.TabIndex = 4;
            this.BtnProveedores.Text = "PROOVEDORES";
            this.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProveedores.UseVisualStyleBackColor = false;
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.Gray;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.Image = global::Metalurgica.Properties.Resources.Productos1;
            this.BtnProductos.Location = new System.Drawing.Point(528, 318);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(120, 120);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "PRODUCTOS\r\n";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProductos.UseVisualStyleBackColor = false;
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Gray;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Image = global::Metalurgica.Properties.Resources.Clientes;
            this.BtnClientes.Location = new System.Drawing.Point(227, 152);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(120, 120);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "CLIENTES";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClientes.UseVisualStyleBackColor = false;
            // 
            // BtnVentas
            // 
            this.BtnVentas.BackColor = System.Drawing.Color.Gray;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Image = global::Metalurgica.Properties.Resources.Ventas;
            this.BtnVentas.Location = new System.Drawing.Point(528, 152);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(120, 120);
            this.BtnVentas.TabIndex = 1;
            this.BtnVentas.Text = "VENTAS";
            this.BtnVentas.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCerrar.Image = global::Metalurgica.Properties.Resources.Boton_Cerrar;
            this.BtnCerrar.Location = new System.Drawing.Point(822, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(29, 27);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metalurgica.Properties.Resources.Metallon;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.BtnProveedores);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnProveedores;
    }
}

