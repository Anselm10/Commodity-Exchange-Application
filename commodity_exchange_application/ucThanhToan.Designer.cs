namespace commodity_exchange_application
{
    partial class ucThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThanhToan));
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.PostName = new Guna.UI.WinForms.GunaLabel();
            this.PostPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PostPrice = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(104, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(194, 17);
            this.label.TabIndex = 20;
            this.label.Text = "Đổi miễn phí trong vòng 7 ngày";
            // 
            // PostName
            // 
            this.PostName.AutoSize = true;
            this.PostName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostName.Location = new System.Drawing.Point(104, 30);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(499, 17);
            this.PostName.TabIndex = 18;
            this.PostName.Text = "GIÀY THỂ THAO MLB CHUNKY LINER BASIC BOS 3ASXCLB3N-43GOS MÀU VÀNG";
            // 
            // PostPic
            // 
            this.PostPic.Image = ((System.Drawing.Image)(resources.GetObject("PostPic.Image")));
            this.PostPic.ImageRotate = 0F;
            this.PostPic.Location = new System.Drawing.Point(25, 13);
            this.PostPic.Name = "PostPic";
            this.PostPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PostPic.Size = new System.Drawing.Size(73, 83);
            this.PostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostPic.TabIndex = 16;
            this.PostPic.TabStop = false;
            // 
            // PostPrice
            // 
            this.PostPrice.AutoSize = true;
            this.PostPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostPrice.ForeColor = System.Drawing.Color.Red;
            this.PostPrice.Location = new System.Drawing.Point(584, 43);
            this.PostPrice.Name = "PostPrice";
            this.PostPrice.Size = new System.Drawing.Size(92, 21);
            this.PostPrice.TabIndex = 21;
            this.PostPrice.Text = "2.990.000 ₫";
            // 
            // ucThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PostPrice);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PostName);
            this.Controls.Add(this.PostPic);
            this.Name = "ucThanhToan";
            this.Size = new System.Drawing.Size(754, 106);
            this.Load += new System.EventHandler(this.ucThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel label;
        public Guna.UI.WinForms.GunaLabel PostName;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PostPic;
        public Guna.UI.WinForms.GunaLabel PostPrice;
    }
}
