using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Con_ObjetoPersona
{
    public class Nodo
    {
        public Persona _datos;
        public Nodo _Siguiente;

        public Nodo (Persona valor)
        {
            _datos = valor;
            _Siguiente = null;
        }
        public Nodo(Persona valor, Nodo siguiente)
        {
            _datos=valor;
            _Siguiente = siguiente;
        }
        public Persona getDatos()
        {
            return _datos;
        }
        public Nodo getSiguiente()
        {
            return _Siguiente;
        }
    }
}
