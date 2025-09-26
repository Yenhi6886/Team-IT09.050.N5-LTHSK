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
    public partial class Frmbaocaoquanlythuephong : Form
    {
        public Frmbaocaoquanlythuephong()
        {
            InitializeComponent();
        }

        private void Frmbaocaoquanlythuephong_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //lấy chuỗi kết nối từ file App.config
            conn.ConnectionString = "Data Source=ADMIN-PC\\TAN;Initial Catalog=doanqlks;Integrated Security=True";

            try
            {
                //mở chuỗi kết nối
                conn.Open();
                //khai báo đối tượng SqlCommand trong SqlDataAdapter
                da.SelectCommand = new SqlCommand();
                //gọi thủ tục từ SQL
                da.SelectCommand.CommandText = "baocaothongkequanlykhachsan";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                CrystalReport2 rp = new CrystalReport2();
                rp.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rp;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
