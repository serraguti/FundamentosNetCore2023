using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
           InitializeComponent();
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        //RECIBIMOS EL PARAMETRO WRAPPER POR VALOR
        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //TANTO EN EL METODO COMO EN LA LLAMADA, DEBEMOS 
            //UTILIZAR LA PALABRA ref
            int doble = this.GetDobleOk(numero);
            //this.GetDobleReferencia(ref numero);
            this.lblResultado.Text = doble.ToString();
        }

        int GetDobleOk(int num)
        {
            int doble = num * 2;
            return doble;
        }

        void GetDobleReferencia(ref int num)
        {
            num = num * 2;
        }

        void MetodoEvento(object sender, EventArgs e)
        {

        }

        private void Form14Metodos_Load(object sender, EventArgs e)
        {

        }

        private void Form14Metodos_FormClosed(object sender
            , FormClosedEventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender
            , MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender
            , KeyPressEventArgs e)
        {
            //HANDLED DESACTIVA LOS EVENTOS SUCESIVOS DEL METODO
            //KEYCHAR ES LA TECLA PULSADA
            char teclaBorrar = (char)Keys.Back;
            this.lblResultado.Text = e.KeyChar.ToString();
            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            this.lblResultado.Text = e.KeyChar.ToString();
            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
