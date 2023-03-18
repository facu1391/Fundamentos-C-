namespace InterfazGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leer la caja de texto
            string nombre = textBox1.Text;
            label2.Text = $"Hola {nombre}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}