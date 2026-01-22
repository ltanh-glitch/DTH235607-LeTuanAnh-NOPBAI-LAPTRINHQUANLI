namespace QLBH.Forms
{
    partial class frmHangSanXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbThongTinHang = new GroupBox();
            btnThoat = new Button();
            btnHuybo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenHangSanXuat = new TextBox();
            lblTenhangSX = new Label();
            gpbDanhSach = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            gpbThongTinHang.SuspendLayout();
            gpbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // gpbThongTinHang
            // 
            gpbThongTinHang.Controls.Add(btnThoat);
            gpbThongTinHang.Controls.Add(btnHuybo);
            gpbThongTinHang.Controls.Add(btnLuu);
            gpbThongTinHang.Controls.Add(btnXoa);
            gpbThongTinHang.Controls.Add(btnSua);
            gpbThongTinHang.Controls.Add(btnThem);
            gpbThongTinHang.Controls.Add(txtTenHangSanXuat);
            gpbThongTinHang.Controls.Add(lblTenhangSX);
            gpbThongTinHang.Location = new Point(12, 12);
            gpbThongTinHang.Name = "gpbThongTinHang";
            gpbThongTinHang.Size = new Size(872, 126);
            gpbThongTinHang.TabIndex = 2;
            gpbThongTinHang.TabStop = false;
            gpbThongTinHang.Text = "Thông tin hãng sản xuất";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(750, 73);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuybo
            // 
            btnHuybo.Location = new Point(629, 73);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(94, 29);
            btnHuybo.TabIndex = 6;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(507, 73);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(393, 73);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(272, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(152, 73);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(186, 20);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(658, 27);
            txtTenHangSanXuat.TabIndex = 1;
            // 
            // lblTenhangSX
            // 
            lblTenhangSX.AutoSize = true;
            lblTenhangSX.Location = new Point(28, 27);
            lblTenhangSX.Name = "lblTenhangSX";
            lblTenhangSX.Size = new Size(150, 20);
            lblTenhangSX.TabIndex = 0;
            lblTenhangSX.Text = "Tên hãng sản xuất (*):";
            // 
            // gpbDanhSach
            // 
            gpbDanhSach.Controls.Add(dataGridView);
            gpbDanhSach.Location = new Point(12, 144);
            gpbDanhSach.Name = "gpbDanhSach";
            gpbDanhSach.Size = new Size(872, 373);
            gpbDanhSach.TabIndex = 3;
            gpbDanhSach.TabStop = false;
            gpbDanhSach.Text = "Danh sách loại sản phẩm:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(866, 347);
            dataGridView.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 16.04278F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.FillWeight = 183.957214F;
            TenHangSanXuat.HeaderText = "Tên hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 529);
            Controls.Add(gpbThongTinHang);
            Controls.Add(gpbDanhSach);
            Name = "frmHangSanXuat";
            Text = "Hãng Sản Xuất";
            Load += frmHangSanXuat_Load;
            gpbThongTinHang.ResumeLayout(false);
            gpbThongTinHang.PerformLayout();
            gpbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbThongTinHang;
        private Button btnThoat;
        private Button btnHuybo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenHangSanXuat;
        private Label lblTenhangSX;
        private GroupBox gpbDanhSach;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
    }
}