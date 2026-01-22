using QLBH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmHangSanXuat : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuybo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<HangSanXuat> lsp = new List<HangSanXuat>();
            lsp = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    HangSanXuat lsp = new HangSanXuat();
                    lsp.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Add(lsp);

                    context.SaveChanges();
                }
                else
                {
                    HangSanXuat lsp = context.HangSanXuat.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenHangSanXuat = txtTenHangSanXuat.Text;
                        context.HangSanXuat.Update(lsp);

                        context.SaveChanges();
                    }
                }

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HangSanXuat lsp = context.HangSanXuat.Find(id);
                if (lsp != null)
                {
                    context.HangSanXuat.Remove(lsp);
                }
                context.SaveChanges();

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
