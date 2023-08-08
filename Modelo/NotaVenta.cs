using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NotaVenta : Documento // Nota de venta hereda de la clase documento
    {
        private Cliente _cliente; // la nota de venta tendra asociado un cliente, siendo esta una nueva propiedad 
        
        public NotaVenta() 
        { 
        
        }
        
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        
    }
}
