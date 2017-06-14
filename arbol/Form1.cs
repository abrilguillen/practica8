using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol
{
    public partial class frmArbolBinario : Form
    {
        Arbol miArbol = new Arbol();
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miArbol.agregar(new Nodo(int.Parse(txtAgregar.Text)));
            txtAgregar.Clear();
            txtAgregar.Focus();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Nodo miNodo = miArbol.buscar(int.Parse(txtAgregar.Text));

            if(miNodo != null)
            {//.dato para saber que valor tiene miNodo
                txtMostrar.Text = miNodo.dato.ToString();
            }
            else
            {
                txtMostrar.Text = "No se encontró";
            }
        }

        private void cmdIN_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miArbol.inOrden();
        }

        private void cmdPRE_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miArbol.preOrden();
        }

        private void cmdPOST_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miArbol.postOrden();
        }
    }
}
