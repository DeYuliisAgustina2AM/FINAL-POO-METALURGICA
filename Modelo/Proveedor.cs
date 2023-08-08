using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        
        private string _nombre;
        private long _cuit;
        private string _razonSocial;
        private string _direccion;
        private long _telefono;
        private string _email;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public long Cuit { get => _cuit; set => _cuit = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value;  }
        public string Email { get => _email; set => _email = value; }

        public Proveedor(string nombre, long cuit, string razonSocial, string direccion, long telefono, string email)
        {
            Nombre = nombre;
            Cuit = cuit;
            RazonSocial = razonSocial;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

    }
}
