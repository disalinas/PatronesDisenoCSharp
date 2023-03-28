using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PatronesDiseñoCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocio.AbstractFactory.Catalogo catalogo = new Negocio.AbstractFactory.Catalogo();
            catalogo.Ejecutar("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Negocio.AbstractFactory.Catalogo catalogo = new Negocio.AbstractFactory.Catalogo();
            catalogo.Ejecutar("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Negocio.Builder.ClienteVehiculo cliente = new Negocio.Builder.ClienteVehiculo();
            cliente.Ejecutar("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Negocio.Builder.ClienteVehiculo cliente = new Negocio.Builder.ClienteVehiculo();
            cliente.Ejecutar("2");
        }
    }
}
