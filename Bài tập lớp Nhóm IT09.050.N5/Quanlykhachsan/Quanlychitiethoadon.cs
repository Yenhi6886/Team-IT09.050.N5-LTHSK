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
    public partial class Quanlychitiethoadon : Form
    {
        public Quanlychitiethoadon()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True"; // Thay thế Your_Connection_String bằng chuỗi kết nối của bạn
        private SqlConnection connection;
        private void Quanlychitiethoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doanqlksDataSet3.tblDichvu' table. You can move, or remove it, as needed.
            this.tblDichvuTableAdapter.Fill(this.doanqlksDataSet3.tblDichvu);
            // TODO: This line of code loads data into the 'doanqlksDataSet2.tblDangky' table. You can move, or remove it, as needed.
            this.tblDangkyTableAdapter.Fill(this.doanqlksDataSet2.tblDangky);
            LoadData();
            connection = new SqlConnection(connectionString);
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve data
                SqlCommand command = new SqlCommand("dbo.SelectHoadonchitiet", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data to DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedServiceCode = int.Parse(txtMaDichVu.SelectedValue.ToString()); // Replace with the actual selected service code from the ComboBox

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetPriceByServiceCode", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDichVu", selectedServiceCode);

                    int price = Convert.ToInt32(command.ExecuteScalar());
                    txtGiaDichVu.Text = price.ToString(); 

                 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Capture input values from TextBox controls
            int maDangKy = Convert.ToInt32(txtMaDangKy.Text);
            int maDichVu = Convert.ToInt32(txtMaDichVu.SelectedValue.ToString());
            DateTime ngaySuDung = Convert.ToDateTime(txtNgaySuDung.Text);
            int giaDichVu = Convert.ToInt32(txtGiaDichVu.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Call the stored procedure dbo.UpdateHoadonchitiet
                using (SqlCommand command = new SqlCommand("dbo.UpdateHoadonchitiet", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters
                    command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                    command.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    command.Parameters.AddWithValue("@NgaySuDung", ngaySuDung);
                    command.Parameters.AddWithValue("@GiaDichVu", giaDichVu);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();
                }
            }

            // Refresh DataGridView after editing
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Access data in the selected row
                txtMaDangKy.Text = selectedRow.Cells["MaDangKy"].Value.ToString();
                txtMaDichVu.Text = selectedRow.Cells["MaDichVu"].Value.ToString();
                txtNgaySuDung.Text = selectedRow.Cells["NgaySuDung"].Value.ToString();
                txtGiaDichVu.Text = selectedRow.Cells["GiaDichVu"].Value.ToString();
            }
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            // Capture input values from TextBox controls
            int maDangKy = Convert.ToInt32(txtMaDangKy.Text);
            int maDichVu = Convert.ToInt32(txtMaDichVu.SelectedValue.ToString());
            DateTime ngaySuDung = Convert.ToDateTime(txtNgaySuDung.Text);
            int giaDichVu = Convert.ToInt32(txtGiaDichVu.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Call the stored procedure dbo.InsertHoadonchitiet
                using (SqlCommand command = new SqlCommand("dbo.InsertHoadonchitiet", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters
                    command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                    command.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    command.Parameters.AddWithValue("@NgaySuDung", ngaySuDung);
                    command.Parameters.AddWithValue("@GiaDichVu", giaDichVu);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();
                }
            }

            // Refresh DataGridView after adding
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Confirm deletion with the user

            // Capture input values from TextBox controls
            int maDangKy = Convert.ToInt32(txtMaDangKy.Text);
            int maDichVu = Convert.ToInt32(txtMaDichVu.SelectedValue.ToString());
            DateTime ngaySuDung = Convert.ToDateTime(txtNgaySuDung.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Call the stored procedure dbo.DeleteHoadonchitiet
                using (SqlCommand command = new SqlCommand("dbo.DeleteHoadonchitiet", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters
                    command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                    command.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    command.Parameters.AddWithValue("@NgaySuDung", ngaySuDung);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();
                }
            }

            // Refresh DataGridView after deleting
            LoadData();
        }
    }
}
