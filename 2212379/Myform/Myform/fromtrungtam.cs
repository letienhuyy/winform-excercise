using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myform
{
    public partial class frmtrungtam : Form
    {
        private RadioButton rdnamm;
        private RadioButton rdNu;
        private TextBox textBox1;
        private DateTimePicker dtbNgayDangKy;
        private CheckBox chkTinHocA;
        private CheckBox chkTinHocB;
        private CheckBox chkTiengAnhA;
        private CheckBox chkTiengAnhB;
        private Button txtTongTien;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label cboMaNV;
        private Label rdNam;
        private Label txtHoTen;
        private Label label6;
        private Label hiu;
        private Label label10;
        private Label label12;
        private Label lblTienTHB;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label lblTienTHA;
        private Label label20;
        private Label lblTienTAA;
        private Label lblTienTAB;
        private ComboBox comboBox1;

        public frmtrungtam()

        {

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdnamm = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtbNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.chkTinHocA = new System.Windows.Forms.CheckBox();
            this.chkTinHocB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
            this.txtTongTien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hiu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTienTHB = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTienTHA = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTienTAA = new System.Windows.Forms.Label();
            this.lblTienTAB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.comboBox1.Location = new System.Drawing.Point(122, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // rdnamm
            // 
            this.rdnamm.AutoSize = true;
            this.rdnamm.Location = new System.Drawing.Point(338, 106);
            this.rdnamm.Name = "rdnamm";
            this.rdnamm.Size = new System.Drawing.Size(47, 17);
            this.rdnamm.TabIndex = 1;
            this.rdnamm.TabStop = true;
            this.rdnamm.Text = "Nam";
            this.rdnamm.UseVisualStyleBackColor = true;
            this.rdnamm.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(419, 106);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dtbNgayDangKy
            // 
            this.dtbNgayDangKy.Location = new System.Drawing.Point(122, 217);
            this.dtbNgayDangKy.Name = "dtbNgayDangKy";
            this.dtbNgayDangKy.Size = new System.Drawing.Size(200, 20);
            this.dtbNgayDangKy.TabIndex = 4;
            // 
            // chkTinHocA
            // 
            this.chkTinHocA.AutoSize = true;
            this.chkTinHocA.Location = new System.Drawing.Point(122, 269);
            this.chkTinHocA.Name = "chkTinHocA";
            this.chkTinHocA.Size = new System.Drawing.Size(74, 17);
            this.chkTinHocA.TabIndex = 5;
            this.chkTinHocA.Text = "Tin Học A";
            this.chkTinHocA.UseVisualStyleBackColor = true;
            this.chkTinHocA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkTinHocB
            // 
            this.chkTinHocB.AutoSize = true;
            this.chkTinHocB.Location = new System.Drawing.Point(122, 292);
            this.chkTinHocB.Name = "chkTinHocB";
            this.chkTinHocB.Size = new System.Drawing.Size(74, 17);
            this.chkTinHocB.TabIndex = 6;
            this.chkTinHocB.Text = "Tin Học B";
            this.chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            this.chkTiengAnhA.AutoSize = true;
            this.chkTiengAnhA.Location = new System.Drawing.Point(122, 315);
            this.chkTiengAnhA.Name = "chkTiengAnhA";
            this.chkTiengAnhA.Size = new System.Drawing.Size(85, 17);
            this.chkTiengAnhA.TabIndex = 7;
            this.chkTiengAnhA.Text = "Tiếng Anh A";
            this.chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            this.chkTiengAnhB.AutoSize = true;
            this.chkTiengAnhB.Location = new System.Drawing.Point(122, 338);
            this.chkTiengAnhB.Name = "chkTiengAnhB";
            this.chkTiengAnhB.Size = new System.Drawing.Size(85, 17);
            this.chkTiengAnhB.TabIndex = 8;
            this.chkTiengAnhB.Text = "Tiếng Anh B";
            this.chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(232, 363);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(178, 31);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.UseVisualStyleBackColor = true;
            this.txtTongTien.Click += new System.EventHandler(this.txtTongTien_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(100, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tính Tiền ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = global::Myform.Properties.Resources.Screenshot_2024_08_27_085344;
            this.button3.Location = new System.Drawing.Point(232, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 45);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(400, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 51);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboMaNV
            // 
            this.cboMaNV.AutoSize = true;
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.Location = new System.Drawing.Point(22, 110);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(77, 13);
            this.cboMaNV.TabIndex = 2;
            this.cboMaNV.Text = "Mã học viên";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(268, 108);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(60, 13);
            this.rdNam.TabIndex = 2;
            this.rdNam.Text = "Giới Tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(24, 166);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(49, 13);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.Text = "Họ Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label2";
            // 
            // hiu
            // 
            this.hiu.AutoSize = true;
            this.hiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiu.Location = new System.Drawing.Point(120, 370);
            this.hiu.Name = "hiu";
            this.hiu.Size = new System.Drawing.Size(75, 15);
            this.hiu.TabIndex = 2;
            this.hiu.Text = "Tổng Tiền ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(653, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "label2";
            // 
            // lblTienTHB
            // 
            this.lblTienTHB.AutoSize = true;
            this.lblTienTHB.Location = new System.Drawing.Point(324, 292);
            this.lblTienTHB.Name = "lblTienTHB";
            this.lblTienTHB.Size = new System.Drawing.Size(74, 13);
            this.lblTienTHB.TabIndex = 2;
            this.lblTienTHB.Text = "500.000 đồng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(611, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "label2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(710, 498);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "label2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(940, 501);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "label2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Ngày Đăng Ký";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblTienTHA
            // 
            this.lblTienTHA.AutoSize = true;
            this.lblTienTHA.Location = new System.Drawing.Point(324, 265);
            this.lblTienTHA.Name = "lblTienTHA";
            this.lblTienTHA.Size = new System.Drawing.Size(77, 13);
            this.lblTienTHA.TabIndex = 2;
            this.lblTienTHA.Text = "300.000 đồng ";
            this.lblTienTHA.Click += new System.EventHandler(this.label18_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(653, 423);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "label2";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // lblTienTAA
            // 
            this.lblTienTAA.AutoSize = true;
            this.lblTienTAA.Location = new System.Drawing.Point(324, 315);
            this.lblTienTAA.Name = "lblTienTAA";
            this.lblTienTAA.Size = new System.Drawing.Size(74, 13);
            this.lblTienTAA.TabIndex = 2;
            this.lblTienTAA.Text = "400.000 đồng";
            // 
            // lblTienTAB
            // 
            this.lblTienTAB.AutoSize = true;
            this.lblTienTAB.Location = new System.Drawing.Point(324, 338);
            this.lblTienTAB.Name = "lblTienTAB";
            this.lblTienTAB.Size = new System.Drawing.Size(74, 13);
            this.lblTienTAB.TabIndex = 2;
            this.lblTienTAB.Text = "600.000 đồng";
            // 
            // frmtrungtam
            // 
            this.ClientSize = new System.Drawing.Size(524, 455);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTienTHA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblTienTAB);
            this.Controls.Add(this.lblTienTAA);
            this.Controls.Add(this.lblTienTHB);
            this.Controls.Add(this.hiu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.chkTiengAnhB);
            this.Controls.Add(this.chkTiengAnhA);
            this.Controls.Add(this.chkTinHocB);
            this.Controls.Add(this.chkTinHocA);
            this.Controls.Add(this.dtbNgayDangKy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdnamm);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmtrungtam";
            this.Text = "Simple Drawing";
            this.Load += new System.EventHandler(this.frmtrungtam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmtrungtam_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
             s += int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 dong";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {



        }
        private void Raset()
            {
            this.cboMaNV.Text = "";
            this.txtHoTen.Text = "";
            this.dtbNgayDangKy.Value = DateTime.Now;
            this.rdnamm.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked= false;
            this.chkTinHocA.Checked = false;    
            this.chkTinHocB.Checked= false;
            this.hiu.Text = "";





            }
    
        

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_Click(object sender, EventArgs e)
        {

        }
    }
}
