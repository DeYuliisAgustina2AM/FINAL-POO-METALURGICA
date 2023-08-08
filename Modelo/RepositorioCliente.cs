using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCliente
    {
        private List<Cliente> _listaCliente; // lista de clientes

        public RepositorioCliente()
        {
            _listaCliente = new List<Cliente>();
        }
        public ReadOnlyCollection<Cliente> ListarCliente { get => _listaCliente.AsReadOnly(); }
        
       
            
        public bool Agregar(Cliente cliente) //funcion para agregar cliente a lista de clientes
        {
            var ClienteEncontrado = _listaCliente.FirstOrDefault(x => x.DniCuit == cliente.DniCuit); // busco si el cliente ya existe en la lista de clientes
            if (ClienteEncontrado == null)   // si no existe...
            {
                _listaCliente.Add(cliente); // agrgeo cliente a la lista
                return true;
            }
            else return false;
        }

        public bool Eliminar(Cliente cliente) 
        {
            var clienteEncontrado = _listaCliente.FirstOrDefault(x => x.DniCuit == cliente.DniCuit);
            if (clienteEncontrado != null)
            {
                _listaCliente.Remove(cliente); // elimino cliente de la lista
                return true;
            }
            return false;
        }

        public bool Modificar(Cliente cliente, Cliente clienteModificado) // paso como parametro cliente ya existente y cliente modificado
        {
            var clienteEncontrado = _listaCliente.FirstOrDefault(x => x.DniCuit == cliente.DniCuit); // busco al cliente en la lista
            if (clienteEncontrado != null)
            {
                _listaCliente.Remove(cliente); // elimino ese cliente de la lista
                _listaCliente.Add(clienteModificado); // agrego el cliente modificado a la lista
                return true;
            }
            return false;
        }
    }
}
