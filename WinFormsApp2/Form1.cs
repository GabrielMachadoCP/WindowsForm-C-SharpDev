namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            int aumentoLargura = 100; // Aumentar largura
            int aumentoAltura = 40;  // Aumentar altura

            // Ajustar posição antes de aumentar o tamanho
            button1.Left -= aumentoLargura / 2;
            button1.Top -= aumentoAltura / 2;

            // Aumentar o tamanho do botão
            button1.Width += aumentoLargura;
            button1.Height += aumentoAltura;

            button1.Text = "Encerrando Programa...";
            await Task.Delay(5000); // Aguarda 5 segundos
            Application.Exit(); // Fecha o programa
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
