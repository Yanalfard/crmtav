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
    public partial class RemindersForm : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;

        public RemindersForm()
        {
            InitializeComponent();
        }

        public RemindersForm(TblAgent agent)
        {
            InitializeComponent();
            _agent = agent;
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
                Width = 750,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "تاریخ",
                FieldName = "Time",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 250,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "بازاریاب",
                FieldName = "AgentName",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Width = 200,
                Visible = true
            });
        }

        private void RemindersForm_Load(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            _createGrid();
            List<CtoReminders> remindersToShow =
                new List<CtoReminders>();
            CrmTavEntities context = new CrmTavEntities();
            List<TblReminder> allReminders = context.TblReminder.Where(i => i.AgentId == _agent.id).OrderByDescending(j => j.id).ToList();
            foreach (TblReminder i in allReminders)
            {
                remindersToShow.Add(new CtoReminders(i.id, i.Title, $"{i.Time.Hour}:{i.Time.Minute}:{i.Time.Second} {i.Time.ToPersian()}", _agent.Name));
            }
            GrdReminders.DataSource = remindersToShow;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            RemindersDialog dialog = new RemindersDialog(_agent);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RemindersForm_Load(sender, e);
            }
        }

        private void GrdReminders_Click(object sender, EventArgs e)
        {
            RemindersDialog dialog = new RemindersDialog(_agent, true, Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id")));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RemindersForm_Load(sender, e);
            }
        }
    }
}