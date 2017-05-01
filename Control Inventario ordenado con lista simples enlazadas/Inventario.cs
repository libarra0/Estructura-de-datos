using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    class Inventario
    {
        private Producto Primero;

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
            //Evalua mediante el número del código si su posición es la primera
            if (Primero == null || Product.Codigo < Primero.Codigo)
            {
                Product.Siguiente = Primero;
                Primero = Product;
            }
            //Evalua mediante el código si la posición es siguiente de su predecesor
            else
            {
                Producto temp = Primero;
                while (temp.Siguiente != null && Product.Codigo > temp.Siguiente.Codigo)
                {
                    temp = temp.Siguiente;
                    Product.Siguiente = temp.Siguiente;
                }
                temp.Siguiente = Product;
            }
        }

        /// <summary>
        /// Agrega al inicio de la lista un producto
        /// </summary>
        /// <param name="Product">Un producto</param>
        //public void AgregarAlInicio(Producto Product)
        //{
        //    Product.Siguiente = Primero;
        //    Primero = Product;
        //}
        /// <summary>
        /// Busca un producto en el inventario a partir de un código dado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        /// <returns></returns>
        public Producto Buscar(int ID)
        {
            Producto temp = Primero;
            while(temp.Siguiente !=null && ID != temp.Codigo)
            {
                temp = temp.Siguiente;
            }
            if(temp.Codigo == ID)
            {
                return temp;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Elimina el producto del código especificado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        public void Eliminar(int ID)
        {
            Producto temp = Primero;
            if(Primero.Codigo == ID)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                while(temp.Siguiente != null && ID != temp.Siguiente.Codigo)
                {
                    temp = temp.Siguiente;
                }
                if(temp.Siguiente != null)
                {
                    temp.Siguiente = temp.Siguiente.Siguiente;
                }
            }
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
        public string Reporte()
        {
            string reporte = "";
            Producto t = Primero;
            while(t!=null)
            {
                reporte += t.ToString() + "\r\n";
                t = t.Siguiente;
            }
            return reporte;
        }
        /// <summary>
        /// Regresa el reporte invertido de la lista
        /// </summary>
        /// <returns>Índice invertido</returns>
        public string ReporteInverso()
        {
            if(Primero != null)
            {
                return ReporteInverso(Primero);
            }
            else
            {
                return "";
            }
        }

        private string ReporteInverso(Producto nodo)
        {
            if(nodo.Siguiente == null)
            {
                return nodo.ToString() + "\r\n";
            }
            else
            {
                return ReporteInverso(nodo.Siguiente) + nodo.ToString() + "\r\n";
            }
        }
    }
}

