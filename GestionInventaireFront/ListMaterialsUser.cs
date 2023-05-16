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
using System.Linq.Expressions;

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
            frmSearchMaterialsUser searchHome = new frmSearchMaterialsUser();
            this.Hide();
            searchHome.ShowDialog();
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            material materialShow = new material();
            materialShow.Name = Convert.ToString(dataGridView2[0, index].Value);
            materialShow.Description = Convert.ToString(dataGridView2[1, index].Value);
            materialShow.PurchaseDate = Convert.ToDateTime(dataGridView2[2, index].Value);
            materialShow.Brands = Convert.ToString(dataGridView2[3, index].Value);
            materialShow.Modules = Convert.ToString(dataGridView2[4, index].Value);
            materialShow.StockagePlaces = Convert.ToString(dataGridView2[5, index].Value);
            materialShow.RenewDate = Convert.ToDateTime(dataGridView2[6, index].Value);
            materialShow.Quantity = Convert.ToInt32(dataGridView2[7, index].Value);
            materialShow.Types = Convert.ToString(dataGridView2[8, index].Value);
            materialShow.Archived = Convert.ToBoolean(dataGridView2[9, index].Value);


            frmShowDetailsUser showDetails = new frmShowDetailsUser(materialShow, MaterialCheck);
            this.Hide();
            showDetails.ShowDialog();
            this.Close();
        }

        private void FrmListMaterialsUser_Load(object sender, EventArgs e)
        {
            //get the list of material that aren't archived
            ConnectionDB bdd = new ConnectionDB();
            dataGridView2.DataSource = bdd.GetMaterials(true);

            //set not base criteria off
            purchaseDateDataGridViewTextBoxColumn.Visible = false;
            renewDateDataGridViewTextBoxColumn.Visible = false;
            brandsDataGridViewTextBoxColumn.Visible = false;
            modulesDataGridViewTextBoxColumn.Visible = false;
            stockagePlacesDataGridViewTextBoxColumn.Visible = false;
            archivedDataGridViewCheckBoxColumn.Visible = false;
            typesDataGridViewTextBoxColumn.Visible = false;

            //set all rows to invisible
            dataGridView2.CurrentCell = null;
            List<string> Criteria = new List<string>();
            int modifications = 0;
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                dataGridView2.CurrentCell = null;
                row.Visible = false;
            }

            //if this is a criteria then check if there is smt similar in the dataBase and show it
            if (MaterialCheck.Name != null)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[0].Value.ToString() == MaterialCheck.Name)
                    {
                        Criteria.Add(element.Cells[0].Value.ToString());
                        element.Visible = true;
                    }
                }
            }

            if (MaterialCheck.Description != null)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[1].Value.ToString() == MaterialCheck.Description)
                    {
                        Criteria.Add(element.Cells[1].Value.ToString());
                        element.Visible = true;
                    }
                }
            }

            if (MaterialCheck.Quantity != 0)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[7].Value.ToString() == MaterialCheck.Quantity.ToString())
                    {
                        Criteria.Add(element.Cells[7].Value.ToString());
                        element.Visible = true;
                    }
                }
            }
            if (MaterialCheck.Brands != null)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[3].Value.ToString() == MaterialCheck.Brands)
                    {
                        Criteria.Add(element.Cells[3].Value.ToString());
                        element.Visible = true;
                    }
                }

                brandsDataGridViewTextBoxColumn.Visible = true;
            }
            if (MaterialCheck.Modules != null)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[4].Value.ToString() == MaterialCheck.Modules)
                    {
                        Criteria.Add(element.Cells[4].Value.ToString());
                        element.Visible = true;
                    }
                }

                modulesDataGridViewTextBoxColumn.Visible = true;
            }
            if (MaterialCheck.StockagePlaces != null)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[5].Value.ToString() == MaterialCheck.StockagePlaces)
                    {
                        Criteria.Add(element.Cells[5].Value.ToString());
                        element.Visible = true;
                    }
                }

                stockagePlacesDataGridViewTextBoxColumn.Visible = true;
            }
            if (MaterialCheck.Types != null)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[8].Value.ToString() == MaterialCheck.Types)
                    {
                        Criteria.Add(element.Cells[8].Value.ToString());
                        element.Visible = true;
                    }
                }

                typesDataGridViewTextBoxColumn.Visible = true;
            }
            if (MaterialCheck.RenewDate != DateTime.MinValue)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[6].Value.ToString() == MaterialCheck.RenewDate.ToString())
                    {
                        Criteria.Add(element.Cells[6].Value.ToString());
                        element.Visible = true;
                    }
                }

                renewDateDataGridViewTextBoxColumn.Visible = true;
            }
            if (MaterialCheck.PurchaseDate != DateTime.MinValue)
            {
                modifications++;
                foreach (DataGridViewRow element in dataGridView2.Rows)
                {
                    if (element.Cells[2].Value.ToString() == MaterialCheck.PurchaseDate.ToString())
                    {
                        Criteria.Add(element.Cells[2].Value.ToString());
                        element.Visible = true;
                    }
                }

                purchaseDateDataGridViewTextBoxColumn.Visible = true;
            }

            Criteria = Criteria.Distinct().ToList();
            if (Criteria.Count == modifications)
            {
                bool checkSHow = false;
                if (Criteria.Count > 1)
                {
                    dataGridView2.CurrentCell = null;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        dataGridView2.CurrentCell = null;
                        row.Visible = false;
                    }
                    foreach (DataGridViewRow element in dataGridView2.Rows)
                    {
                        modifications = 0;
                        for (int i = 0; i < element.Cells.Count; i++)
                        {
                            foreach (string crit in Criteria)
                            {
                                if (element.Cells[i].Value.ToString() == crit)
                                {
                                    modifications++;
                                }
                            }
                            if (modifications == Criteria.Count)
                            {
                                element.Visible = true;
                                checkSHow = true;
                            }

                        }
                    }
                    if(checkSHow == false)
                    {
                        MessageBox.Show("Aucun éléments correspondent à votre recherche!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        frmSearchMaterialsUser searchHome = new frmSearchMaterialsUser();
                        this.Hide();
                        searchHome.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun éléments correspondent à votre recherche!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmSearchMaterialsUser searchHome = new frmSearchMaterialsUser();
                this.Hide();
                searchHome.ShowDialog();
                this.Close();
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            material materialShow = new material();
            materialShow.Name = Convert.ToString(dataGridView2[0, index].Value);
            materialShow.Description = Convert.ToString(dataGridView2[1, index].Value);
            materialShow.PurchaseDate = Convert.ToDateTime(dataGridView2[2, index].Value);
            materialShow.Brands = Convert.ToString(dataGridView2[3, index].Value);
            materialShow.Modules = Convert.ToString(dataGridView2[4, index].Value);
            materialShow.StockagePlaces = Convert.ToString(dataGridView2[5, index].Value);
            materialShow.RenewDate = Convert.ToDateTime(dataGridView2[6, index].Value);
            materialShow.Quantity = Convert.ToInt32(dataGridView2[7, index].Value);
            materialShow.Types = Convert.ToString(dataGridView2[8, index].Value);
            materialShow.Archived = Convert.ToBoolean(dataGridView2[9, index].Value);


            frmShowDetailsUser showDetails = new frmShowDetailsUser(materialShow, MaterialCheck);
            this.Hide();
            showDetails.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
