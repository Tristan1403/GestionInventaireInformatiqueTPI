namespace GestionInventaireFront
{
    partial class FrmListModifyAdmin
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
            this.lblBrands = new System.Windows.Forms.Label();
            this.cbxBrands = new System.Windows.Forms.ComboBox();
            this.txtBrands = new System.Windows.Forms.TextBox();
            this.cmdHomeListAddDelete = new System.Windows.Forms.Button();
            this.txtModules = new System.Windows.Forms.TextBox();
            this.cbxModules = new System.Windows.Forms.ComboBox();
            this.lblModules = new System.Windows.Forms.Label();
            this.txtPlaces = new System.Windows.Forms.TextBox();
            this.cbxPlaces = new System.Windows.Forms.ComboBox();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.tbxTypes = new System.Windows.Forms.TextBox();
            this.cbxTypes = new System.Windows.Forms.ComboBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Location = new System.Drawing.Point(42, 117);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(53, 15);
            this.lblBrands.TabIndex = 0;
            this.lblBrands.Text = "marques";
            // 
            // cbxBrands
            // 
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Location = new System.Drawing.Point(42, 154);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(121, 23);
            this.cbxBrands.TabIndex = 1;
            // 
            // txtBrands
            // 
            this.txtBrands.Location = new System.Drawing.Point(42, 215);
            this.txtBrands.Name = "txtBrands";
            this.txtBrands.Size = new System.Drawing.Size(121, 23);
            this.txtBrands.TabIndex = 2;
            // 
            // cmdHomeListAddDelete
            // 
            this.cmdHomeListAddDelete.Location = new System.Drawing.Point(663, 390);
            this.cmdHomeListAddDelete.Name = "cmdHomeListAddDelete";
            this.cmdHomeListAddDelete.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeListAddDelete.TabIndex = 3;
            this.cmdHomeListAddDelete.Text = "accueil admin";
            this.cmdHomeListAddDelete.UseVisualStyleBackColor = true;
            this.cmdHomeListAddDelete.Click += new System.EventHandler(this.cmdHomeListAddDelete_Click);
            // 
            // txtModules
            // 
            this.txtModules.Location = new System.Drawing.Point(196, 215);
            this.txtModules.Name = "txtModules";
            this.txtModules.Size = new System.Drawing.Size(121, 23);
            this.txtModules.TabIndex = 6;
            // 
            // cbxModules
            // 
            this.cbxModules.FormattingEnabled = true;
            this.cbxModules.Location = new System.Drawing.Point(196, 154);
            this.cbxModules.Name = "cbxModules";
            this.cbxModules.Size = new System.Drawing.Size(121, 23);
            this.cbxModules.TabIndex = 5;
            this.cbxModules.SelectedIndexChanged += new System.EventHandler(this.cbxModules_SelectedIndexChanged);
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Location = new System.Drawing.Point(196, 117);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(53, 15);
            this.lblModules.TabIndex = 4;
            this.lblModules.Text = "modules";
            // 
            // txtPlaces
            // 
            this.txtPlaces.Location = new System.Drawing.Point(357, 215);
            this.txtPlaces.Name = "txtPlaces";
            this.txtPlaces.Size = new System.Drawing.Size(121, 23);
            this.txtPlaces.TabIndex = 9;
            // 
            // cbxPlaces
            // 
            this.cbxPlaces.FormattingEnabled = true;
            this.cbxPlaces.Location = new System.Drawing.Point(357, 154);
            this.cbxPlaces.Name = "cbxPlaces";
            this.cbxPlaces.Size = new System.Drawing.Size(121, 23);
            this.cbxPlaces.TabIndex = 8;
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Location = new System.Drawing.Point(357, 117);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(98, 15);
            this.lblPlaces.TabIndex = 7;
            this.lblPlaces.Text = "lieux de stockage";
            // 
            // tbxTypes
            // 
            this.tbxTypes.Location = new System.Drawing.Point(508, 215);
            this.tbxTypes.Name = "tbxTypes";
            this.tbxTypes.Size = new System.Drawing.Size(121, 23);
            this.tbxTypes.TabIndex = 12;
            // 
            // cbxTypes
            // 
            this.cbxTypes.FormattingEnabled = true;
            this.cbxTypes.Location = new System.Drawing.Point(508, 154);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(121, 23);
            this.cbxTypes.TabIndex = 11;
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(508, 117);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(35, 15);
            this.lblTypes.TabIndex = 10;
            this.lblTypes.Text = "types";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(663, 144);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(106, 40);
            this.cmdDelete.TabIndex = 13;
            this.cmdDelete.Text = "effacer";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(663, 205);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(106, 41);
            this.cmdAdd.TabIndex = 14;
            this.cmdAdd.Text = "ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // FrmListModifyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.tbxTypes);
            this.Controls.Add(this.cbxTypes);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.txtPlaces);
            this.Controls.Add(this.cbxPlaces);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.txtModules);
            this.Controls.Add(this.cbxModules);
            this.Controls.Add(this.lblModules);
            this.Controls.Add(this.cmdHomeListAddDelete);
            this.Controls.Add(this.txtBrands);
            this.Controls.Add(this.cbxBrands);
            this.Controls.Add(this.lblBrands);
            this.Name = "FrmListModifyAdmin";
            this.Text = "ListeModifyAdmin";
            this.Load += new System.EventHandler(this.ListModifyAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBrands;
        private ComboBox cbxBrands;
        private TextBox txtBrands;
        private Button cmdHomeListAddDelete;
        private TextBox txtModules;
        private ComboBox cbxModules;
        private Label lblModules;
        private TextBox txtPlaces;
        private ComboBox cbxPlaces;
        private Label lblPlaces;
        private TextBox tbxTypes;
        private ComboBox cbxTypes;
        private Label lblTypes;
        private Button cmdDelete;
        private Button cmdAdd;
    }
}