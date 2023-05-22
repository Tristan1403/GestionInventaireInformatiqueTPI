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
            DateTime minDate = new DateTime(1900, 1, 1);
            int checkCriteria = 0;
            if (txtName.Text != "")
            {
                materialSend.Name = txtName.Text;
                checkCriteria++;
            }
            if (txtDescription.Text != "") 
            {
                materialSend.Description = txtDescription.Text;
                checkCriteria++;
            }
            if (txtQuantity.Text != "") 
            {
                materialSend.Quantity = Int32.Parse(txtQuantity.Text);
                checkCriteria++;
            } 
            if(cbxBrand.Text != "")
            {
                materialSend.Brands = cbxBrand.SelectedItem.ToString();
                checkCriteria++;
            }
            if(cbxModule.Text != "")
            {
                materialSend.Modules = cbxModule.SelectedItem.ToString();
                checkCriteria++;
            }
            if(cbxStoragePlace.Text != "")
            {
                materialSend.StockagePlaces = cbxStoragePlace.SelectedItem.ToString();
                checkCriteria++;
            }
            if(cbxType.Text != "")
            {
                materialSend.Types = cbxType.SelectedItem.ToString();
                checkCriteria++;
            }
            if(dateTPRenewDate.Value != minDate)
            {
                materialSend.RenewDate = dateTPRenewDate.Value;
                checkCriteria++;
            }
            else
            {
                materialSend.PurchaseDate = DateTime.MinValue;
            }
            if (dateTPPurchaseDate.Value != minDate)
            {
                materialSend.PurchaseDate = dateTPPurchaseDate.Value;
                checkCriteria++;
            }
            else
            {
                materialSend.PurchaseDate = DateTime.MinValue;
            }
            if (checkCriteria > 0)
            {
                FrmListMaterialsUser listMaterialsUser = new FrmListMaterialsUser(materialSend);
                this.Hide();
                listMaterialsUser.ShowDialog();
                this.Close();
            }             
            else
            {
                MessageBox.Show("Veuillez choisir au moins un critère", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
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
