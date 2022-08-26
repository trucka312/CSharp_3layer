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
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }

        BUS_hanghoa hanghoa = new BUS_hanghoa();

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hanghoa.Load();
            textma.Clear();
            textten.Clear();
            textchungloai.Clear();
            textdongia.Clear();
            textsoluong.Clear();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            hanghoa ob = new hanghoa (textma.Text, textten.Text, textchungloai.Text,int.Parse(textdongia.Text),int.Parse(textsoluong.Text));
            hanghoa.Insert(ob);
            FormHangHoa_Load(sender, e);
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            hanghoa ob = new hanghoa(textma.Text, textten.Text, textchungloai.Text, int.Parse(textdongia.Text), int.Parse(textsoluong.Text));
            hanghoa.Update(ob);
            FormHangHoa_Load(sender, e);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            hanghoa ob = new hanghoa(textma.Text, textten.Text, textchungloai.Text, int.Parse(textdongia.Text), int.Parse(textsoluong.Text));
            hanghoa.Delete(ob);
            FormHangHoa_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textchungloai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textdongia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textsoluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
