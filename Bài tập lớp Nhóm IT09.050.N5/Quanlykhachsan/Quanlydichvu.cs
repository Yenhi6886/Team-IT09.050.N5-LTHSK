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
    public partial class Quanlydichvu : Form
    {
        public Quanlydichvu()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM tblDichvu";
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
        private string connectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"; // Thay thế Your_Connection_String bằng chuỗi kết nối của bạn

        private SqlConnection connection;
        private bool ValidateInput()
        {
            // Check if MaDichVu is a valid integer
            if (!int.TryParse(txtMaDichVu.Text, out _))
            {
                MessageBox.Show("Mã Dịch Vụ phải là số nguyên.");
                return false;
            }

            // Check if TenDichVu is not empty
            if (string.IsNullOrEmpty(txtTenDichVu.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Dịch Vụ.");
                return false;
            }

            // Check if GiaDichVu is a valid integer
            if (!int.TryParse(txtGiaDichVu.Text, out _))
            {
                MessageBox.Show("Giá Dịch Vụ phải là số nguyên.");
                return false;
            }

            return true;
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertDichvu", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDichVu", int.Parse(txtMaDichVu.Text));
                cmd.Parameters.AddWithValue("@TenDichVu", txtTenDichVu.Text);
                cmd.Parameters.AddWithValue("@GiaDichVu", int.Parse(txtGiaDichVu.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Thêm thành công! Mã Dịch Vụ: {txtMaDichVu.Text}");
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
            if (!ValidateInput())
                return;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertDichvu", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDichVu", int.Parse(txtMaDichVu.Text));
                cmd.Parameters.AddWithValue("@TenDichVu", txtTenDichVu.Text);
                cmd.Parameters.AddWithValue("@GiaDichVu", int.Parse(txtGiaDichVu.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Thêm thành công! Mã Dịch Vụ: {txtMaDichVu.Text}");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDichVu.Text))
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để xóa!");
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_DeleteDichvu", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDichVu", int.Parse(txtMaDichVu.Text));
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
                txtTenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
                txtGiaDichVu.Text = row.Cells["GiaDichVu"].Value.ToString();
            }
        }

        private void Quanlydichvu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
