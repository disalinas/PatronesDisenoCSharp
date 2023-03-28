using Modelos.Documentacion.Formato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Documentacion.Vehiculo
{
    public class ConstructorDocumentacionVehiculoHTML : AConstructorDocumentacionVehiculo
    {
        public ConstructorDocumentacionVehiculoHTML()
        {
            this.documentacion = new DocumentacionHTML();
        }

        public override void ConstruyeSolicitudMatriculacion(string pNombreCliente)
        {
            string documento = string.Format("<HTML>Solicitud de pedido Cliente: {0}</HTML>", pNombreCliente);
            this.documentacion.AgregarDocumento(documento);
        }

        public override void ConstruyeSolicitudPedido(string pNombreCliente)
        {
            string documento = string.Format("<HTML>Solicitud de matriculación Solicitante: {0}</HTML>", pNombreCliente);
            this.documentacion.AgregarDocumento(documento);
        }
    }
}
