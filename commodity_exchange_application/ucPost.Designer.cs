namespace commodity_exchange_application
{
    partial class ucPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPost));
            this.PostPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.PostName = new Guna.UI.WinForms.GunaLabel();
            this.btnDelPost = new Guna.UI2.WinForms.Guna2Button();
            this.PostPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPrice
            // 
            this.PostPrice.AutoSize = true;
            this.PostPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostPrice.ForeColor = System.Drawing.Color.Red;
            this.PostPrice.Location = new System.Drawing.Point(110, 60);
            this.PostPrice.Name = "PostPrice";
            this.PostPrice.Size = new System.Drawing.Size(92, 21);
            this.PostPrice.TabIndex = 15;
            this.PostPrice.Text = "2.990.000 ₫";
            this.PostPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PostPrice_MouseClick);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Lime;
            this.gunaLabel2.Location = new System.Drawing.Point(218, 60);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 21);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Cho trả giá";
            this.gunaLabel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PostPrice_MouseClick);
            // 
            // PostName
            // 
            this.PostName.AutoSize = true;
            this.PostName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostName.Location = new System.Drawing.Point(110, 34);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(456, 15);
            this.PostName.TabIndex = 13;
            this.PostName.Text = "GIÀY THỂ THAO MLB CHUNKY LINER BASIC BOS 3ASXCLB3N-43GOS MÀU VÀNG";
            this.PostName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PostPrice_MouseClick);
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
            this.btnDelPost.Location = new System.Drawing.Point(591, 44);
            this.btnDelPost.Name = "btnDelPost";
            this.btnDelPost.Size = new System.Drawing.Size(89, 37);
            this.btnDelPost.TabIndex = 12;
            this.btnDelPost.Text = "Gỡ bài";
            this.btnDelPost.Click += new System.EventHandler(this.btnDelPost_Click);
            // 
            // PostPic
            // 
            this.PostPic.Image = ((System.Drawing.Image)(resources.GetObject("PostPic.Image")));
            this.PostPic.ImageRotate = 0F;
            this.PostPic.Location = new System.Drawing.Point(31, 17);
            this.PostPic.Name = "PostPic";
            this.PostPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PostPic.Size = new System.Drawing.Size(73, 83);
            this.PostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PostPic.TabIndex = 11;
            this.PostPic.TabStop = false;
            this.PostPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PostPrice_MouseClick);
            // 
            // ucPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PostPrice);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.PostName);
            this.Controls.Add(this.btnDelPost);
            this.Controls.Add(this.PostPic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucPost";
            this.Size = new System.Drawing.Size(796, 119);
            this.Click += new System.EventHandler(this.ucPost_Click);
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
    }
}
