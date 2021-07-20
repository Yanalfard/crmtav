
namespace CrmTav_V2.Views
{
    partial class RemindersDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTitle = new DevExpress.XtraEditors.TextEdit();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.DtDate = new Atf.UI.DateTimeSelector();
            this.TxtTime = new DevExpress.XtraEditors.TextEdit();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(13, 212);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(222, 76);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(787, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 56);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "موضوع";
            // 
            // TxtTitle
            // 
            this.TxtTitle.EditValue = "";
            this.TxtTitle.Location = new System.Drawing.Point(13, 13);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTitle.Size = new System.Drawing.Size(726, 72);
            this.TxtTitle.TabIndex = 1;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(812, 107);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 56);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "زمان";
            // 
            // DtDate
            // 
            this.DtDate.Location = new System.Drawing.Point(13, 101);
            this.DtDate.Name = "DtDate";
            this.DtDate.Size = new System.Drawing.Size(486, 63);
            this.DtDate.TabIndex = 2;
            this.DtDate.UsePersianFormat = true;
            // 
            // TxtTime
            // 
            this.TxtTime.EditValue = "";
            this.TxtTime.Location = new System.Drawing.Point(517, 100);
            this.TxtTime.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTime.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTime.Properties.Appearance.Options.UseFont = true;
            this.TxtTime.Properties.Mask.EditMask = "00:00";
            this.TxtTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtTime.Size = new System.Drawing.Size(222, 66);
            this.TxtTime.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(656, 212);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(222, 76);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // RemindersDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 301);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.DtDate);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.labelControl3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemindersDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RemindersDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtTitle;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private Atf.UI.DateTimeSelector DtDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtTime;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
    }
}