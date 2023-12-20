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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            if (mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo--;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            //15 + (6 * 2) + 1997 + 4 + 499 - 19 + 4 + 2 à 2514
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            string diaSemana = "";
            if (resultado == 0)
            {
                diaSemana = "SABADO";
            }
            else if (resultado == 1)
            {
                diaSemana = "DOMINGO";
            }else if (resultado == 2)
            {
                diaSemana = "LUNES";
            }else if (resultado == 3)
            {
                diaSemana = "MARTES";
            }else if (resultado == 4)
            {
                diaSemana = "MIERCOLES";
            }else if (resultado == 5)
            {
                diaSemana = "JUEVES";
            }else if (resultado == 6)
            {
                diaSemana = "VIERNES";
            }
            else
            {
                diaSemana = "ALGO FALLA";
            }
            this.lblDiaSemana.Text = diaSemana;
        }
    }
}
