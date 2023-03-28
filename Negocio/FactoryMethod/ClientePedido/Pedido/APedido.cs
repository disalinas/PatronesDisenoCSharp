using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ClientePedido.Pedido
{
    public abstract class APedido
    {
        protected double importe;

        public APedido(double pImporte)
        {
            this.importe = pImporte;
        }

        public abstract void Paga();
        public abstract bool Valida();
    }
}
