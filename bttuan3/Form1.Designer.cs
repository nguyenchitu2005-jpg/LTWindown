namespace bttuan3
{
    partial class Form1
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
            this.lblFormDatHang = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lstDanhSachSanPham = new System.Windows.Forms.ListBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.cboThanhToan = new System.Windows.Forms.ComboBox();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.txtThongTinDonHang = new System.Windows.Forms.TextBox();
            this.lblThongTinDonHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormDatHang
            // 
            this.lblFormDatHang.AutoSize = true;
            this.lblFormDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormDatHang.Location = new System.Drawing.Point(29, 29);
            this.lblFormDatHang.Name = "lblFormDatHang";
            this.lblFormDatHang.Size = new System.Drawing.Size(181, 29);
            this.lblFormDatHang.TabIndex = 0;
            this.lblFormDatHang.Text = "Form đặt hàng";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(29, 84);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(107, 20);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(29, 112);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(94, 20);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(154, 82);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(218, 22);
            this.txtKhachHang.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(154, 110);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(218, 22);
            this.txtDienThoai.TabIndex = 4;
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(30, 161);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(186, 20);
            this.lblDanhSachSanPham.TabIndex = 5;
            this.lblDanhSachSanPham.Text = "Danh sách sản phẩm";
            // 
            // lstDanhSachSanPham
            // 
            this.lstDanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhSachSanPham.FormattingEnabled = true;
            this.lstDanhSachSanPham.ItemHeight = 20;
            this.lstDanhSachSanPham.Items.AddRange(new object[] {
            "Doraemon",
            "Kinh Van Hoa",
            "Harry Potter"});
            this.lstDanhSachSanPham.Location = new System.Drawing.Point(33, 193);
            this.lstDanhSachSanPham.Name = "lstDanhSachSanPham";
            this.lstDanhSachSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDanhSachSanPham.Size = new System.Drawing.Size(339, 144);
            this.lstDanhSachSanPham.TabIndex = 6;
            this.lstDanhSachSanPham.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachSanPham_SelectedIndexChanged);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.Location = new System.Drawing.Point(30, 356);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(102, 20);
            this.lblThanhToan.TabIndex = 7;
            this.lblThanhToan.Text = "Thanh toán";
            // 
            // cboThanhToan
            // 
            this.cboThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThanhToan.FormattingEnabled = true;
            this.cboThanhToan.Items.AddRange(new object[] {
            "ATM",
            "Momo",
            "Zalopay",
            "Tiền mặt"});
            this.cboThanhToan.Location = new System.Drawing.Point(33, 379);
            this.cboThanhToan.Name = "cboThanhToan";
            this.cboThanhToan.Size = new System.Drawing.Size(339, 28);
            this.cboThanhToan.TabIndex = 8;
            this.cboThanhToan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Location = new System.Drawing.Point(33, 413);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(110, 31);
            this.btnDatHang.TabIndex = 9;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // txtThongTinDonHang
            // 
            this.txtThongTinDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinDonHang.Location = new System.Drawing.Point(453, 112);
            this.txtThongTinDonHang.Multiline = true;
            this.txtThongTinDonHang.Name = "txtThongTinDonHang";
            this.txtThongTinDonHang.Size = new System.Drawing.Size(290, 308);
            this.txtThongTinDonHang.TabIndex = 10;
            // 
            // lblThongTinDonHang
            // 
            this.lblThongTinDonHang.AutoSize = true;
            this.lblThongTinDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinDonHang.Location = new System.Drawing.Point(449, 82);
            this.lblThongTinDonHang.Name = "lblThongTinDonHang";
            this.lblThongTinDonHang.Size = new System.Drawing.Size(169, 20);
            this.lblThongTinDonHang.TabIndex = 11;
            this.lblThongTinDonHang.Text = "Thông tin đơn hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.lblThongTinDonHang);
            this.Controls.Add(this.txtThongTinDonHang);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.cboThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.lstDanhSachSanPham);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblFormDatHang);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình đặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormDatHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.ListBox lstDanhSachSanPham;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.ComboBox cboThanhToan;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.TextBox txtThongTinDonHang;
        private System.Windows.Forms.Label lblThongTinDonHang;
    }
}

