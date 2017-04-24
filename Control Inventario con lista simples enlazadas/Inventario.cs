using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    class Inventario
    {
        public static int code;
        public static string name;
        public static double price;
        public static int cant;

        private Producto Primero = new Producto(code,name,price,cant);

        /// <summary>
        /// Crea un inventario con espacio para 20 productos.
        /// </summary>
        public Inventario()
        {
            Primero = null;
        }
        /// <summary>
        /// Agrega un producto al inventario.
        /// </summary>
        /// <param name="Product">Un producto.</param>
        public void Agregar(Producto Product)
        {
            if(Primero == null)
            {
                Primero = Product;
            }
            else
            {
                Producto temp = Primero;
                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = Product;
            }
        }
        /// <summary>
        /// Busca un producto en el inventario a partir de un código dado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        /// <returns></returns>
        public void Buscar(Producto Actual)
        {
            Actual = Primero;
            bool encotrado = false;
            int codigoEncontrado = 0;
            if(Primero != null)
            {
                while(Actual != null && encotrado != true)
                {
                    if(Actual.Codigo == codigoEncontrado)
                    {
                        encotrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if(!encotrado)
                {
                    encotrado = false;
                }
            }
        }
        /// <summary>
        /// Elimina el producto del código especificado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        public void Eliminar(Producto Actual)
        {
            
        }
        /// <summary>
        /// Inserta el producto en la pocisión indicada
        /// </summary>
        /// <param name="pos">Pocisión del producto</param>
        /// <param name="producto">Un producto</param>
        public void Insertar(int pos, Producto producto)
        {
            
        }
        /// <summary>
        /// Regresa el producto en el índice indicado.
        /// </summary>
        /// <returns>Índice.</returns>
        //public string Reporte()
        //{
        //    //string reporte = "";
        //    //foreach (Producto Proc in _producto)
        //    //{
        //    //    reporte += Proc + "\r\n";
        //    //}
        //    //return reporte;
        //}
    }
}

