using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Ruta
    {
        private Base Primero;

        public Ruta()
        {
            Primero = null;
        }
        /// <summary>
        /// Agrega una nueva base al recorrido.
        /// </summary>
        /// <param name="nueva">Una base</param>
        public void Agregar(Base nueva)
        {
            if(Primero==null)
            {
                Primero = nueva;
                Primero.Siguiente = nueva;
            }
            else
            {
                Agregar(nueva, Primero);
            }
        }

        private void Agregar(Base nueva, Base ultima)
        {
            if(ultima.Anterior != Primero)
            {
                ultima.Siguiente = nueva;
                nueva.Siguiente = ultima;
            }
            else
            {
                Agregar(nueva, ultima.Siguiente);
            }
        }
        /// <summary>
        /// Agrega una base al inicio de la lista
        /// </summary>
        /// <param name="nueva">Una base</param>
        public void AgregarAlInicio(Base nueva)
        {
            nueva.Siguiente = Primero;
            Primero = nueva;
        }
        /// <summary>
        /// Busca un base a partir del nombre de la base.
        /// </summary>
        /// <param name="Codigo">Código del station.</param>
        /// <returns></returns>
        public Base Buscar(string name)
        {
            Base temp = Primero;
            while (temp.Siguiente != null && name != temp.Nombre)
            {
                temp = temp.Siguiente;
                temp.Anterior = null;
            }
            if (temp.Nombre == name)
            {
                return temp;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Elimina la base con un nombre en especifico.
        /// </summary>
        /// <param name="Codigo">Nombre de la base.</param>
        public void Eliminar(string name)
        {
            Base temp = Primero;
            if (Primero.Nombre == name)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                while (temp.Siguiente != null && name != temp.Siguiente.Nombre)
                {
                    temp = temp.Siguiente;
                }
                if (temp.Siguiente != null)
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
        /// Inserta una base en la pocisión indicada
        /// </summary>
        /// <param name="pos">Pocisión de la base</param>
        /// <param name="producto">Una base</param>
        public void Insertar(int pos, Base station)
        {
            if (Primero.Anterior != Primero)
            {
                Agregar(station);
            }
            else
            {
                Base temp = Primero;
                for (int i = 0; i < pos - 1; i++)
                {
                    temp = temp.Siguiente;
                    station.Siguiente = temp.Siguiente;
                    temp.Siguiente = station;
                }
            }
        }
        /// <summary>
        /// Regresa el reporte de la ruta.
        /// </summary>
        /// <returns>Índice.</returns>
        public string Reporte()
        {
            string reporte = "";
            Base b = Primero;
            while (b != Primero)
            {
                reporte += b.ToString() + "\r\n";
                b = b.Siguiente;
            }
            return reporte;
        }
    }
}
