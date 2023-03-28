using Modelos.ClientePedido.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.ClientePedido.Tipo
{
    public abstract class ACliente
    {
        protected IList<APedido> pedidos = new List<APedido>();

        public void NuevoPedido(double pImporte)
        {
            APedido pedido = this.CreaPedido(pImporte);

            if (pedido.Valida())
            {
                pedido.Paga();
                pedidos.Add(pedido);
            }
        }

        protected abstract APedido CreaPedido(double pImporte);
    }
}
