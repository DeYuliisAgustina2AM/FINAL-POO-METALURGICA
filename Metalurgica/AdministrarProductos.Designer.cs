namespace Metalurgica
{
    partial class AdministrarProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.DatosClientesGb = new System.Windows.Forms.GroupBox();
            this.CantidadNud = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.StockTxt = new System.Windows.Forms.TextBox();
            this.ProductoTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CodProductoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ListaProductosGb = new System.Windows.Forms.GroupBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.ListaProductosDgv = new System.Windows.Forms.DataGridView();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DatosClientesGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNud)).BeginInit();
            this.ListaProductosGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 138);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(538, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(406, 31);
            this.label11.TabIndex = 12;
            this.label11.Text = "ADMINISTRAR PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Comercialización de Productos Metalúrgicos y Siderúrgicos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Métallon s.r.l";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metalurgica.Properties.Resources.Metallon;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Gray;
            this.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBtn.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CerrarBtn.Image = global::Metalurgica.Properties.Resources.Boton_Cerrar;
            this.CerrarBtn.Location = new System.Drawing.Point(1173, 3);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(29, 27);
            this.CerrarBtn.TabIndex = 4;
            this.CerrarBtn.UseVisualStyleBackColor = false;
            // 
            // DatosClientesGb
            // 
            this.DatosClientesGb.Controls.Add(this.PrecioTxt);
            this.DatosClientesGb.Controls.Add(this.CantidadNud);
            this.DatosClientesGb.Controls.Add(this.DescripcionTxt);
            this.DatosClientesGb.Controls.Add(this.StockTxt);
            this.DatosClientesGb.Controls.Add(this.ProductoTxt);
            this.DatosClientesGb.Controls.Add(this.label9);
            this.DatosClientesGb.Controls.Add(this.label8);
            this.DatosClientesGb.Controls.Add(this.label7);
            this.DatosClientesGb.Controls.Add(this.CodProductoTxt);
            this.DatosClientesGb.Controls.Add(this.label6);
            this.DatosClientesGb.Controls.Add(this.label5);
            this.DatosClientesGb.Controls.Add(this.label4);
            this.DatosClientesGb.Controls.Add(this.CancelarBtn);
            this.DatosClientesGb.Controls.Add(this.GuardarBtn);
            this.DatosClientesGb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DatosClientesGb.Location = new System.Drawing.Point(12, 164);
            this.DatosClientesGb.Name = "DatosClientesGb";
            this.DatosClientesGb.Size = new System.Drawing.Size(403, 462);
            this.DatosClientesGb.TabIndex = 8;
            this.DatosClientesGb.TabStop = false;
            this.DatosClientesGb.Text = "Datos Productos";
            // 
            // CantidadNud
            // 
            this.CantidadNud.Location = new System.Drawing.Point(124, 197);
            this.CantidadNud.Name = "CantidadNud";
            this.CantidadNud.Size = new System.Drawing.Size(133, 20);
            this.CantidadNud.TabIndex = 33;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(124, 139);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(133, 20);
            this.DescripcionTxt.TabIndex = 32;
            // 
            // StockTxt
            // 
            this.StockTxt.Location = new System.Drawing.Point(124, 260);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(133, 20);
            this.StockTxt.TabIndex = 30;
            // 
            // ProductoTxt
            // 
            this.ProductoTxt.Location = new System.Drawing.Point(124, 89);
            this.ProductoTxt.Name = "ProductoTxt";
            this.ProductoTxt.Size = new System.Drawing.Size(133, 20);
            this.ProductoTxt.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cantidad:";
            // 
            // CodProductoTxt
            // 
            this.CodProductoTxt.Location = new System.Drawing.Point(124, 41);
            this.CodProductoTxt.Name = "CodProductoTxt";
            this.CodProductoTxt.Size = new System.Drawing.Size(133, 20);
            this.CodProductoTxt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cod. Producto:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.Gray;
            this.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelarBtn.Location = new System.Drawing.Point(279, 406);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 16;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.Color.Gray;
            this.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarBtn.Location = new System.Drawing.Point(31, 406);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 15;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = false;
            // 
            // ListaProductosGb
            // 
            this.ListaProductosGb.Controls.Add(this.EliminarBtn);
            this.ListaProductosGb.Controls.Add(this.ModificarBtn);
            this.ListaProductosGb.Controls.Add(this.AgregarBtn);
            this.ListaProductosGb.Controls.Add(this.ConsultarBtn);
            this.ListaProductosGb.Controls.Add(this.ListaProductosDgv);
            this.ListaProductosGb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ListaProductosGb.Location = new System.Drawing.Point(430, 192);
            this.ListaProductosGb.Name = "ListaProductosGb";
            this.ListaProductosGb.Size = new System.Drawing.Size(753, 417);
            this.ListaProductosGb.TabIndex = 9;
            this.ListaProductosGb.TabStop = false;
            this.ListaProductosGb.Text = "Productos";
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.Gray;
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EliminarBtn.Location = new System.Drawing.Point(298, 378);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.EliminarBtn.TabIndex = 8;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.Color.Gray;
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModificarBtn.Location = new System.Drawing.Point(104, 378);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarBtn.TabIndex = 9;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = false;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.Color.Gray;
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgregarBtn.Location = new System.Drawing.Point(6, 378);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 10;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.BackColor = System.Drawing.Color.Gray;
            this.ConsultarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsultarBtn.Location = new System.Drawing.Point(201, 378);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBtn.TabIndex = 11;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = false;
            // 
            // ListaProductosDgv
            // 
            this.ListaProductosDgv.AllowUserToAddRows = false;
            this.ListaProductosDgv.AllowUserToDeleteRows = false;
            this.ListaProductosDgv.BackgroundColor = System.Drawing.Color.Gray;
            this.ListaProductosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProductosDgv.Location = new System.Drawing.Point(3, 19);
            this.ListaProductosDgv.Name = "ListaProductosDgv";
            this.ListaProductosDgv.ReadOnly = true;
            this.ListaProductosDgv.Size = new System.Drawing.Size(744, 353);
            this.ListaProductosDgv.TabIndex = 0;
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(124, 321);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(133, 20);
            this.PrecioTxt.TabIndex = 34;
            // 
            // AdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1213, 660);
            this.Controls.Add(this.ListaProductosGb);
            this.Controls.Add(this.DatosClientesGb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DatosClientesGb.ResumeLayout(false);
            this.DatosClientesGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNud)).EndInit();
            this.ListaProductosGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox DatosClientesGb;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.NumericUpDown CantidadNud;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox StockTxt;
        private System.Windows.Forms.TextBox ProductoTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodProductoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox ListaProductosGb;
        private System.Windows.Forms.DataGridView ListaProductosDgv;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioTxt;
    }
}