using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos.Automovil
{
    public class AutomovilElectrico : AAutomovil
    {
        public AutomovilElectrico(string pModelo, string pColor, int pPotencia, double pEspacio)
            :base(pModelo, pColor, pPotencia, pEspacio)
        {

        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine(string.Format("Automóvil eléctrico modelo '{0}', color '{1}', potencia '{2}' y espacio '{3}'.",
                this.modelo, this.color, this.potencia, this.espacio));
        }
    }
}
