using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        
        private int _dato;
        private Proceso _siguiente;

        public Proceso(int dato)
        {
            this._dato = dato;
        }

        /// <summary>
        /// Ingresa el valor de nuevo dato
        /// </summary>
        public int Dato
        {
            get
            {
                return _dato;
            }
            set
            {
                _dato = value;
            }
        }
        /// <summary>
        /// Indica cual es el inicio
        /// </summary>
        public Proceso Siguiente
        {
            get
            {
                return _siguiente;
            }
            set
            {
                _siguiente = value;
            }
        }

        public override string ToString()
        {
            return "Tiempo = " + _dato;
        }
    }
}
