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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.GbListaClientes = new System.Windows.Forms.GroupBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.ListaClientesDgv = new System.Windows.Forms.DataGridView();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.GbDatosClientes = new System.Windows.Forms.GroupBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SituacionCmb = new System.Windows.Forms.ComboBox();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaNacimientoDtp = new System.Windows.Forms.DateTimePicker();
            this.RazonSocialTxt = new System.Windows.Forms.TextBox();
            this.DniCuitTxt = new System.Windows.Forms.TextBox();
            this.NombreApellidoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientesDgv)).BeginInit();
            this.GbDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 138);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(588, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "ADMINISTRAR CLIENTES";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comercialización de Productos Metalúrgicos y Siderúrgicos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Métallon s.r.l";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Gray;
            this.CerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarBtn.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CerrarBtn.Image = global::Metalurgica.Properties.Resources.Boton_Cerrar;
            this.CerrarBtn.Location = new System.Drawing.Point(1263, 3);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(29, 27);
            this.CerrarBtn.TabIndex = 4;
            this.CerrarBtn.UseVisualStyleBackColor = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // GbListaClientes
            // 
            this.GbListaClientes.Controls.Add(this.EliminarBtn);
            this.GbListaClientes.Controls.Add(this.AgregarBtn);
            this.GbListaClientes.Controls.Add(this.ConsultarBtn);
            this.GbListaClientes.Controls.Add(this.ListaClientesDgv);
            this.GbListaClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GbListaClientes.Location = new System.Drawing.Point(435, 149);
            this.GbListaClientes.Name = "GbListaClientes";
            this.GbListaClientes.Size = new System.Drawing.Size(854, 494);
            this.GbListaClientes.TabIndex = 6;
            this.GbListaClientes.TabStop = false;
            this.GbListaClientes.Text = "Clientes";
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.Gray;
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EliminarBtn.Location = new System.Drawing.Point(560, 452);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.EliminarBtn.TabIndex = 7;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.Color.Gray;
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgregarBtn.Location = new System.Drawing.Point(268, 452);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 7;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.BackColor = System.Drawing.Color.Gray;
            this.ConsultarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsultarBtn.Location = new System.Drawing.Point(419, 452);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBtn.TabIndex = 7;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = false;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // ListaClientesDgv
            // 
            this.ListaClientesDgv.AllowUserToAddRows = false;
            this.ListaClientesDgv.AllowUserToDeleteRows = false;
            this.ListaClientesDgv.BackgroundColor = System.Drawing.Color.Gray;
            this.ListaClientesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaClientesDgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.ListaClientesDgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListaClientesDgv.Location = new System.Drawing.Point(4, 19);
            this.ListaClientesDgv.Name = "ListaClientesDgv";
            this.ListaClientesDgv.ReadOnly = true;
            this.ListaClientesDgv.Size = new System.Drawing.Size(846, 427);
            this.ListaClientesDgv.TabIndex = 0;
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.Color.Gray;
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModificarBtn.Location = new System.Drawing.Point(156, 452);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarBtn.TabIndex = 7;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // GbDatosClientes
            // 
            this.GbDatosClientes.Controls.Add(this.EmailTxt);
            this.GbDatosClientes.Controls.Add(this.ModificarBtn);
            this.GbDatosClientes.Controls.Add(this.label10);
            this.GbDatosClientes.Controls.Add(this.CancelarBtn);
            this.GbDatosClientes.Controls.Add(this.GuardarBtn);
            this.GbDatosClientes.Controls.Add(this.label9);
            this.GbDatosClientes.Controls.Add(this.SituacionCmb);
            this.GbDatosClientes.Controls.Add(this.TelefonoTxt);
            this.GbDatosClientes.Controls.Add(this.label8);
            this.GbDatosClientes.Controls.Add(this.DireccionTxt);
            this.GbDatosClientes.Controls.Add(this.label7);
            this.GbDatosClientes.Controls.Add(this.FechaNacimientoDtp);
            this.GbDatosClientes.Controls.Add(this.RazonSocialTxt);
            this.GbDatosClientes.Controls.Add(this.DniCuitTxt);
            this.GbDatosClientes.Controls.Add(this.NombreApellidoTxt);
            this.GbDatosClientes.Controls.Add(this.label6);
            this.GbDatosClientes.Controls.Add(this.label5);
            this.GbDatosClientes.Controls.Add(this.label4);
            this.GbDatosClientes.Controls.Add(this.label3);
            this.GbDatosClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GbDatosClientes.Location = new System.Drawing.Point(12, 149);
            this.GbDatosClientes.Name = "GbDatosClientes";
            this.GbDatosClientes.Size = new System.Drawing.Size(403, 494);
            this.GbDatosClientes.TabIndex = 7;
            this.GbDatosClientes.TabStop = false;
            this.GbDatosClientes.Text = "Datos Clientes";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(134, 327);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(173, 20);
            this.EmailTxt.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "E - mail:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.Gray;
            this.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelarBtn.Location = new System.Drawing.Point(285, 452);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 16;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.Color.Gray;
            this.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarBtn.Location = new System.Drawing.Point(37, 452);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 15;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = false;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Situación:";
            // 
            // SituacionCmb
            // 
            this.SituacionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SituacionCmb.FormattingEnabled = true;
            this.SituacionCmb.Items.AddRange(new object[] {
            "Seleccione...",
            "Mayorista",
            "Minorista"});
            this.SituacionCmb.Location = new System.Drawing.Point(134, 375);
            this.SituacionCmb.Name = "SituacionCmb";
            this.SituacionCmb.Size = new System.Drawing.Size(173, 21);
            this.SituacionCmb.TabIndex = 13;
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(134, 278);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(173, 20);
            this.TelefonoTxt.TabIndex = 12;
            this.TelefonoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTxt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Teléfono:";
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(134, 227);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.Size = new System.Drawing.Size(173, 20);
            this.DireccionTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dirección:";
            // 
            // FechaNacimientoDtp
            // 
            this.FechaNacimientoDtp.Location = new System.Drawing.Point(134, 175);
            this.FechaNacimientoDtp.Name = "FechaNacimientoDtp";
            this.FechaNacimientoDtp.Size = new System.Drawing.Size(173, 20);
            this.FechaNacimientoDtp.TabIndex = 8;
            // 
            // RazonSocialTxt
            // 
            this.RazonSocialTxt.Location = new System.Drawing.Point(134, 123);
            this.RazonSocialTxt.Name = "RazonSocialTxt";
            this.RazonSocialTxt.Size = new System.Drawing.Size(173, 20);
            this.RazonSocialTxt.TabIndex = 7;
            // 
            // DniCuitTxt
            // 
            this.DniCuitTxt.Location = new System.Drawing.Point(134, 74);
            this.DniCuitTxt.Name = "DniCuitTxt";
            this.DniCuitTxt.Size = new System.Drawing.Size(173, 20);
            this.DniCuitTxt.TabIndex = 5;
            this.DniCuitTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniCuitTxt_KeyPress);
            // 
            // NombreApellidoTxt
            // 
            this.NombreApellidoTxt.Location = new System.Drawing.Point(134, 29);
            this.NombreApellidoTxt.Name = "NombreApellidoTxt";
            this.NombreApellidoTxt.Size = new System.Drawing.Size(173, 20);
            this.NombreApellidoTxt.TabIndex = 4;
            this.NombreApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreApellidoTxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Razón Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DNI / CUIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre y Apellido:";
            // 
            // AdministrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1297, 660);
            this.Controls.Add(this.GbDatosClientes);
            this.Controls.Add(this.GbListaClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdministrarClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientesDgv)).EndInit();
            this.GbDatosClientes.ResumeLayout(false);
            this.GbDatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbListaClientes;
        private System.Windows.Forms.DataGridView ListaClientesDgv;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.GroupBox GbDatosClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDtp;
        private System.Windows.Forms.TextBox RazonSocialTxt;
        private System.Windows.Forms.TextBox DniCuitTxt;
        private System.Windows.Forms.TextBox NombreApellidoTxt;
        private System.Windows.Forms.ComboBox SituacionCmb;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}