using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class Menutrangchu : Form
    {
        public Menutrangchu()
        {
            InitializeComponent();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlydichvu a = new Quanlydichvu();
            a.Show();
                
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhansu a = new Quanlynhansu();
            a.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlythongtinphong a = new Quanlythongtinphong();
            a.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlykhachhang a = new Quanlykhachhang();
            a.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiem a = new Timkiem();
            a.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void báoCáoThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbaocaoquanlythuephong a = new Frmbaocaoquanlythuephong();
            a.Show();
        }

        private void báoCáoThốngKêHóaĐơnĐãThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmthongkehoadondathanhtoan a = new Frmthongkehoadondathanhtoan();
            a.Show();
        }

        private void quảnLýThôngTinThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlydatphong a = new Quanlydatphong();
            a.Show();
        }
    }
}
