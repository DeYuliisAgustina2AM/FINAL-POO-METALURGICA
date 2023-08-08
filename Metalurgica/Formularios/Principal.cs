using Metalurgica.Formularios;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metalurgica
{
    public partial class Principal : Form
    {
        Form AdministrarClientes = new AdministrarClientes();
        Form AdministrarVentas = new AdministrarVentas();
        Form AdministrarProveedores = new AdministrarProveedores();
        Form AdministrarProductos = new AdministrarProductos();
        Form AdministrarCompras = new AdministrarCompras();
        int AccionBtnProductos = 0;

        public Principal()
        {
            InitializeComponent();
            ProductosPnl.Visible = false;
        }
        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarClientes.Show();
        }

        private void VentasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarVentas.Show();
        }

        private void ProveedoresBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarProveedores.Show();
        }

        private void ProductosBtn_Click(object sender, EventArgs e)
        {
            if (AccionBtnProductos == 0)
            {
                ProductosPnl.Visible = true;
                AccionBtnProductos = 1;
            }
            else
            {
                if (AccionBtnProductos == 1)
                {
                    ProductosPnl.Visible = false;
                    AccionBtnProductos = 0;
                }
            }
            

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
           
        }

        private void CrearProductosBtn_Click(object sender, EventArgs e)
        {
            ProductosPnl.Visible = false;
            this.Hide();
            AdministrarProductos.Show();
        }

        private void ComprasBtn_Click(object sender, EventArgs e)
        {
            ProductosPnl.Visible = false;
            this.Hide();
            AdministrarCompras.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion();
            informacion.Show();
            this.Hide();
        }
    }
}
