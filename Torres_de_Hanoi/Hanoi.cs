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
    public class Hanoi
    {
        //si devuelve true el disco se ha movido de la pila A a B
        //si devuelve false el disco se ha movido de la pila B a A
        public bool moverDiscoEntrePilas(Pila a, Pila b)
        {
            if (a.Top < b.Top)
            {
                if (a.isEmpty())
                {
                    a.push(b.pop());
                    return false;
                }
                else
                {
                    b.push(a.pop());
                    return true;
                }
            }
            else
            {
                if (b.isEmpty())
                {
                    b.push(a.pop());
                    return true;
                }
                else
                {
                    a.push(b.pop());
                    return false;
                }
            }
        }

        public int iterativo(int numeroDiscosTotales, Pila ini, Pila fin, Pila aux)
        {
            int movimientosIterativo = 0;

            if (numeroDiscosTotales % 2 == 0) // Si el número de discos es par
            {
                while (fin.Size != numeroDiscosTotales)
                {   
                    if (moverDiscoEntrePilas(ini, aux))
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de INI a AUX");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de AUX a INI");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }

                    if (fin.Size == numeroDiscosTotales)
                        break;

                    if (moverDiscoEntrePilas(ini, fin))
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de INI a FIN");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de FIN a INI");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }

                    if (fin.Size == numeroDiscosTotales)
                        break;

                    if (moverDiscoEntrePilas(aux, fin))
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de AUX a FIN");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de FIN a AUX");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                }
            }
            else // Si el número de discos es impar
            {
                while (fin.Size != numeroDiscosTotales)
                {
                    if (moverDiscoEntrePilas(ini, fin))
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de INI a FIN");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de FIN a INI");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }

                    if (fin.Size == numeroDiscosTotales)
                        break;

                    if (moverDiscoEntrePilas(ini, aux))
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de INI a AUX");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de AUX a INI");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }

                    if (fin.Size == numeroDiscosTotales)
                        break;

                    if (moverDiscoEntrePilas(aux, fin))
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de AUX a FIN");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Situación tras el movimiento " + ++movimientosIterativo + " de FIN a AUX");
                        Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                        Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                        Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                        Console.WriteLine();
                    }
                }
            }

            return movimientosIterativo;
        }


        int movimientosRecursivo = 0; //los movimientos en recursivo se declaran de forma global
                                      //porque si no se reescribirían constantemente

        public int recursivoConTexto(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 1)
            {
                moverDiscoEntrePilas(ini, fin);
                movimientosRecursivo++;
                Console.WriteLine("Situación tras el movimiento " + movimientosRecursivo);
                Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                Console.WriteLine();
            }
            else
            {
                recursivoConTexto(n - 1, ini, aux, fin);
                moverDiscoEntrePilas(ini, fin);
                movimientosRecursivo++;
                Console.WriteLine("Situación tras el movimiento " + movimientosRecursivo);
                Console.WriteLine("Pila INI: " + string.Join(", ", ini.obtenerContenidoPila()));
                Console.WriteLine("Pila AUX: " + string.Join(", ", aux.obtenerContenidoPila()));
                Console.WriteLine("Pila FIN: " + string.Join(", ", fin.obtenerContenidoPila()));
                Console.WriteLine();
                recursivoConTexto(n - 1, aux, fin, ini);
            }

            return movimientosRecursivo;
        }

        /*        public int recursivo(int n, Pila ini, Pila fin, Pila aux) {
            if (n == 1)
            {
                moverDiscoEntrePilas(ini, fin);
                movimientosRecursivo++;
            }
            else
            {
                recursivo(n-1, ini, aux, fin);
                moverDiscoEntrePilas(ini, fin);
                movimientosRecursivo++;
                recursivo(n-1, aux, fin, ini);
            }

            return movimientosRecursivo;
        }*/

    }
}
