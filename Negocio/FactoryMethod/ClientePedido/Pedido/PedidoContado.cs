using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ClientePedido.Pedido
{
    public class PedidoContado : APedido
    {
        public PedidoContado(double pImporte) : base(pImporte)
        {

        }

        public override void Paga()
        {
            Console.WriteLine(string.Format("El pago del pedido por importe de {0} se ha realizado.", this.importe));
        }

        public override bool Valida()
        {
            return true;
        }
    }
}
