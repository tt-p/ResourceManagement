namespace FP_Group_27
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.lblWarn = new System.Windows.Forms.Label();
            this.topBar1 = new FP_Group_27.ERMS.UI_Components.TopBar();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.AutoCompleteCustomSource.AddRange(new string[] {
            "Eren",
            "Mehmet Ali",
            "Taha"});
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUser.Location = new System.Drawing.Point(108, 7);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(134, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(36, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User Name :";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(43, 46);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password :";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(108, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(134, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // checkPass
            // 
            this.checkPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(248, 44);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(53, 17);
            this.checkPass.TabIndex = 4;
            this.checkPass.Text = "Show";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // tlPanel
            // 
            this.tlPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlPanel.ColumnCount = 3;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlPanel.Controls.Add(this.checkPass, 2, 1);
            this.tlPanel.Controls.Add(this.txtUser, 1, 0);
            this.tlPanel.Controls.Add(this.txtPass, 1, 1);
            this.tlPanel.Controls.Add(this.lblPass, 0, 1);
            this.tlPanel.Controls.Add(this.lblUser, 0, 0);
            this.tlPanel.Controls.Add(this.btnLogin, 1, 2);
            this.tlPanel.Location = new System.Drawing.Point(262, 288);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 3;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlPanel.Size = new System.Drawing.Size(350, 100);
            this.tlPanel.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(108, 73);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbxUser
            // 
            this.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxUser.Image = global::FP_Group_27.Properties.Resources.user;
            this.pbxUser.Location = new System.Drawing.Point(262, 102);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(350, 136);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 6;
            this.pbxUser.TabStop = false;
            // 
            // lblWarn
            // 
            this.lblWarn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWarn.AutoSize = true;
            this.lblWarn.Location = new System.Drawing.Point(437, 272);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(0, 13);
            this.lblWarn.TabIndex = 7;
            this.lblWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topBar1
            // 
            this.topBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.topBar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.form = this;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.MinBtn = true;
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(900, 30);
            this.topBar1.TabIndex = 8;
            this.topBar1.TextColor = System.Drawing.Color.White;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(863, 463);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.tlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.tlPanel.ResumeLayout(false);
            this.tlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWarn;
        private ERMS.UI_Components.TopBar topBar1;
        private System.Windows.Forms.Button btnHelp;
    }
}

