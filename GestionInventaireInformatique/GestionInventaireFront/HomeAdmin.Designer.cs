namespace GestionInventaireFront
{
    partial class FrmHomeAdmin
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
            this.CmdInsert = new System.Windows.Forms.Button();
            this.CmdModify = new System.Windows.Forms.Button();
            this.CmdList = new System.Windows.Forms.Button();
            this.cmdHomeAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdInsert
            // 
            this.CmdInsert.Location = new System.Drawing.Point(135, 50);
            this.CmdInsert.Name = "CmdInsert";
            this.CmdInsert.Size = new System.Drawing.Size(464, 92);
            this.CmdInsert.TabIndex = 0;
            this.CmdInsert.Text = "insérer du matériel";
            this.CmdInsert.UseVisualStyleBackColor = true;
            this.CmdInsert.Click += new System.EventHandler(this.CmdInsert_Click);
            // 
            // CmdModify
            // 
            this.CmdModify.Location = new System.Drawing.Point(135, 160);
            this.CmdModify.Name = "CmdModify";
            this.CmdModify.Size = new System.Drawing.Size(464, 92);
            this.CmdModify.TabIndex = 1;
            this.CmdModify.Text = "modifier le matériel";
            this.CmdModify.UseVisualStyleBackColor = true;
            this.CmdModify.Click += new System.EventHandler(this.CmdModify_Click);
            // 
            // CmdList
            // 
            this.CmdList.Location = new System.Drawing.Point(135, 280);
            this.CmdList.Name = "CmdList";
            this.CmdList.Size = new System.Drawing.Size(464, 92);
            this.CmdList.TabIndex = 2;
            this.CmdList.Text = "modifier les listes marques, modules et lieux d\'emplacement";
            this.CmdList.UseVisualStyleBackColor = true;
            this.CmdList.Click += new System.EventHandler(this.CmdList_Click);
            // 
            // cmdHomeAdmin
            // 
            this.cmdHomeAdmin.Location = new System.Drawing.Point(663, 390);
            this.cmdHomeAdmin.Name = "cmdHomeAdmin";
            this.cmdHomeAdmin.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeAdmin.TabIndex = 3;
            this.cmdHomeAdmin.Text = "se déconnecter";
            this.cmdHomeAdmin.UseVisualStyleBackColor = true;
            this.cmdHomeAdmin.Click += new System.EventHandler(this.cmdHomeAdmin_Click);
            // 
            // FrmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdHomeAdmin);
            this.Controls.Add(this.CmdList);
            this.Controls.Add(this.CmdModify);
            this.Controls.Add(this.CmdInsert);
            this.Name = "FrmHomeAdmin";
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.FrmHomeAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CmdInsert;
        private Button CmdModify;
        private Button CmdList;
        private Button cmdHomeAdmin;
    }
}