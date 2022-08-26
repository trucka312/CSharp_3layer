using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        BUS_khachhang khachhang = new BUS_khachhang();
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khachhang.Load();
            textBoxma.Clear();
            textBoxten.Clear();
            textBoxngaysinh.Clear();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            khachhang ob = new DTO.khachhang(textBoxma.Text,textBoxten.Text,Convert.ToDateTime(textBoxngaysinh.Text));
            khachhang.Insert(ob);
            FormKhachHang_Load(sender, e);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            khachhang ob = new DTO.khachhang(textBoxma.Text, textBoxten.Text, Convert.ToDateTime(textBoxngaysinh.Text));
            khachhang.Update(ob);
            FormKhachHang_Load(sender, e);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            khachhang ob = new DTO.khachhang(textBoxma.Text, textBoxten.Text, Convert.ToDateTime(textBoxngaysinh.Text));
            khachhang.Delete(ob);
            FormKhachHang_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxngaysinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
