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
    public partial class AdministrarClientes : Form
    {
        static RepositorioCliente repositorioCliente = new RepositorioCliente();
        
        public AdministrarClientes()
        {
            InitializeComponent();
            ModoGrilla();
        }
        
        private void ModoGrilla() // deshabilito group de datos y habilito el de grilla
        {
            GbDatosClientes.Enabled = false;
            GbListaClientes.Enabled = true;
        }
        private void ArmarGrilla()
        {
  
            ListaClientesDgv.DataSource = null;
            ListaClientesDgv.DataSource = repositorioCliente.ListarCliente; // uno la grilla de clientes con la lista de clientes del repositorio
        }
        private void ModoDatos() // deshabilito group de datos y deshabilito el de grilla
        {
            GbListaClientes.Enabled = false;
            GbDatosClientes.Enabled = true;
        }
        private void Clean()
        {
            NombreApellidoTxt.Text = "";
            DniCuitTxt.Text = "";
            RazonSocialTxt.Text = "";
            FechaNacimientoDtp.Text = "";
            DireccionTxt.Text = "";
            TelefonoTxt.Text = "";
            EmailTxt.Text = "";
        }
        public Cliente.Situacion Situacion()
        {
            if (SituacionCmb.SelectedIndex == 1)
            {
                return Cliente.Situacion.Mayorista;
            }
            else
            {
                return Cliente.Situacion.Minorista;
            }
        }
        private void GuardarBtn_Click(object sender, EventArgs e) 
        {
            Cliente oCliente = new Cliente(); // creo objeto cliente

            string nombre = NombreApellidoTxt.Text;
            string cuit = DniCuitTxt.Text;
            string razonSocial = RazonSocialTxt.Text;
            string fecha = FechaNacimientoDtp.Text;
            string direccion = DireccionTxt.Text;
            string telefono = TelefonoTxt.Text;
            string email = EmailTxt.Text;
            string situacion = SituacionCmb.Text;

            if (ValidarExistenciaDatos(nombre, cuit, razonSocial, fecha, direccion, telefono, email, situacion) == true) // valido que no hayan cajas de texto en blanco
            {
                if (!long.TryParse(DniCuitTxt.Text, out long DniCuit)) 
                {
                    MessageBox.Show("Por favor, ingrese el CUIT o DNI correctamente");
                    return;
                }
                if (!long.TryParse(TelefonoTxt.Text, out long telefono1)) 
                {
                    MessageBox.Show("Por favor, ingrese el telefono correctamente");
                    return;
                }
                if (!DateTime.TryParse(FechaNacimientoDtp.Text, out DateTime fechanacimiento))
                {
                    MessageBox.Show("Por favor, ingrese la fecha de nacimiento correctamente");
                    return;
                }
                //asigno valores a las propiedades del objeto cliente
                oCliente.NombreyApellido = NombreApellidoTxt.Text;
                oCliente.DniCuit = Convert.ToInt64(DniCuitTxt.Text);
                oCliente.RazonSocial = RazonSocialTxt.Text;
                oCliente.FechaNacimiento = fechanacimiento;
                oCliente.Direccion = DireccionTxt.Text;
                oCliente.Telefono = telefono1;
                oCliente.Email = EmailTxt.Text;
                oCliente.situacion = Situacion();

                if (repositorioCliente.Agregar(oCliente) == true) // si el cliente se agrego correctamente retorna true 
                {
                    MessageBox.Show("El cliente se registró con exito");
                    ArmarGrilla();
                    ModoGrilla();
                    Clean();
                }
                else
                {
                    MessageBox.Show("El cliente no se pudo registrar. Compruebe que el dni o cuit no se encuentre repetido, intente nuevamente"); // si el cliente ya existia con ese dni, entonces no se agregara a la lista y retornara false, devolviendo ese mensaje
                }

            }

        }

        private void AdministrarClientes_Load(object sender, EventArgs e)
        {
            ListaClientesDgv.ForeColor = Color.Black; 
            GbDatosClientes.Enabled = false;
            SituacionCmb.SelectedIndex = 0;
            ArmarGrilla();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            ModificarBtn.Enabled = false;
            ModoDatos();
            AgregarBtn.Enabled = true;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Clean();
            ModoGrilla();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {

            if (ListaClientesDgv.Rows.Count > 0)
            {
                if (ListaClientesDgv.CurrentRow == null) // si no hay ninguna fila seleccionada ....
                {
                    MessageBox.Show("Debe seleccionar a un cliente de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oCliente = (Cliente)ListaClientesDgv.CurrentRow.DataBoundItem; // asigno al objeto cliente los datos de la fila actual seleccionada
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el cliente con CUIT o DNI n°: " + oCliente.DniCuit + " de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (repositorioCliente.Eliminar(oCliente) == true) // si se elimino correctamente el cliente, retorna true
                    {
                        MessageBox.Show("Eliminado con exito!");
                    };
                    ArmarGrilla();

                }
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {

            if (ListaClientesDgv.Rows.Count > 0) 
            {
                if (ListaClientesDgv.CurrentRow == null) // si no hay ninguna fila seleccionada ....
                {
                    MessageBox.Show("Debe seleccionar a un cliente de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var oCliente = (Cliente)ListaClientesDgv.CurrentRow.DataBoundItem; // asigno al objeto cliente los datos de la fila actual seleccionada
                string nombre = NombreApellidoTxt.Text;
                string cuit = DniCuitTxt.Text;
                string razonSocial = RazonSocialTxt.Text;
                string fecha = FechaNacimientoDtp.Text;
                string direccion = DireccionTxt.Text;
                string telefono = TelefonoTxt.Text;
                string email = EmailTxt.Text;
                string situacion = SituacionCmb.Text;

                if (ValidarExistenciaDatos(nombre, cuit, razonSocial, fecha, direccion, telefono, email, situacion) == true) // valido que no hayan cajas de texto en blanco
                {
                    if (!long.TryParse(DniCuitTxt.Text, out long dnicuit))
                    {
                        MessageBox.Show("Por favor, ingrese el CUIT o DNI correctamente");
                        return;
                    }
                    if (!long.TryParse(TelefonoTxt.Text, out long telefono1))
                    {
                        MessageBox.Show("Por favor, ingrese el telefono correctamente");
                        return;
                    }
                    if (!DateTime.TryParse(FechaNacimientoDtp.Text, out DateTime fechanacimiento))
                    {
                        MessageBox.Show("Por favor, ingrese la fecha de nacimiento correctamente");
                        return;
                    }
                    // creo un nuevo objeto cliente y le asigno los nuevos valores
                    Cliente oClienteModificado = new Cliente();
                    oClienteModificado.NombreyApellido = NombreApellidoTxt.Text;
                    oClienteModificado.DniCuit = dnicuit;
                    oClienteModificado.RazonSocial = RazonSocialTxt.Text;
                    oClienteModificado.FechaNacimiento = fechanacimiento;
                    oClienteModificado.Direccion = DireccionTxt.Text;
                    oClienteModificado.Telefono = telefono1;
                    oClienteModificado.Email = EmailTxt.Text;
                    oClienteModificado.situacion = Situacion();
                    if (repositorioCliente.Modificar(oCliente, oClienteModificado) == true) // paso el objeto cliente actual del datagrid y el objeto cliente modificado
                    {
                        MessageBox.Show("El cliente se modificó con exito");
                        GuardarBtn.Enabled = true;
                        ArmarGrilla();
                        ModoGrilla();
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no se pudo modificar, intente nuevamente");
                    }
                };
            }
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {

            if (ListaClientesDgv.Rows.Count > 0)
            {
                if (ListaClientesDgv.CurrentRow == null) // si no hay ninguna fila seleccionada ....
                {
                    MessageBox.Show("Debe seleccionar a un cliente de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var oCliente = (Cliente)ListaClientesDgv.CurrentRow.DataBoundItem; // asigno al objeto cliente los datos de la fila actual seleccionada 
                NombreApellidoTxt.Text = oCliente.NombreyApellido; //asigno a cada caja de texto su correspondiente valor de cada propiedad del cliente
                DniCuitTxt.Text = oCliente.DniCuit.ToString();
                RazonSocialTxt.Text = oCliente.RazonSocial;
                FechaNacimientoDtp.Text = oCliente.FechaNacimiento.ToString();
                DireccionTxt.Text = oCliente.Direccion;
                TelefonoTxt.Text = oCliente.Telefono.ToString();
                EmailTxt.Text = oCliente.Email;
                SituacionCmb.Text = oCliente.situacion.ToString();
                GuardarBtn.Enabled = false;
                ModificarBtn.Enabled = true;
                ModoDatos();
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrarVentas.repositorioCliente = repositorioCliente; // al repositorio cliente declarado en el form administrar venta, le asigno el repositorio del acutal form
            Principal principal = new Principal();
            principal.Show();
            
        }
        #region VALIDACIONES
        private bool ValidarExistenciaDatos(string Nombre, string Cuit, string RazonSocial, string FechaNacimiento, string Direccion, string Telefono, string Email, string Situacion) // valido que las cadenas pasadas no sean nulas
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                MessageBox.Show("La casilla Nombre está en blanco. Por favor complete los datos!.");
                return false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Cuit))
                {
                    MessageBox.Show("La casilla cuit está en blanco. Por favor complete los datos!.");
                    return false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(RazonSocial))
                    {
                        MessageBox.Show("La casilla Razón Social está en blanco. Por favor complete los datos!.");
                        return false;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(FechaNacimiento))
                        {
                            MessageBox.Show("La casilla Fecha está en blanco. Por favor complete los datos!.");
                            return false;
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(Direccion))
                            {
                                MessageBox.Show("La casilla Dirección está en blanco. Por favor complete los datos!.");
                                return false;
                            }
                            else
                            {
                                if (string.IsNullOrWhiteSpace(Telefono))
                                {
                                    MessageBox.Show("La casilla Telefono está en blanco. Por favor complete los datos!.");
                                    return false;
                                }
                                else
                                {
                                    if (string.IsNullOrWhiteSpace(Email))
                                    {
                                        MessageBox.Show("La casilla Nombre está en blanco. Por favor complete los datos!.");
                                        return false;
                                    }
                                    else
                                    {
                                        if (Situacion == "Seleccione...") 
                                        {
                                            MessageBox.Show("Por Favor seleccione un tipo de sitacion!.");
                                            return false;
                                        }
                                        else
                                        {
                                            if (CalculoEdad() < 18)
                                            {
                                                MessageBox.Show("La persona es menor de 18 años...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        private void NombreApellidoTxt_KeyPress(object sender, KeyPressEventArgs e) // No permite escribir numeros en esta casilla
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar números en el nombre...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DniCuitTxt_KeyPress(object sender, KeyPressEventArgs e) // No permite escribir letras en esta casilla
        {
            if (char.IsLetter(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el DNI/CUIT...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TelefonoTxt_KeyPress(object sender, KeyPressEventArgs e) // No permite escribir letras en esta casilla
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar letras en el telefono...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int CalculoEdad() 
        {
            int edad = DateTime.Now.Year - FechaNacimientoDtp.Value.Year;
            if (DateTime.Now.Month < FechaNacimientoDtp.Value.Month)
            {
                edad -= 1;
            }
            if (DateTime.Now.Month == FechaNacimientoDtp.Value.Month && DateTime.Now.Day < FechaNacimientoDtp.Value.Day)
            {
                edad -= 1;
            }
            return edad;
        }
        #endregion
    }
}