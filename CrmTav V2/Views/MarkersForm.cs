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
    public partial class MarkersForm : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;

        public MarkersForm()
        {
            InitializeComponent();
        }
        public MarkersForm(TblAgent agent)
        {
            _agent = agent;
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
                Caption = "نام",
                FieldName = "Name",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 600,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "نام کاربری",
                FieldName = "Username",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 400,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "تلفن",
                FieldName = "TellNo",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "تاریخ استخدام",
                FieldName = "DateCome",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
        }

        private void MarkersForm_Load(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            _createGrid();
            CrmTavEntities context = new CrmTavEntities();
            List<TblAgent> Allagents = context.TblAgent.OrderBy(i => i.id).ToList();
            List<CtoAgent> agentsToShow = new List<CtoAgent>();
            Allagents.ForEach(i => agentsToShow.Add(new CtoAgent(i.id, i.Name, i.Username, i.TellNo, i.DateCome.ToPersian())));
            GrdMarketers.DataSource = agentsToShow;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MarketersDialog dialog = new MarketersDialog(_agent, false, 0);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MarkersForm_Load(sender, e);
            }
        }

        private void GrdMarketers_Click(object sender, EventArgs e)
        {
            MarketersDialog dialog = new MarketersDialog(_agent, true, Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id")));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MarkersForm_Load(sender, e);
            }
        }
    }
}