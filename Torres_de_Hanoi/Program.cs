// Manuel Borregales
// Mario Luis Mesa
// Algoritmica y Matematicas para videojuegos
// Practica 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            int cantidadDiscos = 0;
           
            Console.WriteLine("Bienvenido al juego de las Torres de Hanoi");
            
            bool cantidadValida = false;
            while (!cantidadValida)
            {
                Console.WriteLine("Indica el número de discos para 3 torres...");
                try
                {
                    cantidadDiscos = int.Parse(Console.ReadLine());
                    if (cantidadDiscos < 1)
                    {
                        Console.WriteLine("Debes indicar un número mayor a uno.");
                    }
                    else
                    {
                        cantidadValida = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes ingresar un número válido.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error: " + e.Message);
                }
            }


            for (int i = cantidadDiscos; i >= 1; i--)
            {
                try
                {
                    ini.push(new Disco(i));
                }
                catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un error al agregar los discos a la pila");
                }
            }

            Hanoi hanoi = new Hanoi();
            int movimientosHechos = 0;
            char opcion;

            do
            {
                Console.WriteLine("Indica I para Iterativo o R para Recursivo...");
                opcion = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (opcion)
                {
                    case 'I':
                        Console.WriteLine("Has elegido el algoritmo iterativo");
                        Console.WriteLine();
                        Console.WriteLine("Situación inicial: ");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                        movimientosHechos = hanoi.iterativo(cantidadDiscos, ini, fin, aux);
                        break;
                    case 'R':
                        Console.WriteLine("Has elegido el algoritmo recursivo");
                        Console.WriteLine();
                        Console.WriteLine("Situación inicial: ");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                        movimientosHechos = hanoi.recursivoConTexto(cantidadDiscos, ini, fin, aux);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            } while (opcion != 'I' && opcion != 'R');

            double movimientoRequeridos = Math.Pow(2, cantidadDiscos) - 1;

            Console.WriteLine("Resuelto en " + movimientosHechos + " movimientos");
            Console.WriteLine("Número de movimentos necesarios mínimos: " + movimientoRequeridos);
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
