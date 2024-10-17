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
    public partial class BillNhap : Form
    {
        int id;
        public BillNhap(int x)
        {
            InitializeComponent();
            id = x;
        }
        MyDatabase mydb = new MyDatabase();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select IdPhieuThu,TenNL as 'IdNL',SL,NhapKho.GiaTien from NhapKho join NguyenLieu on NhapKho.IdNL = NguyenLieu.IdNL where IdPhieuThu=@id");
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BillNhap");
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["BillNhap"];

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
