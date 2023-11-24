using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Con_ObjetoPersona
{
    public class Lista
    {
      private  Nodo primero;
      private  Nodo ultimo;
      
        public Lista()
        {
            primero = ultimo = null;
        }
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }
        public void InsertarPersona()
        {
            Console.WriteLine("Ingrese el nuevo nombre:");
            string nuevoNombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva edad:");
            int nuevaEdad = int.Parse(Console.ReadLine());

            Persona nuevaPersona = new Persona(nuevoNombre, nuevaEdad);
            Nodo nuevoNodo = new Nodo(nuevaPersona);

            if (ListaVacia())
            {
                primero = nuevoNodo;
            }
            else
            {
                Nodo actual = primero;
                while (actual.getSiguiente() != null)
                {
                    actual = actual.getSiguiente();
                }

                actual._Siguiente = nuevoNodo;
            }

            Console.WriteLine("Persona insertada correctamente.");
        }

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"Nombre: {actual.getDatos().Nombre}, Edad: {actual.getDatos().Edad}");
                    actual = actual.getSiguiente();
                }
               
            }
        }
        public void BuscarPersona(string nombre)
        {
            bool encontrado = false;
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.getDatos().Nombre == nombre)
                    {
                        Console.WriteLine("Persona encontrada: " + actual.getDatos().Nombre);
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra la persona con el nombre proporcionado.");
                }
            }
        }
        public void InsertarInicio(int elemento)
        {
            //HACIENDO UNA INSTANCIA NODO PARA INSERTAR
            Nodo nuevoNodo = new Nodo(elemento);


            if (ListaVacia())
            {
                //COMO TENEMOS LA LISTA VACIA NO TENEMOS SEGUNDO NUMERO
                //LO QUE FACILITA YA QUE EL PRIMERO VA A HACER EL PRIMERO
                //Y EL ULTIMO, EN OTRAS PALABRAS
                //EL NUMERO DEL PRIMERO SERA AL NUEVO NODO

                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                //EL NUMERO QUE TIENE ACTUAL EL NODO
                //VA A HACER IGUAL AL SIGUIENTE Y SE GUARDARA
                //EN PRIMER NODO
                nuevoNodo._Siguiente = primero;
            }
        }

        public void EliminarPrimerElemento()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

         else if (primero.getSiguiente() == null)
            {
                // Solo hay un elemento en la lista
                primero = ultimo = null;
            }
            else
            {
                // Hay más de un elemento en la lista
                primero = primero.getSiguiente();
            }

            Console.WriteLine("Primer elemento eliminado correctamente.");
        }
        public void EliminarUltimoElemento()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacía. No hay elementos para eliminar.");
                return;
            }

            if (primero.getSiguiente() == null)
            {
                // Solo hay un elemento en la lista
                primero = ultimo = null;
            }
            else
            {
                Nodo actual = primero;

                while (actual.getSiguiente() != null)
                {
                    actual = actual.getSiguiente();
                }

                // Actualiza el puntero "_Siguiente" y elimina el último nodo
                actual._Siguiente = null;
                ultimo = actual;
            }

            Console.WriteLine("Último elemento eliminado correctamente.");
        }

    }
}
