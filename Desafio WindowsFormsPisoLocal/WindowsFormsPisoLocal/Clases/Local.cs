using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPisoLocal.Clases
{
    class Local : Inmueble
    {
        private int cant_ventanas;

        public int cant_Ventanas 
        { 
            get => cant_ventanas; 
            set => cant_ventanas = value; 
        }

        public Local(string direccion, int mt, bool esNuevo, double precio_base, int numVentanas) : base(direccion, mt, esNuevo, precio_base)
        {
            this.cant_ventanas = numVentanas;
        }



        public override double calcularPrecio(double precio_base)
        {
            double precio_final;
            double x = 0.0;
            double y = 0.0;
            double z = 0.0;


            if (esNuevo==true)
            {
                x = x - (precio_base * 1) / 100;
            }
            else 
            {
                x = x - (precio_base * 2) / 100;
            
            }

            if (mt>50)
            {
                y = y + (precio_base * 1) / 100;
            }

            if (cant_ventanas <= 1)
                z = z - (precio_base * 2) / 100;
            else if (cant_ventanas >= 4)
                z = z + (precio_base * 2) / 100;

            precio_final = precio_base + x + y + z;

            return precio_final;
        }
    }
}
