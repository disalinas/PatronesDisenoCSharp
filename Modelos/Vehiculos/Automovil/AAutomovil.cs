using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Vehiculos.Automovil
{
    public abstract class AAutomovil
    {
        protected string modelo;
        protected string color;
        protected int potencia;
        protected double espacio;

        public AAutomovil(string pModelo, string pColor, int pPotencia, double pEspacio)
        {
            this.modelo = pModelo;
            this.color = pColor;
            this.potencia = pPotencia;
            this.espacio = pEspacio;
        }

        public abstract void MostrarCaracteristicas();
    }
}
