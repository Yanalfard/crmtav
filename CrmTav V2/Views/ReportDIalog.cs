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
    public partial class ReportDIalog : DevExpress.XtraEditors.XtraForm
    {
        private TblClient _client;
        public ReportDIalog(TblClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == string.Empty)
            {
                Err.SetError(TxtTitle, "اینجا خالی میباشد");
            }
            else if (TxtDesc.Text == string.Empty)
            {
                Err.SetError(TxtDesc, "اینجا خالی میباشد");
            }
            else if (TxtTime.Text == string.Empty)
            {
                Err.SetError(TxtTime, "اینجا خالی میباشد");
            }
            else
            {
                TblReport report = new TblReport
                {
                    Title = TxtTitle.Text,
                    Desc = TxtDesc.Text,
                    Date = TxtTime.Text,
                    ClientId = _client.id
                };
                CrmTavEntities context = new CrmTavEntities();
                context.TblReport.Add(report);
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}