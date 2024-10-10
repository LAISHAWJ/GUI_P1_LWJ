namespace WeversMarket_GUI_P1
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }
    }
}
