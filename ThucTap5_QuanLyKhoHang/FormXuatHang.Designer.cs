﻿namespace ThucTap5_QuanLyKhoHang
{
    partial class FormXuatHang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTimhang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSoDangCo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textMahang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonThoi = new System.Windows.Forms.Button();
            this.buttonTiep = new System.Windows.Forms.Button();
            this.textSoXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textXuatxu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDonvitinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonKhoaTuychinh = new System.Windows.Forms.Button();
            this.textManhaCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textMaphieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNhaCC = new System.Windows.Forms.ComboBox();
            this.nhanhanhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoHangDataSet1 = new ThucTap5_QuanLyKhoHang.QuanLyKhoHangDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.texttenphieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quanLyKhoHangDataSet = new ThucTap5_QuanLyKhoHang.QuanLyKhoHangDataSet();
            this.nhacungcapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhacungcapTableAdapter = new ThucTap5_QuanLyKhoHang.QuanLyKhoHangDataSetTableAdapters.nhacungcapTableAdapter();
            this.nhanhanhangTableAdapter = new ThucTap5_QuanLyKhoHang.QuanLyKhoHangDataSet1TableAdapters.nhanhanhangTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanhanhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textTimhang);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 709);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất hàng";
            // 
            // textTimhang
            // 
            this.textTimhang.Location = new System.Drawing.Point(138, 48);
            this.textTimhang.Name = "textTimhang";
            this.textTimhang.Size = new System.Drawing.Size(136, 20);
            this.textTimhang.TabIndex = 11;
            this.textTimhang.TextChanged += new System.EventHandler(this.textTimhang_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tìm hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 609);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textSoDangCo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textMahang);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonThoi);
            this.groupBox2.Controls.Add(this.buttonTiep);
            this.groupBox2.Controls.Add(this.textSoXuat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textXuatxu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textDongia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textDonvitinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textTenhang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(464, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 324);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textSoDangCo
            // 
            this.textSoDangCo.Location = new System.Drawing.Point(330, 48);
            this.textSoDangCo.Name = "textSoDangCo";
            this.textSoDangCo.ReadOnly = true;
            this.textSoDangCo.Size = new System.Drawing.Size(107, 20);
            this.textSoDangCo.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Số đang có";
            // 
            // textMahang
            // 
            this.textMahang.Location = new System.Drawing.Point(80, 193);
            this.textMahang.Name = "textMahang";
            this.textMahang.ReadOnly = true;
            this.textMahang.Size = new System.Drawing.Size(142, 20);
            this.textMahang.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ma";
            // 
            // buttonThoi
            // 
            this.buttonThoi.Location = new System.Drawing.Point(320, 204);
            this.buttonThoi.Name = "buttonThoi";
            this.buttonThoi.Size = new System.Drawing.Size(97, 29);
            this.buttonThoi.TabIndex = 11;
            this.buttonThoi.Text = "THÔI";
            this.buttonThoi.UseVisualStyleBackColor = true;
            // 
            // buttonTiep
            // 
            this.buttonTiep.Location = new System.Drawing.Point(320, 155);
            this.buttonTiep.Name = "buttonTiep";
            this.buttonTiep.Size = new System.Drawing.Size(97, 30);
            this.buttonTiep.TabIndex = 10;
            this.buttonTiep.Text = "Tiếp";
            this.buttonTiep.UseVisualStyleBackColor = true;
            this.buttonTiep.Click += new System.EventHandler(this.buttonTiep_Click);
            // 
            // textSoXuat
            // 
            this.textSoXuat.Location = new System.Drawing.Point(322, 101);
            this.textSoXuat.Name = "textSoXuat";
            this.textSoXuat.Size = new System.Drawing.Size(118, 20);
            this.textSoXuat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số xuất";
            // 
            // textXuatxu
            // 
            this.textXuatxu.Location = new System.Drawing.Point(80, 67);
            this.textXuatxu.Name = "textXuatxu";
            this.textXuatxu.ReadOnly = true;
            this.textXuatxu.Size = new System.Drawing.Size(142, 20);
            this.textXuatxu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Xuất xứ";
            // 
            // textDongia
            // 
            this.textDongia.Location = new System.Drawing.Point(80, 105);
            this.textDongia.Name = "textDongia";
            this.textDongia.ReadOnly = true;
            this.textDongia.Size = new System.Drawing.Size(142, 20);
            this.textDongia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            // 
            // textDonvitinh
            // 
            this.textDonvitinh.Location = new System.Drawing.Point(80, 148);
            this.textDonvitinh.Name = "textDonvitinh";
            this.textDonvitinh.ReadOnly = true;
            this.textDonvitinh.Size = new System.Drawing.Size(142, 20);
            this.textDonvitinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // textTenhang
            // 
            this.textTenhang.Location = new System.Drawing.Point(80, 27);
            this.textTenhang.Name = "textTenhang";
            this.textTenhang.ReadOnly = true;
            this.textTenhang.Size = new System.Drawing.Size(142, 20);
            this.textTenhang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(464, 353);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(460, 362);
            this.dataGridView2.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.buttonKhoaTuychinh);
            this.groupBox3.Controls.Add(this.textManhaCC);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textMaphieu);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboNhaCC);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.texttenphieu);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(940, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 354);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo phiếu xuất";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // buttonKhoaTuychinh
            // 
            this.buttonKhoaTuychinh.Location = new System.Drawing.Point(84, 333);
            this.buttonKhoaTuychinh.Name = "buttonKhoaTuychinh";
            this.buttonKhoaTuychinh.Size = new System.Drawing.Size(137, 23);
            this.buttonKhoaTuychinh.TabIndex = 12;
            this.buttonKhoaTuychinh.Text = "Khóa tùy chỉnh phiếu";
            this.buttonKhoaTuychinh.UseVisualStyleBackColor = true;
            this.buttonKhoaTuychinh.Click += new System.EventHandler(this.buttonKhoaTuychinh_Click);
            // 
            // textManhaCC
            // 
            this.textManhaCC.Location = new System.Drawing.Point(126, 286);
            this.textManhaCC.Name = "textManhaCC";
            this.textManhaCC.ReadOnly = true;
            this.textManhaCC.Size = new System.Drawing.Size(136, 20);
            this.textManhaCC.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mã nhà nhận hàng";
            // 
            // textMaphieu
            // 
            this.textMaphieu.Location = new System.Drawing.Point(126, 234);
            this.textMaphieu.Name = "textMaphieu";
            this.textMaphieu.ReadOnly = true;
            this.textMaphieu.Size = new System.Drawing.Size(136, 20);
            this.textMaphieu.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nhà nhận hàng";
            // 
            // comboNhaCC
            // 
            this.comboNhaCC.DataSource = this.nhanhanhangBindingSource;
            this.comboNhaCC.DisplayMember = "ten";
            this.comboNhaCC.FormattingEnabled = true;
            this.comboNhaCC.Location = new System.Drawing.Point(126, 121);
            this.comboNhaCC.Name = "comboNhaCC";
            this.comboNhaCC.Size = new System.Drawing.Size(136, 21);
            this.comboNhaCC.TabIndex = 27;
            this.comboNhaCC.ValueMember = "ma";
            this.comboNhaCC.SelectedIndexChanged += new System.EventHandler(this.comboNhaCC_SelectedIndexChanged);
            // 
            // nhanhanhangBindingSource
            // 
            this.nhanhanhangBindingSource.DataMember = "nhanhanhang";
            this.nhanhanhangBindingSource.DataSource = this.quanLyKhoHangDataSet1;
            // 
            // quanLyKhoHangDataSet1
            // 
            this.quanLyKhoHangDataSet1.DataSetName = "QuanLyKhoHangDataSet1";
            this.quanLyKhoHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ngày xuất";
            // 
            // texttenphieu
            // 
            this.texttenphieu.Location = new System.Drawing.Point(126, 56);
            this.texttenphieu.Name = "texttenphieu";
            this.texttenphieu.Size = new System.Drawing.Size(136, 20);
            this.texttenphieu.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tên phiếu";
            // 
            // quanLyKhoHangDataSet
            // 
            this.quanLyKhoHangDataSet.DataSetName = "QuanLyKhoHangDataSet";
            this.quanLyKhoHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhacungcapBindingSource
            // 
            this.nhacungcapBindingSource.DataMember = "nhacungcap";
            this.nhacungcapBindingSource.DataSource = this.quanLyKhoHangDataSet;
            // 
            // nhacungcapTableAdapter
            // 
            this.nhacungcapTableAdapter.ClearBeforeFill = true;
            // 
            // nhanhanhangTableAdapter
            // 
            this.nhanhanhangTableAdapter.ClearBeforeFill = true;
            // 
            // FormXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 733);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormXuatHang";
            this.Text = "FormXuatHang";
            this.Load += new System.EventHandler(this.FormXuatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanhanhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textTimhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textMahang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonThoi;
        private System.Windows.Forms.Button buttonTiep;
        private System.Windows.Forms.TextBox textSoXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textXuatxu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDonvitinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonKhoaTuychinh;
        private System.Windows.Forms.TextBox textManhaCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textMaphieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNhaCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texttenphieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoDangCo;
        private System.Windows.Forms.Label label13;
        private QuanLyKhoHangDataSet quanLyKhoHangDataSet;
        private System.Windows.Forms.BindingSource nhacungcapBindingSource;
        private QuanLyKhoHangDataSetTableAdapters.nhacungcapTableAdapter nhacungcapTableAdapter;
        private QuanLyKhoHangDataSet1 quanLyKhoHangDataSet1;
        private System.Windows.Forms.BindingSource nhanhanhangBindingSource;
        private QuanLyKhoHangDataSet1TableAdapters.nhanhanhangTableAdapter nhanhanhangTableAdapter;
    }
}