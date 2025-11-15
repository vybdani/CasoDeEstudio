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
        private string[] nombresEdificios = {
    "Entrada", "Edificio A", "Edificio B",
    "Edificio C", "Cafeteria"
    };
        private int[,] matrizAdyacencia;
    
    
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

            matrizAdyacencia = new int[,]
            {
                { 0, 10,  0, 15,  5 },
                { 10,  0,  5,  0,  0 },
                { 0,  5,  0, 20, 10 },
                { 15,  0, 20,  0,  0 },
                { 5,  0, 10,  0,  0 }
            };

            cbOrigen.Items.AddRange(nombresEdificios);
            cbDestino.Items.AddRange(nombresEdificios);
            cbOrigen.SelectedIndex = 0;
            cbDestino.SelectedIndex = 4;
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

        //Esta funcion si la saque de internet profe, no sabia como hacer que cambiara de color
        //aunque es mas que todo para que se viera lindo
        private void tvJerarquia_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == null) return;

            Color colorTexto;
            Brush brochaFondo;

            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                brochaFondo = new SolidBrush(Color.Tan);
                colorTexto = Color.Black;
            }
            else
            {
                brochaFondo = new SolidBrush(tvJerarquia.BackColor);
                colorTexto = tvJerarquia.ForeColor;
            }

            e.Graphics.FillRectangle(brochaFondo, e.Bounds);

            TextRenderer.DrawText(e.Graphics,
                                  e.Node.Text,
                                  tvJerarquia.Font,
                                  e.Bounds,
                                  colorTexto,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            brochaFondo.Dispose();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoRuta_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            if (cbOrigen.SelectedItem == null || cbDestino.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un origen y un destino.");
                return;
            }

            string origen = cbOrigen.SelectedItem.ToString();
            string destino = cbDestino.SelectedItem.ToString();

            if (origen == destino)
            {
                lblResultadoRuta.Text = "Ya estás en tu destino.";
                return;
            }

            string resultado = AlgoritmoDijkstra(origen, destino);
            lblResultadoRuta.Text = resultado;
        }

        // 4 horas pase investigando esta cosa y como se hacia este dijkstra
        private string AlgoritmoDijkstra(string nombreOrigen, string nombreDestino)
        {
            int numNodos = nombresEdificios.Length;
            int idxOrigen = Array.IndexOf(nombresEdificios, nombreOrigen);
            int idxDestino = Array.IndexOf(nombresEdificios, nombreDestino);

            int[] distancias = new int[numNodos];
            bool[] visitados = new bool[numNodos];
            int[] previo = new int[numNodos];

            for (int i = 0; i < numNodos; i++)
            {
                distancias[i] = int.MaxValue;
                visitados[i] = false;
                previo[i] = -1;
            }

            distancias[idxOrigen] = 0;

            for (int i = 0; i < numNodos - 1; i++)
            {
                int u = -1;
                int minDis = int.MaxValue;
                for (int v = 0; v < numNodos; v++)
                {
                    if (!visitados[v] && distancias[v] < minDis)
                    {
                        minDis = distancias[v];
                        u = v;
                    }
                }

                if (u == -1) break;

                visitados[u] = true;

                for (int v = 0; v < numNodos; v++)
                {
                    if (!visitados[v] && matrizAdyacencia[u, v] > 0)
                    {
                        int nuevaDistancia = distancias[u] + matrizAdyacencia[u, v];
                        if (nuevaDistancia < distancias[v])
                        {
                            distancias[v] = nuevaDistancia;
                            previo[v] = u;
                        }
                    }
                }
            }

            if (distancias[idxDestino] == int.MaxValue)
            {
                return $"No se encontró un camino de {nombreOrigen} a {nombreDestino}.";
            }

            string camino = "";
            int actual = idxDestino;
            while (actual != -1)
            {
                camino = nombresEdificios[actual] + (camino == "" ? "" : " -> " + camino);
                actual = previo[actual];
            }

            return $"Distancia: {distancias[idxDestino]} metros. \nRuta: {camino}";
        }

        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
