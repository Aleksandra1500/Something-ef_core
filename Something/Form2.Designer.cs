
namespace Something
{
    partial class Form2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAmId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmIdAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmRodzaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmPodstawowy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmIdAdresNavigation = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pLinqInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "AmId ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(Something.AdrEmail);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAmId,
            this.colAmIdAdres,
            this.colAmEmail,
            this.colAmRodzaj,
            this.colAmPodstawowy,
            this.colAmIdAdresNavigation});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colAmId
            // 
            this.colAmId.FieldName = "AmId";
            this.colAmId.MinWidth = 25;
            this.colAmId.Name = "colAmId";
            this.colAmId.Visible = true;
            this.colAmId.VisibleIndex = 0;
            this.colAmId.Width = 94;
            // 
            // colAmIdAdres
            // 
            this.colAmIdAdres.FieldName = "AmIdAdres";
            this.colAmIdAdres.MinWidth = 25;
            this.colAmIdAdres.Name = "colAmIdAdres";
            this.colAmIdAdres.Visible = true;
            this.colAmIdAdres.VisibleIndex = 1;
            this.colAmIdAdres.Width = 94;
            // 
            // colAmEmail
            // 
            this.colAmEmail.FieldName = "AmEmail";
            this.colAmEmail.MinWidth = 25;
            this.colAmEmail.Name = "colAmEmail";
            this.colAmEmail.Visible = true;
            this.colAmEmail.VisibleIndex = 2;
            this.colAmEmail.Width = 94;
            // 
            // colAmRodzaj
            // 
            this.colAmRodzaj.FieldName = "AmRodzaj";
            this.colAmRodzaj.MinWidth = 25;
            this.colAmRodzaj.Name = "colAmRodzaj";
            this.colAmRodzaj.Visible = true;
            this.colAmRodzaj.VisibleIndex = 3;
            this.colAmRodzaj.Width = 94;
            // 
            // colAmPodstawowy
            // 
            this.colAmPodstawowy.FieldName = "AmPodstawowy";
            this.colAmPodstawowy.MinWidth = 25;
            this.colAmPodstawowy.Name = "colAmPodstawowy";
            this.colAmPodstawowy.Visible = true;
            this.colAmPodstawowy.VisibleIndex = 4;
            this.colAmPodstawowy.Width = 94;
            // 
            // colAmIdAdresNavigation
            // 
            this.colAmIdAdresNavigation.FieldName = "AmIdAdresNavigation";
            this.colAmIdAdresNavigation.MinWidth = 25;
            this.colAmIdAdresNavigation.Name = "colAmIdAdresNavigation";
            this.colAmIdAdresNavigation.Visible = true;
            this.colAmIdAdresNavigation.VisibleIndex = 5;
            this.colAmIdAdresNavigation.Width = 94;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmId;
        private DevExpress.XtraGrid.Columns.GridColumn colAmIdAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colAmEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAmRodzaj;
        private DevExpress.XtraGrid.Columns.GridColumn colAmPodstawowy;
        private DevExpress.XtraGrid.Columns.GridColumn colAmIdAdresNavigation;
    }
}