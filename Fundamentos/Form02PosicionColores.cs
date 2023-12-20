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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosicionX.Text);
            int posY = int.Parse(this.txtPosicionY.Text);
            this.btnCambiarPosicion.Location =
                new Point(posX, posY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor de rojo debe estar entre 0 y 255");
            }else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor de verde debe ser entre 0 y 255");
            }else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor de azul debe estar entre 0 y 255");
            }
            else
            {
                this.BackColor =
                    Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}
