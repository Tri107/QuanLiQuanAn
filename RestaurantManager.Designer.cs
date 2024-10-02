namespace QLQuanAn
{
    partial class RestaurantManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLoaiMonAn = new System.Windows.Forms.Button();
            this.btnMonAn = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cmbMonAn = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbChonBan = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsvDanhMuc = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnLoaiMonAn);
            this.panel1.Controls.Add(this.btnMonAn);
            this.panel1.Controls.Add(this.btnBan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 683);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Chocolate;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(38, 586);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(143, 43);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Chocolate;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(38, 501);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(143, 43);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Chocolate;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(38, 416);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(143, 43);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLoaiMonAn
            // 
            this.btnLoaiMonAn.BackColor = System.Drawing.Color.Chocolate;
            this.btnLoaiMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiMonAn.ForeColor = System.Drawing.Color.White;
            this.btnLoaiMonAn.Location = new System.Drawing.Point(38, 331);
            this.btnLoaiMonAn.Name = "btnLoaiMonAn";
            this.btnLoaiMonAn.Size = new System.Drawing.Size(143, 43);
            this.btnLoaiMonAn.TabIndex = 1;
            this.btnLoaiMonAn.Text = "Loại món ăn";
            this.btnLoaiMonAn.UseVisualStyleBackColor = false;
            this.btnLoaiMonAn.Click += new System.EventHandler(this.btnLoaiMonAn_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.BackColor = System.Drawing.Color.Chocolate;
            this.btnMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.ForeColor = System.Drawing.Color.White;
            this.btnMonAn.Location = new System.Drawing.Point(38, 246);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Size = new System.Drawing.Size(143, 43);
            this.btnMonAn.TabIndex = 1;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.UseVisualStyleBackColor = false;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.White;
            this.btnBan.Location = new System.Drawing.Point(38, 161);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(143, 43);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bàn";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLQuanAn.Properties.Resources.Designer;
            this.pictureBox1.Location = new System.Drawing.Point(38, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.cmbLoaiMonAn);
            this.panel2.Controls.Add(this.nudSoLuong);
            this.panel2.Controls.Add(this.btnThemMon);
            this.panel2.Controls.Add(this.cmbMonAn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 100);
            this.panel2.TabIndex = 1;
            // 
            // cmbLoaiMonAn
            // 
            this.cmbLoaiMonAn.FormattingEnabled = true;
            this.cmbLoaiMonAn.Location = new System.Drawing.Point(775, 13);
            this.cmbLoaiMonAn.Name = "cmbLoaiMonAn";
            this.cmbLoaiMonAn.Size = new System.Drawing.Size(159, 28);
            this.cmbLoaiMonAn.TabIndex = 6;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(941, 40);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 26);
            this.nudSoLuong.TabIndex = 5;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(1027, 12);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 75);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // cmbMonAn
            // 
            this.cmbMonAn.FormattingEnabled = true;
            this.cmbMonAn.Location = new System.Drawing.Point(775, 59);
            this.cmbMonAn.Name = "cmbMonAn";
            this.cmbMonAn.Size = new System.Drawing.Size(159, 28);
            this.cmbMonAn.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(902, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 339);
            this.panel3.TabIndex = 2;
            // 
            // cmbChonBan
            // 
            this.cmbChonBan.FormattingEnabled = true;
            this.cmbChonBan.Location = new System.Drawing.Point(6, 51);
            this.cmbChonBan.Name = "cmbChonBan";
            this.cmbChonBan.Size = new System.Drawing.Size(136, 28);
            this.cmbChonBan.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lsvDanhMuc);
            this.panel4.Location = new System.Drawing.Point(992, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 471);
            this.panel4.TabIndex = 2;
            // 
            // lsvDanhMuc
            // 
            this.lsvDanhMuc.HideSelection = false;
            this.lsvDanhMuc.Location = new System.Drawing.Point(3, 3);
            this.lsvDanhMuc.Name = "lsvDanhMuc";
            this.lsvDanhMuc.Size = new System.Drawing.Size(366, 465);
            this.lsvDanhMuc.TabIndex = 0;
            this.lsvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lsvDanhMuc.View = System.Windows.Forms.View.Details;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FloralWhite;
            this.panel5.Controls.Add(this.btnThanhToan);
            this.panel5.Controls.Add(this.btnChuyenBan);
            this.panel5.Controls.Add(this.txtTongTien);
            this.panel5.Controls.Add(this.cmbChonBan);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(992, 583);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 100);
            this.panel5.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(252, 36);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 52);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(148, 36);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(98, 52);
            this.btnChuyenBan.TabIndex = 2;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(121, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(202, 26);
            this.txtTongTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Tiền";
            // 
            // flpBan
            // 
            this.flpBan.Location = new System.Drawing.Point(223, 106);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(763, 577);
            this.flpBan.TabIndex = 4;
            // 
            // RestaurantManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1361, 683);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1383, 739);
            this.Name = "RestaurantManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán ăn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cmbMonAn;
        private System.Windows.Forms.ComboBox cmbChonBan;
        private System.Windows.Forms.ListView lsvDanhMuc;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiMonAn;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLoaiMonAn;
        private System.Windows.Forms.Button btnMonAn;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
    }
}