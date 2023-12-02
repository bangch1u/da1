using A_DAL.DomainClass;
using B_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.QuanLyPhieu
{
    public partial class fThemPM : Form
    {
        public fThemPM()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdTheThuVien == tbIDTheTV.Text);
            if (obj != null)
            {
                MessageBox.Show("Id thẻ thư viện này đã được cấp phiếu mượn");
                return;
            }

            PhieuMuon pm = new PhieuMuon()
            {
                IdTheThuVien = tbIDTheTV.Text,
                IdPhieuMuon = tbMaPM.Text,
                TongSachMuon = 0,
                NgayTaoPhieu = dateTimePicker1.Value,
                TrangThai = cmbTrangThai.SelectedItem.ToString() == "Hoạt Động" ? true : false
            };
            var a = svc.services.AddPhieuMuon(pm);
            if (a == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại do phiếu mượn đã tồn tại");
            }
        }
    }
}
