using Modelos.Vehiculos.Automovil;
using Modelos.Vehiculos.Motocicleta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos
{
    public class FactoryVehiculoElectrico : IFactoryVehiculo
    {
        public AAutomovil CrearAutomovil(string pModelo, string pColor, int pPotencia, double pEspacio)
        {
            return new AutomovilElectrico(pModelo, pColor, pPotencia, pEspacio);
        }

        public AScooter CrearScooter(string pModelo, string pColor, int pPotencia)
        {
            return new ScooterElectrica(pModelo, pColor, pPotencia);
        }
    }
}
