using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioDocumento<TipoNota> // repositorio de decoumento. Recibe que tipo de documento va a ser: nota de venta o de compra
    {
        private List<Documento> _listaDocumentos; // lista de documentos

        public RepositorioDocumento()
        {
            _listaDocumentos = new List<Documento>();
        }
        public ReadOnlyCollection<Documento> ListarDocumentos { get => _listaDocumentos.AsReadOnly(); }


        public bool Agregar(Documento documento) // agrego documento a la lista de documentos
        {
            var documentoEncontrado = _listaDocumentos.FirstOrDefault(x => x.Numero == documento.Numero);
            if (documentoEncontrado == null)
            {
                _listaDocumentos.Add(documento);
                return true;
            }
            else return false;
        }

        
    }
}
