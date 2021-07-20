using CrmTav_V2.Models;
using CrmTav_V2.Models.ViewModels;
using CrmTav_V2.Utilities;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace CrmTav_V2.Views
{
    public partial class MoneyReportForm : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;

        public MoneyReportForm()
        {
            InitializeComponent();
        }

        public MoneyReportForm(TblAgent agent)
        {
            InitializeComponent();
            _agent = agent;
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
                Width = 100,
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

        private void _createGridClients()
        {
            GrdClient1.Columns.Add(new GridColumn
            {
                Caption = "کد",
                FieldName = "id",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Width = 50,
                Visible = true
            }); GrdClient1.Columns.Add(new GridColumn
            {
                Caption = "نام مشتری",
                FieldName = "Name",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 150,
                Visible = true
            }); GrdClient1.Columns.Add(new GridColumn
            {
                Caption = "توضیحات",
                FieldName = "Desc",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 500,
                Visible = true
            }); GrdClient1.Columns.Add(new GridColumn
            {
                Caption = "تاریخ قرارداد",
                FieldName = "DateOfContract",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 100,
                Visible = true
            });
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<TblMoney> records = new List<TblMoney>();
            CrmTavEntities core = new CrmTavEntities();
            long incomes = 0;
            long outgoes = 0;
            // && ToDateTime(i.Date) >= DtFrom.Value
            foreach (TblMoney i in core.TblMoney.ToList())
            {
                if (i.Date.ToDateTime() < DtTo.Value && i.Date.ToDateTime() >= DtFrom.Value)
                {
                    records.Add(i);
                    if (i.Amount >= 0)
                        incomes += i.Amount;
                    else
                        outgoes += i.Amount;
                }
            }
            records.Reverse();
            GrdMoney.DataSource = records;
            LblIncome.Text = string.Format("{0:n0}", incomes);
            LblOutgo.Text = string.Format("{0:n0}", outgoes);
            LblAll.Text = string.Format("{0:n0}", incomes + outgoes);
        }

        private void MoneyReportForm_Load(object sender, EventArgs e)
        {
            gridView2.Columns.Clear();
            _createGridMoney();
            GrdClient1.Columns.Clear();
            _createGridClients();
            string construct = DateTime.Now.ToPersian();
            DtTo.Text = construct;
            DtToClient.Text = construct;
            string[] split = construct.Split('/');
            construct = Convert.ToInt32(split[1]) == 1 ? $"{Convert.ToInt32(split[0]) - 1}/12/{split[2]}" : $"{split[0]}/{Convert.ToInt32(split[1]) - 1}/{split[2]}";
            DtFrom.Text = construct;
            DtFromClient.Text = construct;
        }

        private void BtnSearchCustomers_Click(object sender, EventArgs e)
        {
            List<TblClient> records = new List<TblClient>();
            CrmTavEntities core = new CrmTavEntities();
            long incomes = 0;
            // && ToDateTime(i.Date) >= DtFrom.Value
            foreach (TblClient i in core.TblClient.ToList())
            {
                if (i.DateOfContract.Value < DtToClient.Value && i.DateOfContract.Value >= DtFromClient.Value)
                {
                    records.Add(i);
                    incomes += i.Price ?? 0;
                }
            }
            List<CtoClient> result = new List<CtoClient>();
            foreach (TblClient i in records)
                result.Add(new CtoClient(i.id, i.Name, i.Desc, i.DateOfContract.Value.ToPersian()));
            result.Reverse();
            GrdClient.DataSource = result;
            LblClientIncome.Text = string.Format("{0:n0}", incomes);
        }

    }
}