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
            this.cmdHomeListAddDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHomeListAddDelete
            // 
            this.cmdHomeListAddDelete.Location = new System.Drawing.Point(663, 390);
            this.cmdHomeListAddDelete.Name = "cmdHomeListAddDelete";
            this.cmdHomeListAddDelete.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeListAddDelete.TabIndex = 4;
            this.cmdHomeListAddDelete.Text = "accueil";
            this.cmdHomeListAddDelete.UseVisualStyleBackColor = true;
            this.cmdHomeListAddDelete.Click += new System.EventHandler(this.cmdHomeListAddDelete_Click);
            // 
            // FrmListMaterialsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdHomeListAddDelete);
            this.Name = "FrmListMaterialsUser";
            this.Text = "ListeMaterialsUser";
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdHomeListAddDelete;
    }
}