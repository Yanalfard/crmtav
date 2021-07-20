
namespace CrmTav_V2.Views
{
    partial class FractionsDialog
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
            this.DtDate = new Atf.UI.DateTimeSelector();
            this.TxtAmount = new DevExpress.XtraEditors.TextEdit();
            this.TxtTo = new DevExpress.XtraEditors.TextEdit();
            this.TxtBank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // DtDate
            // 
            this.DtDate.Location = new System.Drawing.Point(12, 371);
            this.DtDate.Name = "DtDate";
            this.DtDate.Size = new System.Drawing.Size(642, 63);
            this.DtDate.TabIndex = 30;
            this.DtDate.UsePersianFormat = true;
            // 
            // TxtAmount
            // 
            this.TxtAmount.EditValue = "";
            this.TxtAmount.Location = new System.Drawing.Point(13, 283);
            this.TxtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtAmount.Properties.Mask.EditMask = "d";
            this.TxtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAmount.Size = new System.Drawing.Size(642, 72);
            this.TxtAmount.TabIndex = 29;
            // 
            // TxtTo
            // 
            this.TxtTo.EditValue = "";
            this.TxtTo.Location = new System.Drawing.Point(13, 193);
            this.TxtTo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTo.Size = new System.Drawing.Size(642, 72);
            this.TxtTo.TabIndex = 28;
            // 
            // TxtBank
            // 
            this.TxtBank.EditValue = "";
            this.TxtBank.Location = new System.Drawing.Point(13, 103);
            this.TxtBank.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBank.Name = "TxtBank";
            this.TxtBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBank.Size = new System.Drawing.Size(642, 72);
            this.TxtBank.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(774, 21);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 56);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "شماره چک";
            // 
            // TxtNo
            // 
            this.TxtNo.EditValue = "";
            this.TxtNo.Location = new System.Drawing.Point(13, 13);
            this.TxtNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtNo.Size = new System.Drawing.Size(642, 72);
            this.TxtNo.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(848, 379);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 56);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "تاریخ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(845, 289);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 56);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "مقدار";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(819, 200);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 56);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "از طرف";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(854, 109);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 56);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "بانک";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(12, 471);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(298, 73);
            this.BtnSubmit.TabIndex = 36;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(613, 471);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(298, 73);
            this.BtnDelete.TabIndex = 37;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // FractionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 556);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.DtDate);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.TxtBank);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtNo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FractionsDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FractionsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Atf.UI.DateTimeSelector DtDate;
        private DevExpress.XtraEditors.TextEdit TxtAmount;
        private DevExpress.XtraEditors.TextEdit TxtTo;
        private DevExpress.XtraEditors.TextEdit TxtBank;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
    }
}