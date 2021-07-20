using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmTav_V2.Models;
using CrmTav_V2.Utilities;

namespace CrmTav_V2.Views
{
    public partial class SignForm : DevExpress.XtraEditors.XtraForm
    {
        public SignForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            CrmTavEntities core = new CrmTavEntities();
            try
            {
                Err.ClearErrors();
                if (TxtUsername.Text == "")
                    Err.SetError(TxtUsername, "نام کابری خالی میباشد");
                else if (TxtPassword.Text == "")
                    Err.SetError(TxtPassword, "رمز عبور خالی میباشد");
                else
                {
                    TblAgent agent = core.TblAgent.First(i => i.Username == TxtUsername.Text);
                    if (agent != null)
                        if (agent.Password == TxtPassword.Text)
                        {
                            Main form = new Main(agent);
                            form.Show();
                            Hide();
                        }
                        else
                            Err.SetError(TxtPassword, "رمز عبور اشتباه میباشد");
                    else
                        Err.SetError(TxtUsername, "نام کابری اشتباه میباشد");
                }
            }
            catch
            {
                Err.SetError(TxtUsername, "خطا در سرور");
            }
        }

        private void SignForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                if (!MethodRepo.CheckForInternetConnection())
                {
                    XtraMessageBox.Show("لطفا سیستم خود را به اینترنت متصل کرده و دوباره امتحان کنید", "اخطار");
                    Application.Exit();
                }
            }
            catch (WebException)
            {
                XtraMessageBox.Show("لطفا سیستم خود را به اینترنت متصل کرده و دوباره امتحان کنید", "اخطار");
                Application.Exit();
            }
        }
    }
}