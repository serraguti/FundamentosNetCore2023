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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            //SIEMPRE ESCRIBIREMOS DESPUES DE ESTE METODO
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void chkCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkCambiarFormato.Checked == true)
            {
                this.txtFechaActual.Text =
                    fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text =
                    fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            int incremento = int.Parse(this.txtIncremento.Text);
            if (this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if (this.rdbAnyos.Checked == true)
            {
                fecha = fecha.AddYears(incremento);
            }else
            {
                fecha = fecha.AddMonths(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
