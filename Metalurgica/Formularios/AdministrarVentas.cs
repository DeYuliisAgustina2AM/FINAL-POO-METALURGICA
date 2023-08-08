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
    public partial class AdministrarVentas : Form
    {
        public AdministrarVentas()
        {
            InitializeComponent();
            DatosVentasGb.Enabled = false;
            ListaProductosGb.Enabled = false;
        }

        static RepositorioDocumento<NotaVenta> repositorioDocumento = new RepositorioDocumento<NotaVenta>();
        NotaVenta notaVenta;
        
        internal static RepositorioCliente repositorioCliente;
        internal static RepositorioProducto repositorioProducto;
        
        private void AdministrarVentas_Load(object sender, EventArgs e)
        {
            if (repositorioCliente != null) // si ya tenemos elementos en el repositorio cliente...
            { 

                foreach (Cliente cliente in repositorioCliente.ListarCliente) // por cada cliente de la lista de clientes en el repositorio
                {
                ClientesCmb.Items.Add(cliente.DniCuit); // agrego el dni del cliente el el combo box
                }
                if (repositorioProducto != null) // hago la misma validacion para productos
                {
                    foreach (Producto producto in repositorioProducto.ListarProductos)
                    {
                        ProductosCmb.Items.Add(producto.Codigo);
                    }
                    ArmarGrillaStock();
                    CrearVentabtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No tienes clientes o productos registrados, por favor creelos antes de usar esta función ! ", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CrearVentabtn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No tienes clientes o productos registrados, por favor creelos antes de usar esta función ! ","Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CrearVentabtn.Enabled = false;
            }
            ArmarGrillaNotasVenta();
        }
        
        private void ArmarGrillaProductos()
        {
           ListaItemsVentaDgv.DataSource = null;
           ListaItemsVentaDgv.DataSource = notaVenta.ListarItemProductos;
           ListaItemsVentaDgv.ForeColor = Color.Black;
        }
        private void ArmarGrillaNotasVenta()
        {
            ListaNotasVentadgv.DataSource = null;
            ListaNotasVentadgv.DataSource = repositorioDocumento.ListarDocumentos;
            ListaNotasVentadgv.ForeColor = Color.Black;
        }
        private void ArmarGrillaStock()
        {
            StockDgv.DataSource = null;
            StockDgv.ForeColor = Color.Black;
            StockDgv.Rows.Clear(); // borro elemtnos de la lista
            foreach (Producto producto in repositorioProducto.ListarProductos)
            {
                StockDgv.Rows.Add(producto.Codigo, producto.Stock); // agrego codigo y cantidad de stock de cada producto
            }
        }
        private void Limpiar()
        {
            NumeroTxt.Text = "";
            ClientesCmb.Text = "";
            ProductosCmb.Text = "";
            CantidadTxt.Text = "";
            ListaItemsVentaDgv.DataSource = null;
            ListaItemsVentaDgv.Rows.Clear();
        }

        private void AgregarItembtn_Click(object sender, EventArgs e) // boton para agregar items
        {
            if(ValidarExistenciaDatos(CantidadTxt.Text, ProductosCmb.Text) == true){ // si esos cuadros de texto no estan vacios...
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
                foreach (Producto producto in repositorioProducto.ListarProductos) // recorro lista de productos
                {
                    if (producto.Codigo == codProducto) // si encuentro un producto con el mismo codigo ingresado....
                    {                 
                        if (repositorioProducto.DecrementarStock(producto, cantidad) == true) // decremento stock en esa cantidad y si la operacion se realiza correctamente devuelve true
                        {
                            if (notaVenta.AgregarItem(producto, cantidad) == true) // paso el producto y cantidad del nuevo item
                            {
                                ArmarGrillaProductos();
                                Totallbl.Text = "Total a pagar : $ " + notaVenta.Total.ToString();
                                CantidadTxt.Text = "";
                                ProductosCmb.Text = "";
                                return;
                            }
                            else // si ya tuvieramos ese producto cargado como item, la funcion de agregar item da false y ....
                            {
                                MessageBox.Show("Usted ya cargo ese producto");
                                return;
                            }
                        }
                        else // si no pudimos decrementar el stock debido a que no hay suficientes productos...
                        {
                            MessageBox.Show("NO HAY STOCK SUFICIENTE de este producto. Seleccione otro producto o realice una nueva compra primero...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CantidadTxt.Text = "";
                            ProductosCmb.Text = "";
                            return;
                        }
                    }
                }
            }
        }

        private void EliminarItembtn_Click(object sender, EventArgs e) // boton para eliminar items
        {
            if (ListaItemsVentaDgv.Rows.Count > 0)
            {
                if (ListaItemsVentaDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un item de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oItem = (Item)ListaItemsVentaDgv.CurrentRow.DataBoundItem; // asigno a mi variable item los datos de la fila seleccionada
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el Item de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    repositorioProducto.IncrementarStock(oItem.Producto, oItem.Cantidad); // sube stock de ese producto en esa cantidad porque ya no lo vamos a vender
                    notaVenta.EliminarItem(oItem); // elimino item de lista de items
                    ArmarGrillaProductos();
                    Totallbl.Text = "Total a pagar : $ " + notaVenta.Total.ToString();
                    CantidadTxt.Text = "";
                    ProductosCmb.Text = "";
                    return;
                }
            }
        }

        private void AgregarVentaBtn_Click(object sender, EventArgs e) // una vez cargados todos los items para finalizar la nota de venta apreto este boton
        {
            if (ValidarExistenciaDatos(NumeroTxt.Text, ClientesCmb.Text) == true)
            {
                if (!int.TryParse(NumeroTxt.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingrese el numero de nota de venta correctamente");
                    return;
                }
                if (!DateTime.TryParse(FechaDtp.Text, out DateTime fecha))
                {
                    MessageBox.Show("Por favor, ingrese la fecha correctamente");
                    return;
                }
                Producto producto = new Producto();
                notaVenta.Numero = numero;
                notaVenta.Fecha = fecha;
                long dniCliente = Convert.ToInt32(ClientesCmb.Text);
                foreach (Cliente cliente in repositorioCliente.ListarCliente) // recorro todos los clientes de la lista de clientes
                {
                    if (cliente.DniCuit == dniCliente) // cuando el dni de uno de los clientes de la lista coincide con el ingresado...
                    {
                        notaVenta.Cliente = cliente; // agrego cliente asociado a esta nota de venta
                        int StockTotal = Convert.ToInt32(producto.Stock) - Convert.ToInt32(CantidadTxt.Value); //Creamos una variable que sea la suma del stock previo de ese producto y el stock a vender 
                        if (StockTotal < 5 || StockTotal == 0)
                        {
                            MessageBox.Show("Alerta, su stock actual es menor al minimo estipulado, por favor compra mas stock para estar dentro del minimo estipulado", "Atencíon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (repositorioDocumento.Agregar(notaVenta) == true) // agrego nota de venta a lista de este tipo de documento
                        {
                            MessageBox.Show("Nota de venta creada con exito");
                            Limpiar();
                            DatosVentasGb.Enabled = false;
                            ListaProductosGb.Enabled = false;
                            ArmarGrillaStock();
                            ArmarGrillaNotasVenta();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la nota de venta. Compruebe que no haya repetido numero de nota de venta");
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


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal principal = new Principal();
            principal.Show();
        }

        private void CrearVentabtn_Click_1(object sender, EventArgs e)
        {
            DatosVentasGb.Enabled = true;
            ListaProductosGb.Enabled = true;
            Totallbl.Text = "Total a pagar : $ ";
            notaVenta = new NotaVenta();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            CantidadTxt.Text = "";
            ProductosCmb.Text = "";
        }
    }
}
