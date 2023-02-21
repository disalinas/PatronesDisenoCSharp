using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos.Motocicleta
{
    public class ScooterElectrica : AScooter
    {
        public ScooterElectrica(string pModelo, string pColor, int pPotencia)
            :base(pModelo, pColor, pPotencia)
        {

        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine(string.Format("Scooter eléctrica modelo '{0}', color '{1}' y potencia '{2}'.",
                this.modelo, this.color, this.potencia));
        }
    }
}
