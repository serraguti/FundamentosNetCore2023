using System;
using System.Collections;
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
    public partial class Form15ArrayList : Form
    {
        void MetodoDelegado(object sender, EventArgs e)
        {

        }

        public Form15ArrayList()
        {
            //EL DISEÑADOR NOS AYUDA A CREAR METODOS DELEGADOS 
            //MEDIANTE LA TECLA TAB
            //this.button1.Click += Button1_Click;

            InitializeComponent();
            //DECLARAMOS UNA COLECCION GENERICA
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //ACCEDEMOS DIRECTAMENTE A LAS PROPIEDADES DEL OBJETO
            botones[1].BackColor = Color.Yellow;
            //TENEMOS ERRORES EN COMPILACION
            //botones.Add(this.textBox1);

            //COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //AÑADIMOS UN TEXTBOX A LA COLECCION
            coleccion.Add(this.textBox1);
            //SI INTENTAMOS ACCEDER A LAS PROPIEDADES, NO PODREMOS
            //DEBEMOS REALIZAR EL CASTING PARA PODER APLICAR SUS PROPIEDADES
            ((Button)coleccion[0]).Text = "Soy un botón";
            //MEDIANTE LA ABSTRACCION, PODEMOS RECORRER TODOS LOS ELEMENTOS
            //DE UNA COLECCION UTILIZANDO UNA CLASE EN COMUN
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.Yellow;
            //}
            //SI TENEMOS OBJETOS QUE NO SEAN DE LA MISMA FAMILIA DIRECTA
            //DEBEMOS ENCONTRAR SU FAMILIA EN COMUN MEDIANTE ABSTRACCION
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.LightGreen;
                //DENTRO DE LA ABSTRACCION, PODEMOS CONVERTIR 
                //A SU CLASE BASE PARA APLICAR SUS PROPIEDADES O METODOS
                //DESEAMOS UTILIZAR EL METODO Paste() DEL CONTROL TextBox
                //PREGUNTAMOS POR LA CLASE DEL OBJETO
                if (control is TextBox)
                {
                    //REALIZAMOS UN CASTING PARA APLICAR SOBRE EL OBJETO
                    ((TextBox)control).Paste();
                }
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
