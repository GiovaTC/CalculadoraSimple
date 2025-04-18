namespace CalculadoraSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Items.AddRange(new string[] { "+", "-", "*", "/" });
            cmbOperacion.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNumero1.Text);
                double num2 = Convert.ToDouble(txtNumero2.Text);
                string operacion = cmbOperacion.SelectedItem.ToString();
                double resultado = 0;

                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                           resultado = num1 / num2;
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero.");
                            return;
                        }
                        break;
                }

                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos");
            }
        }
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
