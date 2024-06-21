namespace commodity_exchange_application
{
    partial class FormDK_Ban
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
            this.components = new System.ComponentModel.Container();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblDK_Ban = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaGoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTaHuHai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTaChiTiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTinhTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.txtImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cbLoaiMatHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNgayMua = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaPanel1.Controls.Add(this.lblDK_Ban);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(746, 51);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lblDK_Ban
            // 
            this.lblDK_Ban.AutoSize = true;
            this.lblDK_Ban.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDK_Ban.ForeColor = System.Drawing.Color.White;
            this.lblDK_Ban.Location = new System.Drawing.Point(21, 7);
            this.lblDK_Ban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDK_Ban.Name = "lblDK_Ban";
            this.lblDK_Ban.Size = new System.Drawing.Size(99, 25);
            this.lblDK_Ban.TabIndex = 0;
            this.lblDK_Ban.Text = "Đăng bán";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaPanel2.Controls.Add(this.txtNgayMua);
            this.gunaPanel2.Controls.Add(this.cbLoaiMatHang);
            this.gunaPanel2.Controls.Add(this.btnBrowse);
            this.gunaPanel2.Controls.Add(this.txtImage);
            this.gunaPanel2.Controls.Add(this.txtDiaChi);
            this.gunaPanel2.Controls.Add(this.txtGiaGoc);
            this.gunaPanel2.Controls.Add(this.txtMoTaHuHai);
            this.gunaPanel2.Controls.Add(this.txtName);
            this.gunaPanel2.Controls.Add(this.btnSave);
            this.gunaPanel2.Controls.Add(this.txtPrice);
            this.gunaPanel2.Controls.Add(this.txtMoTaChiTiet);
            this.gunaPanel2.Controls.Add(this.txtTinhTrang);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 51);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(746, 406);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(512, 207);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(135, 37);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Thêm Ảnh";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(46, 207);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "Địa chỉ*";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 39);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaGoc.DefaultText = "";
            this.txtGiaGoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaGoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaGoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaGoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaGoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaGoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaGoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaGoc.Location = new System.Drawing.Point(46, 162);
            this.txtGiaGoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.PasswordChar = '\0';
            this.txtGiaGoc.PlaceholderText = "Giá gốc*";
            this.txtGiaGoc.SelectedText = "";
            this.txtGiaGoc.Size = new System.Drawing.Size(172, 39);
            this.txtGiaGoc.TabIndex = 22;
            // 
            // txtMoTaHuHai
            // 
            this.txtMoTaHuHai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaHuHai.DefaultText = "";
            this.txtMoTaHuHai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaHuHai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaHuHai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaHuHai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaHuHai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaHuHai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTaHuHai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaHuHai.Location = new System.Drawing.Point(248, 162);
            this.txtMoTaHuHai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMoTaHuHai.Name = "txtMoTaHuHai";
            this.txtMoTaHuHai.PasswordChar = '\0';
            this.txtMoTaHuHai.PlaceholderText = "Mô tả hư hại*";
            this.txtMoTaHuHai.SelectedText = "";
            this.txtMoTaHuHai.Size = new System.Drawing.Size(207, 39);
            this.txtMoTaHuHai.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(46, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Tên mặt hàng*";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(172, 39);
            this.txtName.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(234, 316);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Đăng bán";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(46, 116);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Giá bán*";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(172, 39);
            this.txtPrice.TabIndex = 17;
            // 
            // txtMoTaChiTiet
            // 
            this.txtMoTaChiTiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaChiTiet.DefaultText = "";
            this.txtMoTaChiTiet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChiTiet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChiTiet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTaChiTiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChiTiet.Location = new System.Drawing.Point(46, 253);
            this.txtMoTaChiTiet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            this.txtMoTaChiTiet.PasswordChar = '\0';
            this.txtMoTaChiTiet.PlaceholderText = "Mô tả chi tiết*";
            this.txtMoTaChiTiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTaChiTiet.SelectedText = "";
            this.txtMoTaChiTiet.Size = new System.Drawing.Size(553, 58);
            this.txtMoTaChiTiet.TabIndex = 16;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.DefaultText = "";
            this.txtTinhTrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhTrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTinhTrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Location = new System.Drawing.Point(248, 116);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.PasswordChar = '\0';
            this.txtTinhTrang.PlaceholderText = "Tình trạng mặt hàng*";
            this.txtTinhTrang.SelectedText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(207, 39);
            this.txtTinhTrang.TabIndex = 15;
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.Image = global::commodity_exchange_application.Properties.Resources.icon_add;
            this.txtImage.ImageRotate = 0F;
            this.txtImage.Location = new System.Drawing.Point(495, 32);
            this.txtImage.Margin = new System.Windows.Forms.Padding(2);
            this.txtImage.Name = "txtImage";
            this.txtImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtImage.Size = new System.Drawing.Size(173, 168);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 24;
            this.txtImage.TabStop = false;
            // 
            // cbLoaiMatHang
            // 
            this.cbLoaiMatHang.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiMatHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiMatHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiMatHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiMatHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiMatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiMatHang.ItemHeight = 30;
            this.cbLoaiMatHang.Items.AddRange(new object[] {
            "Thời Trang",
            "Đồ gia dụng",
            "Điện thoại",
            "Đồ điện tử",
            "Đồ điện máy",
            "Đồ dùng văn phòng"});
            this.cbLoaiMatHang.Location = new System.Drawing.Point(248, 71);
            this.cbLoaiMatHang.Name = "cbLoaiMatHang";
            this.cbLoaiMatHang.Size = new System.Drawing.Size(207, 36);
            this.cbLoaiMatHang.TabIndex = 26;
            // 
            // txtNgayMua
            // 
            this.txtNgayMua.BackColor = System.Drawing.Color.White;
            this.txtNgayMua.BorderColor = System.Drawing.Color.White;
            this.txtNgayMua.Checked = true;
            this.txtNgayMua.CustomFormat = "yy/mm/dddd";
            this.txtNgayMua.FillColor = System.Drawing.Color.White;
            this.txtNgayMua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtNgayMua.Location = new System.Drawing.Point(248, 207);
            this.txtNgayMua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgayMua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgayMua.Name = "txtNgayMua";
            this.txtNgayMua.Size = new System.Drawing.Size(207, 40);
            this.txtNgayMua.TabIndex = 27;
            this.txtNgayMua.Value = new System.DateTime(2024, 5, 3, 6, 28, 54, 441);
            // 
            // FormDK_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 457);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDK_Ban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDK_Ban";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lblDK_Ban;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtImage;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaGoc;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaHuHai;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaChiTiet;
        private Guna.UI2.WinForms.Guna2TextBox txtTinhTrang;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiMatHang;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtNgayMua;
    }
}