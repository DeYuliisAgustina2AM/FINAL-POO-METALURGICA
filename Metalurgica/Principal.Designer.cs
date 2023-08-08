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
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProveedoresBtn = new System.Windows.Forms.Button();
            this.ProductosBtn = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.VentasBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 139);
            this.panel1.TabIndex = 0;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Gray;
            this.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBtn.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CerrarBtn.Image = global::Metalurgica.Properties.Resources.Boton_Cerrar;
            this.CerrarBtn.Location = new System.Drawing.Point(822, 5);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(29, 27);
            this.CerrarBtn.TabIndex = 3;
            this.CerrarBtn.UseVisualStyleBackColor = false;
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
            // ProveedoresBtn
            // 
            this.ProveedoresBtn.BackColor = System.Drawing.Color.Gray;
            this.ProveedoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProveedoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresBtn.Image = global::Metalurgica.Properties.Resources.Proveedores1;
            this.ProveedoresBtn.Location = new System.Drawing.Point(227, 318);
            this.ProveedoresBtn.Name = "ProveedoresBtn";
            this.ProveedoresBtn.Size = new System.Drawing.Size(120, 120);
            this.ProveedoresBtn.TabIndex = 4;
            this.ProveedoresBtn.Text = "PROOVEDORES";
            this.ProveedoresBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProveedoresBtn.UseVisualStyleBackColor = false;
            // 
            // ProductosBtn
            // 
            this.ProductosBtn.BackColor = System.Drawing.Color.Gray;
            this.ProductosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosBtn.Image = global::Metalurgica.Properties.Resources.Productos1;
            this.ProductosBtn.Location = new System.Drawing.Point(528, 318);
            this.ProductosBtn.Name = "ProductosBtn";
            this.ProductosBtn.Size = new System.Drawing.Size(120, 120);
            this.ProductosBtn.TabIndex = 3;
            this.ProductosBtn.Text = "PRODUCTOS\r\n";
            this.ProductosBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProductosBtn.UseVisualStyleBackColor = false;
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.BackColor = System.Drawing.Color.Gray;
            this.ClientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.Image = global::Metalurgica.Properties.Resources.Clientes;
            this.ClientesBtn.Location = new System.Drawing.Point(227, 152);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(120, 120);
            this.ClientesBtn.TabIndex = 2;
            this.ClientesBtn.Text = "CLIENTES";
            this.ClientesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientesBtn.UseVisualStyleBackColor = false;
            // 
            // VentasBtn
            // 
            this.VentasBtn.BackColor = System.Drawing.Color.Gray;
            this.VentasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasBtn.Image = global::Metalurgica.Properties.Resources.Ventas;
            this.VentasBtn.Location = new System.Drawing.Point(528, 152);
            this.VentasBtn.Name = "VentasBtn";
            this.VentasBtn.Size = new System.Drawing.Size(120, 120);
            this.VentasBtn.TabIndex = 1;
            this.VentasBtn.Text = "VENTAS";
            this.VentasBtn.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.ProveedoresBtn);
            this.Controls.Add(this.ProductosBtn);
            this.Controls.Add(this.ClientesBtn);
            this.Controls.Add(this.VentasBtn);
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
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button VentasBtn;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button ProductosBtn;
        private System.Windows.Forms.Button ProveedoresBtn;
    }
}

