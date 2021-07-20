
namespace CrmTav_V2.Views
{
    partial class MoneyReportForm
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
            this.Tabs = new DevExpress.XtraBars.Navigation.TabPane();
            this.Accounting = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.LblAll = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LblOutgo = new DevExpress.XtraEditors.LabelControl();
            this.LblIncome = new DevExpress.XtraEditors.LabelControl();
            this.Label5 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DtTo = new Atf.UI.DateTimeSelector();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.DtFrom = new Atf.UI.DateTimeSelector();
            this.GrdMoney = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Customers = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LblClientIncome = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSearchClient = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.DtToClient = new Atf.UI.DateTimeSelector();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.DtFromClient = new Atf.UI.DateTimeSelector();
            this.GrdClient = new DevExpress.XtraGrid.GridControl();
            this.GrdClient1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).BeginInit();
            this.Tabs.SuspendLayout();
            this.Accounting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Accounting);
            this.Tabs.Controls.Add(this.Customers);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Accounting,
            this.Customers});
            this.Tabs.RegularSize = new System.Drawing.Size(2338, 1041);
            this.Tabs.SelectedPage = this.Customers;
            this.Tabs.Size = new System.Drawing.Size(2338, 1041);
            this.Tabs.TabIndex = 24;
            // 
            // Accounting
            // 
            this.Accounting.Caption = "حسابرسی";
            this.Accounting.Controls.Add(this.progressPanel1);
            this.Accounting.Controls.Add(this.LblAll);
            this.Accounting.Controls.Add(this.labelControl4);
            this.Accounting.Controls.Add(this.LblOutgo);
            this.Accounting.Controls.Add(this.LblIncome);
            this.Accounting.Controls.Add(this.Label5);
            this.Accounting.Controls.Add(this.label4);
            this.Accounting.Controls.Add(this.BtnSearch);
            this.Accounting.Controls.Add(this.labelControl1);
            this.Accounting.Controls.Add(this.DtTo);
            this.Accounting.Controls.Add(this.labelControl3);
            this.Accounting.Controls.Add(this.DtFrom);
            this.Accounting.Controls.Add(this.GrdMoney);
            this.Accounting.Name = "Accounting";
            this.Accounting.Size = new System.Drawing.Size(2338, 951);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Location = new System.Drawing.Point(1984, 697);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(283, 136);
            this.progressPanel1.TabIndex = 48;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // LblAll
            // 
            this.LblAll.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblAll.Appearance.Options.UseFont = true;
            this.LblAll.Location = new System.Drawing.Point(1965, 480);
            this.LblAll.Margin = new System.Windows.Forms.Padding(4);
            this.LblAll.Name = "LblAll";
            this.LblAll.Size = new System.Drawing.Size(0, 55);
            this.LblAll.TabIndex = 47;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(2268, 478);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 56);
            this.labelControl4.TabIndex = 46;
            this.labelControl4.Text = "کل";
            // 
            // LblOutgo
            // 
            this.LblOutgo.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblOutgo.Appearance.Options.UseFont = true;
            this.LblOutgo.Location = new System.Drawing.Point(1965, 394);
            this.LblOutgo.Margin = new System.Windows.Forms.Padding(4);
            this.LblOutgo.Name = "LblOutgo";
            this.LblOutgo.Size = new System.Drawing.Size(0, 55);
            this.LblOutgo.TabIndex = 45;
            // 
            // LblIncome
            // 
            this.LblIncome.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblIncome.Appearance.Options.UseFont = true;
            this.LblIncome.Location = new System.Drawing.Point(1965, 308);
            this.LblIncome.Margin = new System.Windows.Forms.Padding(4);
            this.LblIncome.Name = "LblIncome";
            this.LblIncome.Size = new System.Drawing.Size(0, 55);
            this.LblIncome.TabIndex = 44;
            // 
            // Label5
            // 
            this.Label5.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.Appearance.Options.UseFont = true;
            this.Label5.Location = new System.Drawing.Point(2214, 392);
            this.Label5.Margin = new System.Windows.Forms.Padding(4);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 56);
            this.Label5.TabIndex = 42;
            this.Label5.Text = "خروجی";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Location = new System.Drawing.Point(2226, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 56);
            this.label4.TabIndex = 43;
            this.label4.Text = "ورودی";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSearch.Appearance.Options.UseFont = true;
            this.BtnSearch.Location = new System.Drawing.Point(1934, 197);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(375, 88);
            this.BtnSearch.TabIndex = 41;
            this.BtnSearch.Text = "جست و جو";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2288, 115);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 56);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "تا";
            // 
            // DtTo
            // 
            this.DtTo.Location = new System.Drawing.Point(1934, 110);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(314, 63);
            this.DtTo.TabIndex = 39;
            this.DtTo.UsePersianFormat = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(2288, 25);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 56);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "از";
            // 
            // DtFrom
            // 
            this.DtFrom.Location = new System.Drawing.Point(1934, 20);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(314, 63);
            this.DtFrom.TabIndex = 37;
            this.DtFrom.UsePersianFormat = true;
            // 
            // GrdMoney
            // 
            this.GrdMoney.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GrdMoney.Location = new System.Drawing.Point(30, 20);
            this.GrdMoney.MainView = this.gridView2;
            this.GrdMoney.Margin = new System.Windows.Forms.Padding(4);
            this.GrdMoney.Name = "GrdMoney";
            this.GrdMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdMoney.Size = new System.Drawing.Size(1897, 913);
            this.GrdMoney.TabIndex = 36;
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
            // Customers
            // 
            this.Customers.Caption = "مشتریان";
            this.Customers.Controls.Add(this.LblClientIncome);
            this.Customers.Controls.Add(this.labelControl9);
            this.Customers.Controls.Add(this.BtnSearchClient);
            this.Customers.Controls.Add(this.labelControl10);
            this.Customers.Controls.Add(this.DtToClient);
            this.Customers.Controls.Add(this.labelControl11);
            this.Customers.Controls.Add(this.DtFromClient);
            this.Customers.Controls.Add(this.GrdClient);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(2338, 951);
            // 
            // LblClientIncome
            // 
            this.LblClientIncome.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblClientIncome.Appearance.Options.UseFont = true;
            this.LblClientIncome.Location = new System.Drawing.Point(1967, 308);
            this.LblClientIncome.Margin = new System.Windows.Forms.Padding(4);
            this.LblClientIncome.Name = "LblClientIncome";
            this.LblClientIncome.Size = new System.Drawing.Size(0, 55);
            this.LblClientIncome.TabIndex = 56;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(2212, 307);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(97, 56);
            this.labelControl9.TabIndex = 55;
            this.labelControl9.Text = "دریافتی";
            // 
            // BtnSearchClient
            // 
            this.BtnSearchClient.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSearchClient.Appearance.Options.UseFont = true;
            this.BtnSearchClient.Location = new System.Drawing.Point(1934, 197);
            this.BtnSearchClient.Name = "BtnSearchClient";
            this.BtnSearchClient.Size = new System.Drawing.Size(375, 88);
            this.BtnSearchClient.TabIndex = 53;
            this.BtnSearchClient.Text = "جست و جو";
            this.BtnSearchClient.Click += new System.EventHandler(this.BtnSearchCustomers_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(2288, 115);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(19, 56);
            this.labelControl10.TabIndex = 52;
            this.labelControl10.Text = "تا";
            // 
            // DtToClient
            // 
            this.DtToClient.Location = new System.Drawing.Point(1934, 110);
            this.DtToClient.Name = "DtToClient";
            this.DtToClient.Size = new System.Drawing.Size(314, 63);
            this.DtToClient.TabIndex = 51;
            this.DtToClient.UsePersianFormat = true;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(2288, 25);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(20, 56);
            this.labelControl11.TabIndex = 50;
            this.labelControl11.Text = "از";
            // 
            // DtFromClient
            // 
            this.DtFromClient.Location = new System.Drawing.Point(1934, 20);
            this.DtFromClient.Name = "DtFromClient";
            this.DtFromClient.Size = new System.Drawing.Size(314, 63);
            this.DtFromClient.TabIndex = 49;
            this.DtFromClient.UsePersianFormat = true;
            // 
            // GrdClient
            // 
            this.GrdClient.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GrdClient.Location = new System.Drawing.Point(30, 20);
            this.GrdClient.MainView = this.GrdClient1;
            this.GrdClient.Margin = new System.Windows.Forms.Padding(4);
            this.GrdClient.Name = "GrdClient";
            this.GrdClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdClient.Size = new System.Drawing.Size(1897, 913);
            this.GrdClient.TabIndex = 48;
            this.GrdClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdClient1});
            // 
            // GrdClient1
            // 
            this.GrdClient1.ColumnPanelRowHeight = 0;
            this.GrdClient1.FooterPanelHeight = 0;
            this.GrdClient1.GridControl = this.GrdClient;
            this.GrdClient1.GroupRowHeight = 0;
            this.GrdClient1.LevelIndent = 0;
            this.GrdClient1.Name = "GrdClient1";
            this.GrdClient1.PreviewIndent = 0;
            this.GrdClient1.RowHeight = 0;
            this.GrdClient1.ViewCaptionHeight = 0;
            // 
            // MoneyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2363, 1065);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoneyReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MoneyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.Accounting.ResumeLayout(false);
            this.Accounting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClient1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane Tabs;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Accounting;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Customers;
        private DevExpress.XtraEditors.LabelControl LblAll;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LblOutgo;
        private DevExpress.XtraEditors.LabelControl LblIncome;
        private DevExpress.XtraEditors.LabelControl Label5;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Atf.UI.DateTimeSelector DtTo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Atf.UI.DateTimeSelector DtFrom;
        private DevExpress.XtraGrid.GridControl GrdMoney;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton BtnSearchClient;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Atf.UI.DateTimeSelector DtToClient;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Atf.UI.DateTimeSelector DtFromClient;
        private DevExpress.XtraGrid.GridControl GrdClient;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdClient1;
        private DevExpress.XtraEditors.LabelControl LblClientIncome;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}