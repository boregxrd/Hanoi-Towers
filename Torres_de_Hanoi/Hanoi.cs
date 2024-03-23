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

            if ( numeroDiscosTotales % 2 == 0  ) { // el algoritmo cambia un poco dependiendo de si es par o impar
                while (fin.Size != numeroDiscosTotales) {

                    if (moverDiscoEntrePilas(ini, aux)) { // como se menciono en la funcion, dependiendo  
                        Console.WriteLine("Movemos disco de ini a aux"); // de sidevuelve true o false es 
                    } else {                                             // de A a B o viceversa.
                        Console.WriteLine("Movemos disco de aux a ini");
                    } movimientosIterativo++;
                    
                    if (fin.Size == numeroDiscosTotales) break; // para cada movimiento se verifica si ha terminado el juego

                    if(moverDiscoEntrePilas(ini, fin)) {
                        Console.WriteLine("Movemos disco de ini a fin");
                    } else {
                        Console.WriteLine("Movemos disco de fin a ini");
                    } movimientosIterativo++;

                    if (fin.Size == numeroDiscosTotales) break;

                    if (moverDiscoEntrePilas(aux, fin)) {
                        Console.WriteLine("Movemos disco de aux a fin");
                    } else {
                        Console.WriteLine("Movemos disco de fin a aux");
                    } movimientosIterativo++;

                }

            } else { // si es impar
                while (fin.Size != numeroDiscosTotales) {
                    
                    if (moverDiscoEntrePilas(ini, fin)) { 
                        Console.WriteLine("Movemos disco de ini a fin");
                    } else {
                        Console.WriteLine("Movemos disco de fin a ini");
                    } movimientosIterativo++;

                    if ( fin.Size == numeroDiscosTotales ) break;

                    if (moverDiscoEntrePilas(ini, aux)) {
                        Console.WriteLine("Movemos disco de ini a aux");
                    } else {
                        Console.WriteLine("Movemos disco de aux a ini");
                    } movimientosIterativo++; 
                    
                    if (fin.Size == numeroDiscosTotales ) break;

                    if (moverDiscoEntrePilas(aux, fin)) {
                        Console.WriteLine("Movemos disco de aux a fin");
                    } else {
                        Console.WriteLine("Movemos disco de fin a aux");
                    } movimientosIterativo++; 

                }
            }
            return movimientosIterativo;
        }

        int movimientosRecursivo = 0; //los movimientos en recursivo se declaran de forma global
                                      //porque si no se reescribirían constantemente
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {

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
        }

    }
}
