
namespace Quanlykhachsan
{
    partial class Quanlychitiethoadon
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Thêm = new System.Windows.Forms.Button();
            this.txtMaDichVu = new System.Windows.Forms.ComboBox();
            this.tblDichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doanqlksDataSet3 = new Quanlykhachsan.doanqlksDataSet3();
            this.txtGiaDichVu = new System.Windows.Forms.ComboBox();
            this.txtNgaySuDung = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDangKy = new System.Windows.Forms.ComboBox();
            this.tblDangkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doanqlksDataSet2 = new Quanlykhachsan.doanqlksDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblDangkyTableAdapter = new Quanlykhachsan.doanqlksDataSet2TableAdapters.tblDangkyTableAdapter();
            this.tblDichvuTableAdapter = new Quanlykhachsan.doanqlksDataSet3TableAdapters.tblDichvuTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Thêm);
            this.groupBox1.Controls.Add(this.txtMaDichVu);
            this.groupBox1.Controls.Add(this.txtGiaDichVu);
            this.groupBox1.Controls.Add(this.txtNgaySuDung);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaDangKy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1217, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(736, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(546, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Thêm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Thêm.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thêm.ForeColor = System.Drawing.Color.Black;
            this.Thêm.Location = new System.Drawing.Point(360, 254);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(126, 39);
            this.Thêm.TabIndex = 23;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.DataSource = this.tblDichvuBindingSource;
            this.txtMaDichVu.DisplayMember = "TenDichVu";
            this.txtMaDichVu.FormattingEnabled = true;
            this.txtMaDichVu.Location = new System.Drawing.Point(187, 150);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(311, 27);
            this.txtMaDichVu.TabIndex = 8;
            this.txtMaDichVu.ValueMember = "MaDichVu";
            this.txtMaDichVu.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tblDichvuBindingSource
            // 
            this.tblDichvuBindingSource.DataMember = "tblDichvu";
            this.tblDichvuBindingSource.DataSource = this.doanqlksDataSet3;
            // 
            // doanqlksDataSet3
            // 
            this.doanqlksDataSet3.DataSetName = "doanqlksDataSet3";
            this.doanqlksDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.FormattingEnabled = true;
            this.txtGiaDichVu.Location = new System.Drawing.Point(806, 150);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.Size = new System.Drawing.Size(282, 27);
            this.txtGiaDichVu.TabIndex = 7;
            // 
            // txtNgaySuDung
            // 
            this.txtNgaySuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySuDung.Location = new System.Drawing.Point(806, 77);
            this.txtNgaySuDung.Name = "txtNgaySuDung";
            this.txtNgaySuDung.Size = new System.Drawing.Size(282, 26);
            this.txtNgaySuDung.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sử dụng";
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.DataSource = this.tblDangkyBindingSource;
            this.txtMaDangKy.DisplayMember = "MaDangKy";
            this.txtMaDangKy.FormattingEnabled = true;
            this.txtMaDangKy.Location = new System.Drawing.Point(187, 77);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(311, 27);
            this.txtMaDangKy.TabIndex = 3;
            this.txtMaDangKy.ValueMember = "MaDangKy";
            // 
            // tblDangkyBindingSource
            // 
            this.tblDangkyBindingSource.DataMember = "tblDangky";
            this.tblDangkyBindingSource.DataSource = this.doanqlksDataSet2;
            // 
            // doanqlksDataSet2
            // 
            this.doanqlksDataSet2.DataSetName = "doanqlksDataSet2";
            this.doanqlksDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đăng ký ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(22, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1217, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblDangkyTableAdapter
            // 
            this.tblDangkyTableAdapter.ClearBeforeFill = true;
            // 
            // tblDichvuTableAdapter
            // 
            this.tblDichvuTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(649, 57);
            this.label7.TabIndex = 6;
            this.label7.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            // 
            // Quanlychitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 862);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quanlychitiethoadon";
            this.Text = "Quanlychitiethoadon";
            this.Load += new System.EventHandler(this.Quanlychitiethoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanqlksDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtMaDichVu;
        private System.Windows.Forms.ComboBox txtGiaDichVu;
        private System.Windows.Forms.DateTimePicker txtNgaySuDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtMaDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private doanqlksDataSet2 doanqlksDataSet2;
        private System.Windows.Forms.BindingSource tblDangkyBindingSource;
        private doanqlksDataSet2TableAdapters.tblDangkyTableAdapter tblDangkyTableAdapter;
        private doanqlksDataSet3 doanqlksDataSet3;
        private System.Windows.Forms.BindingSource tblDichvuBindingSource;
        private doanqlksDataSet3TableAdapters.tblDichvuTableAdapter tblDichvuTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.Label label7;
    }
}