using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1Form.Clases
{
    public class Lista
    {
        public Nodo inicio; //cabeza de la lista

        //constructor por defecto
        public Lista()
        {
            inicio = null;
        }

        //inserta al final de la lista
        public void InsertarF(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }

        //insertar al inicio
        public void Insertar(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = inicio;
            inicio = auxiliar;
        }

        //insertar en una posición específica
        public void InsertarEnPosicion(int item, int posicion)
        {
            if (posicion <= 0)
            {
                Console.WriteLine("La posición debe ser mayor que cero.");
                return;
            }

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = item;

            if (posicion == 1 || inicio == null)
            {
                nuevoNodo.siguiente = inicio;
                inicio = nuevoNodo;
                return;
            }

            Nodo puntero = inicio;
            int contador = 1;

            while (contador < posicion - 1 && puntero.siguiente != null)
            {
                puntero = puntero.siguiente;
                contador++;
            }

            nuevoNodo.siguiente = puntero.siguiente;
            puntero.siguiente = nuevoNodo;
        }

        //eliminar nodo de la lista 
        public void EliminarDato(int item)
        {
            // Si el dato a eliminar es el primer elemento de la lista
            if (inicio != null && inicio.dato == item)
            {
                inicio = inicio.siguiente;
                return;
            }

            // Buscar el nodo anterior al que contiene el dato a eliminar
            Nodo anterior = inicio;
            while (anterior.siguiente != null && anterior.siguiente.dato != item)
            {
                anterior = anterior.siguiente;
            }

            // Si se encontró el nodo anterior, se enlaza con el siguiente nodo al que contiene el dato a eliminar
            if (anterior.siguiente != null)
            {
                anterior.siguiente = anterior.siguiente.siguiente;
            }
        }

        //insertar en forma ascendente
        public void InsertarAscendente(int item)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = item;

            if (inicio == null || item <= inicio.dato)
            {
                nuevoNodo.siguiente = inicio;
                inicio = nuevoNodo;
            }
            else
            {
                Nodo puntero = inicio;
                while (puntero.siguiente != null && puntero.siguiente.dato < item)
                {
                    puntero = puntero.siguiente;
                }
                nuevoNodo.siguiente = puntero.siguiente;
                puntero.siguiente = nuevoNodo;
            }
        }
        public IEnumerable<int> ObtenerDatos()
        {
            List<int> datos = new List<int>();
            Nodo puntero = inicio;
            while (puntero != null)
            {
                datos.Add(puntero.dato);
                puntero = puntero.siguiente;
            }
            return datos;
        }

    }
}
