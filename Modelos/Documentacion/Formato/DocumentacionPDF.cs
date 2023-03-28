using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Documentacion.Formato
{
    class DocumentacionPDF : ADocumentacion
    {
        public override void AgregarDocumento(string pDocumento)
        {
            if (pDocumento.StartsWith("<PDF>"))
                this.contenido.Add(pDocumento);
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentación PDF");
            foreach (string s in contenido)
            {
                Console.WriteLine(s);
            }
        }
    }
}
