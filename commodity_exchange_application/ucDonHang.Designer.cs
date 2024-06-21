namespace commodity_exchange_application
{
    partial class ucDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDonHang));
            this.PostPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.PostName = new Guna.UI.WinForms.GunaLabel();
            this.btnDelPost = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PostPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tickbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPrice
            // 
            this.PostPrice.AutoSize = true;
            this.PostPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostPrice.ForeColor = System.Drawing.Color.Red;
            this.PostPrice.Location = new System.Drawing.Point(102, 60);
            this.PostPrice.Name = "PostPrice";
            this.PostPrice.Size = new System.Drawing.Size(92, 21);
            this.PostPrice.TabIndex = 20;
            this.PostPrice.Text = "2.990.000 ₫";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Lime;
            this.gunaLabel2.Location = new System.Drawing.Point(210, 60);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 21);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Cho trả giá";
            // 
            // PostName
            // 
            this.PostName.AutoSize = true;
            this.PostName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostName.Location = new System.Drawing.Point(102, 34);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(425, 17);
            this.PostName.TabIndex = 18;
            this.PostName.Text = "GIÀY THỂ THAO MLB CHUNKY LINER BASIC BOS 3ASXCLB3N-43GOS";
            // 
            // btnDelPost
            // 
            this.btnDelPost.BorderRadius = 20;
            this.btnDelPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelPost.ForeColor = System.Drawing.Color.White;
            this.btnDelPost.Location = new System.Drawing.Point(583, 44);
            this.btnDelPost.Name = "btnDelPost";
            this.btnDelPost.Size = new System.Drawing.Size(122, 37);
            this.btnDelPost.TabIndex = 17;
            this.btnDelPost.Text = "Mua ngay";
            this.btnDelPost.Click += new System.EventHandler(this.btnDelPost_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.PostPic);
            this.guna2Panel1.Controls.Add(this.PostPrice);
            this.guna2Panel1.Controls.Add(this.btnDelPost);
            this.guna2Panel1.Controls.Add(this.gunaLabel2);
            this.guna2Panel1.Controls.Add(this.PostName);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(737, 119);
            this.guna2Panel1.TabIndex = 21;
            // 
            // PostPic
            // 
            this.PostPic.Image = ((System.Drawing.Image)(resources.GetObject("PostPic.Image")));
            this.PostPic.ImageRotate = 0F;
            this.PostPic.Location = new System.Drawing.Point(23, 17);
            this.PostPic.Name = "PostPic";
            this.PostPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PostPic.Size = new System.Drawing.Size(73, 83);
            this.PostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostPic.TabIndex = 16;
            this.PostPic.TabStop = false;
            // 
            // tickbox
            // 
            this.tickbox.AutoSize = true;
            this.tickbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tickbox.CheckedState.BorderRadius = 0;
            this.tickbox.CheckedState.BorderThickness = 0;
            this.tickbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tickbox.Location = new System.Drawing.Point(759, 60);
            this.tickbox.Name = "tickbox";
            this.tickbox.Size = new System.Drawing.Size(15, 14);
            this.tickbox.TabIndex = 22;
            this.tickbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tickbox.UncheckedState.BorderRadius = 0;
            this.tickbox.UncheckedState.BorderThickness = 0;
            this.tickbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tickbox.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // ucDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tickbox);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucDonHang";
            this.Size = new System.Drawing.Size(796, 119);
            this.Load += new System.EventHandler(this.ucDonHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel PostPrice;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLabel PostName;
        public Guna.UI2.WinForms.Guna2Button btnDelPost;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PostPic;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox tickbox;
    }
}
