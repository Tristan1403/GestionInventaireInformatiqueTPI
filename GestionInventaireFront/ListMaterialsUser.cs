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
using static Google.Protobuf.Reflection.FieldOptions.Types;
using System.Xml.Linq;

namespace GestionInventaireFront
{
    public partial class FrmListMaterialsUser : Form
    {
        material MaterialCheck = new material();
        public FrmListMaterialsUser(material materialCheck)
        {
            InitializeComponent();
            this.MaterialCheck = materialCheck;
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
            //get the list of material that aren't archived
            ConnectionDB bdd = new ConnectionDB();
            dataGridView1.DataSource = bdd.GetMaterials(true);

            //set not base criteria off
            purchaseDateDataGridViewTextBoxColumn.Visible = false;
            renewDateDataGridViewTextBoxColumn.Visible = false;
            brandsDataGridViewTextBoxColumn.Visible = false;
            modulesDataGridViewTextBoxColumn.Visible = false;
            stockagePlacesDataGridViewTextBoxColumn.Visible = false;
            archivedDataGridViewCheckBoxColumn.Visible = false;
            typesDataGridViewTextBoxColumn.Visible = false;

            //set all rows to invisible
            dataGridView1.CurrentCell = null;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.CurrentCell = null;
                row.Visible = false;
            }

            //if this is a criteria then check if there is smt similar in the dataBase and show it
            if (MaterialCheck.Name != "")
            {
                foreach (DataGridViewRow element in dataGridView1.Rows)
                {
                    if (element.Cells[0].Value.ToString() == MaterialCheck.Name)
                    {
                        element.Visible = true;
                    }
                }
            }
        
            if (MaterialCheck.Description != "")
            {


                if (MaterialCheck.Quantity != 0)
                {

                }
                if (MaterialCheck.Brands != null)
                {
                    brandsDataGridViewTextBoxColumn.Visible = true;
                }
                if (MaterialCheck.Modules != null)
                {
                    modulesDataGridViewTextBoxColumn.Visible = true;
                }
                if (MaterialCheck.StockagePlaces != null)
                {
                    stockagePlacesDataGridViewTextBoxColumn.Visible = true;
                }
                if (MaterialCheck.Types != null)
                {
                    typesDataGridViewTextBoxColumn.Visible = true;
                }
                if (MaterialCheck.RenewDate != DateTime.MinValue)
                {
                    renewDateDataGridViewTextBoxColumn.Visible = true;
                }
                if (MaterialCheck.PurchaseDate != DateTime.MinValue)
                {
                    purchaseDateDataGridViewTextBoxColumn.Visible = true;
                }
            }
        }
    }
}
