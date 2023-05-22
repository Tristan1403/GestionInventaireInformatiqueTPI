namespace GestionInventaireFront
{
    partial class frmShowDetailsUser
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            this.cmdListBack = new System.Windows.Forms.Button();
            this.lblModification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView3.DataSource = this.materialBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1042, 67);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // cmdListBack
            // 
            this.cmdListBack.Location = new System.Drawing.Point(935, 390);
            this.cmdListBack.Name = "cmdListBack";
            this.cmdListBack.Size = new System.Drawing.Size(125, 48);
            this.cmdListBack.TabIndex = 4;
            this.cmdListBack.Text = "retour";
            this.cmdListBack.UseVisualStyleBackColor = true;
            this.cmdListBack.Click += new System.EventHandler(this.cmdHomeAdmin_Click);
            // 
            // lblModification
            // 
            this.lblModification.AutoSize = true;
            this.lblModification.Location = new System.Drawing.Point(117, 211);
            this.lblModification.Name = "lblModification";
            this.lblModification.Size = new System.Drawing.Size(0, 15);
            this.lblModification.TabIndex = 5;
            // 
            // frmShowDetailsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.lblModification);
            this.Controls.Add(this.cmdListBack);
            this.Controls.Add(this.dataGridView3);
            this.Name = "frmShowDetailsUser";
            this.Text = "ShowDetailsUser";
            this.Load += new System.EventHandler(this.ShowDetailsUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView3;
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
        private Button cmdListBack;
        private Label lblModification;
    }
}