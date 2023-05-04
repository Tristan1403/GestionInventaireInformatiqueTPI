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
    }
}
