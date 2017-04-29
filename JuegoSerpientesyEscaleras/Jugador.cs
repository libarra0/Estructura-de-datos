using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpientesyEscaleras
{
    class Jugador
    {
        private int _numero;
        private int _casilla;
        private int numJugador = 1;
        /// <summary>
        /// Crea un nuevo jugador para el juego.
        /// </summary>
        public Jugador()
        {
            _numero = numJugador;
            _casilla = 0;
            numJugador++;
        }
        /// <summary>
        /// Número del jugador.
        /// </summary>
        public int numero
        {
            get
            {
                return _numero;
            }
        }
        /// <summary>
        /// Casilla actual del jugador.
        /// </summary>
        public int casilla
        {
            get
            {
                return _casilla;
            }
        }
        /// <summary>
        /// El jugador lanza un dado.
        /// </summary>
        /// <param name="D1">Recibe un dado.</param>
        /// <returns>Devuelve el valor del tiro.</returns>
        public int Lanzar(Dado D1)
        {
            int numDado;
            numDado = D1.Lanzar();
            _casilla += numDado;
            return numDado;
        }
        /// <summary>
        /// Avanza a la casilla indicada. Se ve afectado por las serpientes o escaleras.
        /// </summary>
        /// <param name="irACasilla"></param>
        /// <returns>Devuelve la casilla actual del jugador.</returns>
        /// <returns>Devuelve 0 se el jugador ha llegado a la casilla final.</returns>
        public int Avanzar(int irACasilla)
        {
            if(irACasilla !=0)
            {
                _casilla = irACasilla;
                return _casilla;
            }
            else
            {
                return 0;
            }
        }
    }
}
