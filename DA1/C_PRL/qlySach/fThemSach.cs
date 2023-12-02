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

namespace C_PRL.qlySach
{
    public partial class fThemSach : Form
    {
        
        public fThemSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach()
            {
                BarCodeSach = tbBarcode.Text,
                TenSach = tbName.Text,
                SoLuong = Convert.ToInt32(tbSoLuong.Text),
                GiaTien = Convert.ToDecimal(tbGiaTien.Text),
                NamXuatBan = dateTimePicker1.Value
            };
            var s = svc.services.AddSach(sach);
            if (s)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
