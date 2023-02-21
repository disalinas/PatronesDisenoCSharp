using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos.Motocicleta
{
    public abstract class AScooter
    {
        protected string modelo;
        protected string color;
        protected int potencia;

        public AScooter(string pModelo, string pColor, int pPotencia)
        {
            this.modelo = pModelo;
            this.color = pColor;
            this.potencia = pPotencia;
        }

        public abstract void MostrarCaracteristicas();
    }
}
