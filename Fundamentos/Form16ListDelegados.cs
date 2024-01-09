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
    public partial class Form16ListDelegados : Form
    {
        //LAS COLECCIONES SE SUELEN DECLARAR A NIVEL DE CLASE
        //POR SI NECESITAMOS UTILIZARLAS EN MULTIPLES METODOS
        List<Button> botones;
        int contador;

        public Form16ListDelegados()
        {
            InitializeComponent();
            //QUEREMOS INCLUIR TODOS LOS BOTONES DENTRO DE UNA COLECCION
            //POSTERIORMENTE, RECORRER DICHA COLECCION Y DELEGAR SU 
            //EVENTO CLICK
            //DENTRO DE FORMS TENEMOS UNA PROPIEDAD LLAMADA
            //CONTROLS QUE CONTIENE TODOS LOS CONTROLES DEL FORMULARIO
            //DICHA PROPIEDAD FUNCIONA POR CONTAINERS, ES DECIR, 
            //SI TENEMOS UN GROUPBOX, DEBEMOS RECORRER Controls DEL 
            //CONTENEDOR GROUPBOX
            //PODRIAMOS REALIZAR ESTO CON LA PROPIEDAD Controls, 
            //PERO POR NORMA SIEMPRE CREAREMOS NUESTRAS PROPIAS COLECCIONES
            this.botones = new List<Button>();
            this.contador = 0;
            //VAMOS A RECORRER TODOS CONTROLES DEL FORM
            foreach (Control control in this.Controls)
            {
                //DEBEMOS PREGUNTAR SI VIENEN BOTONES
                if (control is Button)
                {
                    //ALMACENAMOS NUESTROS BOTONES
                    this.botones.Add((Button)control);
                }
            }
            //A CONTINUACION, TRABAJAMOS CON NUESTRA COLECCION
            //RECORREMOS TODOS LOS BOTONES Y LOS ASOCIAMOS AL EVENTO
            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = "Contador: " + this.contador;
            //CUANDO PULSEMOS CUALQUIER BOTON QUIERO CAMBIAR SU COLOR
            //sender ES EL OBJETO QUE HA REALIZADO LA LLAMADA
            Button boton = (Button)sender;
            boton.BackColor = Color.Coral;
        }
    }
}
