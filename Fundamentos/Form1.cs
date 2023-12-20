using System.Data;
namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //PROPIEDAD CON LLAVE INGLESA
            string texto;
            DataTable fichero;

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIREMOS AQUI
            this.txtNombre.Location = new Point(78, 10);
            //TENEMOS PROPIEDADES DE TIPOS DE DATOS PRIMITIVOS
            //LOS PRIMITIVOS, DIRECTAMENTE SE ESCRIBEN
            this.txtNombre.Text = "Soy un texto";
            this.txtNombre.Width = 180;
            //ESTO ES UNA EXCEPCION EN LA NORMA
            //TENER UNA CLASE ESTRUCTURA O FINAL
            //NO SE INSTANCIA, SE UTILIZA.
            //POR EJEMPLO, LA CLASE COLOR
            this.BackColor = Color.ForestGreen;
            //PONGAMOS QUE DESEAMOS ALINEAR EL TEXTO DE UNA CAJA
            this.txtNombre.TextAlign = HorizontalAlignment.Right;
            this.txtNombre.Text = "Hola mundo";

            int mayor = 888;
            short pequeño = (short)mayor;




        }
    }
}
