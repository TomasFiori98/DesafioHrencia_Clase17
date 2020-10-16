using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPisoLocal.Clases
{
    abstract class Inmueble
    {
        protected String direccion;
        protected int mt;
        protected bool esNuevo;
        protected double precio_base;

        protected Inmueble(string direccion, int mt, bool esNuevo, double precioBase)
        {
            this.direccion = direccion;
            this.mt = mt;
            this.esNuevo = esNuevo;
            this.precio_base = precioBase;
        }


        public abstract double calcularPrecio(double precio_base);
        
        }
    }

