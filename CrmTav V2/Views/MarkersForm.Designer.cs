
namespace CrmTav_V2.Views
{
    partial class MarkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkersForm));
            this.GrdMarketers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMarketers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMarketers
            // 
            this.GrdMarketers.Location = new System.Drawing.Point(12, 12);
            this.GrdMarketers.MainView = this.gridView1;
            this.GrdMarketers.Name = "GrdMarketers";
            this.GrdMarketers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdMarketers.Size = new System.Drawing.Size(1822, 1012);
            this.GrdMarketers.TabIndex = 5;
            this.GrdMarketers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GrdMarketers.Click += new System.EventHandler(this.GrdMarketers_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdMarketers;
            this.gridView1.Name = "gridView1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(1840, 12);
            this.BtnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAdd.Size = new System.Drawing.Size(321, 94);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "اضافه کردن";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // MarkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2173, 1041);
            this.Controls.Add(this.GrdMarketers);
            this.Controls.Add(this.BtnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MarkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMarketers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdMarketers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
    }
}