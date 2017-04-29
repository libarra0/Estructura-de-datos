using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpientesyEscaleras
{
    class Tablero
    {
        private int[] _tablero;
        /// <summary>
        /// Crea un tablero de juego con 100 casillas.
        /// </summary>
        public Tablero()
        {
            _tablero = new int[101];
            for(int i= 0; i<100; i++)
            {
                //Inicializción de los npumeros de las casillas del tablero.
                _tablero[i] = i;
                //Declaración de escaleras.
                _tablero[4] = 25;
                _tablero[13] = 34;
                _tablero[33] = 49;
                _tablero[42] = 63;
                _tablero[50] = 69;
                _tablero[62] = 81;
                _tablero[74] = 92;
                //Declaración de serpientes.
                _tablero[27] = 5;
                _tablero[40] = 20;
                _tablero[54] = 31;
                _tablero[66] = 45;
                _tablero[76] = 56;
                _tablero[89] = 64;
                _tablero[99] = 75;
            }
        }

        public int Posicion(int pos)
        {
            if(pos <= 100)
            {
                return _tablero[pos];
            }
            else
            {
                return 0;
            }
        }
    }
}
