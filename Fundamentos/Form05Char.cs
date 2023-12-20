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
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnRecorrerAscii_Click(object sender, EventArgs e)
        {
            string cadena = "hola coca cola";
            //h$la c$ca c$la
            string subcadena = cadena.Replace('o', '$');



            for (int i = 0; i <= 255; i++)
            {
                //CONVERTIMOS EL INT A CHAR
                char caracter = (char)i;
                if (char.IsLetter(caracter) == true)
                {
                    this.txtLetras.Text =
                        this.txtLetras.Text + caracter;
                }
                else if (char.IsNumber(caracter) == true)
                {
                    this.txtDigitos.Text += caracter;
                }else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += caracter;
                }else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
