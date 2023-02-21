using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos.Automovil
{
    public class AutomovilGasolina : AAutomovil
    {
        public AutomovilGasolina(string pModelo, string pColor, int pPotencia, double pEspacio)
            : base(pModelo, pColor, pPotencia, pEspacio)
        {

        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine(string.Format("Automóvil de gasolina modelo '{0}', color '{1}', potencia '{2}' y espacio '{3}'.",
                this.modelo, this.color, this.potencia, this.espacio));
        }
    }
}
