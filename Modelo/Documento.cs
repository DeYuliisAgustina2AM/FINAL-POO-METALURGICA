using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Documento
    {
        
        private List<Item> _itemProductos; // Lista de items
        private int _numero;
        private DateTime _fecha;

        public Documento()
        {
            _itemProductos = new List<Item>();
        }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public ReadOnlyCollection<Item> ListarItemProductos { get => _itemProductos.AsReadOnly(); }
        public decimal Total { get; internal set; }

        public bool AgregarItem(Producto producto, int cantidad) // para agregar item paso un producto y la cantidad de productos que quiero como parametro
        {
            var itemEncontrado = _itemProductos.FirstOrDefault(itemABuscar => itemABuscar.Producto.Codigo == producto.Codigo); //busco en la lista de items si ya existe el producto
            if (itemEncontrado == null)
            {
                var item = new Item() // creo item
                {
                    Producto = producto,
                    Cantidad = cantidad,
                };
                _itemProductos.Add(item); // agrego a la lista de items este nuevo item
                Total += item.Subtotal; // actualizo el total del documento
                return true;
            }
            else return false;
        }
        public bool EliminarItem(Item item)
        {
            var itemEncontrado = _itemProductos.FirstOrDefault(itemABuscar => itemABuscar.Producto.Codigo == item.Producto.Codigo); // busco item en la lista
            if (itemEncontrado != null)
            {
                Total -= item.Subtotal; // actualizo el total del documento
                _itemProductos.Remove(item); // elimino item del documento
                return true;
            }
            else return false;
        }
       
    }
}
