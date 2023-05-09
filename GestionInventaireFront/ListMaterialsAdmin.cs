using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using System.Linq.Expressions;
using Org.BouncyCastle.Utilities.Collections;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.VisualBasic;
using GestionInventaireClass;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace GestionInventaireFront
{
    public partial class FrmListMaterialsAdmin : Form
    {
        public FrmListMaterialsAdmin()
        {
            InitializeComponent();
        }

        private void cmdHomeListAddDelete_Click(object sender, EventArgs e)
        {
            FrmHomeAdmin homeAdmin = new FrmHomeAdmin();
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }


        private void FrmListMaterialsAdmin_Load(object sender, EventArgs e)
        {
            ConnectionDB bdd = new ConnectionDB();
            dataGridView1.DataSource = bdd.GetMaterials();
        }


        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            material materialModify = new material();
            materialModify.Name = Convert.ToString(dataGridView1[0, row].Value);
            materialModify.Description = Convert.ToString(dataGridView1[1, row].Value);
            materialModify.PurchaseDate = Convert.ToDateTime(dataGridView1[2, row].Value);
            materialModify.Brands = Convert.ToString(dataGridView1[3, row].Value);
            materialModify.Modules = Convert.ToString(dataGridView1[4, row].Value);
            materialModify.StockagePlaces = Convert.ToString(dataGridView1[5, row].Value);
            materialModify.RenewDate = Convert.ToDateTime(dataGridView1[6, row].Value);
            materialModify.Quantity = Convert.ToInt32(dataGridView1[7, row].Value);
            materialModify.Types = Convert.ToString(dataGridView1[8, row].Value);
            materialModify.Archived = Convert.ToBoolean(dataGridView1[9, row].Value);


            frmAddModifyMaterials listAddModify = new frmAddModifyMaterials(materialModify, true);
            this.Hide();
            listAddModify.ShowDialog();
            this.Close();
        }

    }
}
