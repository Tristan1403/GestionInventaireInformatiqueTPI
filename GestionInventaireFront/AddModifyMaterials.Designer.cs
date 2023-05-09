namespace GestionInventaireFront
{
    partial class frmAddModifyMaterials
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblStoragePlace = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRenewDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.rdbArchived = new System.Windows.Forms.CheckBox();
            this.cmdAddModify = new System.Windows.Forms.Button();
            this.cmdHomeAddModify = new System.Windows.Forms.Button();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxStockagePlace = new System.Windows.Forms.ComboBox();
            this.cbxModule = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.dateTPPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dateTPRewnewalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(76, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "nom";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(76, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "description";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(76, 115);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(72, 15);
            this.lblPurchaseDate.TabIndex = 2;
            this.lblPurchaseDate.Text = "date d\'ahcat";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(76, 145);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 15);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "marque";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(76, 172);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(48, 15);
            this.lblModule.TabIndex = 4;
            this.lblModule.Text = "module";
            // 
            // lblStoragePlace
            // 
            this.lblStoragePlace.AutoSize = true;
            this.lblStoragePlace.Location = new System.Drawing.Point(76, 200);
            this.lblStoragePlace.Name = "lblStoragePlace";
            this.lblStoragePlace.Size = new System.Drawing.Size(92, 15);
            this.lblStoragePlace.TabIndex = 5;
            this.lblStoragePlace.Text = "lieu de stockage";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(76, 275);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(30, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "type";
            // 
            // lblRenewDate
            // 
            this.lblRenewDate.AutoSize = true;
            this.lblRenewDate.Location = new System.Drawing.Point(76, 225);
            this.lblRenewDate.Name = "lblRenewDate";
            this.lblRenewDate.Size = new System.Drawing.Size(132, 15);
            this.lblRenewDate.TabIndex = 7;
            this.lblRenewDate.Text = "date de renouvellement";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(76, 249);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "quantité";
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Location = new System.Drawing.Point(76, 304);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(45, 15);
            this.lblArchived.TabIndex = 9;
            this.lblArchived.Text = "archivé";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(234, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(234, 242);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 23);
            this.txtQuantity.TabIndex = 14;
            // 
            // rdbArchived
            // 
            this.rdbArchived.AutoSize = true;
            this.rdbArchived.Location = new System.Drawing.Point(330, 304);
            this.rdbArchived.Name = "rdbArchived";
            this.rdbArchived.Size = new System.Drawing.Size(15, 14);
            this.rdbArchived.TabIndex = 21;
            this.rdbArchived.UseVisualStyleBackColor = true;
            // 
            // cmdAddModify
            // 
            this.cmdAddModify.Location = new System.Drawing.Point(330, 337);
            this.cmdAddModify.Name = "cmdAddModify";
            this.cmdAddModify.Size = new System.Drawing.Size(160, 60);
            this.cmdAddModify.TabIndex = 23;
            this.cmdAddModify.Text = "ajouter/modifier";
            this.cmdAddModify.UseVisualStyleBackColor = true;
            this.cmdAddModify.Click += new System.EventHandler(this.cmdAddModify_Click);
            // 
            // cmdHomeAddModify
            // 
            this.cmdHomeAddModify.Location = new System.Drawing.Point(663, 390);
            this.cmdHomeAddModify.Name = "cmdHomeAddModify";
            this.cmdHomeAddModify.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeAddModify.TabIndex = 24;
            this.cmdHomeAddModify.Text = "accueil admin";
            this.cmdHomeAddModify.UseVisualStyleBackColor = true;
            this.cmdHomeAddModify.Click += new System.EventHandler(this.cmdHomeAddModify_Click);
            // 
            // cbxBrand
            // 
            this.cbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(234, 138);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(200, 23);
            this.cbxBrand.TabIndex = 25;
            // 
            // cbxStockagePlace
            // 
            this.cbxStockagePlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStockagePlace.FormattingEnabled = true;
            this.cbxStockagePlace.Location = new System.Drawing.Point(234, 192);
            this.cbxStockagePlace.Name = "cbxStockagePlace";
            this.cbxStockagePlace.Size = new System.Drawing.Size(200, 23);
            this.cbxStockagePlace.TabIndex = 26;
            // 
            // cbxModule
            // 
            this.cbxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModule.FormattingEnabled = true;
            this.cbxModule.Location = new System.Drawing.Point(234, 165);
            this.cbxModule.Name = "cbxModule";
            this.cbxModule.Size = new System.Drawing.Size(200, 23);
            this.cbxModule.TabIndex = 27;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(234, 268);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(200, 23);
            this.cbxType.TabIndex = 28;
            // 
            // dateTPPurchaseDate
            // 
            this.dateTPPurchaseDate.Location = new System.Drawing.Point(234, 110);
            this.dateTPPurchaseDate.Name = "dateTPPurchaseDate";
            this.dateTPPurchaseDate.Size = new System.Drawing.Size(200, 23);
            this.dateTPPurchaseDate.TabIndex = 29;
            // 
            // dateTPRewnewalDate
            // 
            this.dateTPRewnewalDate.Location = new System.Drawing.Point(234, 217);
            this.dateTPRewnewalDate.Name = "dateTPRewnewalDate";
            this.dateTPRewnewalDate.Size = new System.Drawing.Size(200, 23);
            this.dateTPRewnewalDate.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 453);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // frmAddModifyMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTPRewnewalDate);
            this.Controls.Add(this.dateTPPurchaseDate);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxModule);
            this.Controls.Add(this.cbxStockagePlace);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.cmdHomeAddModify);
            this.Controls.Add(this.cmdAddModify);
            this.Controls.Add(this.rdbArchived);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblArchived);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRenewDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblStoragePlace);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddModifyMaterials";
            this.Text = "AddModifyMaterials";
            this.Load += new System.EventHandler(this.frmAddModifyMaterials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblDescription;
        private Label lblPurchaseDate;
        private Label lblBrand;
        private Label lblModule;
        private Label lblStoragePlace;
        private Label lblType;
        private Label lblRenewDate;
        private Label lblQuantity;
        private Label lblArchived;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private CheckBox rdbArchived;
        private Button cmdAddModify;
        private Button cmdHomeAddModify;
        private ComboBox cbxBrand;
        private ComboBox cbxStockagePlace;
        private ComboBox cbxModule;
        private ComboBox cbxType;
        private DateTimePicker dateTPPurchaseDate;
        private DateTimePicker dateTPRewnewalDate;
        private DateTimePicker dateTimePicker1;
    }
}