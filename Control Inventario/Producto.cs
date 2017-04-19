using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _cantidad;

        public Producto(int code, string name, double price, int cant)
        {
            _codigo = code;
            _nombre = name;
            _precio = price;
            _cantidad = cant;
        }
        /// <summary>
        /// Devuelve el nombre del producto.
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        /// <summary>
        /// Devuelve la cantidad de producto.
        /// </summary>
        public int Cantidad
        {
            set
            {
                _cantidad = value;
            }
            get
            {
                return _cantidad;
            }
        }
        /// <summary>
        /// Devuelve el código único del producto.
        /// </summary>
        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        /// <summary>
        /// Devuelve el precio del producto.
        /// </summary>
        public double Precio
        {
            get
            {
                return _precio;
            }
        }
        /// <summary>
        /// Muestra información del producto
        /// </summary>
        /// <returns>Devuelve nombre y precio del producto.</returns>
        public override string ToString()
        {
            return "Producto: " +_nombre + " Código: " + Codigo + ", Precio: $" + _precio + ", Cantidad: " + _cantidad;
        }
    }
}
