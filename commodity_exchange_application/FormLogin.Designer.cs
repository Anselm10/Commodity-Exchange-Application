namespace commodity_exchange_application
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnSignIn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignUp = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIn.Location = new System.Drawing.Point(395, 318);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Radius = 20;
            this.btnSignIn.Size = new System.Drawing.Size(169, 44);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(362, 203);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 21);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Tên tài khoản";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(362, 267);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(75, 21);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Mật khẩu";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaPanel2.Location = new System.Drawing.Point(346, 385);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(454, 74);
            this.gunaPanel2.TabIndex = 8;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaPanel3.Controls.Add(this.gunaLabel1);
            this.gunaPanel3.Controls.Add(this.panel1);
            this.gunaPanel3.Location = new System.Drawing.Point(346, 2);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(454, 138);
            this.gunaPanel3.TabIndex = 9;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(182, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(214, 65);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Aladdin";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::commodity_exchange_application.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(59, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 86);
            this.panel1.TabIndex = 3;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AnimationHoverSpeed = 0.07F;
            this.btnSignUp.AnimationSpeed = 0.03F;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSignUp.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = null;
            this.btnSignUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUp.Location = new System.Drawing.Point(598, 318);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSignUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignUp.OnHoverImage = null;
            this.btnSignUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUp.Radius = 20;
            this.btnSignUp.Size = new System.Drawing.Size(169, 44);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPanel1.Location = new System.Drawing.Point(1, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(346, 457);
            this.gunaPanel1.TabIndex = 0;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "RMS";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderRadius = 20;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(469, 188);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(298, 36);
            this.txtUserName.TabIndex = 11;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderRadius = 20;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Location = new System.Drawing.Point(469, 252);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.PlaceholderText = "";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(298, 36);
            this.txtPassWord.TabIndex = 12;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnSignIn;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnSignUp;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
    }
}

