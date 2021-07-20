using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CrmTav_V2.Models;
using CrmTav_V2.Models.ViewModels;
using Newtonsoft.Json;

namespace CrmTav_V2.Views
{
    public partial class ClientDialog : DevExpress.XtraEditors.XtraForm
    {
        private TblAgent _agent;
        private TblClient _selectedClient;
        private bool _isEdit;
        private bool _isAdmin;
        private List<CTOProvincesAndCities> _provincesAndCities;
        private int _agentOfInterest = 0;
        public ClientDialog(TblAgent agent, int clientId = 0, bool isEdit = false, bool isNorm = true)
        {
            InitializeComponent();
            _agent = agent;
            _selectedClient = new CrmTavEntities().TblClient.SingleOrDefault(i => i.id == clientId);
            _isEdit = isEdit;
            if (isEdit)
            {
                EditMode(true);
                BtnSubmit.Visible = true;
            }

            if (_agent.Role.Trim() == "0")
                _isAdmin = true;
            if (!isNorm)
            {
                BtnEdit.Visible = true;
            }
        }

        private void SetError(Control control, string error = "این جا خالی است")
        {
            Err.SetError(control, error);
            control.Focus();
        }

        private void EditMode(bool isEdit)
        {
            TxtName.Enabled = !isEdit;
            TxtTellNo1.Enabled = !isEdit;
            DtDelivery.Enabled = !isEdit;
            TxtSupportPrice.Enabled = !isEdit;
            DtContract.Enabled = !isEdit;
            DtSupport.Enabled = !isEdit;
            DtDomain.Enabled = !isEdit;
            DtSsl.Enabled = !isEdit;
            DtHost.Enabled = !isEdit;
            TxtFrom.Enabled = !isEdit;
            TxtDesc.Enabled = !isEdit;
            TxtPaymentWay.Enabled = !isEdit;
            TxtDelayedPenalty.Enabled = !isEdit;
            TxtData.Enabled = !isEdit;
            DtData.Enabled = !isEdit;
            TxtProposal.Enabled = !isEdit;
            BtnReports.Visible = isEdit;
            CheckDomain.Enabled = !isEdit;
            CheckHost.Enabled = !isEdit;
            CheckSsl.Enabled = !isEdit;
            CheckSupport.Enabled = !isEdit;
            TxtDiscount.Enabled = !isEdit;
            TxtPrice.Enabled = !isEdit;
            CmbMarketers.Enabled = !isEdit;
            CmbProvinces.Enabled = !isEdit;
            CmbCities.Enabled = !isEdit;
            TxtTellNo2.Enabled = !isEdit;
            TxtStaticTellNo.Enabled = !isEdit;
            TxtIdentificationNo.Enabled = !isEdit;
            TxtEmail.Enabled = !isEdit;
            TxtAddress.Enabled = !isEdit;
            TxtProjectName.Enabled = !isEdit;
            TxtWebsite.Enabled = !isEdit;
            BtnSubmit.Text = !isEdit ? "ویرایش" : "ثبت";
            BtnFraction.Visible = isEdit;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Err.ClearErrors();
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                SetError(TxtName);
            }
            else
            {
                CrmTavEntities context = new CrmTavEntities();
                TblClient client = new TblClient();
                client.AgentId = _agentOfInterest == 0 ? context.TblAgent.First(i => i.Name == CmbMarketers.Text).id : _agentOfInterest;
                client.Name = TxtName.Text;
                client.DateOfDelivery = DtDelivery.Value;
                client.SupportCost = long.Parse(string.IsNullOrEmpty(TxtSupportPrice.Text) ? "0" : TxtSupportPrice.Text);
                client.DateOfContract = DtContract.Value;
                client.SupportLap = DtSupport.Value;
                client.DomainLap = DtDomain.Value;
                client.SSLLap = DtSsl.Value;
                client.HostLap = DtHost.Value;
                client.From = TxtFrom.Text;
                client.Desc = TxtDesc.Text;
                client.PaymentWay = TxtPaymentWay.Text;
                client.DelayedPenalty = Convert.ToInt32(string.IsNullOrEmpty(TxtDelayedPenalty.Text) ? "0" : TxtDelayedPenalty.Text);
                client.DataWanted = TxtData.Text;
                client.DateDataWanted = DtData.Value;
                client.Proposal = TxtProposal.Text;
                client.DateGenerated = DateTime.Now;
                client.TellNo1 = TxtTellNo1.Text;
                client.Price = long.Parse(string.IsNullOrEmpty(TxtPrice.Text) ? "0" : TxtPrice.Text);
                client.Discount = Convert.ToInt32(string.IsNullOrEmpty(TxtDiscount.Text) ? "0" : TxtDiscount.Text);
                client.TellNo2 = TxtTellNo2.Text;
                client.StaticTellNo = TxtStaticTellNo.Text;
                client.IdentificationNo = TxtIdentificationNo.Text;
                client.Email = TxtEmail.Text;
                client.Address = TxtAddress.Text;
                client.ProjectName = TxtProjectName.Text;
                client.Website = TxtWebsite.Text;
                if (BtnSubmit.Text == "ثبت")
                {
                    context.TblClient.Add(client);
                    if (CheckSupport.Checked)
                    {
                        if (string.IsNullOrEmpty(DtSupport.Text))
                        {
                            SetError(DtSupport);
                        }
                        else
                        {
                            TblReminder reminder = new TblReminder();
                            reminder.AgentId = _agent.id;
                            DateTime time = (DtSupport.Value ?? DateTime.Now);
                            reminder.Time = new DateTime(time.Year, time.Month, time.Day, 13, 1, 1).Subtract(new TimeSpan(15, 0, 0, 0));
                            reminder.Title = $"زمان اتمام پشتیبانی مشتری {client.Name} رسید";
                            reminder.IsReminded = false;
                            context.TblReminder.Add(reminder);
                        }
                    }

                    if (CheckDomain.Checked)
                    {
                        if (string.IsNullOrEmpty(DtDomain.Text))
                        {
                            SetError(DtDomain);
                        }
                        else
                        {
                            TblReminder reminder = new TblReminder();
                            reminder.AgentId = _agent.id;
                            DateTime time = (DtDomain.Value ?? DateTime.Now);
                            reminder.Time = new DateTime(time.Year, time.Month, time.Day, 13, 1, 1).Subtract(new TimeSpan(15, 0, 0, 0));
                            reminder.Title = $"زمان اتمام دامنه مشتری {client.Name} رسید";
                            context.TblReminder.Add(reminder);
                        }
                    }

                    if (CheckSsl.Checked)
                    {
                        if (string.IsNullOrEmpty(DtSsl.Text))
                        {
                            SetError(DtSsl);
                        }
                        else
                        {
                            TblReminder reminder = new TblReminder();
                            reminder.AgentId = _agent.id;
                            DateTime time = (DtSsl.Value ?? DateTime.Now);
                            reminder.Time = new DateTime(time.Year, time.Month, time.Day, 13, 1, 1).Subtract(new TimeSpan(15, 0, 0, 0));
                            reminder.Title = $"زمان اتمام SSL مشتری {client.Name} رسید";
                            context.TblReminder.Add(reminder);
                        }
                    }

                    if (CheckHost.Checked)
                    {
                        if (string.IsNullOrEmpty(DtHost.Text))
                        {
                            SetError(DtHost);
                        }
                        else
                        {
                            TblReminder reminder = new TblReminder();
                            reminder.AgentId = _agent.id;
                            DateTime time = (DtHost.Value ?? DateTime.Now);
                            reminder.Time = new DateTime(time.Year, time.Month, time.Day, 13, 1, 1).Subtract(new TimeSpan(15, 0, 0, 0));
                            reminder.Title = $"زمان اتمام هاست مشتری {client.Name} رسید";
                            context.TblReminder.Add(reminder);
                        }
                    }
                }
                else if (BtnSubmit.Text == "ویرایش")
                {
                    if (_selectedClient.id != 0)
                    {
                        TblClient selectedClient = context.TblClient.SingleOrDefault(i => i.id == _selectedClient.id);
                        selectedClient.AgentId = _agentOfInterest == 0 ? context.TblAgent.First(i => i.Name == CmbMarketers.Text).id : _agentOfInterest;
                        selectedClient.Name = TxtName.Text;
                        selectedClient.DateOfDelivery = DtDelivery.Value;
                        selectedClient.SupportCost = long.Parse(string.IsNullOrEmpty(TxtSupportPrice.Text) ? "0" : TxtSupportPrice.Text);
                        selectedClient.DateOfContract = DtContract.Value;
                        selectedClient.SupportLap = DtSupport.Value;
                        selectedClient.DomainLap = DtDomain.Value;
                        selectedClient.SSLLap = DtSsl.Value;
                        selectedClient.HostLap = DtHost.Value;
                        selectedClient.From = TxtFrom.Text;
                        selectedClient.Desc = TxtDesc.Text;
                        selectedClient.PaymentWay = TxtPaymentWay.Text;
                        selectedClient.DelayedPenalty = Convert.ToInt32(string.IsNullOrEmpty(TxtDelayedPenalty.Text) ? "0" : TxtDelayedPenalty.Text);
                        selectedClient.DataWanted = TxtData.Text;
                        selectedClient.DateDataWanted = DtData.Value;
                        selectedClient.Proposal = TxtProposal.Text;
                        selectedClient.TellNo1 = TxtTellNo1.Text;
                        selectedClient.Province = CmbProvinces.Text;
                        selectedClient.City = CmbCities.Text;
                        selectedClient.TellNo2 = TxtTellNo2.Text;
                        selectedClient.StaticTellNo = TxtStaticTellNo.Text;
                        selectedClient.IdentificationNo = TxtIdentificationNo.Text;
                        selectedClient.Email = TxtEmail.Text;
                        selectedClient.Address = TxtAddress.Text;
                        selectedClient.ProjectName = TxtProjectName.Text;
                        selectedClient.Website = TxtWebsite.Text;
                        selectedClient.Price = long.Parse(string.IsNullOrEmpty(TxtPrice.Text) ? "0" : TxtPrice.Text);
                        selectedClient.Discount = Convert.ToInt32(string.IsNullOrEmpty(TxtDiscount.Text) ? "0" : TxtDiscount.Text);
                    }
                }
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnEdit_CheckedChanged(object sender, EventArgs e)
        {
            EditMode(TxtName.Enabled);
            if (BtnEdit.Checked)
            {
                BtnSubmit.Visible = true;
            }
        }

        private void ClientDialog_Load(object sender, EventArgs e)
        {
            CrmTavEntities context = new CrmTavEntities();
            if (_isAdmin)
            {
                _provincesAndCities =
                    JsonConvert.DeserializeObject<List<CTOProvincesAndCities>>(
                        System.IO.File.ReadAllText($@"{Application.StartupPath}\ProvincesAndCities.json"));
                CmbProvinces.Properties.Items.AddRange(_provincesAndCities.Select(i => i.province).Distinct().OrderBy(i => i).ToList());
                CmbMarketers.Properties.Items.AddRange(context.TblAgent.ToList().Select(i => i.Name).ToList());
                CmbMarketers.SelectedIndex = 0;
                if (_isEdit)
                {
                    TblClient selectedClient = context.TblClient.SingleOrDefault(i => i.id == _selectedClient.id);
                    TxtName.Text = selectedClient.Name;
                    DtDelivery.Value = selectedClient.DateOfDelivery;
                    TxtSupportPrice.Text = selectedClient.SupportCost.ToString();
                    DtContract.Value = selectedClient.DateOfContract;
                    DtSupport.Value = selectedClient.SupportLap;
                    DtDomain.Value = selectedClient.DomainLap;
                    DtSsl.Value = selectedClient.SSLLap;
                    DtHost.Value = selectedClient.HostLap;
                    TxtFrom.Text = selectedClient.From;
                    TxtDesc.Text = selectedClient.Desc;
                    TxtPaymentWay.Text = selectedClient.PaymentWay;
                    TxtDelayedPenalty.Text = selectedClient.DelayedPenalty.ToString();
                    TxtData.Text = selectedClient.DataWanted;
                    DtData.Value = selectedClient.DateDataWanted;
                    TxtProposal.Text = selectedClient.Proposal;
                    TxtTellNo1.Text = selectedClient.TellNo1;
                    TxtPrice.Text = selectedClient.Price.ToString();
                    TxtDiscount.Text = selectedClient.Discount.ToString();
                    TblAgent agent = context.TblAgent.First(i => i.id == selectedClient.AgentId);
                    CmbMarketers.Text = agent.Name;
                    CmbProvinces.Text = selectedClient.Province;
                    CmbCities.Text = selectedClient.City;
                    TxtTellNo2.Text = selectedClient.TellNo2;
                    TxtEmail.Text = selectedClient.Email;
                    TxtStaticTellNo.Text = selectedClient.StaticTellNo;
                    TxtAddress.Text = selectedClient.Address;
                    TxtIdentificationNo.Text = selectedClient.IdentificationNo;
                    TxtProjectName.Text = selectedClient.ProjectName;
                    TxtWebsite.Text = selectedClient.Website;
                }

            }
            else
            {
                _provincesAndCities =
                JsonConvert.DeserializeObject<List<CTOProvincesAndCities>>(
                    System.IO.File.ReadAllText($@"{Application.StartupPath}\ProvincesAndCities.json"));
                CmbProvinces.Properties.Items.AddRange(_provincesAndCities.Select(i => i.province).Distinct().OrderBy(i => i).ToList());
                CmbMarketers.Properties.Items.AddRange(context.TblAgent.ToList().Select(i => i.Name).ToList());
                CmbMarketers.SelectedIndex = 0;
                if (_isEdit)
                {
                    TblClient selectedClient = context.TblClient.SingleOrDefault(i => i.id == _selectedClient.id);
                    if (selectedClient.TblAgent.id != _agent.id)
                    {
                        labelControl25.Visible = false;
                        labelControl23.Visible = false;
                        labelControl16.Visible = false;
                        labelControl22.Visible = false;
                        labelControl24.Visible = false;
                        labelControl26.Visible = false;
                        TxtIdentificationNo.Visible = false;
                        TxtStaticTellNo.Visible = false;
                        TxtTellNo1.Visible = false;
                        TxtTellNo2.Visible = false;
                        TxtEmail.Visible = false;
                        TxtAddress.Visible = false;
                        labelControl14.Visible = false;
                        DtData.Visible = false;
                        groupControl2.Visible = false;
                        groupControl4.Visible = false;
                        BtnEdit.Visible = false;
                    }
                    else
                    {
                        groupControl2.Visible = false;
                        labelControl11.Visible = false;
                        labelControl15.Visible = false;
                        TxtProposal.Visible = false;
                        labelControl19.Visible = false;
                        CmbMarketers.Visible = false;
                        TxtPaymentWay.Visible = false;
                    }
                    TxtName.Text = selectedClient.Name;
                    DtDelivery.Value = selectedClient.DateOfDelivery;
                    TxtSupportPrice.Text = selectedClient.SupportCost.ToString();
                    DtContract.Value = selectedClient.DateOfContract;
                    DtSupport.Value = selectedClient.SupportLap;
                    DtDomain.Value = selectedClient.DomainLap;
                    DtSsl.Value = selectedClient.SSLLap;
                    DtHost.Value = selectedClient.HostLap;
                    TxtFrom.Text = selectedClient.From;
                    TxtDesc.Text = selectedClient.Desc;
                    TxtPaymentWay.Text = selectedClient.PaymentWay;
                    TxtDelayedPenalty.Text = selectedClient.DelayedPenalty.ToString();
                    TxtData.Text = selectedClient.DataWanted;
                    DtData.Value = selectedClient.DateDataWanted;
                    TxtProposal.Text = selectedClient.Proposal;
                    TxtTellNo1.Text = selectedClient.TellNo1;
                    TxtPrice.Text = selectedClient.Price.ToString();
                    TxtDiscount.Text = selectedClient.Discount.ToString();
                    TblAgent agent = context.TblAgent.First(i => i.id == selectedClient.AgentId);
                    CmbMarketers.Text = agent.Name;
                    CmbProvinces.Text = selectedClient.Province;
                    CmbCities.Text = selectedClient.City;
                    TxtTellNo2.Text = selectedClient.TellNo2;
                    TxtEmail.Text = selectedClient.Email;
                    TxtStaticTellNo.Text = selectedClient.StaticTellNo;
                    TxtAddress.Text = selectedClient.Address;
                    TxtIdentificationNo.Text = selectedClient.IdentificationNo;
                    TxtProjectName.Text = selectedClient.ProjectName;
                }
                else
                {
                    groupControl2.Visible = false;
                    labelControl11.Visible = false;
                    labelControl15.Visible = false;
                    TxtProposal.Visible = false;
                    TxtPaymentWay.Visible = false;
                    labelControl19.Visible = false;
                    CmbMarketers.Visible = false;
                    _agentOfInterest = _agent.id;
                }
            }
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(_agent, _selectedClient);
            form.ShowDialog();
        }

        private void CmbProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbCities.Properties.Items.AddRange(_provincesAndCities.Where(i => i.province == CmbProvinces.Text).Select(i => i.city).Distinct().OrderBy(i => i).ToList());
        }

        private void CheckSupport_CheckedChanged(object sender, EventArgs e)
        {
            if (DtSupport.Text == "")
                CheckSupport.Checked = false;
        }

        private void CheckHost_CheckedChanged(object sender, EventArgs e)
        {
            if (DtHost.Text == "")
                CheckHost.Checked = false;
        }

        private void CheckDomain_CheckedChanged(object sender, EventArgs e)
        {
            if (DtDomain.Text == "")
                CheckDomain.Checked = false;
        }

        private void CheckSsl_CheckedChanged(object sender, EventArgs e)
        {
            if (DtSsl.Text == "")
                CheckSsl.Checked = false;
        }

        private void BtnFraction_Click(object sender, EventArgs e)
        {
            FractionsForm form = new FractionsForm(_agent, _selectedClient);
            form.ShowDialog();
        }
    }
}