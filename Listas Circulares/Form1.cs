using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares
{
    public partial class Form1 : Form
    {
        Base B1;
        Ruta R1;
        string Parada;
        int Tiempo;

        public Form1()
        {
            InitializeComponent();
        }


        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Parada = txtParada.Text;
            Tiempo = Convert.ToInt32(txtHorario.Text);
            B1 = new Base(Parada, Tiempo);
            R1.Agregar(B1);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Parada = txtParada.Text;
            R1.Buscar(Parada);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Parada = txtParada.Text;
            R1.Eliminar(Parada);
        }

        private void cmdAgregarInicio_Click(object sender, EventArgs e)
        {
            Parada = txtParada.Text;
            Tiempo = Convert.ToInt32(txtHorario.Text);
            B1 = new Base(Parada, Tiempo);
            R1.AgregarAlInicio(B1);
        }

        private void cmdEliminarInicio_Click(object sender, EventArgs e)
        {
            R1.EliminarInicio();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            Base NuevaBase = new Base(txtReporte.Text, Convert.ToInt32(txtHorario.Text));
            R1.Insertar(Convert.ToInt32(txtNuevaBase.Text), NuevaBase);
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = R1.Reporte();
        }
    }
}
