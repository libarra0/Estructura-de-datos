using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasFIFO
{
    public partial class Form1 : Form
    {
        private Proceso miProceso;
        private Random r = new Random();
        private Procesador mififo = new Procesador();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSimulacion_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int cev = 0; 

            for(int i =0; i <200; i++)
            {
                if(r.Next(1,5) == 1)
                {
                    Proceso n = new Proceso(r.Next(4, 15));
                    mififo.meter(n);
                    contador++;
                }

                miProceso = mififo.peek();

                if(miProceso == null)
                {
                    cev++;
                }
                
                else
                {
                    miProceso.Dato--;
                    if (miProceso.Dato == 0)
                    {
                        mififo.sacar();
                    }
                }
            }

            txtResultado.Text = " " ;
            txtResultado.Text = "Cola vacia: " + cev + " ciclos" + Environment.NewLine;
            txtResultado.Text += mififo.ToString();
        }
    }
}
