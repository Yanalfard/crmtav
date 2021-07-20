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
using CrmTav_V2.Utilities;

namespace CrmTav_V2.Views
{
    public partial class MoneyForm : DevExpress.XtraEditors.XtraForm
    {
        public MoneyForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Err.ClearErrors();
            if (TxtAmount.Text == string.Empty)
            {
                Err.SetError(TxtAmount, "این فیلد خالی میباشد");
                TxtAmount.Focus();
            }
            else if (TxtDesc.Text == string.Empty)
            {
                Err.SetError(TxtDesc, "این فیلد خالی میباشد");
                TxtDesc.Focus();
            }
            else if (TxtDate.Text == string.Empty)
            {
                Err.SetError(TxtDate, "این فیلد خالی میباشد");
                TxtDate.Focus();
            }
            else
            {
                CrmTavEntities context = new CrmTavEntities();
                TblMoney mon = new TblMoney
                {
                    Amount = GrpType.SelectedIndex == 0 ? long.Parse(TxtAmount.Text) : long.Parse(TxtAmount.Text) * -1,
                    Description = TxtDesc.Text,
                    Date = TxtDate.Text,
                    DatePass = TxtDatePass.Text
                };
                TblMoney money = context.TblMoney.Add(mon);
                context.SaveChanges();
                DialogResult = money != null ? DialogResult.OK : DialogResult.Cancel;
            }
        }

        private void MoneyForm_Load(object sender, EventArgs e)
        {
            TxtDate.Text = DateTime.Now.ToPersian();
        }
    }
}