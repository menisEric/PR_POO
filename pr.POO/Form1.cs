using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr.POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perro perrito = new Perro();
            perrito.Altura = "1.00mt";
            perrito.Nombre = "Vegetta";
            perrito.Raza = "Obejero Aleman";

            txtResultado.Text = perrito.comer("carne");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perro perrito = new Perro("Wendy", "sharpeyn", "30cm");
            txtResultado.Text = perrito.comer("pollo");
        }
    }
}
