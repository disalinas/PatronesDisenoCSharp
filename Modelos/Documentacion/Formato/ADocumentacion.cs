using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Documentacion.Formato
{
    public abstract class ADocumentacion
    {
        protected IList<string> contenido = new List<string>();

        public abstract void AgregarDocumento(string pDocumento);
        public abstract void Imprime();
    }
}
