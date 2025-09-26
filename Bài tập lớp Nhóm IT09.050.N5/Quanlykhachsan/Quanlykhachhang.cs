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
    public partial class Quanlykhachhang : Form
    {
        private string connectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"; // Thay thế Your_Connection_String bằng chuỗi kết nối của bạn
        private SqlConnection connection;

        public Quanlykhachhang()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM tblKhach";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private bool ValidateInput()
        {
            // Kiểm tra xem các trường thông tin cần thiết đã được điền đầy đủ hay không
            if (string.IsNullOrEmpty(txtCMND.Text) || string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(cboGioiTinh.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            if (PhoneNumberExists(txtSoDienThoai.Text, txtMaKhachHang.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
                return false;
            }


            return true;
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            if (!ValidateInput() || !IsValidNumber(txtMaKhachHang.Text))
                return;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertKhach", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Use the provided MaKhachHang value from txtMaKhachHang TextBox
                cmd.Parameters.AddWithValue("@MaKhachHang", int.Parse(txtMaKhachHang.Text));
                cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Thêm thành công! Mã Khách Hàng: {txtMaKhachHang.Text}");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput() || !IsValidNumber(txtMaKhachHang.Text))
                return;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateKhach", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", int.Parse(txtMaKhachHang.Text));
                cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!");
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_DeleteKhach", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", int.Parse(txtMaKhachHang.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private bool PhoneNumberExists(string phoneNumber, string currentCustomerId)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM tblKhach WHERE SoDienThoai = '{phoneNumber}' AND MaKhachHang <> {currentCustomerId}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        private bool IsValidNumber(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        private string GetValueFromCell(DataGridViewRow row, string columnName, string defaultValue)
        {
            object cellValue = row.Cells[columnName].Value;
            return cellValue != DBNull.Value && cellValue != null ? cellValue.ToString() : defaultValue;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaKhachHang.Text = GetValueFromCell(row, "MaKhachHang", "DefaultMaKhachHang");
                txtCMND.Text = GetValueFromCell(row, "CMND", "DefaultCMND");
                txtHoTen.Text = GetValueFromCell(row, "HoTen", "DefaultHoTen");

                // Check for DBNull before converting to DateTime
                object ngaySinhValue = row.Cells["NgaySinh"].Value;
                if (ngaySinhValue != DBNull.Value && ngaySinhValue != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(ngaySinhValue);
                }
                else
                {
                    // Handle the case where the value is DBNull or null
                    // You can set a default value or display an error message
                    dtpNgaySinh.Value = DateTime.Now; // Set a default value (e.g., current date)
                }

                cboGioiTinh.Text = GetValueFromCell(row, "GioiTinh", "DefaultGioiTinh");
                txtSoDienThoai.Text = GetValueFromCell(row, "SoDienThoai", "DefaultSoDienThoai");
            }
        }
    }
}
