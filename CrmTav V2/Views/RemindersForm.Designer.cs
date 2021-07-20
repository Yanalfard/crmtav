
namespace CrmTav_V2.Views
{
    partial class RemindersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindersForm));
            this.GrdReminders = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReminders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdReminders
            // 
            this.GrdReminders.Location = new System.Drawing.Point(16, 20);
            this.GrdReminders.MainView = this.gridView1;
            this.GrdReminders.Name = "GrdReminders";
            this.GrdReminders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdReminders.Size = new System.Drawing.Size(1822, 1012);
            this.GrdReminders.TabIndex = 5;
            this.GrdReminders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GrdReminders.Click += new System.EventHandler(this.GrdReminders_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdReminders;
            this.gridView1.Name = "gridView1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(1844, 20);
            this.BtnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAdd.Size = new System.Drawing.Size(321, 94);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "اضافه کردن";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RemindersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2183, 1050);
            this.Controls.Add(this.GrdReminders);
            this.Controls.Add(this.BtnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemindersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RemindersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdReminders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdReminders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
    }
}