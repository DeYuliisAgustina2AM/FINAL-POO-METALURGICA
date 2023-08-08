using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int _codigo;
        private decimal _precio;
        private string _descripcion;
        private int _stock;
        public Producto(int codigo, decimal precio, string descripcion, int stock)
        {
            Codigo = codigo;
            Precio = precio;
            Descripcion = descripcion;
            _stock = stock;
        }
        public Producto()
        {

        }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value;}
        public int Stock { get => _stock; set => _stock = value; }
    }
}
