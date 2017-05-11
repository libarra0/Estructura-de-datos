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
        Base B1, B2, B3;
        Ruta R1 = new Ruta();

        public Form1()
        {
            InitializeComponent();
            B1 = new Base("A", 05);
            B2 = new Base("B", 10);
            B3 = new Base("C", 15);
            R1.Agregar(B1);
            R1.Agregar(B2);
            R1.Agregar(B3);
            R1.Insertar(0, B3);
        }
    }
}
