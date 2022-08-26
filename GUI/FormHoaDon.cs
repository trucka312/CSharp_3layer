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
using BUS;

namespace GUI
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        BUS_hoadon hoadon = new BUS_hoadon();

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =hoadon.Load();
            textBoxma.Clear();
            textBoxngaymua.Clear();
            textBoxmakhach.Clear();
            textBoxmahang.Clear();
            textBoxsoluong.Clear();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            hoadon ob = new hoadon(textBoxma.Text,Convert.ToDateTime(textBoxngaymua.Text), textBoxmakhach.Text, textBoxmahang.Text, int.Parse(textBoxsoluong.Text));
            hoadon.Insert(ob);
            FormHoaDon_Load(sender, e);
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            hoadon ob = new hoadon(textBoxma.Text, Convert.ToDateTime(textBoxngaymua.Text), textBoxmakhach.Text, textBoxmahang.Text, int.Parse(textBoxsoluong.Text));
            hoadon.Update(ob);
            FormHoaDon_Load(sender, e);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            hoadon ob = new hoadon(textBoxma.Text, Convert.ToDateTime(textBoxngaymua.Text), textBoxmakhach.Text, textBoxmahang.Text, int.Parse(textBoxsoluong.Text));
            hoadon.Delete(ob);
            FormHoaDon_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxngaymua.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxmakhach.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxmahang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxsoluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
