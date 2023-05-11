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
    /// <summary>
    /// This form is usefull to modify the 4 lists 
    /// </summary>
    public partial class FrmListModifyAdmin : Form
    {
        public FrmListModifyAdmin()
        {
            InitializeComponent();
        }

        private void ListModifyAdmin_Load(object sender, EventArgs e)
        {
            ConnectionDB bdd = new ConnectionDB();
            List<string> brands = new List<string>();
            string listName = "brands";
            cbxBrands.Items.AddRange(bdd.GetList(listName).ToArray());
            listName = "types";
            cbxTypes.Items.AddRange(bdd.GetList(listName).ToArray());
            listName = "modules";
            cbxModules.Items.AddRange(bdd.GetList(listName).ToArray());
            listName = "storageplaces";
            cbxPlaces.Items.AddRange(bdd.GetList(listName).ToArray());

        }

        private void cmdHomeListAddDelete_Click(object sender, EventArgs e)
        {
            FrmHomeAdmin homeAdmin = new FrmHomeAdmin();
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void cbxModules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBrands.SelectedItem == null && cbxModules.SelectedItem == null && cbxPlaces.SelectedItem == null && cbxTypes.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez selectionné au moins un mot à effacer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConnectionDB bdd = new ConnectionDB();
                    int itemDelete = 0;
                    if (cbxBrands.SelectedItem != null)
                    {
                        itemDelete++;
                        bdd.DeleteWord(cbxBrands.Text, "brands");
                    }
                    if (cbxModules.SelectedItem != null)
                    {
                        itemDelete++;
                        bdd.DeleteWord(cbxModules.Text, "modules");
                    }
                    if (cbxPlaces.SelectedItem != null)
                    {
                        itemDelete++;
                        bdd.DeleteWord(cbxPlaces.Text, "storageplaces");
                    }
                    if (cbxTypes.SelectedItem != null)
                    {
                        itemDelete++;
                        bdd.DeleteWord(cbxTypes.Text, "types");
                    }

                    MessageBox.Show("Vous avez bien supprimer " + itemDelete + " mot(s)!", "mots effacés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            FrmListModifyAdmin listModifyAdmin = new FrmListModifyAdmin();
            this.Hide();
            listModifyAdmin.ShowDialog();
            this.Close();
        }



        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtBrands.Text == "" && txtModules.Text == "" && txtPlaces.Text == "" && txtTypes.Text == "")
            {
                MessageBox.Show("Veuillez écrire au moins un mot à ajouter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ConnectionDB bdd = new ConnectionDB();
                    int addItem = 0;
                    if (txtTypes.Text != "")
                    {
                        addItem++;
                        bdd.InsertWord(txtTypes.Text, "types");
                    }
                    if (txtPlaces.Text != "")
                    {
                        addItem++;
                        bdd.InsertWord(txtPlaces.Text, "storageplaces");
                    }
                    if (txtModules.Text != "")
                    {
                        addItem++;
                        bdd.InsertWord(txtModules.Text, "modules");
                    }
                    if (txtBrands.Text != "")
                    {
                        addItem++;
                        bdd.InsertWord(txtBrands.Text, "brands");
                    }

                    MessageBox.Show("Vous avez bien ajouté " + addItem + " mot(s)!", "mots ajoutés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                FrmListModifyAdmin listModifyAdmin = new FrmListModifyAdmin();
                this.Hide();
                listModifyAdmin.ShowDialog();
                this.Close();
            }
        }
    }
}
