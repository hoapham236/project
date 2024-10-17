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
    public partial class XuatBill : Form
    {
        public XuatBill()
        {
            InitializeComponent();
        }
        MyDatabase mydb = new MyDatabase();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select IdBil,IdRoom,Type,TimeCin,TimeCout,BookRoom.name,CMND,address,phone,note,Service.Name as 'NameService',SL,BookRoom.price as 'priceRoom',Service.price as 'priceService',IdMon,TenMon,GiaMon from (Service full join ExtraService full join Mon on ExtraService.IdService = Mon.IdMon on ExtraService.IdService = Service.Id) full join BookRoom full join Room on BookRoom.IdRoom=Room.Id on BookRoom.IdBil=ExtraService.IdBill where IdBil=@id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = CheckOutRoom.idbil;
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Columns.Add("totalprice");
            dt.Rows[0]["totalprice"] = CheckOutRoom.price;
            dt.Columns.Add("TenTN");
            dt.Rows[0]["TenTN"] = Worksession.tentn;
            ds.Tables.Add(dt);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void XuatBill_Load(object sender, EventArgs e)
        {

        }
    }
}
