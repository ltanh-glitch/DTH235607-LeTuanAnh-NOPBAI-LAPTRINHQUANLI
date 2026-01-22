namespace QLBH.Forms
{
    partial class frmLoaiSanPham
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
            gpbThongTinLoai = new GroupBox();
            btnThoat = new Button();
            btnHuybo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            lblTenLoaiSP = new Label();
            gpbDanhSach = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            gpbThongTinLoai.SuspendLayout();
            gpbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // gpbThongTinLoai
            // 
            gpbThongTinLoai.Controls.Add(btnThoat);
            gpbThongTinLoai.Controls.Add(btnHuybo);
            gpbThongTinLoai.Controls.Add(btnLuu);
            gpbThongTinLoai.Controls.Add(btnXoa);
            gpbThongTinLoai.Controls.Add(btnSua);
            gpbThongTinLoai.Controls.Add(btnThem);
            gpbThongTinLoai.Controls.Add(txtTenLoai);
            gpbThongTinLoai.Controls.Add(lblTenLoaiSP);
            gpbThongTinLoai.Location = new Point(12, 12);
            gpbThongTinLoai.Name = "gpbThongTinLoai";
            gpbThongTinLoai.Size = new Size(872, 126);
            gpbThongTinLoai.TabIndex = 0;
            gpbThongTinLoai.TabStop = false;
            gpbThongTinLoai.Text = "Thông tin loại sản phẩm";
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
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(186, 20);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(658, 27);
            txtTenLoai.TabIndex = 1;
            // 
            // lblTenLoaiSP
            // 
            lblTenLoaiSP.AutoSize = true;
            lblTenLoaiSP.Location = new Point(28, 27);
            lblTenLoaiSP.Name = "lblTenLoaiSP";
            lblTenLoaiSP.Size = new Size(152, 20);
            lblTenLoaiSP.TabIndex = 0;
            lblTenLoaiSP.Text = "Tên loại sản phẩm (*):";
            // 
            // gpbDanhSach
            // 
            gpbDanhSach.Controls.Add(dataGridView);
            gpbDanhSach.Location = new Point(12, 144);
            gpbDanhSach.Name = "gpbDanhSach";
            gpbDanhSach.Size = new Size(872, 373);
            gpbDanhSach.TabIndex = 1;
            gpbDanhSach.TabStop = false;
            gpbDanhSach.Text = "Danh sách loại sản phẩm:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(866, 347);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 16.04278F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.FillWeight = 183.957214F;
            TenLoai.HeaderText = "Tên loại sản phẩm";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 529);
            Controls.Add(gpbDanhSach);
            Controls.Add(gpbThongTinLoai);
            Name = "frmLoaiSanPham";
            Text = "Loại Sản Phẩm";
            Load += frmLoaiSanPham_Load;
            gpbThongTinLoai.ResumeLayout(false);
            gpbThongTinLoai.PerformLayout();
            gpbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbThongTinLoai;
        private Button btnThoat;
        private Button btnHuybo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoai;
        private Label lblTenLoaiSP;
        private GroupBox gpbDanhSach;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
    }
}