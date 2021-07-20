
namespace CrmTav_V2.Views
{
    partial class MoneyForm
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDatePass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAmount = new DevExpress.XtraEditors.TextEdit();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.GrpType = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1227, 786);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 56);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "تاریخ پاس";
            // 
            // TxtDatePass
            // 
            this.TxtDatePass.EditValue = "";
            this.TxtDatePass.Location = new System.Drawing.Point(59, 779);
            this.TxtDatePass.Name = "TxtDatePass";
            this.TxtDatePass.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtDatePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDatePass.Size = new System.Drawing.Size(536, 72);
            this.TxtDatePass.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1202, 697);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(152, 56);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "تاریخ ساخت";
            // 
            // TxtDate
            // 
            this.TxtDate.EditValue = "";
            this.TxtDate.Location = new System.Drawing.Point(59, 690);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDate.Size = new System.Drawing.Size(536, 72);
            this.TxtDate.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1236, 347);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 56);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "توضیحات";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(59, 151);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtDesc.Properties.Appearance.Options.UseFont = true;
            this.TxtDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDesc.Size = new System.Drawing.Size(1160, 486);
            this.TxtDesc.TabIndex = 3;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(523, 876);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(324, 76);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1288, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 56);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "مقدار";
            // 
            // TxtAmount
            // 
            this.TxtAmount.EditValue = "";
            this.TxtAmount.Location = new System.Drawing.Point(683, 18);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtAmount.Properties.Mask.EditMask = "c";
            this.TxtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAmount.Size = new System.Drawing.Size(536, 72);
            this.TxtAmount.TabIndex = 1;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // GrpType
            // 
            this.GrpType.Location = new System.Drawing.Point(59, 15);
            this.GrpType.Name = "GrpType";
            this.GrpType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "واریز"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "برداشت")});
            this.GrpType.Size = new System.Drawing.Size(465, 76);
            this.GrpType.TabIndex = 2;
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1382, 973);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtDatePass);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.GrpType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoneyForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MoneyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtDatePass;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit TxtDesc;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAmount;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private DevExpress.XtraEditors.RadioGroup GrpType;
    }
}