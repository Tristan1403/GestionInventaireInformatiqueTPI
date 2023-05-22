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
using System.Windows.Forms.Design.Behavior;

namespace GestionInventaireFront
{
    public partial class frmShowDetailsUser : Form
    {
        material showMaterial = new material();
        material materialCheck = new material();
        public frmShowDetailsUser(material showMaterial, material materialCheck)
        {
            InitializeComponent();

            this.showMaterial = showMaterial;
            this.materialCheck = materialCheck;
        }

        private void cmdHomeAdmin_Click(object sender, EventArgs e)
        {
            FrmListMaterialsUser home = new FrmListMaterialsUser(materialCheck);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowDetailsUser_Load(object sender, EventArgs e)
        {
            List<material> listMaterial = new List<material>();
            listMaterial.Add(showMaterial);
            dataGridView3.DataSource = listMaterial;

            ConnectionDB bdd = new ConnectionDB();
            List<MessageDB> listMessage = new List<MessageDB>();
            listMessage = bdd.GetMessages(showMaterial.Name);
            if(listMessage.Count > 0)
            {
                foreach (MessageDB message in listMessage)
                {
                    lblModification.Text += "La modification " + message.MessageString + " a été faite le " + message.MessageDate + " !" + Environment.NewLine;
                }
            }
            else
            {
                lblModification.Text = "pas de mofification";
            }
           
        }
    }
}
