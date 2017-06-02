using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Procesador
    {
        private Proceso _principio;
        private int noProcesos = 0;
        /// <summary>
        /// Agrega el siguiente dato en la cola
        /// </summary>
        /// <param name="fase"></param>
        public void meter(Proceso fase)
        {
            if(_principio == null)
            {
                _principio = fase;
                noProcesos++;
            }
            else
            {
                fase.Siguiente = _principio;
                _principio = fase;
                noProcesos++;
            }
        }
        /// <summary>
        /// Saca el proceso de la cola cuando termino de ejecutarlo
        /// </summary>
        /// <returns></returns>
        public Proceso sacar()
        {
            if (_principio != null)
            {
                Proceso aux;

                if (_principio.Siguiente == null)
                {
                    aux = _principio;
                    _principio = null;
                    noProcesos--;

                    return aux;
                }
                else
                {
                    Proceso final = _principio;

                    while (final.Siguiente.Siguiente != null)
                    {
                        final = final.Siguiente;
                    }
                    aux = final.Siguiente;
                    final.Siguiente = null;
                    noProcesos--;

                    return aux;
                }
            }
            return null;
        }
        /// <summary>
        /// Ve cual es el siguiente en salir.
        /// </summary>
        /// <returns></returns>
        public Proceso peek()
        {
            if (_principio != null)
            {
                Proceso aux = _principio;

                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                return aux;
            }
            return null;
        }

        public override string ToString()
        {
            string proceso = "";

            if (_principio != null)
            {
                Proceso aux = _principio;
                int duracion = 0;

                while (aux.Siguiente != null)
                {
                    duracion += aux.Dato;
                    aux = aux.Siguiente;
                }

                proceso += "Procesos pendientes: " + noProcesos + Environment.NewLine;
                proceso += "Suma del tiempo de vida de los porcesos: " + duracion;
            }
            else
                proceso = "No se encontraron procesos";

            return proceso;
        }

    }
}
