using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ClientePedido.Pedido
{
    public class PedidoCredito : APedido
    {
        public PedidoCredito(double pImporte) : base(pImporte)
        {

        }

        public override void Paga()
        {
            Console.WriteLine(string.Format("El pago del pedido a crédito de {0} se ha realizado.", this.importe));
        }

        public override bool Valida()
        {
            return (this.importe >= 1000.0) && (this.importe <= 5000.0);
        }
    }
}
