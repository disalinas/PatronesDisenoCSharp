using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos.Motocicleta
{
    public class ScooterGasolina : AScooter
    {
        public ScooterGasolina(string pModelo, string pColor, int pPotencia)
            : base(pModelo, pColor, pPotencia)
        {

        }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine(string.Format("Scooter de gasolina modelo '{0}', color '{1}' y potencia '{2}'.",
                this.modelo, this.color, this.potencia));
        }
    }
}
