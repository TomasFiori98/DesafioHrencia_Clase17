using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPisoLocal.Clases
{

    class Piso : Inmueble
    {
        private int numPiso;

        public Piso(string direccion, int mt, bool esNuevo, double precio_base, int numPiso) : base(direccion, mt, esNuevo, precio_base)
        {
            this.numPiso = numPiso;
        }

        public int NumPiso 
        { 
            get => numPiso; 
            set => numPiso = value; 
        }

        public override double calcularPrecio(double precio_base)
        {
            double precio_final;
            double x = 0.0;
            double y = 0.0;

            if (esNuevo == true)
            {
                x = x - (precio_base * 1) / 100;
            }
            else
            {
                x = x - (precio_base * 2) / 100;
            }

            if (numPiso >= 3)
            {
                y = y + (precio_base * 3) / 100;
            }

            precio_final = precio_base + x + y;

            return precio_final;

        }
    }
}
