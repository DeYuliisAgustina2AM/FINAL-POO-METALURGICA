using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProveedor
    {
        private List<Proveedor> _listaProveedores; // lista de proveedores


        public RepositorioProveedor()
        {
            _listaProveedores = new List<Proveedor>();
        }
        public ReadOnlyCollection<Proveedor> ListarProveedores { get => _listaProveedores.AsReadOnly(); }


        public bool Agregar(Proveedor proveedor) //funcion para agregar proveedor a lista de proveedores
        {
            var proveedorEncontrado = _listaProveedores.FirstOrDefault(x => x.Cuit == proveedor.Cuit); // busco si el proveedor ya existe en la lista de proveedores
            if (proveedorEncontrado == null) // si no existe...
            {
                _listaProveedores.Add(proveedor); // agrgeo proveedor a la lista
                return true;
            }
            else return false;
        }

        public bool Eliminar(Proveedor proveedor)
        {
            var proveedorEncontrado = _listaProveedores.FirstOrDefault(x => x.Cuit == proveedor.Cuit); 
            if (proveedorEncontrado != null)
            { 
                _listaProveedores.Remove(proveedor); // elimino proveedor de la lista
                return true;
            }
            return false;
        }

        public bool Modificar(Proveedor proveedor, Proveedor proveedorModificado) // paso como parametro proveedor ya existente y proveedor modificado
        {
            var proveedorEncontrado = _listaProveedores.FirstOrDefault(x => x.Cuit == proveedor.Cuit); // busco al proveedor en la lista
            if (proveedorEncontrado != null)
            {
                _listaProveedores.Remove(proveedor); // elimino ese proveedor de la lista
                _listaProveedores.Add(proveedorModificado);  // agrego el proveedor modificado a la lista
                return true;
            }
            return false;
        }
    }
}
