using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Dalia
{
    public class Lista
    {
        Persona persona = new Persona();
        public Nodo primero = null;
        public Nodo ultimo = null;

        public void Incertar()
        {
            primero = ultimo = null;
        }
        public bool listaVacia()
        {
            if (primero.getsiguiente() != null)
            {
                return false;
            }
            return true;
        }

        //Buscar en la lista la persona con el nombre "Juan" y que devuelva un mensaje donde se diga la posicion en la que se encuentra o mensaje de que no se encuentra en caso contrario .
        public void BuscarPersona()
        {
            Console.WriteLine("Escriba el nombre de la presona que busca:");
            string nomabuscar = Console.ReadLine();
            while (primero.getsiguiente() != null)
            {
                Nodo temporal;
                int contador = 0;
                if(persona.nombre == nomabuscar)
                {
                    Console.WriteLine($"La persona se encuentra en la pocicion {contador + 1}");
                }
                else
                {
                    temporal= primero.getsiguiente();
                    contador++;
                }
            }
            Console.WriteLine("La persona no se encuentra");
        }
    }
}
