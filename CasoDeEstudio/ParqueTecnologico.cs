using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoDeEstudio
{
    public partial class ParqueTecnologico : Form
    {
        public ParqueTecnologico()
        {
            InitializeComponent();
        }

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            if (txtPuesto.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del puesto.");
                return;
            }

            TreeNode nodoSeleccionado = tvJerarquia.SelectedNode;
            TreeNode nuevoNodo = new TreeNode(txtPuesto.Text);

            if (nodoSeleccionado == null)
            {
                tvJerarquia.Nodes.Add(nuevoNodo);
            }
            else
            {
                nodoSeleccionado.Nodes.Add(nuevoNodo);
                nodoSeleccionado.Expand();
            }
            txtPuesto.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tvJerarquia.Nodes.Count == 0)
            {
                tvJerarquia.Nodes.Add("Presidente (CEO)");
            }
        }

        private void btnBorrarSelecionado_Click(object sender, EventArgs e)
        {
            TreeNode nodoSeleccionado = tvJerarquia.SelectedNode;
            if (nodoSeleccionado != null)
            {
                if (nodoSeleccionado.Parent == null)
                {
                    MessageBox.Show("No puede borrar el nodo raíz");
                }
                else
                {
                    nodoSeleccionado.Remove();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un puesto para borrar");
            }
        }

        private void btnContarPuestos_Click(object sender, EventArgs e)
        {
            TreeNode nodoSeleccionado = tvJerarquia.SelectedNode;

            if (nodoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un puesto para empezar a contar");
                return;
            }

            int totalDescendientes = nodoSeleccionado.GetNodeCount(true);
            int totalContado = 1 + totalDescendientes;

            MessageBox.Show($"Total de puestos (desde '{nodoSeleccionado.Text}'): {totalContado}");
        }

        private void btnBuscarPuesto_Click(object sender, EventArgs e)
        {
            string puestoBuscado = txtPuesto.Text;
            if (puestoBuscado == "") return;

            AsignarNombresATodosLosNodos(tvJerarquia.Nodes);

            TreeNode[] nodosEncontrados = tvJerarquia.Nodes.Find(puestoBuscado, true);

            if (nodosEncontrados.Length > 0)
            {
                tvJerarquia.SelectedNode = nodosEncontrados[0];
                tvJerarquia.Focus();
                tvJerarquia.SelectedNode.EnsureVisible();
            }
            else
            {
                MessageBox.Show("Puesto no encontrado.");
            }
        }
        private void AsignarNombresATodosLosNodos(TreeNodeCollection nodos)
        {
            foreach (TreeNode nodo in nodos)
            {
                nodo.Name = nodo.Text;
                if (nodo.Nodes.Count > 0)
                {
                    AsignarNombresATodosLosNodos(nodo.Nodes);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tvJerarquia_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void txtPuesto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
