namespace GestionInventaireFront
{
    partial class FrmListMaterialsUser
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
            this.cmdSearchMaterial = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.lblLisUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSearchMaterial
            // 
            this.cmdSearchMaterial.Location = new System.Drawing.Point(540, 425);
            this.cmdSearchMaterial.Name = "cmdSearchMaterial";
            this.cmdSearchMaterial.Size = new System.Drawing.Size(125, 48);
            this.cmdSearchMaterial.TabIndex = 4;
            this.cmdSearchMaterial.Text = "accueil";
            this.cmdSearchMaterial.UseVisualStyleBackColor = true;
            this.cmdSearchMaterial.Click += new System.EventHandler(this.cmdHomeListAddDelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.materialBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(653, 372);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
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
            // lblLisUser
            // 
            this.lblLisUser.AutoSize = true;
            this.lblLisUser.Location = new System.Drawing.Point(79, 19);
            this.lblLisUser.Name = "lblLisUser";
            this.lblLisUser.Size = new System.Drawing.Size(479, 15);
            this.lblLisUser.TabIndex = 6;
            this.lblLisUser.Text = "Bonjour, Veuillez double cliquer à gauche de la colone pour afficher les détails " +
    "du matériel";
            this.lblLisUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmListMaterialsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 485);
            this.Controls.Add(this.lblLisUser);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmdSearchMaterial);
            this.Name = "FrmListMaterialsUser";
            this.Text = "ListeMaterialsUser";
            this.Load += new System.EventHandler(this.FrmListMaterialsUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdSearchMaterial;
        private DataGridView dataGridView2;
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
        private BindingSource materialBindingSource;
        private Label lblLisUser;
    }
}