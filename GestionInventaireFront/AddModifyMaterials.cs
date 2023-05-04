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
    }
}
