namespace Metalurgica
{
    partial class AdministrarClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GbListaClientes = new System.Windows.Forms.GroupBox();
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GbDatosClientes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.CmbSituacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.GbDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 138);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Métallon s.r.l";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comercialización de Productos Metalúrgicos y Siderúrgicos";
            // 
            // GbListaClientes
            // 
            this.GbListaClientes.Controls.Add(this.BtnEliminar);
            this.GbListaClientes.Controls.Add(this.BtnModificar);
            this.GbListaClientes.Controls.Add(this.BtnAgregar);
            this.GbListaClientes.Controls.Add(this.BtnConsultar);
            this.GbListaClientes.Controls.Add(this.DgvListaClientes);
            this.GbListaClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GbListaClientes.Location = new System.Drawing.Point(12, 149);
            this.GbListaClientes.Name = "GbListaClientes";
            this.GbListaClientes.Size = new System.Drawing.Size(753, 494);
            this.GbListaClientes.TabIndex = 6;
            this.GbListaClientes.TabStop = false;
            this.GbListaClientes.Text = "Clientes";
            // 
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.BackgroundColor = System.Drawing.Color.Gray;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Location = new System.Drawing.Point(6, 19);
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.Size = new System.Drawing.Size(744, 427);
            this.DgvListaClientes.TabIndex = 0;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.Gray;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConsultar.Location = new System.Drawing.Point(380, 452);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Gray;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAgregar.Location = new System.Drawing.Point(185, 452);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Gray;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnModificar.Location = new System.Drawing.Point(283, 452);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Gray;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Location = new System.Drawing.Point(477, 452);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // GbDatosClientes
            // 
            this.GbDatosClientes.Controls.Add(this.BtnCancelar);
            this.GbDatosClientes.Controls.Add(this.BtnGuardar);
            this.GbDatosClientes.Controls.Add(this.label9);
            this.GbDatosClientes.Controls.Add(this.CmbSituacion);
            this.GbDatosClientes.Controls.Add(this.TxtTelefono);
            this.GbDatosClientes.Controls.Add(this.label8);
            this.GbDatosClientes.Controls.Add(this.TxtDireccion);
            this.GbDatosClientes.Controls.Add(this.label7);
            this.GbDatosClientes.Controls.Add(this.dateTimePicker1);
            this.GbDatosClientes.Controls.Add(this.TxtDni);
            this.GbDatosClientes.Controls.Add(this.TxtApellido);
            this.GbDatosClientes.Controls.Add(this.TxtNombre);
            this.GbDatosClientes.Controls.Add(this.label6);
            this.GbDatosClientes.Controls.Add(this.label5);
            this.GbDatosClientes.Controls.Add(this.label4);
            this.GbDatosClientes.Controls.Add(this.label3);
            this.GbDatosClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GbDatosClientes.Location = new System.Drawing.Point(786, 149);
            this.GbDatosClientes.Name = "GbDatosClientes";
            this.GbDatosClientes.Size = new System.Drawing.Size(403, 494);
            this.GbDatosClientes.TabIndex = 7;
            this.GbDatosClientes.TabStop = false;
            this.GbDatosClientes.Text = "Datos Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DNI:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(129, 29);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(154, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(129, 82);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(154, 20);
            this.TxtApellido.TabIndex = 5;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(129, 137);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(154, 20);
            this.TxtDni.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(129, 250);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(154, 20);
            this.TxtDireccion.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Teléfono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(129, 314);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(154, 20);
            this.TxtTelefono.TabIndex = 12;
            // 
            // CmbSituacion
            // 
            this.CmbSituacion.FormattingEnabled = true;
            this.CmbSituacion.Items.AddRange(new object[] {
            "Seleccione...",
            "Mayorista",
            "Minorista"});
            this.CmbSituacion.Location = new System.Drawing.Point(129, 375);
            this.CmbSituacion.Name = "CmbSituacion";
            this.CmbSituacion.Size = new System.Drawing.Size(154, 21);
            this.CmbSituacion.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Situación:";
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
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCerrar.Image = global::Metalurgica.Properties.Resources.Boton_Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1181, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 27);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Gray;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGuardar.Location = new System.Drawing.Point(40, 452);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Gray;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancelar.Location = new System.Drawing.Point(288, 452);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // AdministrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1217, 680);
            this.Controls.Add(this.GbDatosClientes);
            this.Controls.Add(this.GbListaClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarClientes";
            this.Text = "AdministrarClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
            this.GbDatosClientes.ResumeLayout(false);
            this.GbDatosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbListaClientes;
        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.GroupBox GbDatosClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CmbSituacion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}