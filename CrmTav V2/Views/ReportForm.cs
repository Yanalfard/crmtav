using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmTav_V2.Models;
using DevExpress.XtraGrid.Columns;

namespace CrmTav_V2.Views
{
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private TblClient _client;

        public ReportForm(TblAgent agent, TblClient client)
        {
            InitializeComponent();
            _agent = agent;
            _client = client;
        }

        private void _createGrid()
        {
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "کد",
                FieldName = "id",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Width = 50,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "عنوان",
                FieldName = "Title",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "توضیحات",
                FieldName = "Desc",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 800,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "تاریخ",
                FieldName = "Date",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            CrmTavEntities context = new CrmTavEntities();
            gridView1.Columns.Clear();
            _createGrid();
            List<TblReport> reportsDto = context.TblReport.Where(i => i.ClientId == _client.id).ToList();
            List<TblReport> reports = new List<TblReport>(reportsDto.Count);
            foreach (TblReport i in reportsDto)
                reports.Add(i);

            reports.Reverse();
            GrdReports.DataSource = reports;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ReportDIalog dialog = new ReportDIalog(_client);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ReportForm_Load(sender, e);
            }
        }
    }
}