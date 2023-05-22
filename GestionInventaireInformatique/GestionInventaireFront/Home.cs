namespace GestionInventaireFront
{
    /// <summary>
    /// This form is usefull to choose between the admin part and user part
    /// </summary>
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void CmdUser_Click(object sender, EventArgs e)
        {
            //open the user part
            frmSearchMaterialsUser search = new frmSearchMaterialsUser();
            this.Hide();
            search.ShowDialog();
            this.Close();
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            //go to the admin login
            FrmloginAdmin loginAdmin = new FrmloginAdmin();
            this.Hide();
            loginAdmin.ShowDialog();
            this.Close();
        }
    }
}