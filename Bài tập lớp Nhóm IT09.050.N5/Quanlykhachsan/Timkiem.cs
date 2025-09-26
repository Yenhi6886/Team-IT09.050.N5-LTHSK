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
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();
        }
        private string ConnectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"; // Thay thế Your_Connection_String bằng chuỗi kết nối của bạn

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (radioButton1.Checked == true)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.tblKhach WHERE HoTen LIKE @HoTen";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HoTen", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }

            if(radioButton2.Checked==true)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT dk.*, kh.HoTen AS HoTenKhachHang FROM dbo.tblDangky dk " +
                                   "JOIN dbo.tblKhach kh ON dk.MaKhachHang = kh.MaKhachHang " +
                                   "WHERE kh.HoTen LIKE @HoTen";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HoTen", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
        }
    }
    
}
