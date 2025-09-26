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
    public partial class Quanlynhansu : Form
    {
        private SqlConnection connection;
        public Quanlynhansu()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private string connectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"; // Thay thế Your_Connection_String bằng chuỗi kết nối của bạn

        private void Thêm_Click(object sender, EventArgs e)
        {
           
                if (!ValidateNhanvienInput())
                    return;

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertNhanvien", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNhanVien", int.Parse(txtMaNhanVien.Text));
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Thêm thành công! Mã Nhân Viên: {txtMaNhanVien.Text}");
                    LoadNhanvienData();
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
            if (!ValidateNhanvienInput())
                return;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateNhanvien", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNhanVien", int.Parse(txtMaNhanVien.Text));
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadNhanvienData();
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
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_DeleteNhanvien", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhanVien", int.Parse(txtMaNhanVien.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadNhanvienData();
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
        private void LoadNhanvienData()
        {
            try
            {
                string query = "SELECT * FROM tblNhanvien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvNhanvien.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private bool ValidateNhanvienInput()
        {
            // Check if MaNhanVien is a valid integer
            if (!int.TryParse(txtMaNhanVien.Text, out _))
            {
                MessageBox.Show("Mã Nhân Viên phải là số nguyên.");
                return false;
            }

            // Check if HoTen is not empty
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên.");
                return false;
            }

            // Add additional validation rules as needed

            return true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];

                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
            }
        }

        private void Quanlynhansu_Load(object sender, EventArgs e)
        {
            LoadNhanvienData();
        }
    }
}
