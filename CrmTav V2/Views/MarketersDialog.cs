using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using CrmTav_V2.Models;

namespace CrmTav_V2.Views
{
    public partial class MarketersDialog : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private TblAgent _agentSelected;
        private bool _isEdit;
        public MarketersDialog()
        {
            InitializeComponent();
        }

        public MarketersDialog(TblAgent agent, bool isEdit = false, int agentSelected = 0)
        {
            CrmTavEntities context = new CrmTavEntities();
            _agent = agent;
            _isEdit = isEdit;
            if (_isEdit)
                _agentSelected = context.TblAgent.First(i => i.id == agentSelected);
            InitializeComponent();
        }

        private void EditMode(bool isEdit)
        {
            BtnSubmit.Text = isEdit ? "ویرایش" : "ثبت";
            BtnDelete.Visible = isEdit;
        }

        private void SetError(Control control, string error = "این جا خالی است")
        {
            Err.SetError(control, error);
            control.Focus();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (string.IsNullOrEmpty(TxtName.Text))
                {
                    SetError(TxtName);
                }
                else if (string.IsNullOrEmpty(TxtUsername.Text))
                {
                    SetError(TxtUsername);
                }
                else if (string.IsNullOrEmpty(TxtPassword.Text))
                {
                    SetError(TxtPassword);
                }
                else if (string.IsNullOrEmpty(TxtTellNo.Text))
                {
                    SetError(TxtTellNo);
                }
                else if (string.IsNullOrEmpty(DtTimeCome.Text))
                {
                    SetError(DtTimeCome);
                }
                else
                {
                    CrmTavEntities context = new CrmTavEntities();
                    if (!_isEdit)
                    {
                        TblAgent agent = new TblAgent();
                        agent.Name = TxtName.Text;
                        agent.Username = TxtUsername.Text;
                        agent.Password = TxtPassword.Text;
                        agent.TellNo = TxtTellNo.Text;
                        agent.DateCome = DtTimeCome.Value ?? DateTime.Now;
                        agent.IsAvailibal = CheckIsAvailibal.Checked;
                        agent.Role = "1";
                        context.TblAgent.Add(agent);
                        context.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        TblAgent agent = context.TblAgent.First(i => i.id == _agentSelected.id);
                        agent.Name = TxtName.Text;
                        agent.Username = TxtUsername.Text;
                        agent.Password = TxtPassword.Text;
                        agent.TellNo = TxtTellNo.Text;
                        agent.DateCome = DtTimeCome.Value ?? DateTime.Now;
                        agent.IsAvailibal = CheckIsAvailibal.Checked;
                        agent.Role = "1";
                        context.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CrmTavEntities context = new CrmTavEntities();
                TblAgent agentToDelete = context.TblAgent.First(i => i.id == _agentSelected.id);
                context.TblAgent.Remove(agentToDelete);
                context.SaveChanges();
            }
            catch
            {
                XtraMessageBox.Show("این داده دارای روابط غیرقابل حذف میباشد", "اخطار");
            }
        }

        private void MarketersDialog_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                EditMode(true);
                TxtName.Text = _agentSelected.Name;
                TxtUsername.Text = _agentSelected.Username;
                TxtPassword.Text = _agentSelected.Password;
                TxtTellNo.Text = _agentSelected.TellNo;
                DtTimeCome.Value = _agentSelected.DateCome;
                CheckIsAvailibal.Checked = _agentSelected.IsAvailibal;
            }
        }
    }
}