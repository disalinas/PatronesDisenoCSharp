using Modelos.Documentacion.Formato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Documentacion.Vehiculo
{
    public abstract class AConstructorDocumentacionVehiculo
    {
        protected ADocumentacion documentacion;

        public abstract void ConstruyeSolicitudPedido(string pNombreCliente);
        public abstract void ConstruyeSolicitudMatriculacion(string pNombreCliente);
        public ADocumentacion Resultado()
        {
            return this.documentacion;
        }
    }
}
