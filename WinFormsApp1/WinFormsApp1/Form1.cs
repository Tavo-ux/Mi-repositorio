namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario miInventar = new Inventario();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            miInventar.CantidadInventario = int.Parse(txtCantidad.Text);
            miInventar.IdProducto = txtID.Text;
            miInventar.NombreProducto = txtProducto.Text;

            dgvInventario.Rows.Add(miInventar.NombreProducto, miInventar.CantidadInventario, miInventar.IdProducto);

            txtProducto.Text = "";
            txtID.Text = "";
            txtCantidad.Text = "";
        }

    }
}