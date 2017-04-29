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
        Producto Prod;
        string Nombre;
        int Precio, Cantidad, Codigo;

        public Form1()
        {
            InitializeComponent();
            Invent = new Inventario();
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            //Ingreso de los datos del producto.
            Nombre = txtNombre.Text;
            Precio = Convert.ToInt32(txtPrecio.Text);
            Cantidad = Convert.ToInt32(txtCantidad.Text);
            Codigo = Convert.ToInt32(txtCódigo.Text);
            //Se crea el producto nuevo.
            Prod = new Producto(Codigo, Nombre, Precio, Cantidad);
            //Agrega el producto al inventario.
            Invent.Agregar(Prod);
        }

        private void cmdAgregarAlInicio_Click(object sender, EventArgs e)
        {
            //Ingreso de los datos del producto.
            Nombre = txtNombre.Text;
            Precio = Convert.ToInt32(txtPrecio.Text);
            Cantidad = Convert.ToInt32(txtCantidad.Text);
            Codigo = Convert.ToInt32(txtCódigo.Text);
            //Se crea el producto nuevo.
            Prod = new Producto(Codigo, Nombre, Precio, Cantidad);
            //Agrega el producto al inventario.
            Invent.AgregarAlInicio(Prod);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(txtCódigo.Text);
            Invent.Eliminar(Codigo);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            Producto Nuevo = new Producto(Convert.ToInt32(txtCódigo.Text), txtNombre.Text,
                Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
            //Invent.Insertar(Convert.ToInt32(txtInsertar.Text), Nuevo);

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(txtCódigo.Text);
            txtReporte.Text = Invent.Buscar(Codigo).ToString();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = Invent.Reporte();
        }

        private void cmdInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Text = Invent.ReporteInverso();
        }
    }
}
