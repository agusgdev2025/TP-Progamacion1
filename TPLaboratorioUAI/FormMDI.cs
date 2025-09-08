namespace TPLaboratorioUAI
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void FormMDI_Load(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();

            formPrincipal.WindowState = FormWindowState.Maximized;
            formPrincipal.MdiParent = this;
            formPrincipal.Show();
        }
    }
}
