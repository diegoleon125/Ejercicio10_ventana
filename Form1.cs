namespace Ejercicio10_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float consum = float.Parse(txtconsum.Text);
            float descuento;
            if (consum > 100)
            {
                descuento = consum * 0.20f;
            }
            else
            {
                descuento = consum * 0.10f;
            }
            lblDesc.Text =     "monto del descuento:     " + descuento;
            float subtotal = consum - descuento;
            lblSubtotal.Text = "subtotal:                          " + subtotal;
            float impuesto = (subtotal) * 0.18f;
            lblImpuesto.Text = "monto del impuesto:     " + impuesto;
            float aPagar = consum - descuento + impuesto;
            lblaPagar.Text = "importe final a pagar:   " + aPagar;
        }
    }
}