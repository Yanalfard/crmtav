
namespace CrmTav_V2.Views
{
    partial class FractionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractionsForm));
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdFractions = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFractions)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(1840, 14);
            this.BtnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAdd.Size = new System.Drawing.Size(321, 94);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "اضافه کردن";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdFractions;
            this.gridView1.Name = "gridView1";
            // 
            // GrdFractions
            // 
            this.GrdFractions.Location = new System.Drawing.Point(12, 14);
            this.GrdFractions.MainView = this.gridView1;
            this.GrdFractions.Name = "GrdFractions";
            this.GrdFractions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdFractions.Size = new System.Drawing.Size(1822, 1012);
            this.GrdFractions.TabIndex = 7;
            this.GrdFractions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GrdFractions.Click += new System.EventHandler(this.GrdFractions_Click);
            // 
            // FractionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2173, 1041);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.GrdFractions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FractionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FractionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFractions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl GrdFractions;
    }
}