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
            this.ProductosPnl = new System.Windows.Forms.Panel();
            this.ComprasBtn = new System.Windows.Forms.Button();
            this.CrearProductosBtn = new System.Windows.Forms.Button();
            this.ProveedoresBtn = new System.Windows.Forms.Button();
            this.ProductosBtn = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.VentasBtn = new System.Windows.Forms.Button();
            this.InformacionBtn = new System.Windows.Forms.Button();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ProductosPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.InformacionBtn);
            this.panel1.Controls.Add(this.CerrarBtn);
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
            // ProductosPnl
            // 
            this.ProductosPnl.Controls.Add(this.ComprasBtn);
            this.ProductosPnl.Controls.Add(this.CrearProductosBtn);
            this.ProductosPnl.Location = new System.Drawing.Point(654, 336);
            this.ProductosPnl.Name = "ProductosPnl";
            this.ProductosPnl.Size = new System.Drawing.Size(200, 88);
            this.ProductosPnl.TabIndex = 5;
            this.ProductosPnl.Visible = false;
            // 
            // ComprasBtn
            // 
            this.ComprasBtn.BackColor = System.Drawing.Color.Gray;
            this.ComprasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtn.Image = global::Metalurgica.Properties.Resources.Comprar_Producto;
            this.ComprasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasBtn.Location = new System.Drawing.Point(4, 42);
            this.ComprasBtn.Name = "ComprasBtn";
            this.ComprasBtn.Size = new System.Drawing.Size(193, 37);
            this.ComprasBtn.TabIndex = 1;
            this.ComprasBtn.Text = "NOTAS DE COMPRA";
            this.ComprasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ComprasBtn.UseVisualStyleBackColor = false;
            this.ComprasBtn.Click += new System.EventHandler(this.ComprasBtn_Click);
            // 
            // CrearProductosBtn
            // 
            this.CrearProductosBtn.BackColor = System.Drawing.Color.Gray;
            this.CrearProductosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearProductosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearProductosBtn.Image = global::Metalurgica.Properties.Resources.Agregar_Productos;
            this.CrearProductosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearProductosBtn.Location = new System.Drawing.Point(4, 0);
            this.CrearProductosBtn.Name = "CrearProductosBtn";
            this.CrearProductosBtn.Size = new System.Drawing.Size(193, 37);
            this.CrearProductosBtn.TabIndex = 0;
            this.CrearProductosBtn.Text = "CREAR PRODUCTO";
            this.CrearProductosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrearProductosBtn.UseVisualStyleBackColor = false;
            this.CrearProductosBtn.Click += new System.EventHandler(this.CrearProductosBtn_Click);
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
            this.ProveedoresBtn.Click += new System.EventHandler(this.ProveedoresBtn_Click);
            // 
            // ProductosBtn
            // 
            this.ProductosBtn.BackColor = System.Drawing.Color.Gray;
            this.ProductosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosBtn.Image = global::Metalurgica.Properties.Resources.Productos;
            this.ProductosBtn.Location = new System.Drawing.Point(528, 318);
            this.ProductosBtn.Name = "ProductosBtn";
            this.ProductosBtn.Size = new System.Drawing.Size(120, 120);
            this.ProductosBtn.TabIndex = 3;
            this.ProductosBtn.Text = "PRODUCTOS\r\n";
            this.ProductosBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProductosBtn.UseVisualStyleBackColor = false;
            this.ProductosBtn.Click += new System.EventHandler(this.ProductosBtn_Click);
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
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
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
            this.VentasBtn.Click += new System.EventHandler(this.VentasBtn_Click);
            // 
            // InformacionBtn
            // 
            this.InformacionBtn.BackColor = System.Drawing.Color.Gray;
            this.InformacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformacionBtn.ForeColor = System.Drawing.Color.White;
            this.InformacionBtn.Image = global::Metalurgica.Properties.Resources.Infromacion;
            this.InformacionBtn.Location = new System.Drawing.Point(780, 3);
            this.InformacionBtn.Name = "InformacionBtn";
            this.InformacionBtn.Size = new System.Drawing.Size(29, 27);
            this.InformacionBtn.TabIndex = 6;
            this.InformacionBtn.UseVisualStyleBackColor = false;
            this.InformacionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Gray;
            this.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBtn.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CerrarBtn.Image = global::Metalurgica.Properties.Resources.Boton_Cerrar;
            this.CerrarBtn.Location = new System.Drawing.Point(825, 3);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(29, 27);
            this.CerrarBtn.TabIndex = 3;
            this.CerrarBtn.UseVisualStyleBackColor = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
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
            this.Controls.Add(this.ProductosPnl);
            this.Controls.Add(this.ProveedoresBtn);
            this.Controls.Add(this.ProductosBtn);
            this.Controls.Add(this.ClientesBtn);
            this.Controls.Add(this.VentasBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ProductosPnl.ResumeLayout(false);
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
        private System.Windows.Forms.Panel ProductosPnl;
        private System.Windows.Forms.Button ComprasBtn;
        private System.Windows.Forms.Button CrearProductosBtn;
        private System.Windows.Forms.Button InformacionBtn;
    }
}

