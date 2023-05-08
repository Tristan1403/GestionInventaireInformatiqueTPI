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
    public partial class frmAddModifyMaterials : Form
    {
        public frmAddModifyMaterials()
        {
            InitializeComponent();
        }

        private void cmdHomeAddModify_Click(object sender, EventArgs e)
        {
            FrmHomeAdmin homeAdmin = new FrmHomeAdmin();
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void cmdAddModify_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" || txtDescription.Text != "" || cbxBrand.SelectedItem != null || cbxModule.SelectedItem != null || cbxStockagePlace.SelectedItem != null || txtQuantity.Text != "" || cbxType.SelectedItem != null)
            {
                material AddMaterial = new material();
                AddMaterial.Name = txtName.Text;
                AddMaterial.Description = txtDescription.Text;
                AddMaterial.PurchaseDate = dateTPPurchaseDate.Value;
                AddMaterial.Brands = cbxBrand.SelectedItem.ToString();
                AddMaterial.Modules = cbxModule.SelectedItem.ToString();
                AddMaterial.StockagePlaces = cbxStockagePlace.SelectedItem.ToString();
                AddMaterial.RenewDate = dateTPRewnewalDate.Value;
                AddMaterial.Quantity = Int32.Parse(txtQuantity.Text);
                AddMaterial.Types = cbxType.SelectedItem.ToString();
                AddMaterial.Archived = false;

                ConnectionDB bdd = new ConnectionDB();
                bdd.InsertMaterial(AddMaterial);

                this.Controls.Clear();
                this.InitializeComponent();
                MessageBox.Show("le materiel "+ AddMaterial.Name + " a été ajouté à la base de donnée!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddModifyMaterials_Load(object sender, EventArgs e)
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
            cbxStockagePlace.Items.AddRange(bdd.GetList(listName).ToArray());
        }
    }
}
