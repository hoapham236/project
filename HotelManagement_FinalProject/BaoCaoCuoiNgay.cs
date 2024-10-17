using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class BaoCaoCuoiNgay : Form
    {
        public BaoCaoCuoiNgay()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select HoTen,NghiepVu,Ngay,GioVao,GioRa,Ca,LuongTrongNgay from CALAM join NHANVIEN on CALAM.ID = NHANVIEN.ID where Ngay=@ngay");
            if (DateTime.Now.Hour < 7)
            {
                cmd.Parameters.AddWithValue("@ngay", DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy"));
            }
            else
            {
                cmd.Parameters.AddWithValue("@ngay", DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
            }
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"BaoCao");
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["BaoCao"];

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
