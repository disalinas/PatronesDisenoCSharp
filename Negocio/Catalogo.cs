using Modelos.Vehiculos;
using Modelos.Vehiculos.Automovil;
using Modelos.Vehiculos.Motocicleta;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Catalogo
    {
        public static int nAutos = 3;
        public static int nScooters = 2;

        public void Ejecutar(string pEleccion)
        {   
            AAutomovil[] autos = new AAutomovil[nAutos];
            AScooter[] scooters = new AScooter[nScooters];

            //Console.WriteLine("Deseas utilizar vehículos eléctricos (1) o gasolina (2): ");
            //string eleccion = Console.ReadLine();
            IFactoryVehiculo fabrica = FactoryVehiculo.Get(pEleccion);

            for (int i = 0; i < nAutos; i++)
            {
                autos[i] = fabrica.CrearAutomovil("estándar", "negro", 6 + i, 3.2);
            }

            for (int i = 0; i < nScooters; i++)
            {
                scooters[i] = fabrica.CrearScooter("clásico", "rojo", 2 + i);
            }

            foreach (AAutomovil auto in autos)
            {
                auto.MostrarCaracteristicas();
            }

            foreach(AScooter scooter in scooters)
            {
                scooter.MostrarCaracteristicas();
            }
        }
    }
}
