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

namespace CrmTav_V2.Views
{
    public partial class FractionsDialog : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private TblClient _client;
        private bool _isEdit;
        private int _selectedFractionId;

        public FractionsDialog()
        {
            InitializeComponent();
        }

        public FractionsDialog(TblAgent agent, TblClient client, bool isEdit = false, int selectedFractionId = 0)
        {
            InitializeComponent();
            _agent = agent;
            _client = client;
            _isEdit = isEdit;
            _selectedFractionId = selectedFractionId;
        }

        private void SetError(Control control, string error = "این جا خالی است")
        {
            Err.SetError(control, error);
            control.Focus();
        }

        private void EditMode(bool isEdit)
        {
            BtnSubmit.Text = isEdit ? "ویرایش" : "ثبت";
            BtnDelete.Visible = isEdit;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DtDate.Text))
                    SetError(DtDate);
                else if (string.IsNullOrEmpty(TxtAmount.Text))
                    SetError(TxtAmount);
                else
                {
                    CrmTavEntities context = new CrmTavEntities();
                    if (!_isEdit)
                    {
                        TblFraction fraction = new TblFraction();
                        fraction.Bank = TxtBank.Text;
                        fraction.No = TxtNo.Text;
                        fraction.Amount = long.Parse(TxtAmount.Text);
                        fraction.Date = DtDate.Value ?? new DateTime(1970, 1, 1, 1, 1, 1);
                        fraction.ClientId = _client.id;
                        fraction.To = TxtTo.Text;
                        context.TblFraction.Add(fraction);
                        context.SaveChanges();

                        TblReminder reminder = new TblReminder();
                        reminder.AgentId = _agent.id;
                        reminder.IsReminded = false;
                        reminder.Time = new DateTime(fraction.Date.Year, fraction.Date.Month, fraction.Date.Day, 13, 1, 1).Subtract(new TimeSpan(1, 0, 0, 0));
                        reminder.Title = $"چک با شماره {fraction.No} از طرف {fraction.To} فردا قابل برداشت است";
                        context.TblReminder.Add(reminder);
                        context.SaveChanges();
                    }
                    else
                    {
                        TblFraction fraction = context.TblFraction.First(i => i.id == _selectedFractionId);
                        fraction.Bank = TxtBank.Text;
                        fraction.No = TxtNo.Text;
                        fraction.Amount = long.Parse(TxtAmount.Text);
                        fraction.Date = DtDate.Value ?? new DateTime(1970, 1, 1, 1, 1, 1);
                        fraction.ClientId = _client.id;
                        fraction.To = TxtTo.Text;
                        context.SaveChanges();
                    }

                    DialogResult = DialogResult.OK;
                }

            }
            catch
            {
                XtraMessageBox.Show("مشکلی پیش آمده به ینال بگویید", "اخطار");
            }
        }

        private void FractionsDialog_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                EditMode(true);
                TblFraction fraction = new CrmTavEntities().TblFraction.First(i => i.id == _selectedFractionId);
                TxtBank.Text = fraction.Bank;
                TxtAmount.Text = fraction.Amount.ToString();
                TxtNo.Text = fraction.No;
                TxtTo.Text = fraction.To;
                DtDate.Value = fraction.Date;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CrmTavEntities context = new CrmTavEntities();
                TblFraction fraction = context.TblFraction.First(i => i.id == _selectedFractionId);
                context.TblFraction.Remove(fraction);
                context.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch
            {
                XtraMessageBox.Show("مشکلی پیش آمده به ینال بگویید", "اخطار");
            }
        }

    }
}