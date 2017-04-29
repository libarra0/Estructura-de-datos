using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoSerpientesyEscaleras
{
    public partial class Form1 : Form
    {
        //Crea a los jugadores, el tablero y el dado.
        Jugador J1 = new Jugador();
        Jugador J2 = new Jugador();
        Tablero Game = new Tablero();
        Dado D1 = new Dado();

        //Variables.
        int resDado, bandera = 1, CasillaAMoverse;
        bool turno = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdTirar_Click(object sender, EventArgs e)
        {
            txtJuego.Text = "";
            do
            {
                J1.Lanzar(D1);
                J2.Lanzar(D1);
            }
            while (J1.casilla < 100 && J2.casilla < 100);

            if(J1.casilla >= 100 && J2.casilla >= 100)
            {
                txtJuego.Text = "Ambos jugadores han empatado";
            }
            else if(J1.casilla >= 100)
            {
                txtJuego.Text = "Ha ganado el jugador 1";
            }
            else if(J2.casilla >= 100)
            {
                txtJuego.Text = "Ha ganado el jugador 2";
            }
        }
    }
}
