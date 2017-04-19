using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    class Inventario
    {
        private Producto[] _producto;
        private int ID;
        /// <summary>
        /// Crea un inventario con espacio para 20 productos.
        /// </summary>
        public Inventario()
        {
            _producto = new Producto[20];
            ID = 0;
        }
        /// <summary>
        /// Agrega un producto al inventario.
        /// </summary>
        /// <param name="Product">Un producto.</param>
        public void Agregar(Producto Product)
        {
            _producto[ID] = Product;
            ID++;
        }
        /// <summary>
        /// Busca un producto en el inventario a partir de un código dado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        /// <returns></returns>
        public Producto Buscar(int Codigo)
        {
            Producto Proc = null;
            for(int i =0; i<ID&& Proc == null; i++)
            {
                if(_producto[i].Codigo == Codigo)
                {
                    Proc = _producto[i];
                }
            }
            return Proc;
        }
        /// <summary>
        /// Elimina el producto del código especificado.
        /// </summary>
        /// <param name="Codigo">Código del producto.</param>
        public void Eliminar(int Codigo)
        {
            int i = 0;
            while(_producto[i].Codigo != Codigo && i <= ID)
            {
                i++;
            }
            if(_producto[i].Codigo == Codigo)
            {
                _producto[i] = null;
            }
            for(int j =i; j<ID;j++)
            {
                _producto[j] = _producto[j + 1];
            }
            ID--;
        }
        /// <summary>
        /// Inserta el producto en la pocisión indicada
        /// </summary>
        /// <param name="pos">Pocisión del producto</param>
        /// <param name="producto">Un producto</param>
        public void Insertar(int pos, Producto producto)
        {
            if(ID <= 20)
            {
                for (int i = _producto.Length - 1; i > pos; i--)
                {
                    _producto[i] = _producto[i-1];
                }
                _producto[pos] = producto;
            }
        }
        /// <summary>
        /// Regresa el producto en el índice indicado.
        /// </summary>
        /// <returns>Índice.</returns>
        public string Reporte()
        {
            string reporte = "";
            foreach(Producto Proc in _producto)
            {
                reporte += Proc + "\r\n";
            }
            return reporte;
        }
    }
}

