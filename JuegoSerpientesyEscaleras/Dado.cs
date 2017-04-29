using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpientesyEscaleras
{
    class Dado
    {
        private static Random dado;

        public Dado()
        {
            dado = new Random();
        }

        public int Lanzar()
        {
            int _número = dado.Next(1, 7);
            return _número;
        }
    }
}
