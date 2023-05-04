namespace GestionInventaireFront
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void CmdUser_Click(object sender, EventArgs e)
        {
            frmSearchMaterialsUser search = new frmSearchMaterialsUser();
            this.Hide();
            search.ShowDialog();
            this.Close();
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            FrmloginAdmin loginAdmin = new FrmloginAdmin();
            this.Hide();
            loginAdmin.ShowDialog();
            this.Close();
        }
    }
}