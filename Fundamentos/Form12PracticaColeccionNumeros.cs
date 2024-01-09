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
    public partial class Form12PracticaColeccionNumeros : Form
    {
        public Form12PracticaColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                var aleat = random.Next(1, 300);
                this.lstNumeros.Items.Add(aleat);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach (int num in this.lstNumeros.Items)
            {
                suma += num;
                if (num % 2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }
            this.txtImpares.Text = sumaImpares.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtSuma.Text = suma.ToString();
        }
    }
}
