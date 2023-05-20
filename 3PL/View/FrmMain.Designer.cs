namespace _3PL.View
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            pic_avtNV = new PictureBox();
            btn_KhachHang = new Button();
            btn_dangxuat = new Button();
            btn_hoadon = new Button();
            btn_thongke = new Button();
            btn_sp = new Button();
            btn_nv = new Button();
            btn_banhang = new Button();
            pn_main = new Panel();
            panel_ttnv = new Panel();
            groupBox2 = new GroupBox();
            textBox_mkcu = new TextBox();
            label10 = new Label();
            button_doimk = new Button();
            label9 = new Label();
            textBox_nhaplaimk = new TextBox();
            label8 = new Label();
            textBox_mkmoi = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lb_maNV = new Label();
            label_ngaysinh = new Label();
            labe_ten = new Label();
            label_gioitinh = new Label();
            label_diachi = new Label();
            label_sdt = new Label();
            labelChaychu = new Label();
            timechaychu = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_avtNV).BeginInit();
            pn_main.SuspendLayout();
            panel_ttnv.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pic_avtNV);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(btn_dangxuat);
            panel1.Controls.Add(btn_hoadon);
            panel1.Controls.Add(btn_thongke);
            panel1.Controls.Add(btn_sp);
            panel1.Controls.Add(btn_nv);
            panel1.Controls.Add(btn_banhang);
            panel1.Location = new Point(20, 20);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 1558);
            panel1.TabIndex = 0;
            // 
            // pic_avtNV
            // 
            pic_avtNV.BackColor = SystemColors.ActiveCaption;
            pic_avtNV.BackgroundImage = (Image)resources.GetObject("pic_avtNV.BackgroundImage");
            pic_avtNV.BackgroundImageLayout = ImageLayout.Stretch;
            pic_avtNV.Location = new Point(32, 29);
            pic_avtNV.Margin = new Padding(5, 7, 5, 7);
            pic_avtNV.Name = "pic_avtNV";
            pic_avtNV.Size = new Size(416, 364);
            pic_avtNV.TabIndex = 21;
            pic_avtNV.TabStop = false;
            pic_avtNV.Click += pic_avtNV_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Anchor = AnchorStyles.None;
            btn_KhachHang.BackColor = Color.DarkCyan;
            btn_KhachHang.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_KhachHang.ForeColor = Color.White;
            btn_KhachHang.Image = (Image)resources.GetObject("btn_KhachHang.Image");
            btn_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.Location = new Point(32, 972);
            btn_KhachHang.Margin = new Padding(5, 7, 5, 7);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(416, 121);
            btn_KhachHang.TabIndex = 20;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.UseVisualStyleBackColor = false;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_dangxuat
            // 
            btn_dangxuat.Anchor = AnchorStyles.None;
            btn_dangxuat.BackColor = Color.DarkCyan;
            btn_dangxuat.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangxuat.ForeColor = Color.White;
            btn_dangxuat.Image = (Image)resources.GetObject("btn_dangxuat.Image");
            btn_dangxuat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangxuat.Location = new Point(32, 1241);
            btn_dangxuat.Margin = new Padding(5, 7, 5, 7);
            btn_dangxuat.Name = "btn_dangxuat";
            btn_dangxuat.Size = new Size(416, 121);
            btn_dangxuat.TabIndex = 19;
            btn_dangxuat.Text = "Đăng Xuất";
            btn_dangxuat.UseVisualStyleBackColor = false;
            btn_dangxuat.Click += btn_dangxuat_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Anchor = AnchorStyles.None;
            btn_hoadon.BackColor = Color.DarkCyan;
            btn_hoadon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hoadon.ForeColor = Color.White;
            btn_hoadon.Image = (Image)resources.GetObject("btn_hoadon.Image");
            btn_hoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hoadon.Location = new Point(32, 569);
            btn_hoadon.Margin = new Padding(5, 7, 5, 7);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(416, 121);
            btn_hoadon.TabIndex = 15;
            btn_hoadon.Text = "Hóa Đơn";
            btn_hoadon.UseVisualStyleBackColor = false;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_thongke
            // 
            btn_thongke.Anchor = AnchorStyles.None;
            btn_thongke.BackColor = Color.DarkCyan;
            btn_thongke.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_thongke.ForeColor = Color.White;
            btn_thongke.Image = (Image)resources.GetObject("btn_thongke.Image");
            btn_thongke.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongke.Location = new Point(32, 1107);
            btn_thongke.Margin = new Padding(5, 7, 5, 7);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(416, 121);
            btn_thongke.TabIndex = 18;
            btn_thongke.Text = "Thống Kê";
            btn_thongke.UseVisualStyleBackColor = false;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // btn_sp
            // 
            btn_sp.Anchor = AnchorStyles.None;
            btn_sp.BackColor = Color.DarkCyan;
            btn_sp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sp.ForeColor = Color.White;
            btn_sp.Image = (Image)resources.GetObject("btn_sp.Image");
            btn_sp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sp.Location = new Point(32, 837);
            btn_sp.Margin = new Padding(5, 7, 5, 7);
            btn_sp.Name = "btn_sp";
            btn_sp.Size = new Size(416, 121);
            btn_sp.TabIndex = 17;
            btn_sp.Text = "Sản Phẩm";
            btn_sp.UseVisualStyleBackColor = false;
            btn_sp.Click += btn_sp_Click;
            // 
            // btn_nv
            // 
            btn_nv.Anchor = AnchorStyles.None;
            btn_nv.BackColor = Color.DarkCyan;
            btn_nv.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nv.ForeColor = Color.White;
            btn_nv.Image = (Image)resources.GetObject("btn_nv.Image");
            btn_nv.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nv.Location = new Point(32, 702);
            btn_nv.Margin = new Padding(5, 7, 5, 7);
            btn_nv.Name = "btn_nv";
            btn_nv.Size = new Size(416, 121);
            btn_nv.TabIndex = 16;
            btn_nv.Text = "Nhân Viên";
            btn_nv.UseVisualStyleBackColor = false;
            btn_nv.Click += btn_nv_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.Anchor = AnchorStyles.None;
            btn_banhang.BackColor = Color.DarkCyan;
            btn_banhang.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_banhang.ForeColor = Color.White;
            btn_banhang.Image = (Image)resources.GetObject("btn_banhang.Image");
            btn_banhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_banhang.Location = new Point(32, 435);
            btn_banhang.Margin = new Padding(5, 7, 5, 7);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(416, 121);
            btn_banhang.TabIndex = 14;
            btn_banhang.Text = "Bán Hàng";
            btn_banhang.UseVisualStyleBackColor = false;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // pn_main
            // 
            pn_main.Controls.Add(panel_ttnv);
            pn_main.ImeMode = ImeMode.On;
            pn_main.Location = new Point(510, 157);
            pn_main.Margin = new Padding(5, 7, 5, 7);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(2264, 1474);
            pn_main.TabIndex = 2;
            // 
            // panel_ttnv
            // 
            panel_ttnv.Controls.Add(groupBox2);
            panel_ttnv.Controls.Add(groupBox1);
            panel_ttnv.Location = new Point(5, 0);
            panel_ttnv.Margin = new Padding(5, 7, 5, 7);
            panel_ttnv.Name = "panel_ttnv";
            panel_ttnv.Size = new Size(2264, 1480);
            panel_ttnv.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_mkcu);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(button_doimk);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox_nhaplaimk);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox_mkmoi);
            groupBox2.Location = new Point(798, 168);
            groupBox2.Margin = new Padding(5, 7, 5, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 7, 5, 7);
            groupBox2.Size = new Size(798, 568);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đổi mật khẩu";
            // 
            // textBox_mkcu
            // 
            textBox_mkcu.Location = new Point(346, 94);
            textBox_mkcu.Margin = new Padding(5, 7, 5, 7);
            textBox_mkcu.Name = "textBox_mkcu";
            textBox_mkcu.Size = new Size(347, 39);
            textBox_mkcu.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(93, 113);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(211, 32);
            label10.TabIndex = 15;
            label10.Text = "Nhập mật khẩu cũ";
            // 
            // button_doimk
            // 
            button_doimk.BackColor = Color.FromArgb(128, 255, 255);
            button_doimk.Location = new Point(197, 404);
            button_doimk.Margin = new Padding(5, 7, 5, 7);
            button_doimk.Name = "button_doimk";
            button_doimk.Size = new Size(349, 66);
            button_doimk.TabIndex = 21;
            button_doimk.Text = "Đổi mật khẩu";
            button_doimk.UseVisualStyleBackColor = false;
            button_doimk.Click += button_doimk_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 202);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(227, 32);
            label9.TabIndex = 16;
            label9.Text = "Nhập mật khẩu mới";
            // 
            // textBox_nhaplaimk
            // 
            textBox_nhaplaimk.Location = new Point(346, 283);
            textBox_nhaplaimk.Margin = new Padding(5, 7, 5, 7);
            textBox_nhaplaimk.Name = "textBox_nhaplaimk";
            textBox_nhaplaimk.Size = new Size(347, 39);
            textBox_nhaplaimk.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 303);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(258, 32);
            label8.TabIndex = 17;
            label8.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox_mkmoi
            // 
            textBox_mkmoi.Location = new Point(346, 184);
            textBox_mkmoi.Margin = new Padding(5, 7, 5, 7);
            textBox_mkmoi.Name = "textBox_mkmoi";
            textBox_mkmoi.Size = new Size(347, 39);
            textBox_mkmoi.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lb_maNV);
            groupBox1.Controls.Add(label_ngaysinh);
            groupBox1.Controls.Add(labe_ten);
            groupBox1.Controls.Add(label_gioitinh);
            groupBox1.Controls.Add(label_diachi);
            groupBox1.Controls.Add(label_sdt);
            groupBox1.Location = new Point(80, 168);
            groupBox1.Margin = new Padding(5, 7, 5, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 7, 5, 7);
            groupBox1.Size = new Size(707, 568);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 79);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 2;
            label3.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 136);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 200);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 32);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 256);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 320);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 32);
            label6.TabIndex = 5;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 376);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 32);
            label7.TabIndex = 6;
            label7.Text = "Ngày sinh";
            // 
            // lb_maNV
            // 
            lb_maNV.AutoSize = true;
            lb_maNV.Location = new Point(333, 79);
            lb_maNV.Margin = new Padding(5, 0, 5, 0);
            lb_maNV.Name = "lb_maNV";
            lb_maNV.Size = new Size(204, 32);
            lb_maNV.TabIndex = 7;
            lb_maNV.Text = "......................................";
            // 
            // label_ngaysinh
            // 
            label_ngaysinh.AutoSize = true;
            label_ngaysinh.Location = new Point(333, 376);
            label_ngaysinh.Margin = new Padding(5, 0, 5, 0);
            label_ngaysinh.Name = "label_ngaysinh";
            label_ngaysinh.Size = new Size(204, 32);
            label_ngaysinh.TabIndex = 13;
            label_ngaysinh.Text = "......................................";
            // 
            // labe_ten
            // 
            labe_ten.AutoSize = true;
            labe_ten.Location = new Point(333, 136);
            labe_ten.Margin = new Padding(5, 0, 5, 0);
            labe_ten.Name = "labe_ten";
            labe_ten.Size = new Size(204, 32);
            labe_ten.TabIndex = 8;
            labe_ten.Text = "......................................";
            // 
            // label_gioitinh
            // 
            label_gioitinh.AutoSize = true;
            label_gioitinh.Location = new Point(333, 320);
            label_gioitinh.Margin = new Padding(5, 0, 5, 0);
            label_gioitinh.Name = "label_gioitinh";
            label_gioitinh.Size = new Size(204, 32);
            label_gioitinh.TabIndex = 12;
            label_gioitinh.Text = "......................................";
            // 
            // label_diachi
            // 
            label_diachi.AutoSize = true;
            label_diachi.Location = new Point(333, 256);
            label_diachi.Margin = new Padding(5, 0, 5, 0);
            label_diachi.Name = "label_diachi";
            label_diachi.Size = new Size(204, 32);
            label_diachi.TabIndex = 11;
            label_diachi.Text = "......................................";
            // 
            // label_sdt
            // 
            label_sdt.AutoSize = true;
            label_sdt.Location = new Point(333, 200);
            label_sdt.Margin = new Padding(5, 0, 5, 0);
            label_sdt.Name = "label_sdt";
            label_sdt.Size = new Size(204, 32);
            label_sdt.TabIndex = 10;
            label_sdt.Text = "......................................";
            // 
            // labelChaychu
            // 
            labelChaychu.AutoSize = true;
            labelChaychu.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelChaychu.ForeColor = Color.Black;
            labelChaychu.Location = new Point(973, 15);
            labelChaychu.Margin = new Padding(5, 0, 5, 0);
            labelChaychu.Name = "labelChaychu";
            labelChaychu.Size = new Size(1690, 154);
            labelChaychu.TabIndex = 3;
            labelChaychu.Text = "Khách hàng là thượng đế, Mua 1 là Hoàng đế Mua 2 là Thượng đế\r\n\r\n";
            labelChaychu.Click += labelChaychu_Click;
            // 
            // timechaychu
            // 
            timechaychu.Enabled = true;
            timechaychu.Interval = 20;
            timechaychu.Tick += timechaychu_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(2762, 1598);
            Controls.Add(labelChaychu);
            Controls.Add(pn_main);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_avtNV).EndInit();
            pn_main.ResumeLayout(false);
            panel_ttnv.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pic_avtNV;
        private Button btn_KhachHang;
        private Button btn_dangxuat;
        private Button btn_hoadon;
        private Button btn_thongke;
        private Button btn_sp;
        private Button btn_nv;
        private Button btn_banhang;
        private Panel pn_main;
        private Panel panel_ttnv;
        private GroupBox groupBox2;
        private TextBox textBox_mkcu;
        private Label label10;
        private Button button_doimk;
        private Label label9;
        private TextBox textBox_nhaplaimk;
        private Label label8;
        private TextBox textBox_mkmoi;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lb_maNV;
        private Label label_ngaysinh;
        private Label labe_ten;
        private Label label_gioitinh;
        private Label label_diachi;
        private Label label_sdt;
        private Label labelChaychu;
        private System.Windows.Forms.Timer timechaychu;
    }
}