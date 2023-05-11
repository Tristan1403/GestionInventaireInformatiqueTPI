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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHomeListAddDelete
            // 
            this.cmdHomeListAddDelete.Location = new System.Drawing.Point(540, 425);
            this.cmdHomeListAddDelete.Name = "cmdHomeListAddDelete";
            this.cmdHomeListAddDelete.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeListAddDelete.TabIndex = 4;
            this.cmdHomeListAddDelete.Text = "accueil";
            this.cmdHomeListAddDelete.UseVisualStyleBackColor = true;
            this.cmdHomeListAddDelete.Click += new System.EventHandler(this.cmdHomeListAddDelete_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(653, 372);
            this.dataGridView1.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // brandsDataGridViewTextBoxColumn
            // 
            this.brandsDataGridViewTextBoxColumn.DataPropertyName = "Brands";
            this.brandsDataGridViewTextBoxColumn.HeaderText = "Brands";
            this.brandsDataGridViewTextBoxColumn.Name = "brandsDataGridViewTextBoxColumn";
            // 
            // modulesDataGridViewTextBoxColumn
            // 
            this.modulesDataGridViewTextBoxColumn.DataPropertyName = "Modules";
            this.modulesDataGridViewTextBoxColumn.HeaderText = "Modules";
            this.modulesDataGridViewTextBoxColumn.Name = "modulesDataGridViewTextBoxColumn";
            // 
            // stockagePlacesDataGridViewTextBoxColumn
            // 
            this.stockagePlacesDataGridViewTextBoxColumn.DataPropertyName = "StockagePlaces";
            this.stockagePlacesDataGridViewTextBoxColumn.HeaderText = "StockagePlaces";
            this.stockagePlacesDataGridViewTextBoxColumn.Name = "stockagePlacesDataGridViewTextBoxColumn";
            // 
            // renewDateDataGridViewTextBoxColumn
            // 
            this.renewDateDataGridViewTextBoxColumn.DataPropertyName = "RenewDate";
            this.renewDateDataGridViewTextBoxColumn.HeaderText = "RenewDate";
            this.renewDateDataGridViewTextBoxColumn.Name = "renewDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // typesDataGridViewTextBoxColumn
            // 
            this.typesDataGridViewTextBoxColumn.DataPropertyName = "Types";
            this.typesDataGridViewTextBoxColumn.HeaderText = "Types";
            this.typesDataGridViewTextBoxColumn.Name = "typesDataGridViewTextBoxColumn";
            // 
            // archivedDataGridViewCheckBoxColumn
            // 
            this.archivedDataGridViewCheckBoxColumn.DataPropertyName = "Archived";
            this.archivedDataGridViewCheckBoxColumn.HeaderText = "Archived";
            this.archivedDataGridViewCheckBoxColumn.Name = "archivedDataGridViewCheckBoxColumn";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(GestionInventaireClass.material);
            // 
            // FrmListMaterialsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdHomeListAddDelete);
            this.Name = "FrmListMaterialsUser";
            this.Text = "ListeMaterialsUser";
            this.Load += new System.EventHandler(this.FrmListMaterialsUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdHomeListAddDelete;
        private DataGridView dataGridView1;
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
    }
}