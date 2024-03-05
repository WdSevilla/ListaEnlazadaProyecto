using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaProyecto.Clases
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
            if (posicion == 1)
            {
                Insertar(item);
                return;
            }

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = item;
            Nodo puntero = inicio;
            int contador = 1;

            while (contador < posicion - 1 && puntero != null)
            {
                puntero = puntero.siguiente;
                contador++;
            }

            if (puntero == null)
            {
                Console.WriteLine("La posición especificada excede la longitud de la lista. Insertando al final.");
                InsertarF(item);
            }
            else
            {
                nuevoNodo.siguiente = puntero.siguiente;
                puntero.siguiente = nuevoNodo;
            }
        }

        //eliminar el primer nodo de la lista 
        public void Eliminar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La Lista está vacía.");
            }
            else
            {
                inicio = inicio.siguiente;
                Console.WriteLine("Se ha eliminado el primer nodo");
            }
        }

        //eliminar el último nodo de la lista
        public void EliminarF()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacía no se puede eliminar.");
            }
            else if (inicio.siguiente == null)
            {
                inicio = null;
            }
            else
            {
                Nodo puntero = inicio;
                while (puntero.siguiente.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = null;
                Console.WriteLine("Se ha eliminado el ultimo nodo");
            }
        }

        //mostrar la lista
        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Nodo puntero = inicio;
                Console.Write("{0} -> \t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> \t", puntero.dato);
                }
                Console.WriteLine();
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
    }
}
