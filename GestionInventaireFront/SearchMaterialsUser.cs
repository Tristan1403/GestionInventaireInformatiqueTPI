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
    public partial class frmSearchMaterialsUser : Form
    {
        material materialSend = new material();
        public frmSearchMaterialsUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtName.Text != "" || txtDescription.Text != "" || txtQuantity.Text != "")
            { 

            }
            FrmListMaterialsUser listMaterialsUser = new FrmListMaterialsUser(materialSend);
            this.Hide();
            listMaterialsUser.ShowDialog();
            this.Close();
        }

        private void cmdHomeSearch_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void frmSearchMaterialsUser_Load(object sender, EventArgs e)
        {
            ConnectionDB bdd = new ConnectionDB();
            List<string> brands = new List<string>();
            string listName = "brands";
            cbxBrand.Items.AddRange(bdd.GetList(listName).ToArray());
            listName = "types";
            cbxType.Items.AddRange(bdd.GetList(listName).ToArray());
            listName = "modules";
            cbxModule.Items.AddRange(bdd.GetList(listName).ToArray());
            listName = "storageplaces";
            cbxStoragePlace.Items.AddRange(bdd.GetList(listName).ToArray());
        }


    }
}
