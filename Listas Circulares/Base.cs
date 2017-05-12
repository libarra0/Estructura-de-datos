using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Base
    {
        private Base _siguiente;
        private Base _anterior;
        private string _nombre;
        private int _minutos;

        public Base(string nombre, int minutos)
        {
            _nombre = nombre;
            _minutos = minutos;
        }
        /// <summary>
        /// Devuelve el nombre de la base.
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        /// <summary>
        /// Devuelve el valor de tiempo en minutos.
        /// </summary>
        public int Minutos
        {
            get
            {
                return _minutos;
            }
        }

        public Base Siguiente
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

        public Base Anterior
        {
            get
            {
                return _anterior;
            }
            set
            {
                _anterior = value;
            }
        }

        public override string ToString()
        {
            return "Parada: " + _nombre + " Hora de llegada: " + _minutos;
        }
    }
}
