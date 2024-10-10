namespace WeversMarket_GUI_P1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtProducto_Click(object sender, EventArgs e)
        {
            ProducForm producForm = new ProducForm();
            this.Hide();
            producForm.Show();
        }

        private void BtCategoria_Click(object sender, EventArgs e)
        {
            CategForm categForm = new CategForm();
            this.Hide();
            categForm.Show();
        }

        private void BtSuplidor_Click(object sender, EventArgs e)
        {
            SupliForm supliForm = new SupliForm();
            this.Hide(); 
            supliForm.Show();
        }
    }
}
