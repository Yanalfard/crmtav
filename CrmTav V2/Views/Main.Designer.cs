
namespace CrmTav_V2.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GrdMain = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdMoney = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.LblAmount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnMoney = new DevExpress.XtraEditors.SimpleButton();
            this.BtnReminders = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMarketers = new DevExpress.XtraEditors.SimpleButton();
            this.PnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.BtnMoneyReport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlButtons)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdMain
            // 
            this.GrdMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GrdMain.Location = new System.Drawing.Point(1779, 80);
            this.GrdMain.MainView = this.gridView1;
            this.GrdMain.Margin = new System.Windows.Forms.Padding(4);
            this.GrdMain.Name = "GrdMain";
            this.GrdMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdMain.Size = new System.Drawing.Size(1646, 1858);
            this.GrdMain.TabIndex = 5;
            this.GrdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GrdMain.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 0;
            this.gridView1.FooterPanelHeight = 0;
            this.gridView1.GridControl = this.GrdMain;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.PreviewIndent = 0;
            this.gridView1.RowHeight = 0;
            this.gridView1.ViewCaptionHeight = 0;
            // 
            // GrdMoney
            // 
            this.GrdMoney.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GrdMoney.Location = new System.Drawing.Point(28, 80);
            this.GrdMoney.MainView = this.gridView2;
            this.GrdMoney.Margin = new System.Windows.Forms.Padding(4);
            this.GrdMoney.Name = "GrdMoney";
            this.GrdMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdMoney.Size = new System.Drawing.Size(1743, 1858);
            this.GrdMoney.TabIndex = 8;
            this.GrdMoney.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.ColumnPanelRowHeight = 0;
            this.gridView2.FooterPanelHeight = 0;
            this.gridView2.GridControl = this.GrdMoney;
            this.gridView2.GroupRowHeight = 0;
            this.gridView2.LevelIndent = 0;
            this.gridView2.Name = "gridView2";
            this.gridView2.PreviewIndent = 0;
            this.gridView2.RowHeight = 0;
            this.gridView2.ViewCaptionHeight = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(7, 7);
            this.BtnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAdd.Size = new System.Drawing.Size(347, 94);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "مشتری جدید";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblAmount
            // 
            this.LblAmount.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblAmount.Appearance.Options.UseFont = true;
            this.LblAmount.Location = new System.Drawing.Point(59, 671);
            this.LblAmount.Margin = new System.Windows.Forms.Padding(4);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(100, 55);
            this.LblAmount.TabIndex = 9;
            this.LblAmount.Text = "Money";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(200, 578);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(154, 56);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "موجودی کل";
            // 
            // BtnMoney
            // 
            this.BtnMoney.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMoney.Appearance.Options.UseFont = true;
            this.BtnMoney.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoney.ImageOptions.Image")));
            this.BtnMoney.Location = new System.Drawing.Point(7, 239);
            this.BtnMoney.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnMoney.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMoney.Name = "BtnMoney";
            this.BtnMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnMoney.Size = new System.Drawing.Size(347, 94);
            this.BtnMoney.TabIndex = 7;
            this.BtnMoney.Text = "واریز برداشت";
            this.BtnMoney.Click += new System.EventHandler(this.BtnMoney_Click);
            // 
            // BtnReminders
            // 
            this.BtnReminders.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnReminders.Appearance.Options.UseFont = true;
            this.BtnReminders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnReminders.ImageOptions.Image")));
            this.BtnReminders.Location = new System.Drawing.Point(7, 122);
            this.BtnReminders.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnReminders.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReminders.Name = "BtnReminders";
            this.BtnReminders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReminders.Size = new System.Drawing.Size(347, 94);
            this.BtnReminders.TabIndex = 11;
            this.BtnReminders.Text = "یادآوری ها";
            this.BtnReminders.Click += new System.EventHandler(this.BtnReminders_Click);
            // 
            // BtnMarketers
            // 
            this.BtnMarketers.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMarketers.Appearance.Options.UseFont = true;
            this.BtnMarketers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMarketers.ImageOptions.Image")));
            this.BtnMarketers.Location = new System.Drawing.Point(7, 353);
            this.BtnMarketers.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnMarketers.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMarketers.Name = "BtnMarketers";
            this.BtnMarketers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnMarketers.Size = new System.Drawing.Size(347, 94);
            this.BtnMarketers.TabIndex = 12;
            this.BtnMarketers.Text = "بازاریاب ها";
            this.BtnMarketers.Click += new System.EventHandler(this.BtnMarketers_Click);
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnMoneyReport);
            this.PnlButtons.Controls.Add(this.BtnAdd);
            this.PnlButtons.Controls.Add(this.BtnMarketers);
            this.PnlButtons.Controls.Add(this.BtnMoney);
            this.PnlButtons.Controls.Add(this.BtnReminders);
            this.PnlButtons.Controls.Add(this.labelControl2);
            this.PnlButtons.Controls.Add(this.LblAmount);
            this.PnlButtons.Location = new System.Drawing.Point(3432, 22);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(361, 1916);
            this.PnlButtons.TabIndex = 13;
            // 
            // BtnMoneyReport
            // 
            this.BtnMoneyReport.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMoneyReport.Appearance.Options.UseFont = true;
            this.BtnMoneyReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoneyReport.ImageOptions.Image")));
            this.BtnMoneyReport.Location = new System.Drawing.Point(7, 469);
            this.BtnMoneyReport.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnMoneyReport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMoneyReport.Name = "BtnMoneyReport";
            this.BtnMoneyReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnMoneyReport.Size = new System.Drawing.Size(347, 94);
            this.BtnMoneyReport.TabIndex = 13;
            this.BtnMoneyReport.Text = "حسابرسی";
            this.BtnMoneyReport.Click += new System.EventHandler(this.BtnMoneyReport_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2590, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 56);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "مشتری ها";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(795, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 56);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "حسابداری";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(3805, 1951);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.GrdMain);
            this.Controls.Add(this.GrdMoney);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlButtons)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.PnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl GrdMoney;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.LabelControl LblAmount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnMoney;
        private DevExpress.XtraEditors.SimpleButton BtnReminders;
        private DevExpress.XtraEditors.SimpleButton BtnMarketers;
        private DevExpress.XtraEditors.PanelControl PnlButtons;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnMoneyReport;
    }
}