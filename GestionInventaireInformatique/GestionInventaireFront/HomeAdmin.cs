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
    /// This form is usefull to choose if you want to insert a new materail, modify one, check the list of material or add, delete word from the lists
    /// </summary>
    public partial class FrmHomeAdmin : Form
    {
        public FrmHomeAdmin()
        {
            InitializeComponent();
        }

        private void cmdHomeAdmin_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void CmdInsert_Click(object sender, EventArgs e)
        {
            material materialAdd = new material();
            frmAddModifyMaterials addModifyMaterial = new frmAddModifyMaterials(materialAdd, false);
            this.Hide();
            addModifyMaterial.ShowDialog();
            this.Close();
        }

        private void CmdModify_Click(object sender, EventArgs e)
        {
            FrmListMaterialsAdmin listMaterialAdmin = new FrmListMaterialsAdmin();
            this.Hide();
            listMaterialAdmin.ShowDialog();
            this.Close();
        }

        private void CmdList_Click(object sender, EventArgs e)
        {
            FrmListModifyAdmin listModifyAdmin = new FrmListModifyAdmin();
            this.Hide();
            listModifyAdmin.ShowDialog();
            this.Close();
        }

        private void FrmHomeAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
