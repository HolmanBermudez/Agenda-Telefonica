using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class Form1 : Form
    {
        public Nodo raiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            ArbolBinario ar = new ArbolBinario();
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            char Sexo = Convert.ToChar(txtSexo.Text);
            int Telefono = int.Parse(txtTelefono.Text);
            ar.Insertar(ref raiz, Nombre, Apellido, Sexo, Telefono);
            Actualizar();

        }
        public void CrearArbolTreeview(Nodo nodo, TreeNode nodosarbol)
        {
            if (nodo.Left != null)
            {
                TreeNode leftNode = new TreeNode(nodo.Left.Nombre);
                nodosarbol.Nodes.Add(leftNode);
                CrearArbolTreeview(nodo.Left, leftNode);
            }
            if (nodo.Right != null)
            {
                TreeNode rightNode = new TreeNode(nodo.Right.Nombre);
                nodosarbol.Nodes.Add(rightNode);
                CrearArbolTreeview(nodo.Right, rightNode);
            }
        }
        public void Actualizar()
        {
            //TreeNode ar = new TreeNode(raiz.Nombre);
            Mostar.Nodes.Clear();
            if (raiz != null)
            {
                TreeNode nodoraiz = new TreeNode(raiz.Nombre);
                CrearArbolTreeview(raiz, nodoraiz);
                Mostar.Nodes.Add(nodoraiz);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArbolBinario ar = new ArbolBinario();
            string bus;
            bus = txtBuscar.Text;
            if (ar.BuscarNodo(raiz, bus) != null) 
            {
                MessageBox.Show("El valor esta dentro del arbol");
            }
            else
            {
                MessageBox.Show("El valor no se encuentra dentro del arbol");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ArbolBinario ar = new ArbolBinario();
            string eli;
            eli = txtEliminar.Text;
            ar.Eliminar(raiz, eli);
            Actualizar();
            MessageBox.Show("El valor sea Eliminado");

        }
    }
}
