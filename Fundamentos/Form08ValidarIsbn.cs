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
    public partial class Form08ValidarIsbn : Form
    {
        public Form08ValidarIsbn()
        {
            InitializeComponent();
        }

        private void btnValidarIsbn_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            if (isbn.Length != 10)
            {
                this.lblMensaje.Text = "El ISBN debe tener 10 caracteres";
            }
            bool textIsNumber = true;
            for (int i = 0; i < isbn.Length; i++)
            {
                char caracter = isbn[i];
                if (char.IsDigit(caracter) == false)
                {
                    textIsNumber = false;
                    break;
                }
            }
            if (textIsNumber == false)
            {
                this.lblMensaje.Text = "El ISBN debe contener solo números";
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int multiplicacion = numero * (i + 1);
                    suma += multiplicacion;
                }
                if (suma%11 == 0)
                {
                    this.lblMensaje.Text = "ISBN correcto";
                }
                else
                {
                    this.lblMensaje.Text = "El ISBN introducido no es válido";
                }
            }
        }
    }
}
