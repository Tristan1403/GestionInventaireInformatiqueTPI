namespace GestionInventaireFront
{
    partial class FrmloginAdmin
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
            this.cmdHomeLogin = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdHomeLogin
            // 
            this.cmdHomeLogin.Location = new System.Drawing.Point(663, 390);
            this.cmdHomeLogin.Name = "cmdHomeLogin";
            this.cmdHomeLogin.Size = new System.Drawing.Size(125, 48);
            this.cmdHomeLogin.TabIndex = 0;
            this.cmdHomeLogin.Text = "accueil";
            this.cmdHomeLogin.UseVisualStyleBackColor = true;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(305, 305);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(185, 62);
            this.cmdLogin.TabIndex = 1;
            this.cmdLogin.Text = "se connecter";
            this.cmdLogin.UseVisualStyleBackColor = true;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(181, 94);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(46, 15);
            this.lblPseudo.TabIndex = 2;
            this.lblPseudo.Text = "pseudo";
            this.lblPseudo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(181, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "mot de passe";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(339, 86);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(100, 23);
            this.txtPseudo.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(339, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // FrmloginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdHomeLogin);
            this.Name = "FrmloginAdmin";
            this.Text = "loginAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdHomeLogin;
        private Button cmdLogin;
        private Label lblPseudo;
        private Label lblPassword;
        private TextBox txtPseudo;
        private TextBox txtPassword;
    }
}