namespace commodity_exchange_application
{
    partial class ucLSMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLSMua));
            this.PostPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.PostName = new Guna.UI.WinForms.GunaLabel();
            this.PostPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPrice
            // 
            this.PostPrice.AutoSize = true;
            this.PostPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostPrice.ForeColor = System.Drawing.Color.Red;
            this.PostPrice.Location = new System.Drawing.Point(105, 61);
            this.PostPrice.Name = "PostPrice";
            this.PostPrice.Size = new System.Drawing.Size(92, 21);
            this.PostPrice.TabIndex = 25;
            this.PostPrice.Text = "2.990.000 ₫";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Lime;
            this.gunaLabel2.Location = new System.Drawing.Point(213, 61);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 21);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "Cho trả giá";
            // 
            // PostName
            // 
            this.PostName.AutoSize = true;
            this.PostName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostName.Location = new System.Drawing.Point(105, 35);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(456, 15);
            this.PostName.TabIndex = 23;
            this.PostName.Text = "GIÀY THỂ THAO MLB CHUNKY LINER BASIC BOS 3ASXCLB3N-43GOS MÀU VÀNG";
            // 
            // PostPic
            // 
            this.PostPic.Image = ((System.Drawing.Image)(resources.GetObject("PostPic.Image")));
            this.PostPic.ImageRotate = 0F;
            this.PostPic.Location = new System.Drawing.Point(26, 18);
            this.PostPic.Name = "PostPic";
            this.PostPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PostPic.Size = new System.Drawing.Size(73, 83);
            this.PostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostPic.TabIndex = 21;
            this.PostPic.TabStop = false;
            // 
            // ucLSMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PostPic);
            this.Controls.Add(this.PostPrice);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.PostName);
            this.Name = "ucLSMua";
            this.Size = new System.Drawing.Size(796, 119);
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2CirclePictureBox PostPic;
        public Guna.UI.WinForms.GunaLabel PostPrice;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLabel PostName;
    }
}
