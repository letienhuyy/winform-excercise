using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialize form components
            this.Text = "Giao Vien";
            this.ClientSize = new System.Drawing.Size(400, 350);

            // Label: Ma So
            Label lblMaSo = new Label();
            lblMaSo.Text = "Mã Số";
            lblMaSo.Location = new System.Drawing.Point(20, 20);

            // ComboBox: cboMaSo
            ComboBox cboMaSo = new ComboBox();
            cboMaSo.Location = new System.Drawing.Point(80, 20);
            cboMaSo.Name = "cboMaSo";
            cboMaSo.Items.AddRange(new string[] { "001", "002", "003" });

            // Label: Ho Ten
            Label lblHoTen = new Label();
            lblHoTen.Text = "Họ Tên";
            lblHoTen.Location = new System.Drawing.Point(20, 50);

            // TextBox: txtHoTen
            TextBox txtHoTen = new TextBox();
            txtHoTen.Location = new System.Drawing.Point(80, 50);

            // Label: Ngay Sinh
            Label lblNgaySinh = new Label();
            lblNgaySinh.Text = "Ngày Sinh";
            lblNgaySinh.Location = new System.Drawing.Point(20, 80);

            // DateTimePicker: dtpNgaySinh
            DateTimePicker dtpNgaySinh = new DateTimePicker();
            dtpNgaySinh.Location = new System.Drawing.Point(80, 80);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;

            // Label: Gioi Tinh
            Label lblGioiTinh = new Label();
            lblGioiTinh.Text = "Giới Tính";
            lblGioiTinh.Location = new System.Drawing.Point(20, 110);

            // RadioButton: rdNam
            RadioButton rdNam = new RadioButton();
            rdNam.Text = "Nam";
            rdNam.Location = new System.Drawing.Point(80, 110);

            // RadioButton: rdNu
            RadioButton rdNu = new RadioButton();
            rdNu.Text = "Nữ";
            rdNu.Location = new System.Drawing.Point(140, 110);

            // Label: So DT
            Label lblSoDT = new Label();
            lblSoDT.Text = "Số ĐT";
            lblSoDT.Location = new System.Drawing.Point(20, 140);

            // MaskedTextBox: mtxtSoDT
            MaskedTextBox mtxtSoDT = new MaskedTextBox();
            mtxtSoDT.Location = new System.Drawing.Point(80, 140);
            mtxtSoDT.Mask = "(999) 000-0000";

            // Label: Dia Chi Mail
            Label lblMail = new Label();
            lblMail.Text = "Địa chỉ mail";
            lblMail.Location = new System.Drawing.Point(20, 170);

            // TextBox: txtMail
            TextBox txtMail = new TextBox();
            txtMail.Location = new System.Drawing.Point(80, 170);

            // Label: Ngoai Ngu
            Label lblNgoaiNgu = new Label();
            lblNgoaiNgu.Text = "Ngoại Ngữ";
            lblNgoaiNgu.Location = new System.Drawing.Point(20, 200);

            // CheckedListBox: chklistNgoaiNgu
            CheckedListBox chklistNgoaiNgu = new CheckedListBox();
            chklistNgoaiNgu.Location = new System.Drawing.Point(80, 200);
            chklistNgoaiNgu.Items.AddRange(new string[] { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật", "Tiếng Nga" });

            // ListBox: Danh sach mon hoc
            Label lblDanhSachMH = new Label();
            lblDanhSachMH.Text = "Danh sách môn học";
            lblDanhSachMH.Location = new System.Drawing.Point(220, 20);

            ListBox lbDanhMucMH = new ListBox();
            lbDanhMucMH.Location = new System.Drawing.Point(220, 50);
            lbDanhMucMH.Items.AddRange(new string[] { "Tin học đại cương", "Lập trình C/C++", "Cấu trúc dữ liệu và giải thuật", "Cơ sở dữ liệu", "Tiếng Anh B1", "Tiếng Anh B2", "Lập trình hướng đối tượng", "Mạng máy tính", "Công nghệ phần mềm", "Phân tích TKHDT" });

            // ListBox: Mon hoc giao vien day
            ListBox lbMonHocDay = new ListBox();
            lbMonHocDay.Location = new System.Drawing.Point(320, 50);

            // Button: Chon
            Button btnChon = new Button();
            btnChon.Text = ">>";
            btnChon.Location = new System.Drawing.Point(280, 100);
            btnChon.Click += new EventHandler(btnChon_Click);

            // Button: Xoa
            Button btnXoa = new Button();
            btnXoa.Text = "<<";
            btnXoa.Location = new System.Drawing.Point(280, 130);
            btnXoa.Click += new EventHandler(btnXoa_Click);

            // Button: Luu
            Button btnLuu = new Button();
            btnLuu.Text = "Lưu";
            btnLuu.Location = new System.Drawing.Point(80, 300);

            // Button: Cancel
            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(160, 300);

            // Button: Exit
            Button btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Location = new System.Drawing.Point(240, 300);

            // LinkLabel: lienhe
            LinkLabel linklblLienHe = new LinkLabel();
            linklblLienHe.Text = "Liên hệ";
            linklblLienHe.Location = new System.Drawing.Point(300, 310);
            linklblLienHe.LinkClicked += new LinkLabelLinkClickedEventHandler(linklblLienHe_LinkClicked);

            // Add all controls to the form
            this.Controls.Add(lblMaSo);
            this.Controls.Add(cboMaSo);
            this.Controls.Add(lblHoTen);
            this.Controls.Add(txtHoTen);
            this.Controls.Add(lblNgaySinh);
            this.Controls.Add(dtpNgaySinh);
            this.Controls.Add(lblGioiTinh);
            this.Controls.Add(rdNam);
            this.Controls.Add(rdNu);
            this.Controls.Add(lblSoDT);
            this.Controls.Add(mtxtSoDT);
            this.Controls.Add(lblMail);
            this.Controls.Add(txtMail);
            this.Controls.Add(lblNgoaiNgu);
            this.Controls.Add(chklistNgoaiNgu);
            this.Controls.Add(lblDanhSachMH);
            this.Controls.Add(lbDanhMucMH);
            this.Controls.Add(lbMonHocDay);
            this.Controls.Add(btnChon);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnLuu);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnExit);
            this.Controls.Add(linklblLienHe);
        }

        // Event Handlers (placeholders for actual logic)
        private void btnChon_Click(object sender, EventArgs e) { /* Logic for selecting items */ }
        private void btnXoa_Click(object sender, EventArgs e) { /* Logic for removing items */ }
        private void linklblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { /* Logic for link click */ }
    }
}
