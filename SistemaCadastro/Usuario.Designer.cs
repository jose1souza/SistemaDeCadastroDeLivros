namespace SistemaCadastro
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.button2 = new System.Windows.Forms.Button();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.BtnConfirmaLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtSenhaLogin, "txtSenhaLogin");
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.TextChanged += new System.EventHandler(this.txtSenhaLogin_TextChanged);
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtUserLogin, "txtUserLogin");
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.TextChanged += new System.EventHandler(this.txtUserLogin_TextChanged);
            // 
            // BtnConfirmaLogin
            // 
            this.BtnConfirmaLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnConfirmaLogin, "BtnConfirmaLogin");
            this.BtnConfirmaLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmaLogin.Name = "BtnConfirmaLogin";
            this.BtnConfirmaLogin.UseVisualStyleBackColor = true;
            this.BtnConfirmaLogin.Click += new System.EventHandler(this.BtnConfirmaLogin_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // Usuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnConfirmaLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.button2);
            this.Name = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Button BtnConfirmaLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}