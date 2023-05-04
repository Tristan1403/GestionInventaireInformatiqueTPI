namespace GestionInventaireFront
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdUser = new System.Windows.Forms.Button();
            this.CmdAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdUser
            // 
            this.CmdUser.Location = new System.Drawing.Point(114, 189);
            this.CmdUser.Name = "CmdUser";
            this.CmdUser.Size = new System.Drawing.Size(193, 133);
            this.CmdUser.TabIndex = 0;
            this.CmdUser.Text = "partie utilisateur";
            this.CmdUser.UseVisualStyleBackColor = true;
            this.CmdUser.Click += new System.EventHandler(this.CmdUser_Click);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Location = new System.Drawing.Point(471, 189);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(193, 133);
            this.CmdAdmin.TabIndex = 1;
            this.CmdAdmin.Text = "partie administrateur";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            this.CmdAdmin.Click += new System.EventHandler(this.CmdAdmin_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdAdmin);
            this.Controls.Add(this.CmdUser);
            this.Name = "FrmHome";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CmdUser;
        private Button CmdAdmin;
    }
}