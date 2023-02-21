using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos
{
    public class FactoryVehiculo
    {
        public static IFactoryVehiculo Get(string pOpcion)
        {
            IFactoryVehiculo fabrica = null;

            switch (pOpcion)
            {
                case "1": // Eléctrico.
                    fabrica = new FactoryVehiculoElectrico();
                    break;
                case "2": // Gasolina.
                    fabrica = new FactoryVehiculosGasolina();
                    break;
                default:
                    throw new ArgumentException(string.Format("Opción de fábrica no disponible '{0}'.", pOpcion));
            }

            return fabrica;
        }
    }
}
