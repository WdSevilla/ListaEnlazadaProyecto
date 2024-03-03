using ListaEnlazadaProyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaProyecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lista listanueva = new Lista();
            char opcion;
            do
            {
                Console.WriteLine("Menu de opciones:");
                Console.WriteLine("a. Insertar al Frente");
                Console.WriteLine("b. Insertar al Final");
                Console.WriteLine("c. Insertar en una posición específica");
                Console.WriteLine("d. Eliminar al Frente");
                Console.WriteLine("e. Eliminar al Final");
                Console.WriteLine("f. Mostrar lista");
                Console.WriteLine("g. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (opcion)
                {
                    case 'a':
                        Console.Write("Ingrese el valor a insertar al frente: ");
                        int valorFrente = int.Parse(Console.ReadLine());
                        listanueva.Insertar(valorFrente);
                        break;
                    case 'b':
                        Console.Write("Ingrese el valor a insertar al final: ");
                        int valorFinal = int.Parse(Console.ReadLine());
                        listanueva.InsertarF(valorFinal);
                        break;
                    case 'c':
                        Console.Write("Ingrese el valor a insertar: ");
                        int valorPosicion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la posición donde desea insertar: ");
                        int posicion = int.Parse(Console.ReadLine());
                        listanueva.InsertarEnPosicion(valorPosicion, posicion);
                        break;
                    case 'd':
                        listanueva.Eliminar();
                        break;
                    case 'e':
                        listanueva.EliminarF();
                        break;
                    case 'f':
                        listanueva.Mostrar();
                        break;
                    case 'g':
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 'g');
        }
    }
    
}
