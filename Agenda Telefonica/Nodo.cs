using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica
{
    public class Nodo
    {
        public string nombre;
        public string apellido;
        public char sexo;
        public int telefono;
        public Nodo left;
        public Nodo right;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public Nodo Left { get => left; set => left = value; }
        public Nodo Right { get => right; set => right = value; }

        public Nodo(string nombre, string apellido, char sexo, int telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Telefono = telefono;
            Left = null;
            Right = null;
        }
    }
}
