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
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //PARA PODER ELIMINAR DE UNA COLECCION TENEMOS DOS OPCIONES
            //1) Remove(objeto): Elimina un elemento enviando el objeto
            //2) RemoveAt(indice): elimina un elemento por su índice
            //RECUPERAMOS EL INDICE SELECCIONADO DEL LISTBOX
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndiceSeleccionado.Text =
                    this.lstElementos.SelectedIndex.ToString();
                this.lblSeleccionado.Text =
                    this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
