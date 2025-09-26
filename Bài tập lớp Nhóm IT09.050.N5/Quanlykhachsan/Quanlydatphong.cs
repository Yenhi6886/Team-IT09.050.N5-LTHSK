using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class Quanlydatphong : Form
    {
        public Quanlydatphong()
        {
            InitializeComponent();
            LoadPhongButtons();
        }
        private string connectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True";

        private void LoadPhongButtons()
        {
            flowLayoutPanel1.Controls.Clear();
            using (SqlConnection connection = new SqlConnection("Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT SoPhong, TrangThai FROM tblPhong";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int soPhong = reader.GetInt32(0);
                    string trangThai = reader.GetString(1);

                    Button phongButton = new Button
                    {
                        Text = $"Phòng {soPhong}",
                        Width = 100,
                        Height = 50,
                        Tag = trangThai, // Store TrangThai in the Tag property for later use
                        Name = soPhong.ToString()
                    };

                    // Set button color based on TrangThai
                    if (trangThai == "Trong")
                    {
                        phongButton.BackColor = System.Drawing.Color.White;
                    }
                    else if (trangThai == "Da dat")
                    {
                        phongButton.BackColor = System.Drawing.Color.Yellow;
                    }

                    // Add a click event handler
                    phongButton.Click += PhongButton_Click;

                    // Add the button to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(phongButton);
                }
            }
        }
        private void PhongButton_Click(object sender, EventArgs e)
        {
            // Access the button's properties using 'sender'
            Button clickedButton = (Button)sender;

            // For example, to get the TrangThai:
            string trangThai = clickedButton.Tag.ToString();
            if(trangThai== "Da dat")
            {
                MessageBox.Show("Phòng đã có người đặt ,vui lòng chọn phòng khác");
            }
            else
            {
                // Now you can use the room number (SoPhong) to load the corresponding room type and room number
                string soPhong = clickedButton.Name;

                // Load room type into cbLoaiphong
                

                // Load room number into cbPhong
                txtMaPhong.Text = soPhong;
                ClearTextBoxes();
            }
            if (txtMaPhong.Text != "")
            {
                string selectedSoPhong = txtMaPhong.Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = $"SELECT DonGia FROM tblPhong WHERE SoPhong = @SoPhong";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SoPhong", selectedSoPhong);

                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                txtDonGia.Text = result.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading DonGia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
       
        private DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        private void LoadData()
        {
            DataTable dataTable = ExecuteStoredProcedure("sp_GetAllDangKy");
            dataGridView1.DataSource = dataTable;
        }
        private void Quanlyphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doanqlksDataSet1.tblKhach' table. You can move, or remove it, as needed.
            this.tblKhachTableAdapter.Fill(this.doanqlksDataSet1.tblKhach);
            // TODO: This line of code loads data into the 'doanqlksDataSet.tblNhanvien' table. You can move, or remove it, as needed.
            this.tblNhanvienTableAdapter.Fill(this.doanqlksDataSet.tblNhanvien);
            LoadData();
        }

        private void Thêm_Click(object sender, EventArgs e)
        {  // Assuming you have textboxes for input, adjust the names accordingly
            int maKhachHang = int.Parse(txtMaKhachHang.SelectedValue.ToString());
            int maNhanVien = int.Parse(txtMaNhanVien.SelectedValue.ToString());
            int maPhong = int.Parse(txtMaPhong.Text);
            int donGia = int.Parse(txtDonGia.Text);
            DateTime ngayDangKy = DateTime.Parse(txtNgayDangKy.Text);
            DateTime ngayNhanPhong = DateTime.Parse(txtNgayNhanPhong.Text);
            DateTime ngayTraPhong = DateTime.Parse(txtNgayTraPhong.Text);
            int tongTien = int.Parse(txtTongTien.Text);
            string trangThai = txtTrangthai.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_InsertDangKy", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaDangKy", int.Parse(txtMaDangKy.Text));
                        // Add parameters
                        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@DonGia", donGia);
                        command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                        command.Parameters.AddWithValue("@NgayNhanPhong", ngayNhanPhong);
                        command.Parameters.AddWithValue("@NgayTraPhong", ngayTraPhong);
                        command.Parameters.AddWithValue("@TongTien", tongTien);
                        command.Parameters.AddWithValue("@Trangthai", trangThai);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
            LoadPhongButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming you have textboxes for input, adjust the names accordingly
            int maDangKy = int.Parse(txtMaDangKy.Text);
            int maKhachHang = int.Parse(txtMaKhachHang.SelectedValue.ToString());
            int maNhanVien = int.Parse(txtMaNhanVien.SelectedValue.ToString());
            int maPhong = int.Parse(txtMaPhong.Text);
            int donGia = int.Parse(txtDonGia.Text);
            DateTime ngayDangKy = DateTime.Parse(txtNgayDangKy.Text);
            DateTime ngayNhanPhong = DateTime.Parse(txtNgayNhanPhong.Text);
            DateTime ngayTraPhong = DateTime.Parse(txtNgayTraPhong.Text);
            int tongTien = int.Parse(txtTongTien.Text);
            string trangThai = txtTrangthai.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_UpdateDangKy", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@DonGia", donGia);
                        command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                        command.Parameters.AddWithValue("@NgayNhanPhong", ngayNhanPhong);
                        command.Parameters.AddWithValue("@NgayTraPhong", ngayTraPhong);
                        command.Parameters.AddWithValue("@TongTien", tongTien);
                        command.Parameters.AddWithValue("@Trangthai", trangThai);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDangKy.Text))
            {
                // Delete record
                SqlParameter[] parameters = {
                    new SqlParameter("@MaDangKy", int.Parse(txtMaDangKy.Text))
                };
                ExecuteStoredProcedure("sp_DeleteDangKy", parameters);

                // Refresh DataGridView after deletion
                LoadData();
            }
            LoadPhongButtons();
        }
        private void ClearTextBoxes()
        {
            txtMaDangKy.Text = "";
            txtMaKhachHang.Text = "";
            txtMaNhanVien.Text = "";
           
          
            txtNgayDangKy.Text = "";
            txtNgayNhanPhong.Text = "";
            txtNgayTraPhong.Text = "";
            txtTongTien.Text = "";
            txtTrangthai.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate your controls with the selected row's data
                txtMaDangKy.Text = row.Cells["MaDangKy"].Value.ToString();
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtNgayDangKy.Text = row.Cells["NgayDangKy"].Value.ToString();
                txtNgayNhanPhong.Text = row.Cells["NgayNhanPhong"].Value.ToString();
                txtNgayTraPhong.Text = row.Cells["NgayTraPhong"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                txtTrangthai.Text= row.Cells["Trangthai"].Value.ToString();
            }
        }
        private void LoadDataIntoComboBox(ComboBox comboBox, string displayMember, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT {displayMember} FROM {tableName}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Text=reader[displayMember].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quanlychitiethoadon a = new Quanlychitiethoadon();
            a.ShowDialog();
        }
    }
}
