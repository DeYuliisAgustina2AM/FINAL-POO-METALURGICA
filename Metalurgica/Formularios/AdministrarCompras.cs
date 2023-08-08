using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metalurgica
{
    public partial class AdministrarCompras : Form
    {
        public AdministrarCompras()
        {
            InitializeComponent();
            DatosCompraGb.Enabled = false;
            ListaProductosGb.Enabled = false;
           
        }

        static RepositorioDocumento<NotaCompra> repositorioDocumento = new RepositorioDocumento<NotaCompra>();
        NotaCompra notaCompra;
        internal static RepositorioProveedor repositorioProveedor;
        internal static RepositorioProducto repositorioProducto;

        

        private void AdministrarCompras_Load(object sender, EventArgs e)
        {
            if (repositorioProducto != null)
            {
                foreach (Producto producto in repositorioProducto.ListarProductos)
                {
                    ProductosCmb.Items.Add(producto.Codigo);
                }
                ArmarGrillaStock();
                if (repositorioProveedor != null)
                {
                    foreach (Proveedor proveedor in repositorioProveedor.ListarProveedores)
                    {
                        ProveedorCmb.Items.Add(proveedor.Cuit);
                    }
                    CrearCompraBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No tienes proveedores o productos registrados, por favor creelos antes de usar esta función ! ", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CrearCompraBtn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No tienes proveedores o productos registrados, por favor creelos antes de usar esta función ! ", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CrearCompraBtn.Enabled = false;
            }
            ArmarGrillaNotasCompra();
            
        }
        private void ArmarGrillaProductos()
        {
            ListaItemsCompraDgv.DataSource = null;
            ListaItemsCompraDgv.DataSource = notaCompra.ListarItemProductos;
            ListaItemsCompraDgv.ForeColor = Color.Black;
        }
        private void ArmarGrillaNotasCompra()
        {
            ListaNotasCompradgv.DataSource = null;
            ListaNotasCompradgv.DataSource = repositorioDocumento.ListarDocumentos;
            ListaNotasCompradgv.ForeColor = Color.Black;
        }
        private void ArmarGrillaStock()
        {
            StockDgv.DataSource = null;
            StockDgv.Rows.Clear();
            StockDgv.ForeColor = Color.Black;
            foreach (Producto producto in repositorioProducto.ListarProductos)
            {
                StockDgv.Rows.Add(producto.Codigo, producto.Stock);
            }
        }
        private void Limpiar()
        {
            NumeroTxt.Text = "";
            FechaDtp.Value = DateTime.Now;
            ProductosCmb.Text = "";
            ProveedorCmb.Text = ""; 
            CantidadTxt.Text = "";
            ListaItemsCompraDgv.DataSource = null;
            ListaItemsCompraDgv.Rows.Clear();
        }

        private void AgregarItembtn_Click(object sender, EventArgs e)
        {
            if (ValidarExistenciaDatos(CantidadTxt.Text, ProductosCmb.Text) == true)
            {
                if (!int.TryParse(CantidadTxt.Text, out int cantidad))
                {
                    MessageBox.Show("Por favor, ingrese la cantidad de productos correctamente");
                    return;
                }
                if (!int.TryParse(ProductosCmb.Text, out int codProducto))
                {
                    MessageBox.Show("Por favor, ingrese el codigo del producto correctamente");
                    return;
                }
               

                foreach (Producto producto in repositorioProducto.ListarProductos)
                {
                    if (producto.Codigo == codProducto)
                    {
                        int StockTotal = Convert.ToInt32(producto.Stock) + Convert.ToInt32(CantidadTxt.Value); //Creamos una variable que sea la suma del stock previo de ese producto y el stock a agregar 
                        if(StockTotal >= 5)
                        {
                            if (StockTotal <= 20) // verifico que este dentro de los limites establecidos, no puedes tener un stock menor a 5 y mayor a 20
                            {
                                if (notaCompra.AgregarItem(producto, cantidad) == true)
                                {
                                    ArmarGrillaProductos();
                                    Totallbl.Text = "Total a pagar : $ " + notaCompra.Total.ToString();
                                    CantidadTxt.Text = "";
                                    ProductosCmb.Text = "";
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Usted ya cargo ese producto");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usted debe poseer un stock máximo de 20 unidades"); // en caso de que el usuario agregue un stock máximo al estipulado se le informará
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted debe poseer un stock minimo de 5 unidades");// en caso de que el usuario agregue un stock minimo al estipulado se le informará
                            return;
                        }
                        
                    }
                }
            }
        }


        private void CrearCompraBtn_Click(object sender, EventArgs e)
        {
            DatosCompraGb.Enabled = true;
            ListaProductosGb.Enabled = true;
            Totallbl.Text = "Total a pagar : $ ";
            notaCompra = new NotaCompra();
        }

        private void EliminarItembtn_Click(object sender, EventArgs e)
        {
            if (ListaItemsCompraDgv.Rows.Count > 0)
            {
                if (ListaItemsCompraDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un item de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oItem = (Item)ListaItemsCompraDgv.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el Item de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    notaCompra.EliminarItem(oItem);
                    ArmarGrillaProductos();
                    Totallbl.Text = "Total a pagar : $ " + notaCompra.Total.ToString();
                    CantidadTxt.Text = "";
                    ProductosCmb.Text = "";
                    return;
                }
            }
        }

        private void AgregarCompraBtn_Click(object sender, EventArgs e)
        {
            if (ValidarExistenciaDatos(NumeroTxt.Text, ProveedorCmb.Text) == true)
            {
                if (!int.TryParse(NumeroTxt.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingrese el numero de nota de compra correctamente");
                    return;
                }
                if (!DateTime.TryParse(FechaDtp.Text, out DateTime fecha))
                {
                    MessageBox.Show("Por favor, ingrese la fecha correctamente");
                    return;
                }
                notaCompra.Numero = numero;
                notaCompra.Fecha = fecha;
                long cuitProveedor = Convert.ToInt32(ProveedorCmb.Text);
                foreach (Proveedor proveedor in repositorioProveedor.ListarProveedores)
                {
                    if (proveedor.Cuit == cuitProveedor)
                    {
                        notaCompra.Proveedor = proveedor;
                        if (repositorioDocumento.Agregar(notaCompra) == true)
                        {
                            foreach(Item item in notaCompra.ListarItemProductos)
                            {
                                repositorioProducto.IncrementarStock(item.Producto, item.Cantidad);
                            }
                            MessageBox.Show("Nota de compra creada con exito");
                            Limpiar();
                            DatosCompraGb.Enabled = false;
                            ListaProductosGb.Enabled = false;
                            ArmarGrillaStock();
                            ArmarGrillaNotasCompra();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la nota de compra. Compruebe que no haya repetido numero de nota de compra");
                            return;
                        }
                    }
                }
            }
        }

        private void NumeroTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el numero de nota ...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidarExistenciaDatos(string casilla1, string casilla2)
        {
            if (string.IsNullOrWhiteSpace(casilla1))
            {
                MessageBox.Show("Hay casillas en blanco. Por favor complete los datos!.");
                return false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(casilla2))
                {
                    MessageBox.Show("Hay casillas en blanco. Por favor complete los datos!.");
                    return false;
                }
                else return true;
            }

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.Show();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            ProductosCmb.Text = "";
            CantidadTxt.Text = "";
        }
    }
}
