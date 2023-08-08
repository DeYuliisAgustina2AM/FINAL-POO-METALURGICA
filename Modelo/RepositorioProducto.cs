using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProducto
    {
        private List<Producto> _listaProductos; // lista de productos

        public RepositorioProducto()
        {
            _listaProductos = new List<Producto>();
            
        }
        public ReadOnlyCollection<Producto> ListarProductos { get => _listaProductos.AsReadOnly(); }
        
        public bool Agregar(Producto producto) //funcion para agregar producto a lista de productos
        {
            var productoEncontrado = _listaProductos.FirstOrDefault(x => x.Codigo == producto.Codigo); // busco si el producto ya existe en la lista de productos
            if (productoEncontrado == null) // si no existe...
            {
                producto.Stock = 0;
                _listaProductos.Add(producto); // agrego producto a la lista
                return true;
            }
            else return false;
        }

        public bool Eliminar(Producto producto)
        {
            var productoEncontrado = _listaProductos.FirstOrDefault(x => x.Codigo == producto.Codigo);
            if (productoEncontrado != null)
            {
                _listaProductos.Remove(producto); // elimino producto de la lista
                return true;
            }
            return false;
        }

        public bool Modificar(Producto producto, Producto productoModificado) // paso como parametro producto ya existente y producto modificado
        {
            var productoEncontrado = _listaProductos.FirstOrDefault(x => x.Codigo == producto.Codigo); // busco al producto en la lista
            if (productoEncontrado != null)
            {
                _listaProductos.Remove(producto); // elimino ese producto de la lista
                productoModificado.Stock = 0; // establezco en cero el stock del producto modificado
                _listaProductos.Add(productoModificado);  // agrego el producto modificado a la lista
                return true;
            }
            return false;
        }
        public bool IncrementarStock(Producto producto, int cantidad) // paso el producto y en cuantas unidades quiero incrementar el stock
        {
            var productoEncontrado = _listaProductos.FirstOrDefault(x => x.Codigo == producto.Codigo);
            
            if (productoEncontrado != null)
            {
                producto.Stock += cantidad; // le incremento el stock
                return true;
            }
            else return false;
        }
        public bool DecrementarStock(Producto producto, int cantidad) // paso el producto y en cuantas unidades quiero disminuir el stock
        {
            var productoEncontrado = _listaProductos.FirstOrDefault(x => x.Codigo == producto.Codigo);
            if (productoEncontrado != null)
            {
                if(producto.Stock >= cantidad) // si hay suficiente stock en el producto...
                {
                    producto.Stock -= cantidad; // actualizo el stock
                    return true;
                } else
                {
                    return false; // sino no realizo ninguna operacion y retorno falso
                }
            }
            else return false;
        }

    }
}
