using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NotaCompra : Documento // Nota de venta hereda de la clase documento
    {
        private Proveedor _proveedor; // la nota de compra tendra asociado un proveedor, siendo esta una nueva propiedad 
        public NotaCompra()
        {

        }
        
        public Proveedor Proveedor { get => _proveedor; set => _proveedor = value; }

       
    }
}
