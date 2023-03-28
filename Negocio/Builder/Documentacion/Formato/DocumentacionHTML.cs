using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Documentacion.Formato
{
    public class DocumentacionHTML : ADocumentacion
    {
        public override void AgregarDocumento(string pDocumento)
        {
            if (pDocumento.StartsWith("<HTML>"))
                this.contenido.Add(pDocumento);
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentación HTML");
            foreach (string s in contenido)
            {
                Console.WriteLine(s);
            }
        }
    }
}
