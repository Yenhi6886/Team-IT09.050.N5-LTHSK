
namespace Quanlykhachsan
{
    partial class Quanlydatphong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doanqlksDataSet = new Quanlykhachsan.doanqlksDataSet();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanvienTableAdapter = new Quanlykhachsan.doanqlksDataSetTableAdapters.tblNhanvienTableAdapter();
            this.txtMaPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.ComboBox();
            this.tblKhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doanqlksDataSet1 = new Quanlykhachsan.doanqlksDataSet1();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.tblKhachTableAdapter = new Quanlykhachsan.doanqlksDataSet1TableAdapters.tblKhachTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 882);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tempus Sans ITC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 857);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(501, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1411, 354);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // doanqlksDataSet
            // 
            this.doanqlksDataSet.DataSetName = "doanqlksDataSet";
            this.doanqlksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tblNhanvien";
            this.tblNhanvienBindingSource.DataSource = this.doanqlksDataSet;
            // 
            // tblNhanvienTableAdapter
            // 
            this.tblNhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.FormattingEnabled = true;
            this.txtMaPhong.Location = new System.Drawing.Point(184, 297);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(291, 27);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.SelectedIndexChanged += new System.EventHandler(this.txtMaPhong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số phòng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataSource = this.tblNhanvienBindingSource;
            this.txtMaNhanVien.DisplayMember = "HoTen";
            this.txtMaNhanVien.FormattingEnabled = true;
            this.txtMaNhanVien.Location = new System.Drawing.Point(184, 201);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(291, 27);
            this.txtMaNhanVien.TabIndex = 5;
            this.txtMaNhanVien.ValueMember = "MaNhanVien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(184, 381);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(291, 26);
            this.txtDonGia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày đăng ký";
            // 
            // txtNgayDangKy
            // 
            this.txtNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayDangKy.Location = new System.Drawing.Point(763, 45);
            this.txtNgayDangKy.Name = "txtNgayDangKy";
            this.txtNgayDangKy.Size = new System.Drawing.Size(265, 26);
            this.txtNgayDangKy.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày nhận phòng";
            // 
            // txtNgayNhanPhong
            // 
            this.txtNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayNhanPhong.Location = new System.Drawing.Point(763, 107);
            this.txtNgayNhanPhong.Name = "txtNgayNhanPhong";
            this.txtNgayNhanPhong.Size = new System.Drawing.Size(265, 26);
            this.txtNgayNhanPhong.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(763, 252);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(265, 26);
            this.txtTongTien.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Trạng thái";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.DataSource = this.tblKhachBindingSource;
            this.txtMaKhachHang.DisplayMember = "HoTen";
            this.txtMaKhachHang.FormattingEnabled = true;
            this.txtMaKhachHang.Location = new System.Drawing.Point(184, 130);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(291, 27);
            this.txtMaKhachHang.TabIndex = 20;
            this.txtMaKhachHang.ValueMember = "MaKhachHang";
            // 
            // tblKhachBindingSource
            // 
            this.tblKhachBindingSource.DataMember = "tblKhach";
            this.tblKhachBindingSource.DataSource = this.doanqlksDataSet1;
            // 
            // doanqlksDataSet1
            // 
            this.doanqlksDataSet1.DataSetName = "doanqlksDataSet1";
            this.doanqlksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mã khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ngày trả phòng";
            // 
            // txtNgayTraPhong
            // 
            this.txtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayTraPhong.Location = new System.Drawing.Point(763, 174);
            this.txtNgayTraPhong.Name = "txtNgayTraPhong";
            this.txtNgayTraPhong.Size = new System.Drawing.Size(265, 26);
            this.txtNgayTraPhong.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.txtMaDangKy);
            this.panel4.Controls.Add(this.txtTrangthai);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.Thêm);
            this.panel4.Controls.Add(this.txtNgayTraPhong);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtMaKhachHang);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtNgayNhanPhong);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtNgayDangKy);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtDonGia);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtMaNhanVien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtMaPhong);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(504, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1408, 500);
            this.panel4.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1142, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 62);
            this.button3.TabIndex = 29;
            this.button3.Text = "Thêm chi tiết hóa đơn";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.Location = new System.Drawing.Point(184, 48);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(291, 26);
            this.txtMaDangKy.TabIndex = 28;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.FormattingEnabled = true;
            this.txtTrangthai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.txtTrangthai.Location = new System.Drawing.Point(763, 319);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(265, 27);
            this.txtTrangthai.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1142, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 62);
            this.button2.TabIndex = 26;
            this.button2.Text = "Xóa thông tin đăng ký";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1142, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 62);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sửa thông tin đăng ký";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Thêm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Thêm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thêm.ForeColor = System.Drawing.Color.Black;
            this.Thêm.Location = new System.Drawing.Point(1142, 45);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(214, 62);
            this.Thêm.TabIndex = 24;
            this.Thêm.Text = "Đăng ký thông tin";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // tblKhachTableAdapter
            // 
            this.tblKhachTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "THUÊ PHÒNG KHÁCH SẠN";
            // 
            // Quanlyphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1007);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quanlyphong";
            this.Text = "Quanlyphong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Quanlyphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private doanqlksDataSet doanqlksDataSet;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private doanqlksDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private System.Windows.Forms.ComboBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtNgayDangKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtNgayNhanPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtMaKhachHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtNgayTraPhong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Thêm;
        private doanqlksDataSet1 doanqlksDataSet1;
        private System.Windows.Forms.BindingSource tblKhachBindingSource;
        private doanqlksDataSet1TableAdapters.tblKhachTableAdapter tblKhachTableAdapter;
        private System.Windows.Forms.ComboBox txtTrangthai;
        private System.Windows.Forms.TextBox txtMaDangKy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}