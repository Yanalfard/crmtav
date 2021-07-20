
namespace CrmTav_V2.Views
{
    partial class ReportDIalog
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTitle = new DevExpress.XtraEditors.TextEdit();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTime = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1189, 297);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 56);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "توضیحات";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(13, 183);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtDesc.Properties.Appearance.Options.UseFont = true;
            this.TxtDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDesc.Size = new System.Drawing.Size(1160, 404);
            this.TxtDesc.TabIndex = 3;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(503, 645);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(240, 76);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1221, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 56);
            this.labelControl2.TabIndex = 20;
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
            this.TxtTitle.Size = new System.Drawing.Size(536, 72);
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
            this.labelControl3.Location = new System.Drawing.Point(1155, 89);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(152, 56);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "تاریخ ساخت";
            // 
            // TxtTime
            // 
            this.TxtTime.EditValue = "";
            this.TxtTime.Location = new System.Drawing.Point(13, 97);
            this.TxtTime.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TxtTime.Properties.Mask.EditMask = "00/99/99";
            this.TxtTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTime.Size = new System.Drawing.Size(536, 72);
            this.TxtTime.TabIndex = 2;
            // 
            // ReportDIalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1328, 738);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtTime);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportDIalog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit TxtDesc;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtTitle;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtTime;
    }
}