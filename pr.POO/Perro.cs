using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr.POO
{
    public class Perro
    {
        private String nombre;
        private String raza;
        private String altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Altura { get => altura; set => altura = value; }

        public string comer(string carne)
        {
            return this.Nombre + "mide " + this.Altura + "y va a comer " + carne;
        }
        public void dormir()
        {

        }
        public void ladrar()
        {

        }

        public Perro()
        {

        }

        public Perro( string nombre, string raza, string altura)
        {
            this.Altura = altura;
            this.Nombre = nombre;
            this.Raza = raza;
        }

    }
}
