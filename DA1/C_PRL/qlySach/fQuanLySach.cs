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
    public partial class fQuanLySach : Form
    {
        List<Sach?> sachList;
        public fQuanLySach()
        {
            InitializeComponent();
            ShowData();
        }
        void ConfigData()
        {
            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                dataGridView1.Rows.Add(
                i.ToString(),
                sach.BarCodeSach,
                sach.TenSach,
                sach.GiaTien,
                sach.NamXuatBan?.ToString("dd/MM/yyyy"),
                svc.services.GetTacGiaByID(sach.BarCodeSach),
                svc.services.GetTheLoaiByID(sach.BarCodeSach),
                svc.services.getCountById(sach.BarCodeSach)
                );
            }
        }

        void ShowData()
        {
            sachList = svc.services.GetAllSach();
            ConfigData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Form ql = new fQuanLySachCT1(sachList[e.RowIndex].BarCodeSach);
                ql.ShowDialog();
            }
        }
    }
}
