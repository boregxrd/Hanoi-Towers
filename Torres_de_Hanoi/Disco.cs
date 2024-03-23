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
    //getter y setter de valor, variable que
    //indica el valor del disco en cuestión
    public class Disco {
        public int Valor { get; set; }

        public Disco(int valor) {
            Valor = valor; 
        }
    }
}
