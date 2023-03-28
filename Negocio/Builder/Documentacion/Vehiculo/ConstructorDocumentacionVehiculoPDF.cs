using Negocio.Documentacion.Formato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Documentacion.Vehiculo
{
    public class ConstructorDocumentacionVehiculoPDF : AConstructorDocumentacionVehiculo
    {
        public ConstructorDocumentacionVehiculoPDF()
        {
            this.documentacion = new DocumentacionPDF();
        }

        public override void ConstruyeSolicitudMatriculacion(string pNombreCliente)
        {
            string documento = string.Format("<PDF>Solicitud de pedido Cliente: {0}</PDF>", pNombreCliente);
            this.documentacion.AgregarDocumento(documento);
        }

        public override void ConstruyeSolicitudPedido(string pNombreCliente)
        {
            string documento = string.Format("<PDF>Solicitud de pedido Solicitante: {0}</PDF>", pNombreCliente);
            this.documentacion.AgregarDocumento(documento);
        }
    }
}
