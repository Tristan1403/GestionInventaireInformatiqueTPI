using GestionInventaireClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventaireFront
{
    public partial class FrmloginAdmin : Form
    {
        public FrmloginAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtPseudo.Text != "" || txtPassword.Text != "")
            {
                ConnectionDB bdd = new ConnectionDB();
                Admin admin = new Admin(txtPseudo.Text, txtPassword.Text);
                bool CheckAmind = bdd.CheckAdmin(admin);

                if(CheckAmind == true)
                {
                    FrmHomeAdmin homeAdmin = new FrmHomeAdmin();
                    this.Hide();
                    homeAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le pseudo ou le mot de passe est incorrecte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
