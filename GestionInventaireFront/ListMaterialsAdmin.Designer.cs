namespace GestionInventaireFront
{
    partial class FrmListMaterialsAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdHomeListAddDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockagePlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renewDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLisUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHomeListAddDelete
            // 
            this.cmdHomeListAddDelete.Location = new System.Drawing.Point(937, 522);
            this.cmdHomeListAddDelete.Name = "cmdHomeListAddDelete";
            this.cmdHomeListAddDelete.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeListAddDelete.TabIndex = 4;
            this.cmdHomeListAddDelete.Text = "accueil admin";
            this.cmdHomeListAddDelete.UseVisualStyleBackColor = true;
            this.cmdHomeListAddDelete.Click += new System.EventHandler(this.cmdHomeListAddDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.brandsDataGridViewTextBoxColumn,
            this.modulesDataGridViewTextBoxColumn,
            this.stockagePlacesDataGridViewTextBoxColumn,
            this.renewDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typesDataGridViewTextBoxColumn,
            this.archivedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.materialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 467);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandsDataGridViewTextBoxColumn
            // 
            this.brandsDataGridViewTextBoxColumn.DataPropertyName = "Brands";
            this.brandsDataGridViewTextBoxColumn.HeaderText = "Brands";
            this.brandsDataGridViewTextBoxColumn.Name = "brandsDataGridViewTextBoxColumn";
            this.brandsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modulesDataGridViewTextBoxColumn
            // 
            this.modulesDataGridViewTextBoxColumn.DataPropertyName = "Modules";
            this.modulesDataGridViewTextBoxColumn.HeaderText = "Modules";
            this.modulesDataGridViewTextBoxColumn.Name = "modulesDataGridViewTextBoxColumn";
            this.modulesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockagePlacesDataGridViewTextBoxColumn
            // 
            this.stockagePlacesDataGridViewTextBoxColumn.DataPropertyName = "StockagePlaces";
            this.stockagePlacesDataGridViewTextBoxColumn.HeaderText = "StockagePlaces";
            this.stockagePlacesDataGridViewTextBoxColumn.Name = "stockagePlacesDataGridViewTextBoxColumn";
            this.stockagePlacesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renewDateDataGridViewTextBoxColumn
            // 
            this.renewDateDataGridViewTextBoxColumn.DataPropertyName = "RenewDate";
            this.renewDateDataGridViewTextBoxColumn.HeaderText = "RenewDate";
            this.renewDateDataGridViewTextBoxColumn.Name = "renewDateDataGridViewTextBoxColumn";
            this.renewDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typesDataGridViewTextBoxColumn
            // 
            this.typesDataGridViewTextBoxColumn.DataPropertyName = "Types";
            this.typesDataGridViewTextBoxColumn.HeaderText = "Types";
            this.typesDataGridViewTextBoxColumn.Name = "typesDataGridViewTextBoxColumn";
            this.typesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // archivedDataGridViewCheckBoxColumn
            // 
            this.archivedDataGridViewCheckBoxColumn.DataPropertyName = "Archived";
            this.archivedDataGridViewCheckBoxColumn.HeaderText = "Archived";
            this.archivedDataGridViewCheckBoxColumn.Name = "archivedDataGridViewCheckBoxColumn";
            this.archivedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(GestionInventaireClass.material);
            // 
            // connectionDBBindingSource
            // 
            this.connectionDBBindingSource.DataSource = typeof(GestionInventaireClass.ConnectionDB);
            // 
            // lblLisUser
            // 
            this.lblLisUser.AutoSize = true;
            this.lblLisUser.Location = new System.Drawing.Point(325, 21);
            this.lblLisUser.Name = "lblLisUser";
            this.lblLisUser.Size = new System.Drawing.Size(439, 15);
            this.lblLisUser.TabIndex = 7;
            this.lblLisUser.Text = "Bonjour, Veuillez cliquer à gauche de la colone pour afficher les détails du maté" +
    "riel";
            // 
            // FrmListMaterialsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 582);
            this.Controls.Add(this.lblLisUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdHomeListAddDelete);
            this.Name = "FrmListMaterialsAdmin";
            this.Text = "ListMaterialsAdmin";
            this.Load += new System.EventHandler(this.FrmListMaterialsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdHomeListAddDelete;
        private DataGridView dataGridView1;
        private BindingSource connectionDBBindingSource;
        private BindingSource materialBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modulesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockagePlacesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renewDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn archivedDataGridViewCheckBoxColumn;
        private Label lblLisUser;
    }
}