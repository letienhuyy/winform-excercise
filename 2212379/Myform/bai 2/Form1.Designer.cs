namespace Lab2
{
    partial class frmGiaoVien
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
            this.lblMaSo = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.chklistNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.lblDanhSachMH = new System.Windows.Forms.Label();
            this.lbDanhMucMH = new System.Windows.Forms.ListBox();
            this.lbMonHocDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linklblLienHe = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblMaSo
            // 
            this.lblMaSo.Location = new System.Drawing.Point(20, 20);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(100, 23);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã Số";
            // 
            // cboMaSo
            // 
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003"});
            this.cboMaSo.Location = new System.Drawing.Point(80, 20);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(121, 24);
            this.cboMaSo.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(20, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 23);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(80, 50);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 80);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(80, 80);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 110);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(100, 23);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // rdNam
            // 
            this.rdNam.Location = new System.Drawing.Point(80, 110);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(104, 24);
            this.rdNam.TabIndex = 7;
            this.rdNam.Text = "Nam";
            // 
            // rdNu
            // 
            this.rdNu.Location = new System.Drawing.Point(140, 110);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(104, 24);
            this.rdNu.TabIndex = 8;
            this.rdNu.Text = "Nữ";
            // 
            // lblSoDT
            // 
            this.lblSoDT.Location = new System.Drawing.Point(20, 140);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(100, 23);
            this.lblSoDT.TabIndex = 9;
            this.lblSoDT.Text = "Số ĐT";
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(80, 140);
            this.mtxtSoDT.Mask = "(999) 000-0000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(100, 22);
            this.mtxtSoDT.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(20, 170);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(100, 23);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Địa chỉ mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(80, 170);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 22);
            this.txtMail.TabIndex = 12;
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.Location = new System.Drawing.Point(20, 200);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(100, 23);
            this.lblNgoaiNgu.TabIndex = 13;
            this.lblNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // chklistNgoaiNgu
            // 
            this.chklistNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklistNgoaiNgu.Location = new System.Drawing.Point(80, 200);
            this.chklistNgoaiNgu.Name = "chklistNgoaiNgu";
            this.chklistNgoaiNgu.Size = new System.Drawing.Size(120, 89);
            this.chklistNgoaiNgu.TabIndex = 14;
            // 
            // lblDanhSachMH
            // 
            this.lblDanhSachMH.Location = new System.Drawing.Point(220, 20);
            this.lblDanhSachMH.Name = "lblDanhSachMH";
            this.lblDanhSachMH.Size = new System.Drawing.Size(100, 23);
            this.lblDanhSachMH.TabIndex = 15;
            this.lblDanhSachMH.Text = "Danh sách môn học";
            // 
            // lbDanhMucMH
            // 
            this.lbDanhMucMH.ItemHeight = 16;
            this.lbDanhMucMH.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Lập trình C/C++",
            "Cấu trúc dữ liệu và giải thuật",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhMucMH.Location = new System.Drawing.Point(220, 50);
            this.lbDanhMucMH.Name = "lbDanhMucMH";
            this.lbDanhMucMH.Size = new System.Drawing.Size(120, 84);
            this.lbDanhMucMH.TabIndex = 16;
            // 
            // lbMonHocDay
            // 
            this.lbMonHocDay.ItemHeight = 16;
            this.lbMonHocDay.Location = new System.Drawing.Point(320, 50);
            this.lbMonHocDay.Name = "lbMonHocDay";
            this.lbMonHocDay.Size = new System.Drawing.Size(120, 84);
            this.lbMonHocDay.TabIndex = 17;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(280, 100);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 18;
            this.btnChon.Text = ">>";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(280, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "<<";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(80, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(240, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            // 
            // linklblLienHe
            // 
            this.linklblLienHe.Location = new System.Drawing.Point(300, 310);
            this.linklblLienHe.Name = "linklblLienHe";
            this.linklblLienHe.Size = new System.Drawing.Size(100, 23);
            this.linklblLienHe.TabIndex = 23;
            this.linklblLienHe.TabStop = true;
            this.linklblLienHe.Text = "Liên hệ";
            this.linklblLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLienHe_LinkClicked);
            // 
            // frmGiaoVien
            // 
            this.ClientSize = new System.Drawing.Size(465, 416);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.chklistNgoaiNgu);
            this.Controls.Add(this.lblDanhSachMH);
            this.Controls.Add(this.lbDanhMucMH);
            this.Controls.Add(this.lbMonHocDay);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.linklblLienHe);
            this.Name = "frmGiaoVien";
            this.Text = "Giao Vien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label chklbNgoaiNgu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbDanhSachMH;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linklblLienHe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.CheckedListBox chklistNgoaiNgu;
        private System.Windows.Forms.Label lblDanhSachMH;
        private System.Windows.Forms.ListBox lbDanhMucMH;
        private System.Windows.Forms.ListBox lbMonHocDay;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMail;
    }
}

