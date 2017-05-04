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
        private Producto Ultimo;

        /// <summary>
        /// Crea un inventario con espacio para 20 productos.
        /// </summary>
        public Inventario()
        {
            Primero = null;
            Ultimo = null;
        }
        /// <summary>
        /// Agrega un producto al inventario.
        /// </summary>
        /// <param name="Product">Un producto.</param>
        //public void Agregar(Producto Product)
        //{
        //    if(Primero == null)
        //    {
        //        Primero = Product;
        //    }
        //    else
        //    {
        //        Producto temp = Primero;
        //        while(temp.Siguiente != null)
        //        {
        //            temp = temp.Siguiente;
        //        }
        //        temp.Siguiente = Product;
        //    }
        //}
        public void Agregar(Producto nuevo)
        {
            if(Primero==null)
            {
                Primero = nuevo;
                nuevo.Anterior = null;
            }
            else
            {
                Agregar(nuevo, Primero);
            }
        }

        private void Agregar(Producto nuevo, Producto ultimo)
        {
            if(ultimo.Siguiente == null)
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
            }
            else
            {
                Agregar(nuevo, ultimo.Siguiente);
            }
        }
        /// <summary>
        /// Agrega al inicio de la lista un producto
        /// </summary>
        /// <param name="Product">Un producto</param>
        public void AgregarAlInicio(Producto Product)
        {
            Product.Siguiente = Primero;
            Primero.Anterior = null;
            Primero = Product;
        }
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
                temp.Anterior = null;
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
        /// Elimina el primer elemento de la lista.
        /// </summary>
        public void EliminarInicio()
        {
            Primero = Primero.Siguiente;
            Primero.Anterior = null;
        }
        /// <summary>
        /// Elimina el ultimo elemento de la lista.
        /// </summary>
        public void EliminarFinal()
        {
            Primero.Anterior = Primero;
            Producto actual = Primero;
            while(actual.Siguiente != null)
            {
                Primero.Anterior = actual;
                actual = actual.Siguiente;
            }
            Primero.Siguiente = null;
        }
        /// <summary>
        /// Inserta el producto en la pocisión indicada
        /// </summary>
        /// <param name="pos">Pocisión del producto</param>
        /// <param name="producto">Un producto</param>
        public void Insertar(int pos, Producto producto)
        {
            if(Primero != null)
            {
                Agregar(producto);
            }
            else
            {
                Producto temp = Primero;
                for(int i =0; i<pos-1; i++)
                {
                    temp = temp.Siguiente;
                    producto.Siguiente = temp.Siguiente;
                    temp.Siguiente = producto;
                }
            }
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
        /// Regresa el reporte invertido de la lista.
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

