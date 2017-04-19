using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Inventario
{
    public partial class Form1 : Form
    {
        Inventario Invent;

        public Form1()
        {
            InitializeComponent();
            Invent = new Inventario();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Invent.Agregar(Convert.ToInt32(this.txtCódigo.Text), this.txtNombre.Text,
                Convert.ToDouble(this.txtPrecio.Text), Convert.ToInt32(this.txtCantidad.Text));

            //borrar la información de cada TextBox
            txtCódigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Invent.Eliminar(Convert.ToInt32(txtCódigo.Text));
            txtCódigo.Text = "";
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            txtReporte.Text = ("Código: " +Convert.ToString(Invent.Buscar(Convert.ToInt32(txtCódigo.Text)).Codigo + "\r\nNombre: " + Invent.Buscar(Convert.ToInt32(txtCódigo.Text)).Nombre
            + "\r\nPrecio: " + Invent.Buscar(Convert.ToInt32(txtCódigo.Text)).Precio + "\r\nCantidad: " + Invent.Buscar(Convert.ToInt32(txtCódigo.Text)).Cantidad));
            txtCódigo.Text = "";
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            
        }
    }
}
