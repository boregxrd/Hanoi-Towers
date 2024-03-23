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
    public class Pila
    {
        public int Size { get; set; } // Numero de discos que tiene la pila
        public int Top { get; set; } // Valor del disco más alto en la pila

        public List<Disco> Discos = new List<Disco>(); 

        public void push(Disco disco) {
            Discos.Add(disco);
            Top = disco.Valor;
            Size++;
        }

        public Disco pop() {
            Disco discoEliminado = Discos[Size - 1];
            Discos.Remove(Discos[Size - 1]);
            Size--;
            if (Size == 0) { // La pila está vacía?
                Top = 0; 
            } else { 
                Top = Discos[Size - 1].Valor; 
            }
            return discoEliminado;
        } 
            
        public bool isEmpty() {
            if (Size == 0) return true;
            return false;
        }
    }
}
