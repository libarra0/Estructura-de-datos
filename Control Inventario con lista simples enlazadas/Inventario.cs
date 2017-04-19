using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    class Inventario
    {
        Producto primero;
        public Producto raiz;

        public Inventario()
        {
            primero = null;
        }
        /// <summary>
        /// Agrega un producto al invetario
        /// </summary>
        /// <param name="codigo">Un código</param>
        /// <param name="nombre">Un nombre</param>
        /// <param name="precio">Un precio</param>
        /// <param name="cantidad">Una cantidad</param>
        public void Agregar(int codigo, String nombre, double precio, int cantidad)
        {
            if (primero == null)
            {
                primero = new Producto(codigo, nombre, precio, cantidad);
                raiz = primero;
            }
            else
            {
                Producto nuevo = new Producto(codigo, nombre, precio, cantidad);
                primero.setSiguiente(nuevo);
                primero = nuevo;
            }
        }
        /// <summary>
        /// Busca un producto en el inventario a partir de un código dado.
        /// </summary>
        /// <param name="codigo">Código del producto.</param>
        /// <returns></returns>
        public Producto Buscar(int codigo)
        {
            Producto puntero = raiz;

            while (puntero.Codigo != codigo)
            {
                puntero = puntero._siguiente;
            }
            return puntero;
        }

        public void Eliminar(int codigo)
        {
            //Creación de los producto actual y anterior
            Producto actual, anterior;
            //Creamos un boleano que nos indique si ya hemos encontrado el producto
            Boolean encontrado = false;
            actual = raiz;
            anterior = null;
            //Iteración de busqueda
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.Codigo == codigo);
                //Evalua si es verdadero toma el prodcuto actual y el siguiente
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual._siguiente;
                }
                //Iteración de cambio de enlaces entre productos
                if (actual != null)
                {
                    if (actual == raiz)
                    {
                        raiz = actual._siguiente;
                    }
                    else
                    {
                        anterior._siguiente = actual._siguiente;
                    }
                    actual = null;
                }
            }
        }
    }
}

