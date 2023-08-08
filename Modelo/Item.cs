using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Item
    {
        private Producto producto;
        private int _cantidad;
        public Item()
        {
        }

        public Producto Producto { get => producto; set => producto = value; }
        public int Cantidad { get => _cantidad; set=> _cantidad = value; }
        
        public decimal Subtotal { get => producto.Precio * _cantidad; }   // solo lectura ya que una vez escritos el producto y la cantidad del item, el subtotal se calculo internamente
    }
}
