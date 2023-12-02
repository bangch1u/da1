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
    public partial class fThemTacGiaSach : Form
    {
        List<Sach?> sachList;
        public fThemTacGiaSach()
        {
            InitializeComponent();
            DataCmb();
            ShowData();
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                dataGridView1.Rows.Add(
                i.ToString(),
                sach.TenSach,
                svc.services.GetTacGiaByID(sach.BarCodeSach),
                 sach.BarCodeSach
                );
            }
        }

        void ShowData()
        {
            sachList = svc.services.GetAllSach();
            ConfigData();
        }
        public void DataCmb()
        {
            var lstTacGia = svc.services.GetAllTacGia();
            var tenTacGiaList = lstTacGia.Select(tacGia => tacGia.HoTen).ToList();

            // Đặt danh sách tên tác giả làm DataSource cho ComboBox
            cmbTacGia.DataSource = lstTacGia;
            cmbTacGia.DisplayMember = "hoTen";

            // Set ValueMember to show the ViTriKeSach
            cmbTacGia.ValueMember = "idTacGia";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TacGiaSach obj = new TacGiaSach()
            {
                BarCodeSach = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                IdTacGia = cmbTacGia.SelectedValue.ToString()
            };
            var result = svc.services.AddTacGiaSach(obj);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                ShowData();
            }
            //MessageBox.Show(cmbTacGia.SelectedValue.ToString());
        }
    }
}
