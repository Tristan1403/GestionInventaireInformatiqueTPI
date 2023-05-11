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
    public partial class FrmListMaterialsUser : Form
    {
        public FrmListMaterialsUser(material material)
        {
            InitializeComponent();
        }

        private void cmdHomeListAddDelete_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void FrmListMaterialsUser_Load(object sender, EventArgs e)
        {
            ConnectionDB bdd = new ConnectionDB();
            dataGridView1.DataSource = bdd.GetMaterials(true);
            purchaseDateDataGridViewTextBoxColumn.Visible = false;
            renewDateDataGridViewTextBoxColumn.Visible = false;
            brandsDataGridViewTextBoxColumn.Visible = false;
            modulesDataGridViewTextBoxColumn.Visible = false;
            stockagePlacesDataGridViewTextBoxColumn.Visible = false;
            archivedDataGridViewCheckBoxColumn.Visible = false;
            typesDataGridViewTextBoxColumn.Visible = false;
        }
    }
}
