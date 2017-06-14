using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    class Nodo
    {
        public int dato {get; set;}
        public Nodo hijoIzq;
        public Nodo hijoDer;

        public Nodo(int dato)
        {
            this.dato = dato;
        }

        public override string ToString()
        {
            return "dato: " + dato;
        }
    }
}
