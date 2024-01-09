using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //CAMBIAMOS A SELECCION MULTIPLE
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            foreach (int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndiceSeleccionado.Text = indices.Trim(',');
            string items = "";
            foreach (string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblSeleccionado.Text = items.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //AL ELIMINAR MULTIPLES ELEMENTOS DE UNA COLECCION
            //SIEMPRE DEBEMOS HACERLO DESDE EL ULTIMO AL PRIMERO 
            //POR EL REPOSICIONAMIENTO DE LOS INDICES
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;

            //RECORREMOS LOS INDICES SELECCIONADOS
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //RECUPERAMOS CADA INDICE
                int indice = this.lstElementos.SelectedIndices[i];
                //ELIMINAMOS CADA ELEMENTO POR SU INDICE DE LA COLECCION
                this.lstElementos.Items.RemoveAt(indice);
            }
        }
    }
}
