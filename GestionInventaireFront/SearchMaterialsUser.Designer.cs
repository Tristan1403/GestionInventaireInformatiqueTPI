namespace GestionInventaireFront
{
    partial class frmSearchMaterialsUser
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
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxModule = new System.Windows.Forms.ComboBox();
            this.cbxStockagePlace = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.txtPurchaseDate = new System.Windows.Forms.TextBox();
            this.txtRenewDate = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRenewDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStoragePlace = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdHomeSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(152, 316);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 23);
            this.cbxType.TabIndex = 46;
            // 
            // cbxModule
            // 
            this.cbxModule.FormattingEnabled = true;
            this.cbxModule.Location = new System.Drawing.Point(152, 213);
            this.cbxModule.Name = "cbxModule";
            this.cbxModule.Size = new System.Drawing.Size(121, 23);
            this.cbxModule.TabIndex = 45;
            // 
            // cbxStockagePlace
            // 
            this.cbxStockagePlace.FormattingEnabled = true;
            this.cbxStockagePlace.Location = new System.Drawing.Point(152, 240);
            this.cbxStockagePlace.Name = "cbxStockagePlace";
            this.cbxStockagePlace.Size = new System.Drawing.Size(121, 23);
            this.cbxStockagePlace.TabIndex = 44;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(152, 186);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 23);
            this.cbxBrand.TabIndex = 43;
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Location = new System.Drawing.Point(152, 158);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(121, 23);
            this.txtPurchaseDate.TabIndex = 42;
            // 
            // txtRenewDate
            // 
            this.txtRenewDate.Location = new System.Drawing.Point(152, 265);
            this.txtRenewDate.Name = "txtRenewDate";
            this.txtRenewDate.Size = new System.Drawing.Size(121, 23);
            this.txtRenewDate.TabIndex = 41;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(152, 290);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 23);
            this.txtQuantity.TabIndex = 40;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(152, 129);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(121, 23);
            this.txtDescription.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 23);
            this.txtName.TabIndex = 38;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(50, 298);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 37;
            this.lblQuantity.Text = "quantité";
            // 
            // lblRenewDate
            // 
            this.lblRenewDate.AutoSize = true;
            this.lblRenewDate.Location = new System.Drawing.Point(50, 273);
            this.lblRenewDate.Name = "lblRenewDate";
            this.lblRenewDate.Size = new System.Drawing.Size(132, 15);
            this.lblRenewDate.TabIndex = 36;
            this.lblRenewDate.Text = "date de renouvellement";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(50, 324);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(30, 15);
            this.lblType.TabIndex = 35;
            this.lblType.Text = "type";
            // 
            // lblStoragePlace
            // 
            this.lblStoragePlace.AutoSize = true;
            this.lblStoragePlace.Location = new System.Drawing.Point(50, 248);
            this.lblStoragePlace.Name = "lblStoragePlace";
            this.lblStoragePlace.Size = new System.Drawing.Size(92, 15);
            this.lblStoragePlace.TabIndex = 34;
            this.lblStoragePlace.Text = "lieu de stockage";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(50, 221);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(48, 15);
            this.lblModule.TabIndex = 33;
            this.lblModule.Text = "module";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(50, 194);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 15);
            this.lblBrand.TabIndex = 32;
            this.lblBrand.Text = "marque";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(50, 164);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(72, 15);
            this.lblPurchaseDate.TabIndex = 31;
            this.lblPurchaseDate.Text = "date d\'ahcat";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 132);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 15);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 15);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "nom";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(284, 359);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(194, 60);
            this.cmdSearch.TabIndex = 47;
            this.cmdSearch.Text = "chercher";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdHomeSearch
            // 
            this.cmdHomeSearch.Location = new System.Drawing.Point(663, 390);
            this.cmdHomeSearch.Name = "cmdHomeSearch";
            this.cmdHomeSearch.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeSearch.TabIndex = 48;
            this.cmdHomeSearch.Text = "accueil";
            this.cmdHomeSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(209, 39);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(369, 15);
            this.lblSearch.TabIndex = 49;
            this.lblSearch.Text = "Voici le menu de recherche! Veuillez sélectionner au moins un critère!";
            // 
            // frmSearchMaterialsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmdHomeSearch);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxModule);
            this.Controls.Add(this.cbxStockagePlace);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.txtPurchaseDate);
            this.Controls.Add(this.txtRenewDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRenewDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblStoragePlace);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "frmSearchMaterialsUser";
            this.Text = "SearchMaterialsUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxType;
        private ComboBox cbxModule;
        private ComboBox cbxStockagePlace;
        private ComboBox cbxBrand;
        private TextBox txtPurchaseDate;
        private TextBox txtRenewDate;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblQuantity;
        private Label lblRenewDate;
        private Label lblType;
        private Label lblStoragePlace;
        private Label lblModule;
        private Label lblBrand;
        private Label lblPurchaseDate;
        private Label lblDescription;
        private Label lblName;
        private Button cmdSearch;
        private Button cmdHomeSearch;
        private Label lblSearch;
    }
}