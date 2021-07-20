using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmTav_V2.Models;

namespace CrmTav_V2.Views
{
    public partial class RemindersDialog : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private bool _isEdit;
        private int _reminderToEditId;

        public RemindersDialog(TblAgent agent, bool isEdit = false, int reminderToEditId = 0)
        {
            InitializeComponent();
            _agent = agent;
            _isEdit = isEdit;
            _reminderToEditId = reminderToEditId;
        }

        public RemindersDialog()
        {
            InitializeComponent();
        }

        private void SetError(Control control, string error = "این جا خالی است")
        {
            Err.SetError(control, error);
            control.Focus();
        }

        private void EditMode(bool isEdit)
        {
            BtnDelete.Visible = isEdit;
            BtnSubmit.Text = isEdit ? "ویرایش" : "ثبت";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Err.ClearErrors();
                if (string.IsNullOrEmpty(TxtTitle.Text))
                    SetError(TxtTitle);
                else if (string.IsNullOrEmpty(DtDate.Text))
                    SetError(DtDate);
                else if (string.IsNullOrEmpty(TxtTime.Text))
                    SetError(TxtTime);
                else
                {
                    if (!_isEdit)
                    {
                        TblReminder reminder = new TblReminder();
                        reminder.AgentId = _agent.id;
                        reminder.Title = TxtTitle.Text;
                        DateTime date = DtDate.Value ?? new DateTime(1990, 1, 1, 1, 1, 1, 1);
                        string[] timeCheck = TxtTime.Text.Replace("_", "").Split(':');
                        int hour = Convert.ToInt32(timeCheck[0]);
                        int minute = Convert.ToInt32(timeCheck[1]);
                        if (Convert.ToInt32(timeCheck[0]) > 24)
                            hour = 0;
                        if (Convert.ToInt32(timeCheck[1]) > 59)
                            minute = 59;

                        reminder.Time = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);
                        CrmTavEntities context = new CrmTavEntities();
                        context.TblReminder.Add(reminder);
                        context.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        CrmTavEntities context = new CrmTavEntities();
                        TblReminder reminder = context.TblReminder.SingleOrDefault(i => i.id == _reminderToEditId); 
                        reminder.AgentId = _agent.id;
                        reminder.Title = TxtTitle.Text;
                        DateTime date = DtDate.Value ?? new DateTime(1990, 1, 1, 1, 1, 1, 1);
                        string[] timeCheck = TxtTime.Text.Replace("_", "").Split(':');
                        int hour = Convert.ToInt32(timeCheck[0]);
                        int minute = Convert.ToInt32(timeCheck[1]);
                        if (Convert.ToInt32(timeCheck[0]) > 24)
                            hour = 0;
                        if (Convert.ToInt32(timeCheck[1]) > 59)
                            minute = 59;
                        reminder.Time = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);
                        context.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("مشکلی پیش آمده به ینال بگویید", "اخطار");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void RemindersDialog_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                EditMode(true);
                TblReminder remider = new CrmTavEntities().TblReminder.SingleOrDefault(i => i.id == _reminderToEditId);
                TxtTitle.Text = remider.Title;
                DtDate.Value = remider.Time;
                TxtTime.Text = (remider.Time.Hour > 9 ? remider.Time.Hour.ToString() : $"0{remider.Time.Hour}") + ":" +
                               (remider.Time.Minute > 9 ? remider.Time.Minute.ToString() : $"0{remider.Time.Minute}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (CrmTavEntities Context = new CrmTavEntities())
                {
                    TblReminder deptDelete = Context.TblReminder.Find(_reminderToEditId);
                    Context.Entry(deptDelete).State = EntityState.Deleted;
                    Context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            catch 
            {
                XtraMessageBox.Show("مشکلی پیش آمده به ینال بگویید", "اخطار");
                DialogResult = DialogResult.Cancel;
            }
        }

    }
}