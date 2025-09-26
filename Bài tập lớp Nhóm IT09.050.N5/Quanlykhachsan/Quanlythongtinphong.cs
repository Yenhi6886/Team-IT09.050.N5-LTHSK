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
    public partial class Quanlythongtinphong : Form
    {
        public Quanlythongtinphong()
        {
            InitializeComponent();
        }
        private string ConnectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"; // Thay thế Your_Connection_String bằng chuỗi kết nối của bạn
        private SqlConnection connection;

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblPhong", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SoPhong", int.Parse(txtSoPhong.Text));
                cmd.Parameters.AddWithValue("@SucChua", txtSucChua.Text);
                cmd.Parameters.AddWithValue("@DonGia", int.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);

                cmd.ExecuteNonQuery();
            }

            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SoPhong", int.Parse(txtSoPhong.Text));
                cmd.Parameters.AddWithValue("@SucChua", txtSucChua.Text);
                cmd.Parameters.AddWithValue("@DonGia", int.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);

                cmd.ExecuteNonQuery();
            }

            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SoPhong", int.Parse(txtSoPhong.Text));

                cmd.ExecuteNonQuery();
            }

            LoadData();
        
    }

        private void Quanlythongtinphong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
                txtSucChua.Text = row.Cells["SucChua"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
}
