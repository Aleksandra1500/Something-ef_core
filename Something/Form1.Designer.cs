
namespace Something
{
    partial class Form1
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrt_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrt_Nazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrt_Rodzaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrt_Procent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTowary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pLinqInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Towary";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 389);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "rt_id ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(Something.Rabat);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrt_id,
            this.colrt_Nazwa,
            this.colrt_Rodzaj,
            this.colrt_Procent,
            this.colTowary});
            this.gridView1.DefaultRelationIndex = 2;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            // 
            // colrt_id
            // 
            this.colrt_id.FieldName = "rt_id";
            this.colrt_id.MinWidth = 25;
            this.colrt_id.Name = "colrt_id";
            this.colrt_id.Visible = true;
            this.colrt_id.VisibleIndex = 0;
            this.colrt_id.Width = 94;
            // 
            // colrt_Nazwa
            // 
            this.colrt_Nazwa.FieldName = "rt_Nazwa";
            this.colrt_Nazwa.MinWidth = 25;
            this.colrt_Nazwa.Name = "colrt_Nazwa";
            this.colrt_Nazwa.Visible = true;
            this.colrt_Nazwa.VisibleIndex = 1;
            this.colrt_Nazwa.Width = 94;
            // 
            // colrt_Rodzaj
            // 
            this.colrt_Rodzaj.FieldName = "rt_Rodzaj";
            this.colrt_Rodzaj.MinWidth = 25;
            this.colrt_Rodzaj.Name = "colrt_Rodzaj";
            this.colrt_Rodzaj.Visible = true;
            this.colrt_Rodzaj.VisibleIndex = 2;
            this.colrt_Rodzaj.Width = 94;
            // 
            // colrt_Procent
            // 
            this.colrt_Procent.FieldName = "rt_Procent";
            this.colrt_Procent.MinWidth = 25;
            this.colrt_Procent.Name = "colrt_Procent";
            this.colrt_Procent.Visible = true;
            this.colrt_Procent.VisibleIndex = 3;
            this.colrt_Procent.Width = 94;
            // 
            // colTowary
            // 
            this.colTowary.FieldName = "Towary";
            this.colTowary.MinWidth = 25;
            this.colTowary.Name = "colTowary";
            this.colTowary.Visible = true;
            this.colTowary.VisibleIndex = 4;
            this.colTowary.Width = 94;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.simpleButton1);
            this.stackPanel1.Controls.Add(this.simpleButton2);
            this.stackPanel1.Controls.Add(this.simpleButton3);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(0, 395);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(800, 55);
            this.stackPanel1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 29);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Towar";
            this.simpleButton1.Click += new System.EventHandler(this.Towar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(128, 13);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(116, 29);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Dokument";
            this.simpleButton2.Click += new System.EventHandler(this.Dokument_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(250, 13);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(116, 29);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Kontrahent";
            this.simpleButton3.Click += new System.EventHandler(this.Kontrahent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colrt_id;
        private DevExpress.XtraGrid.Columns.GridColumn colrt_Nazwa;
        private DevExpress.XtraGrid.Columns.GridColumn colrt_Rodzaj;
        private DevExpress.XtraGrid.Columns.GridColumn colrt_Procent;
        private DevExpress.XtraGrid.Columns.GridColumn colTowary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}

