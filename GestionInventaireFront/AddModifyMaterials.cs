using GestionInventaireClass;
using Microsoft.VisualBasic;
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
    /// <summary>
    /// This form is usefull to add new material and you get there if you double click on smt in the ListMaterialAdmin
    /// </summary>
    public partial class frmAddModifyMaterials : Form
    {
        //init var for the modification
        material materialModify;
        bool modifyOrAdd;
        string name;
        public frmAddModifyMaterials(material materialModify, bool modifyOrAdd)
        {
            InitializeComponent();

            // materialModify has the data we want to monify
            this.materialModify = materialModify;
            //modifyOrAdd is true for a modification and fals for an add
            this.modifyOrAdd = modifyOrAdd;
            rdbArchived.Enabled = false;
        }

        private void cmdHomeAddModify_Click(object sender, EventArgs e)
        {
            //go the admin home
            FrmHomeAdmin homeAdmin = new FrmHomeAdmin();
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void cmdAddModify_Click(object sender, EventArgs e)
        {
            //check if everything is filled
            if(txtName.Text != "" || txtDescription.Text != "" || cbxBrand.SelectedItem != null || cbxModule.SelectedItem != null || cbxStockagePlace.SelectedItem != null || txtQuantity.Text != "" || cbxType.SelectedItem != null)
            {
                if(dateTPPurchaseDate.Value < dateTPRewnewalDate.Value) 
                {
                    try
                    {
                        if (modifyOrAdd == false)
                        {
                            //create a material with the data, the admin inserted
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

                            //insert the material in the DB 
                            ConnectionDB bdd = new ConnectionDB();
                            bdd.InsertMaterial(AddMaterial);

                            //refresh the page
                            this.Controls.Clear();
                            this.InitializeComponent();
                            //tell the admin everything went well
                            MessageBox.Show("le materiel " + AddMaterial.Name + " a été ajouté à la base de donnée!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string MessageModify = Interaction.InputBox("Veuillez préciser votre changement", "message de modification", "modification");

                            //update a material with the data, the admin inserted
                            material updateMaterial = new material();
                            updateMaterial.Name = txtName.Text;
                            updateMaterial.Description = txtDescription.Text;
                            updateMaterial.PurchaseDate = dateTPPurchaseDate.Value;
                            updateMaterial.Brands = cbxBrand.SelectedItem.ToString();
                            updateMaterial.Modules = cbxModule.SelectedItem.ToString();
                            updateMaterial.StockagePlaces = cbxStockagePlace.SelectedItem.ToString();
                            updateMaterial.RenewDate = dateTPRewnewalDate.Value;
                            updateMaterial.Quantity = Int32.Parse(txtQuantity.Text);
                            updateMaterial.Types = cbxType.SelectedItem.ToString();
                            updateMaterial.Archived = rdbArchived.Checked;

                            //insert the material in the DB 
                            ConnectionDB bdd = new ConnectionDB();
                            int id = bdd.GetId(name, "materials");
                            bdd.UpdateMaterial(updateMaterial, id, MessageModify);
                            MessageBox.Show("le materiel " + txtName.Text + " a été modifé dans la base de donnée!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //go back the the matérial list
                            FrmListMaterialsAdmin ListeMaterialAdmin = new FrmListMaterialsAdmin();
                            this.Hide();
                            ListeMaterialAdmin.ShowDialog();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        //show a the error thorowed in UpdateMaterial
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("La date d'achat ne peut pas être après la date de renouvellement!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddModifyMaterials_Load(object sender, EventArgs e)
        {    
            //insert data in the combobox
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

            //if modifyOrAdd is true then it is a modification
            if(modifyOrAdd == true)
            {
                //set base data of the material
                txtName.Text = materialModify.Name;
                txtDescription.Text = materialModify.Description;
                dateTPPurchaseDate.Value = materialModify.PurchaseDate;
                cbxBrand.SelectedItem = materialModify.Brands;
                cbxModule.SelectedItem = materialModify.Modules;
                cbxStockagePlace.SelectedItem = materialModify.StockagePlaces;
                txtQuantity.Text = materialModify.Quantity.ToString();
                dateTPRewnewalDate.Value = materialModify.RenewDate;
                cbxType.SelectedItem = materialModify.Types;
                rdbArchived.Checked = materialModify.Archived;
                rdbArchived.Enabled = true;
            }
  
        }
    }
}
