﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTap5_QuanLyKhoHang
{
    public partial class FormXuatHang : Form
    {
        public FormXuatHang()
        {
            InitializeComponent();
        }





        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");


        private void FormXuatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoHangDataSet1.nhanhanhang' table. You can move, or remove it, as needed.
            this.nhanhanhangTableAdapter.Fill(this.quanLyKhoHangDataSet1.nhanhanhang);
            // TODO: This line of code loads data into the 'quanLyKhoHangDataSet.nhacungcap' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.quanLyKhoHangDataSet.nhacungcap);
            LoadDataHang();
            textMaphieu.Text = GetMaxId().ToString();
        }


        private void LoadDataHang()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ma, ten, xuatxu, donvitinh, dongia,soluong FROM hanghoa  WHERE ten LIKE N'%" + textTimhang.Text + "%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ma"].Visible = false;
            textTenhang.DataBindings.Clear();
            textXuatxu.DataBindings.Clear();
            textMahang.DataBindings.Clear();
            textDongia.DataBindings.Clear();
            textDonvitinh.DataBindings.Clear();
            textSoDangCo.DataBindings.Clear();

            textSoDangCo.DataBindings.Add("Text", dataGridView1.DataSource, "soluong");
            textTenhang.DataBindings.Add("Text", dataGridView1.DataSource, "ten");
            textXuatxu.DataBindings.Add("Text", dataGridView1.DataSource, "xuatxu");
            textDonvitinh.DataBindings.Add("Text", dataGridView1.DataSource, "donvitinh");
            textDongia.DataBindings.Add("Text", dataGridView1.DataSource, "dongia");
            textMahang.DataBindings.Add("Text", dataGridView1.DataSource, "ma");

        }


        private void LoadDataHangDaXuat()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  hh.ten,hh.xuatxu ,ctpx.soluong  FROM chitietphieuxuat ctpx JOIN hanghoa hh  ON ctpx.hanghoama = hh.ma WHERE ctpx.phieuxuatma = '" + textMaphieu.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView2.DataSource = dt;


        }


        private int GetMaxId()
        {
            int pid;
            using (SqlCommand cmd = new SqlCommand("SELECT MAX(ma) AS ID FROM phieuxuat", con))
            {

                con.Open();
                if (cmd.ExecuteScalar() == DBNull.Value)
                    pid = 1;
                else 
                    pid = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                con.Close();
                return pid;
            }

        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textTimhang_TextChanged(object sender, EventArgs e)
        {
            LoadDataHang();
        }

        private void buttonKhoaTuychinh_Click(object sender, EventArgs e)
        {
            if (texttenphieu.TextLength > 0 && textManhaCC.TextLength > 0)
            {
                if ((MessageBox.Show("Bạn muốn tạo phiếu xuất này? Thao tác không thể hoàn tác ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    texttenphieu.ReadOnly = true;
                    comboNhaCC.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    buttonKhoaTuychinh.Enabled = false;



                    con.Open();

                    string chuoisql = "insert into phieuxuat(ma,ten,ngayxuat,nhanhanhangma,thukhoma) select N'{0}',N'{1}',N'{2}',N'{3}',1";
                    string them = string.Format(chuoisql, textMaphieu.Text, texttenphieu.Text, dateTimePicker1.Value.ToString("MM-dd-yyyy"), textManhaCC.Text);
                    SqlCommand cmd = new SqlCommand(them, con);




                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        con.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }

                }
            }
        }

        private void comboNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textManhaCC.Clear();

            if (comboNhaCC.SelectedItem != null)
            {
                textManhaCC.Text = comboNhaCC.SelectedValue.ToString();
            }
        }

        private void buttonTiep_Click(object sender, EventArgs e)
        {


            if ( int.Parse(textSoXuat.Text) < int.Parse(textSoDangCo.Text))
            {
                if ((MessageBox.Show("Bạn muốn thêm hàng này vào phiếu xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();

                    string chuoisql = "insert into chitietphieuxuat( phieuxuatma,hanghoama,soluong ) select N'{0}',N'{1}',N'{2}'";
                    string them = string.Format(chuoisql, textMaphieu.Text, textMahang.Text, Int16.Parse(textSoXuat.Text));
                    SqlCommand cmd = new SqlCommand(them, con);

                    string chuoisql2 = "update hanghoa set soluong = soluong - N'{0}' where ma = N'{1}'";
                    string capnhat = string.Format(chuoisql2, Int16.Parse(textSoXuat.Text), textMahang.Text);
                    SqlCommand cmd2 = new SqlCommand(capnhat, con);



                    try
                    {

                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Thành công");
                        LoadDataHangDaXuat();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }

                }

            }
            else
            {
                MessageBox.Show("Không thể xuất quá số đang có");
            }

        }
    }
}
