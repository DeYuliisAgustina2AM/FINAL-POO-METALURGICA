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
    public partial class AdministrarProveedores : Form
    {
        static RepositorioProveedor repositorioProveedor = new RepositorioProveedor();

        public AdministrarProveedores()
        {
            InitializeComponent();
            ModoGrilla();
        }

        private void AdministrarProveedores_Load(object sender, EventArgs e)
        {
            ListaProveedoresDgv.ForeColor = Color.Black;
            DatosProveedoresGb.Enabled = false;
            ArmarGrilla();
        }
        
        // metodos
        private void ModoGrilla() // habilito los group con DGV
        {
            DatosProveedoresGb.Enabled = false;
            ListaProveedoresGb.Enabled = true;
        }
        private void ModoDatos()
        {
            DatosProveedoresGb.Enabled = true;
            ListaProveedoresGb.Enabled = false;
        }
        private void ArmarGrilla()
        {
            ListaProveedoresDgv.DataSource = null;
            ListaProveedoresDgv.DataSource = repositorioProveedor.ListarProveedores;
        }
        private void Limpiar()
        {
            NombreTxt.Text = CuitTxt.Text = RazonSocialTxt.Text = TelefonoTxt.Text = "";
            DireccionTxt.Text = "";
            EmailTxt.Text = "";
        }
        

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            string nombre = NombreTxt.Text;
            string cuit = CuitTxt.Text;
            string razonSocial = RazonSocialTxt.Text;
            string direccion = DireccionTxt.Text;
            string telefono = TelefonoTxt.Text;
            string email = EmailTxt.Text;
      
            if (ValidarExistenciaDatos(nombre, cuit, razonSocial, direccion, telefono, email) == true) {
                if (!long.TryParse(CuitTxt.Text, out long cuit1))
                {
                    MessageBox.Show("Por favor, ingrese el CUIT correctamente");
                    return;
                }
                if (!long.TryParse(TelefonoTxt.Text, out long telefono1))
                {
                    MessageBox.Show("Por favor, ingrese el telefono correctamente");
                    return;
                }
                var oProveedor = new Proveedor(nombre, cuit1, razonSocial, direccion, telefono1, email);
                if (repositorioProveedor.Agregar(oProveedor) == true)
                {
                    MessageBox.Show("El proveedor se registró con exito");
                    ArmarGrilla();
                    ModoGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El proveedor no se pudo registrar. Compruebe que el cuit no se encuentre repetido, intente nuevamente");
                }
            };
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            ModificarBtn.Enabled = false;
            ModoDatos();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Limpiar();
            ModoGrilla();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (ListaProveedoresDgv.Rows.Count > 0)
            {
                if (ListaProveedoresDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un proveedor de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var oProveedor = (Proveedor)ListaProveedoresDgv.CurrentRow.DataBoundItem;
                string nombre = NombreTxt.Text;
                string cuit = CuitTxt.Text;
                string razonSocial = RazonSocialTxt.Text;
                string direccion = DireccionTxt.Text;
                string telefono = TelefonoTxt.Text;
                string email = EmailTxt.Text;

                if (ValidarExistenciaDatos(nombre, cuit, razonSocial, direccion, telefono, email) == true)
                {
                    if (!long.TryParse(CuitTxt.Text, out long cuit1))
                    {
                        MessageBox.Show("Por favor, ingrese el CUIT correctamente");
                        return;
                    }
                    if (!long.TryParse(TelefonoTxt.Text, out long telefono1))
                    {
                        MessageBox.Show("Por favor, ingrese el telefono correctamente");
                        return;
                    }
                    Proveedor oProveedorModificado = new Proveedor(nombre, cuit1, razonSocial, direccion, telefono1, email);
                    if (repositorioProveedor.Modificar(oProveedor, oProveedorModificado) == true)
                    {
                        MessageBox.Show("El proveedor se modificó con exito");
                        GuardarBtn.Enabled = true;
                        ArmarGrilla();
                        ModoGrilla();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El proveedor no se pudo modificar, intente nuevamente");
                    }
                };
            }

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (ListaProveedoresDgv.Rows.Count > 0)
            {
                if (ListaProveedoresDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un proveedor de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oProveedor = (Proveedor)ListaProveedoresDgv.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el proveedor con CUIT n°: " + oProveedor.Cuit + " de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (repositorioProveedor.Eliminar(oProveedor) == true) {
                        MessageBox.Show("Eliminado con exito!");
                    };
                    ArmarGrilla();
                    
                }
            }
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            if (ListaProveedoresDgv.Rows.Count > 0)
            {
                if (ListaProveedoresDgv.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a un proveedor de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oProveedor = (Proveedor)ListaProveedoresDgv.CurrentRow.DataBoundItem;
                NombreTxt.Text = oProveedor.Nombre;
                CuitTxt.Text = oProveedor.Cuit.ToString();
                RazonSocialTxt.Text = oProveedor.RazonSocial;
                DireccionTxt.Text = oProveedor.Direccion;
                TelefonoTxt.Text = oProveedor.Telefono.ToString();
                EmailTxt.Text = oProveedor.Email;
                GuardarBtn.Enabled = false;
                ModificarBtn.Enabled = true;
                ModoDatos();
            }
        }

        private void ListaProveedoresDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaProveedoresDgv.Rows.Count > 0)
            { 
                var persona = (Proveedor)ListaProveedoresDgv.CurrentRow.DataBoundItem;

            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrarCompras.repositorioProveedor = repositorioProveedor;
            Principal principal = new Principal();
            principal.Show();
        }

        #region VALIDACIONES
        private bool ValidarExistenciaDatos(string nombre, string cuit, string razonSocial, string direccion, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("La casilla Nombre está en blanco. Por favor complete los datos!.");
                return false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(cuit))
                {
                    MessageBox.Show("La casilla cuit está en blanco. Por favor complete los datos!.");
                    return false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(razonSocial))
                    {
                        MessageBox.Show("La casilla Razón Social está en blanco. Por favor complete los datos!.");
                        return false;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(direccion))
                        {
                            MessageBox.Show("La casilla Dirección está en blanco. Por favor complete los datos!.");
                            return false;
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(telefono))
                            {
                                MessageBox.Show("La casilla Teléfono está en blanco. Por favor complete los datos!.");
                                return false;
                            }
                            else
                            {
                                if (string.IsNullOrWhiteSpace(email))
                                {
                                    MessageBox.Show("La casilla Telefono está en blanco. Por favor complete los datos!.");
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        
        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar números en el nombre...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CuitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el CUIT...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TelefonoTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el telefono...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
