namespace QLBongDaTest
{
    partial class frmVDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrVDV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTSX = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpDuyet = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpLuu = new System.Windows.Forms.GroupBox();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboDoi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHinh = new System.Windows.Forms.GroupBox();
            this.btnXoaHinh = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.picVDV = new System.Windows.Forms.PictureBox();
            this.txtHoTenVDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.maVDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenVDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.lblMauTin = new System.Windows.Forms.Label();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVDV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpTSX.SuspendLayout();
            this.grpDuyet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpLuu.SuspendLayout();
            this.grpHinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrVDV
            // 
            this.dgrVDV.AllowUserToAddRows = false;
            this.dgrVDV.AllowUserToResizeColumns = false;
            this.dgrVDV.AllowUserToResizeRows = false;
            this.dgrVDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrVDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrVDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVDV,
            this.hoTenVDV,
            this.nam,
            this.ngaySinh,
            this.maDoi,
            this.viTri,
            this.hinh});
            this.dgrVDV.Location = new System.Drawing.Point(3, 23);
            this.dgrVDV.Name = "dgrVDV";
            this.dgrVDV.RowHeadersWidth = 51;
            this.dgrVDV.RowTemplate.Height = 24;
            this.dgrVDV.Size = new System.Drawing.Size(1309, 381);
            this.dgrVDV.TabIndex = 2;
            this.dgrVDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrVDV_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.dgrVDV);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1315, 492);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách vận động viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpTSX);
            this.panel1.Controls.Add(this.grpDuyet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 85);
            this.panel1.TabIndex = 3;
            // 
            // grpTSX
            // 
            this.grpTSX.Controls.Add(this.btnThoat);
            this.grpTSX.Controls.Add(this.btnXoa);
            this.grpTSX.Controls.Add(this.btnSua);
            this.grpTSX.Controls.Add(this.btnThem);
            this.grpTSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTSX.Location = new System.Drawing.Point(482, 0);
            this.grpTSX.Name = "grpTSX";
            this.grpTSX.Size = new System.Drawing.Size(827, 85);
            this.grpTSX.TabIndex = 7;
            this.grpTSX.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(703, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 45);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(275, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 45);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(151, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 45);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(27, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 45);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpDuyet
            // 
            this.grpDuyet.Controls.Add(this.btnCuoi);
            this.grpDuyet.Controls.Add(this.btnSau);
            this.grpDuyet.Controls.Add(this.lblMauTin);
            this.grpDuyet.Controls.Add(this.btnTruoc);
            this.grpDuyet.Controls.Add(this.btnDau);
            this.grpDuyet.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDuyet.Location = new System.Drawing.Point(0, 0);
            this.grpDuyet.Name = "grpDuyet";
            this.grpDuyet.Size = new System.Drawing.Size(482, 85);
            this.grpDuyet.TabIndex = 5;
            this.grpDuyet.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1315, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.cboGioiTinh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.grpLuu);
            this.panel2.Controls.Add(this.cboDoi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboViTri);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dpkNgaySinh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.grpHinh);
            this.panel2.Controls.Add(this.picVDV);
            this.panel2.Controls.Add(this.txtHoTenVDV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaVDV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1291, 234);
            this.panel2.TabIndex = 0;
            // 
            // grpLuu
            // 
            this.grpLuu.Controls.Add(this.btnKhong);
            this.grpLuu.Controls.Add(this.btnLuu);
            this.grpLuu.Location = new System.Drawing.Point(173, 158);
            this.grpLuu.Name = "grpLuu";
            this.grpLuu.Size = new System.Drawing.Size(363, 67);
            this.grpLuu.TabIndex = 27;
            this.grpLuu.TabStop = false;
            // 
            // btnKhong
            // 
            this.btnKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.Location = new System.Drawing.Point(191, 21);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(144, 32);
            this.btnKhong.TabIndex = 1;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(27, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 32);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboDoi
            // 
            this.cboDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoi.FormattingEnabled = true;
            this.cboDoi.Location = new System.Drawing.Point(404, 124);
            this.cboDoi.Name = "cboDoi";
            this.cboDoi.Size = new System.Drawing.Size(247, 28);
            this.cboDoi.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Đội";
            // 
            // cboViTri
            // 
            this.cboViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Items.AddRange(new object[] {
            "Hậu vệ",
            "Tiền vệ",
            "Tiền đạo",
            "Thủ môn"});
            this.cboViTri.Location = new System.Drawing.Point(218, 124);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(160, 28);
            this.cboViTri.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Vị trí";
            // 
            // dpkNgaySinh
            // 
            this.dpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dpkNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgaySinh.Location = new System.Drawing.Point(27, 125);
            this.dpkNgaySinh.Name = "dpkNgaySinh";
            this.dpkNgaySinh.Size = new System.Drawing.Size(145, 27);
            this.dpkNgaySinh.TabIndex = 22;
            this.dpkNgaySinh.Value = new System.DateTime(2024, 7, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày sinh";
            // 
            // grpHinh
            // 
            this.grpHinh.Controls.Add(this.btnXoaHinh);
            this.grpHinh.Controls.Add(this.btnChonHinh);
            this.grpHinh.Location = new System.Drawing.Point(1114, 48);
            this.grpHinh.Name = "grpHinh";
            this.grpHinh.Size = new System.Drawing.Size(166, 135);
            this.grpHinh.TabIndex = 20;
            this.grpHinh.TabStop = false;
            // 
            // btnXoaHinh
            // 
            this.btnXoaHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHinh.Location = new System.Drawing.Point(28, 76);
            this.btnXoaHinh.Name = "btnXoaHinh";
            this.btnXoaHinh.Size = new System.Drawing.Size(111, 37);
            this.btnXoaHinh.TabIndex = 1;
            this.btnXoaHinh.Text = "Xóa hình";
            this.btnXoaHinh.UseVisualStyleBackColor = true;
            this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHinh.Location = new System.Drawing.Point(28, 21);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(111, 37);
            this.btnChonHinh.TabIndex = 0;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // picVDV
            // 
            this.picVDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picVDV.Image = global::QLBongDaTest.Properties.Resources.None;
            this.picVDV.Location = new System.Drawing.Point(904, 12);
            this.picVDV.Name = "picVDV";
            this.picVDV.Size = new System.Drawing.Size(178, 219);
            this.picVDV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVDV.TabIndex = 19;
            this.picVDV.TabStop = false;
            // 
            // txtHoTenVDV
            // 
            this.txtHoTenVDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTenVDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenVDV.Location = new System.Drawing.Point(169, 48);
            this.txtHoTenVDV.Name = "txtHoTenVDV";
            this.txtHoTenVDV.Size = new System.Drawing.Size(297, 27);
            this.txtHoTenVDV.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ và tên";
            // 
            // txtMaVDV
            // 
            this.txtMaVDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaVDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVDV.Location = new System.Drawing.Point(27, 48);
            this.txtMaVDV.Name = "txtMaVDV";
            this.txtMaVDV.Size = new System.Drawing.Size(114, 27);
            this.txtMaVDV.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã số";
            // 
            // picFileDialog
            // 
            this.picFileDialog.FileName = "hinhanh";
            this.picFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png|All files (*.*)|*" +
    ".*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(494, 48);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(157, 28);
            this.cboGioiTinh.TabIndex = 30;
            // 
            // maVDV
            // 
            this.maVDV.DataPropertyName = "MaVDV";
            this.maVDV.HeaderText = "Mã VĐV";
            this.maVDV.MinimumWidth = 6;
            this.maVDV.Name = "maVDV";
            this.maVDV.ReadOnly = true;
            this.maVDV.Width = 106;
            // 
            // hoTenVDV
            // 
            this.hoTenVDV.DataPropertyName = "HoTenVDV";
            this.hoTenVDV.HeaderText = "Họ và tên";
            this.hoTenVDV.MinimumWidth = 6;
            this.hoTenVDV.Name = "hoTenVDV";
            this.hoTenVDV.ReadOnly = true;
            this.hoTenVDV.Width = 119;
            // 
            // nam
            // 
            this.nam.DataPropertyName = "Nam";
            this.nam.HeaderText = "Nam";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            this.nam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nam.Width = 53;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "NgaySinh";
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            this.ngaySinh.Width = 123;
            // 
            // maDoi
            // 
            this.maDoi.DataPropertyName = "MaDoi";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.maDoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.maDoi.HeaderText = "Đội";
            this.maDoi.MinimumWidth = 6;
            this.maDoi.Name = "maDoi";
            this.maDoi.ReadOnly = true;
            this.maDoi.Width = 66;
            // 
            // viTri
            // 
            this.viTri.DataPropertyName = "ViTri";
            this.viTri.HeaderText = "Vị trí";
            this.viTri.MinimumWidth = 6;
            this.viTri.Name = "viTri";
            this.viTri.ReadOnly = true;
            this.viTri.Width = 79;
            // 
            // hinh
            // 
            this.hinh.DataPropertyName = "Hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.MinimumWidth = 6;
            this.hinh.Name = "hinh";
            this.hinh.ReadOnly = true;
            this.hinh.Width = 77;
            // 
            // btnDau
            // 
            this.btnDau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(29, 26);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(56, 45);
            this.btnDau.TabIndex = 2;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(97, 26);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(56, 45);
            this.btnTruoc.TabIndex = 3;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            // 
            // lblMauTin
            // 
            this.lblMauTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMauTin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMauTin.Location = new System.Drawing.Point(172, 26);
            this.lblMauTin.Name = "lblMauTin";
            this.lblMauTin.Size = new System.Drawing.Size(139, 45);
            this.lblMauTin.TabIndex = 4;
            this.lblMauTin.Text = "0/0";
            this.lblMauTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSau
            // 
            this.btnSau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(329, 26);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(56, 45);
            this.btnSau.TabIndex = 5;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            // 
            // btnCuoi
            // 
            this.btnCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(397, 26);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(56, 45);
            this.btnCuoi.TabIndex = 6;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            // 
            // frmVDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 746);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVDV";
            this.Text = "Quản lý bóng đá";
            this.Load += new System.EventHandler(this.frmVDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVDV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpTSX.ResumeLayout(false);
            this.grpDuyet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpLuu.ResumeLayout(false);
            this.grpHinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgrVDV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog picFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTSX;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpDuyet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpLuu;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboDoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpkNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpHinh;
        private System.Windows.Forms.Button btnXoaHinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.PictureBox picVDV;
        private System.Windows.Forms.TextBox txtHoTenVDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaVDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenVDV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Label lblMauTin;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
    }
}