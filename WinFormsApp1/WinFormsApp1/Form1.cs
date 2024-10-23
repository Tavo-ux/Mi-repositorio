namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente miCLiente = new Cliente();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            miCLiente.NombreCliente = txtNombreCliente.Text;
            miCLiente.NumeroTel = txtNumeroTel.Text;
            miCLiente.CorreoElectronico = txtCorreoElectronico.Text;
            dgvCliente.Rows.Add(miCLiente.NombreCliente, miCLiente.NumeroTel, miCLiente.CorreoElectronico);
            txtNombreCliente.Text = "";
            txtNumeroTel.Text = "";
            txtCorreoElectronico.Text = "";
        }
    }
}