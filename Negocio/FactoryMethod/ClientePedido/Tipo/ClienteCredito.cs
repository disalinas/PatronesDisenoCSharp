using Negocio.ClientePedido.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ClientePedido.Tipo
{
    public class ClienteCredito : ACliente
    {
        protected override APedido CreaPedido(double pImporte)
        {
            return new PedidoCredito(pImporte);
        }
    }
}
