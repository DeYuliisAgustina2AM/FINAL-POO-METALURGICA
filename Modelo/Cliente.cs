using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        private string _nombreyapellido;
        private long _dnicuit;
        private string _razonsocial;
        private DateTime _fechanacimiento;
        private string _direccion;
        private long _telefono;
        private string _email;
        private Situacion _situacion;


        public string NombreyApellido { get => _nombreyapellido; set => _nombreyapellido = value; }
        public long DniCuit { get => _dnicuit; set => _dnicuit = value; }
        public string RazonSocial { get => _razonsocial; set => _razonsocial = value; }
        public DateTime FechaNacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Email {get => _email; set => _email = value; }
        public Situacion situacion { get => _situacion; set => _situacion = value; }

        public enum Situacion {Mayorista, Minorista}

        public Cliente (string NombreyApellido, long DniCuit,string RazonSocial ,DateTime FechaNacimiento, string Direccion, long Telefono, Situacion situacion)
        {
            NombreyApellido = _nombreyapellido;
            DniCuit = _dnicuit;
            RazonSocial = _razonsocial;
            FechaNacimiento = _fechanacimiento;
            Direccion = _direccion;
            Telefono = _telefono;
            situacion = _situacion;
        }
        public Cliente()
        {

        }


    }
}
