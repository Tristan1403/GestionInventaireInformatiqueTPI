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
        public FrmListMaterialsUser()
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
    }
}
