using Modelos.Documentacion.Formato;
using Modelos.Documentacion.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Builder
{
    public class Vendedor
    {
        private AConstructorDocumentacionVehiculo constructorDocumentacion;

        public Vendedor(AConstructorDocumentacionVehiculo pConstructorDocumentacionVehiculo)
        {
            this.constructorDocumentacion = pConstructorDocumentacionVehiculo;
        }

        public ADocumentacion Construye(string pNombreCliente)
        {
            this.constructorDocumentacion.ConstruyeSolicitudPedido(pNombreCliente);
            this.constructorDocumentacion.ConstruyeSolicitudMatriculacion(pNombreCliente);
            ADocumentacion documentacion = this.constructorDocumentacion.Resultado();

            return documentacion;
        }
    }
}
