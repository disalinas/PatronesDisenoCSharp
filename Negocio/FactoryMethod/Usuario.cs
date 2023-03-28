using Negocio.ClientePedido.Tipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.FactoryMethod
{
    public class Usuario
    {
        public void Ejecutar(string pEleccion)
        {
            ACliente cliente;

            if ("1" == pEleccion)
            {
                cliente = new ClienteContado();
            } 
            else
            {
                cliente = new ClienteCredito();
            }

            cliente.NuevoPedido(2000.0);
            cliente.NuevoPedido(10000.0);
        }
    }
}
