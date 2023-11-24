using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Dalia
{
    public class Nodo
    {
        private Persona _dato;
        private Nodo _siguiente;

        public Nodo(Persona persona)
        {
            _dato = persona;
            _siguiente = null;
        }
         public Nodo(Persona persona, Nodo sigiente)
        {
            _dato= persona;
            _siguiente = sigiente;
        }

        public Persona getdato()
        {
            return _dato;
        }

        public Nodo getsiguiente()
        {
            return _siguiente;
        }
    }
}
