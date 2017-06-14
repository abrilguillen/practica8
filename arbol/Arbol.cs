using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    class Arbol
    {
        public Nodo raiz { get; set; }

        public void agregar(Nodo nuevo)
        {
            if(raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                _agregar(nuevo, raiz);
            }
        }

        private void _agregar(Nodo nuevo, Nodo padre)
        {
            if(nuevo.dato < padre.dato)
            {//validar si la izq está vacia
                if(padre.hijoIzq == null)//si el primer espacio a la izq está vacio
                {
                    padre.hijoIzq = nuevo;
                }
                else//que siga buscando hasta que el hijoIzq sea nulo
                {
                    _agregar(nuevo, padre.hijoIzq);
                }
            }
            else
            {
                if(nuevo.dato > padre.dato)
                {
                    if(padre.hijoDer == null)
                    {
                        padre.hijoDer = nuevo;
                    }
                    else
                    {
                        _agregar(nuevo, padre.hijoDer);
                    }
                }
            }
        }

        public Nodo buscar(int datoABuscar)
        {//se compara la raiz
            if(raiz != null)
            {
                return _buscar(raiz, datoABuscar);
            }

            return null;
        }
        
        private Nodo _buscar(Nodo padre, int datoABuscar)
        {//se comparan los hijos y los padres
            if(padre != null)
            {
                if(datoABuscar == padre.dato)// si es igual que el primero
                {
                    return padre;
                }

                else if (datoABuscar > padre.dato && padre.hijoDer != null)//si es igual que un 
                {
                    return _buscar(padre.hijoDer, datoABuscar);
                }

                else if (datoABuscar < padre.dato  && padre.hijoIzq != null)
                {
                    return _buscar(padre.hijoIzq, datoABuscar);
                }
            }

            return null;
        }

        public string inOrden()//izq-raiz-der
        {
            if(raiz != null)
            {
                return _inOrden(raiz);
            }
            return "no hay nada";
        }

        private string _inOrden(Nodo padre)
        {
            string numerosIn = " ";
            if (padre != null)
            {
                if (padre.hijoIzq != null)//va recorriendo todos los izquierdos
                {
                    numerosIn += _inOrden(padre.hijoIzq);
                }

                numerosIn += padre.dato + ",";//aqui ya llegó a la raíz

                if (padre.hijoDer != null)//aqui ya está en los de la derecha
                {
                    numerosIn += _inOrden(padre.hijoDer);
                }
            }
            return numerosIn;
        }

        public string preOrden()//raiz-der-izq
        {
            if (raiz != null)
            {
                return _preOrden(raiz);
            }
            return "no hay nada";
        }

        private string _preOrden(Nodo padre)
        {
            string numerosPre = " ";

            numerosPre += padre.dato + ",";

            if (padre.hijoIzq != null)//va recorriendo todos los izquierdos
            {
                numerosPre += _preOrden(padre.hijoIzq);
            }

            if (padre.hijoDer != null)//aqui ya está en los de la derecha
            {
                numerosPre += _preOrden(padre.hijoDer);
            }
            return numerosPre;
        }

        public string postOrden()//izq- der - raiz
        {
            if (raiz != null)
            {
                return _postOrden(raiz);
            }
            return "no hay nada";
        }

        private string _postOrden(Nodo padre)
        {
            string numerosPost = " ";

            if (padre.hijoIzq != null)//va recorriendo todos los izquierdos
            {
                numerosPost += _postOrden(padre.hijoIzq);
            }

            if (padre.hijoDer != null)//aqui ya está en los de la derecha
            {
                numerosPost += _postOrden(padre.hijoDer);
            }

            numerosPost += padre.dato + ",";//aqui ya llegó a la raíz

            return numerosPost;
        }
    }
}
