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
    public partial class AdministrarProductos : Form
    { 
        static RepositorioProducto repositorioProducto = new RepositorioProducto();
        
        public AdministrarProductos()
        {
            InitializeComponent();
            ModoGrilla();
        }
        private void ModoGrilla()
        {
            ListaProductosGb.Enabled = true;
            DatosProductosGb.Enabled = false;
        }
        private void ArmarGrilla()
        {

            ListaProductosDgv.DataSource = null;
            ListaProductosDgv.DataSource = repositorioProducto.ListarProductos;
        }
        private void ModoDatos()
        {
            ListaProductosGb.Enabled = false;
            DatosProductosGb.Enabled = true;
        }
        private void Clean()
        {
            CodProductoTxt.Text = "";
            DescripcionTxt.Text = "";
            PrecioTxt.Text = "";
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarCompras.repositorioProducto = repositorioProducto; // envio el repositorio de productos a el form de nota de compra para seleccionar producto
            AdministrarVentas.repositorioProducto = repositorioProducto; // lo mismo para ventas
            
            Principal principal = new Principal();
            principal.Show();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Producto oProducto = new Producto();

            string Codigo = CodProductoTxt.Text;
            string Precio = PrecioTxt.Text;
            string Descripcion = DescripcionTxt.Text;

            if (ValidarExistenciaDatos(Codigo, Precio, Descripcion) == true)
            {
                if (!decimal.TryParse(PrecioTxt.Text, out decimal Precio1))
                {
                    MessageBox.Show("Por favor, ingrese el precio correctamente");
                    return;
                }
                if (!int.TryParse(CodProductoTxt.Text, out int Codigo1))
                {
                    MessageBox.Show("Por favor, ingrese el codigo correctamente");
                    return;
                }


                oProducto.Codigo = Convert.ToInt32(Codigo1);
                oProducto.Precio = Convert.ToDecimal(Precio1);
                oProducto.Descripcion = Descripcion;
                
                if (repositorioProducto.Agregar(oProducto) == true)
                {
                    
                    MessageBox.Show("El producto se registró con exito");
                    ArmarGrilla();
                    ModoGrilla();
                    Clean();
                }
                else
                {
                    MessageBox.Show("El producto no se pudo registrar. Compruebe que el codigo no se encuentre repetido, intente nuevamente");
                }

            }
        }
        #region VALIDACIONES
        private bool ValidarExistenciaDatos(string Codigo, string Precio, string Descripcion)
        {
            if (string.IsNullOrWhiteSpace(Codigo))
            {
                MessageBox.Show("La casilla Codigo está en blanco. Por favor complete los datos!.");
                return false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Precio))
                {
                    MessageBox.Show("La casilla Precio está en blanco. Por favor complete los datos!.");
                    return false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Descripcion))
                    {
                        MessageBox.Show("La casilla Descripcion está en blanco. Por favor complete los datos!.");
                        return false;
                    }
                }
            }
            return true;
        }
        private void PrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el precio...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CodProductoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el Codigo del producto...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            ModificarBtn.Enabled = false;
            GuardarBtn.Enabled = true;
            ModoDatos();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Clean();
            ModoGrilla();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (ListaProductosDgv.Rows.Count > 0)
            {
                if (ListaProductosDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un producto de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oProducto = (Producto)ListaProductosDgv.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el producto con codigo n°: " + oProducto.Codigo + " de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (repositorioProducto.Eliminar(oProducto) == true)
                    {
                        MessageBox.Show("Eliminado con exito!");
                    }
                    ArmarGrilla();
                }
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (ListaProductosDgv.Rows.Count > 0)
            {
                if (ListaProductosDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un produto de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var oProducto = (Producto)ListaProductosDgv.CurrentRow.DataBoundItem;
                string Codigo = CodProductoTxt.Text;
                string Precio = PrecioTxt.Text;
                string Descripcion = DescripcionTxt.Text;

                if (ValidarExistenciaDatos(Codigo, Precio, Descripcion) == true)
                {
                    if (!int.TryParse(CodProductoTxt.Text, out int Codigo1))
                    {
                        MessageBox.Show("Por favor, ingrese el Codigo correctamente");
                        return;
                    }
                    if (!decimal.TryParse(PrecioTxt.Text, out decimal Precio1))
                    {
                        MessageBox.Show("Por favor, ingrese el precio correctamente");
                        return;
                    }
                  
                    Producto oProductoModificado = new Producto();
                    oProductoModificado.Codigo = Codigo1;
                    oProductoModificado.Precio = Precio1;
                    oProductoModificado.Descripcion = DescripcionTxt.Text;
                   
                    if (repositorioProducto.Modificar(oProducto, oProductoModificado) == true)
                    {
                        MessageBox.Show("El producto se modificó con exito");
                        GuardarBtn.Enabled = true;
                        ArmarGrilla();
                        ModoGrilla();
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("El producto no se pudo modificar, intente nuevamente");
                    }
                }
            }
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            if (ListaProductosDgv.Rows.Count > 0)
            {
                if (ListaProductosDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un Producto de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oProducto = (Producto)ListaProductosDgv.CurrentRow.DataBoundItem;
                CodProductoTxt.Text = oProducto.Codigo.ToString();
                PrecioTxt.Text = oProducto.Precio.ToString();
                DescripcionTxt.Text = oProducto.Descripcion;
                GuardarBtn.Enabled = false;
                ModificarBtn.Enabled = true;
                ModoDatos();
            }
        }

        private void DatosProductosGb_Enter(object sender, EventArgs e)
        {

        }

        private void AdministrarProductos_Load(object sender, EventArgs e)
        {
            DatosProductosGb.Enabled = false;
            ListaProductosDgv.ForeColor = Color.Black;
            ArmarGrilla();
        }
    }
}
