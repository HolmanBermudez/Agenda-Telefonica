using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica
{
    class ArbolBinario
    {
        public Nodo Raiz;

        public ArbolBinario()
        {
            Raiz = null;
        }

        public void Insertar(ref Nodo raiz, string Nombre, string Apellido, char Sexo, int Telefono)
        {
            raiz = InsertarReg(ref raiz, Nombre, Apellido, Sexo, Telefono);
        }
        public Nodo InsertarReg(ref Nodo Raiz, string Nombre, string Apellido, char Sexo, int Telefono)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo(Nombre, Apellido, Sexo, Telefono);
                return Raiz;
            }
            if (Sexo == 'F')
            {
                Raiz.Left = InsertarReg(ref Raiz.left, Nombre, Apellido, Sexo, Telefono);
            }
            if (Sexo == 'M')
            {
                Raiz.Right = InsertarReg(ref Raiz.right, Nombre, Apellido, Sexo, Telefono);
            }
            return Raiz;

        }
        public void PrintInOrder(Nodo Raiz)
        {
            if (Raiz != null)
            {

                PrintInOrder(Raiz.Left);
                Console.WriteLine($"Nombre: {Raiz.Nombre}, Cost: {Raiz.Apellido}, Telefono {Raiz.Telefono}");
                PrintInOrder(Raiz.Right);

            }
        }
        public void PrintPreOrder(Nodo Raiz)
        {
            if (Raiz != null)
            {
                Console.WriteLine($"Nombre: {Raiz.Nombre}, Apellido: {Raiz.Apellido}, Telefono {Raiz.Telefono}");
                PrintPreOrder(Raiz.Left);
                PrintPreOrder(Raiz.Right);

            }
        }
        public void PrintPostOrder(Nodo Raiz)
        {
            if (Raiz != null)
            {

                PrintPostOrder(Raiz.Left);
                PrintPostOrder(Raiz.Right);
                Console.WriteLine($"Nombre: {Raiz.Nombre}, Apellido: {Raiz.Apellido}, Telefono {Raiz.Telefono}");

            }
        }
        public Nodo BuscarNodo(Nodo aux, string dato)
        {
            if (aux == null)
            {
                return null;
            }
            if (string.Compare(dato, aux.Nombre) == 0)
            {
                return Raiz;
            }
            else if (string.Compare(dato, aux.Nombre) > 0)
            {
                return BuscarNodo(aux.Right, dato);
            }
            else
            {
                return BuscarNodo(aux.Left, dato);
            }
        }
        public Nodo Eliminar(Nodo ini, string dato)
        {
            if (ini == null)
            {
                return ini;
            }
            if (string.Compare(dato, ini.Nombre) < 0)
            {
                ini.Left = Eliminar(ini.Left, dato);
            }
            else if (string.Compare(dato, ini.Nombre) > 0)
            {
                ini.Right = Eliminar(ini.Right, dato);
            }
            else
            {
                if (ini.Left == null)
                {
                    return ini.Right;
                }
                else if (ini.Right == null)
                {
                    return ini.Left;
                }
            }
            return ini;
        }
    }
}
