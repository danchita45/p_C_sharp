using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hola_mundo
{
    internal class carritos
    {
        private int horsepower;
        private int puertas;
        private string nombre;

        public carritos(int horsepower, int puertas, string nombre)
        {
            this.horsepower = horsepower;
            this.puertas = puertas;
            this.nombre = nombre;
        }

        public string getNombre() {
            return nombre;
        }

        public int getHorsepower() {
            return horsepower;
        }

        public int getPuertas() {
            return puertas;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;

        }
        public void setHorsepower( int horsepower)
        {
            this.horsepower = horsepower;

        }
        public void setPuertas(int puertas)
        {
            this.puertas = puertas;

        }


    }

}
