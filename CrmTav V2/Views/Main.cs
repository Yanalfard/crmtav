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
using CrmTav_V2.Models.ViewModels;
using CrmTav_V2.Utilities;
using DevExpress.XtraGrid.Columns;

namespace CrmTav_V2.Views
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private bool _isAdmin;

        public Main()
        {
            InitializeComponent();
        }

        public Main(TblAgent agent)
        {
            _agent = agent;
            if (_agent.Role.Trim() == "0")
                _isAdmin = true;
            InitializeComponent();
        }

        private void _createGridMainForAdmin()
        {
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "کد",
                FieldName = "id",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Width = 50,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "نام مشتری",
                FieldName = "Name",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 150,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "توضیحات",
                FieldName = "Desc",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 500,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "تاریخ قرارداد",
                FieldName = "DateOfContract",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 100,
                Visible = true
            });
        }

        private void _createGridMoney()
        {
            gridView2.Columns.Add(new GridColumn
            {
                Caption = "کد",
                FieldName = "id",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Width = 50,
                Visible = true
            }); gridView2.Columns.Add(new GridColumn
            {
                Caption = "مقدار",
                FieldName = "Amount",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 130,
                Visible = true
            }); gridView2.Columns.Add(new GridColumn
            {
                Caption = "توضیحات",
                FieldName = "Description",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 500,
                Visible = true
            }); gridView2.Columns.Add(new GridColumn
            {
                Caption = "تاریخ ساخت",
                FieldName = "Date",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 100,
                Visible = true
            }); gridView2.Columns.Add(new GridColumn
            {
                Caption = "تاریخ پاس",
                FieldName = "DatePass",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 100,
                Visible = true
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!_isAdmin)
            {
                GrdMoney.Visible = false;
                BtnMoney.Visible = false;
                BtnMarketers.Visible = false;
                labelControl2.Visible = false;
                LblAmount.Visible = false;
                labelControl3.Visible = false;
                gridView1.Columns.Clear();
                CrmTavEntities core = new CrmTavEntities();
                List<TblClient> rawClients = core.TblClient.ToList();
                List<CtoClient> finalClient = new List<CtoClient>(rawClients.Count);
                _createGridMainForAdmin();
                foreach (TblClient i in rawClients)
                    finalClient.Add(i.DateOfContract != null
                        ? new CtoClient(i.id, i.Name, i.Desc, Convert.ToDateTime(i.DateOfContract).ToPersian())
                        : new CtoClient(i.id, i.Name, i.Desc, ""));
                finalClient.Reverse();
                GrdMain.DataSource = finalClient;
            }
            else
            {
                gridView1.Columns.Clear();
                CrmTavEntities core = new CrmTavEntities();
                List<TblClient> rawClients = core.TblClient.ToList();
                List<CtoClient> finalClient = new List<CtoClient>(rawClients.Count);
                _createGridMainForAdmin();
                foreach (TblClient i in rawClients)
                    finalClient.Add(i.DateOfContract != null
                        ? new CtoClient(i.id, i.Name, i.Desc, Convert.ToDateTime(i.DateOfContract).ToPersian())
                        : new CtoClient(i.id, i.Name, i.Desc, "")); finalClient.Reverse();
                GrdMain.DataSource = finalClient;

                gridView2.Columns.Clear();
                List<TblMoney> rawMoneys = core.TblMoney.ToList();
                List<TblMoney> finalMoney = new List<TblMoney>(rawMoneys.Count);
                _createGridMoney();
                foreach (TblMoney i in rawMoneys)
                    finalMoney.Add(i);
                finalMoney.Reverse();
                GrdMoney.DataSource = finalMoney;

                long allMoney = core.TblMoney.Sum(i => i.DatePass == "" ? i.Amount : 0);
                LblAmount.Text = String.Format("{0:n0}", allMoney);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClientDialog dialog = new ClientDialog(_agent);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MainForm_Load(sender, e);
            }

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowHandle = gridView1.FocusedRowHandle;
                TblClient client = new TblClient
                {
                    id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "id")),
                    AgentId = _agent.id,
                    Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString(),
                    Desc = gridView1.GetRowCellValue(rowHandle, "Desc").ToString(),
                };

                ClientDialog form = new ClientDialog(_agent, client.id, true, false);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MainForm_Load(sender, e);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void BtnMoney_Click(object sender, EventArgs e)
        {
            MoneyForm form = new MoneyForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MainForm_Load(sender, e);
            }
        }

        private void BtnReminders_Click(object sender, EventArgs e)
        {
            RemindersForm form = new RemindersForm(_agent);
            form.ShowDialog();
        }

        private void BtnMarketers_Click(object sender, EventArgs e)
        {
            MarkersForm form = new MarkersForm(_agent);
            form.ShowDialog();
        }

        private void BtnMoneyReport_Click(object sender, EventArgs e)
        {
            try
            {
                MoneyReportForm form = new MoneyReportForm(_agent);
                form.ShowDialog();
            }
            catch 
            {
                // ignored
            }
        }
    }
}