using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos
{
    public interface IFactoryVehiculo
    {
        Automovil.AAutomovil CrearAutomovil(string pModelo, string pColor, int pPotencia, double pEspacio);
        Motocicleta.AScooter CrearScooter(string pModelo, string pColor, int pPotencia);
    }
}
