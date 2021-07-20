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
    public partial class FractionsForm : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private TblClient _client;

        public FractionsForm()
        {
            InitializeComponent();
        }

        public FractionsForm(TblAgent agent, TblClient client)
        {
            _agent = agent;
            _client = client;
            InitializeComponent();
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
                Caption = "بانک",
                FieldName = "Bank",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "مقدار",
                FieldName = "Amount",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
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
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "شماره",
                FieldName = "No",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
        }

        private void FractionsForm_Load(object sender, EventArgs e)
        {
            CrmTavEntities context = new CrmTavEntities();
            gridView1.Columns.Clear();
            _createGrid();
            List<TblFraction> fractionsDto = context.TblFraction.Where(i => i.ClientId == _client.id).ToList();
            List<CtoFraction> fractions = new List<CtoFraction>(fractionsDto.Count);
            foreach (TblFraction i in fractionsDto)
                fractions.Add(new CtoFraction(i.id, i.Bank, i.Amount.ToString(), i.Date.ToPersian(), i.No));

            fractions.Reverse();
            GrdFractions.DataSource = fractions;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FractionsDialog dialog = new FractionsDialog(_agent, _client);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FractionsForm_Load(sender, e);
            }
        }

        private void GrdFractions_Click(object sender, EventArgs e)
        {
            FractionsDialog dialog = new FractionsDialog(_agent, _client, true, Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id")));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FractionsForm_Load(sender, e);
            }
        }
    }
}