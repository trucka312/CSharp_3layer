using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DAL;

namespace GUI
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string sql = " select hoadon.mahd,ngaymua,hoadon.makh,hoadon.soluong from khachhang inner join hoadon on khachhang.makh=hoadon.makh inner join hanghoa on hoadon.mahang=hanghoa.mahang  where month(hoadon.ngaymua)=6";

            ketnoi ob = new ketnoi();
            DataTable dt = new DataTable();
            dt = ob.Load_Table(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"D:\trandaiphuc-CD201598\code\GUI\GUI\Report1.rdlc";
            if (dt.Rows.Count > 0)
            {
                ReportDataSource rpt = new ReportDataSource();
                rpt.Name = "DataSet1";
                rpt.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rpt);
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("khong co du lieu");
            this.reportViewer1.RefreshReport();

        }
    }
}
