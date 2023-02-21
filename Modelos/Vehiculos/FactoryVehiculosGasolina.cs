using Modelos.Vehiculos.Automovil;
using Modelos.Vehiculos.Motocicleta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos
{
    public class FactoryVehiculosGasolina : IFactoryVehiculo
    {
        public AAutomovil CrearAutomovil(string pModelo, string pColor, int pPotencia, double pEspacio)
        {
            return new AutomovilGasolina(pModelo, pColor, pPotencia, pEspacio);
        }

        public AScooter CrearScooter(string pModelo, string pColor, int pPotencia)
        {
            return new ScooterGasolina(pModelo, pColor, pPotencia);
        }
    }
}
