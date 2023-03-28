using Negocio.Documentacion.Formato;
using Negocio.Documentacion.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Builder
{
    public class ClienteVehiculo
    {
        public void Ejecutar(string pEleccion)
        {
            AConstructorDocumentacionVehiculo constructorDocumentacion;

            if ("1" == pEleccion)
            {
                constructorDocumentacion = new ConstructorDocumentacionVehiculoHTML();
            } 
            else
            {
                constructorDocumentacion = new ConstructorDocumentacionVehiculoPDF();
            }

            Vendedor vendedor = new Vendedor(constructorDocumentacion);
            ADocumentacion documentacion = vendedor.Construye("Martín");
            documentacion.Imprime();
        }
    }
}
