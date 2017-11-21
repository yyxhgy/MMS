namespace DXApplication4
{
    partial class shd_cx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shd_cx));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timeed = new DevExpress.XtraEditors.DateEdit();
            this.txt_timest = new DevExpress.XtraEditors.DateEdit();
            this.cb_kh = new System.Windows.Forms.ComboBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_key = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.shd_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shd_kh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shd_rq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pagerControl1 = new TActionProject.PagerControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeed.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timest.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_timeed);
            this.splitContainer1.Panel1.Controls.Add(this.txt_timest);
            this.splitContainer1.Panel1.Controls.Add(this.cb_kh);
            this.splitContainer1.Panel1.Controls.Add(this.btn_print);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_key);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.pagerControl1);
            this.splitContainer1.Size = new System.Drawing.Size(876, 381);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(477, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "—";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(317, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "制单日期";
            // 
            // txt_timeed
            // 
            this.txt_timeed.EditValue = null;
            this.txt_timeed.Location = new System.Drawing.Point(495, 25);
            this.txt_timeed.Name = "txt_timeed";
            this.txt_timeed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeed.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeed.Size = new System.Drawing.Size(100, 20);
            this.txt_timeed.TabIndex = 11;
            // 
            // txt_timest
            // 
            this.txt_timest.EditValue = null;
            this.txt_timest.Location = new System.Drawing.Point(371, 25);
            this.txt_timest.Name = "txt_timest";
            this.txt_timest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timest.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timest.Size = new System.Drawing.Size(100, 20);
            this.txt_timest.TabIndex = 12;
            // 
            // cb_kh
            // 
            this.cb_kh.FormattingEnabled = true;
            this.cb_kh.Location = new System.Drawing.Point(190, 25);
            this.cb_kh.Name = "cb_kh";
            this.cb_kh.Size = new System.Drawing.Size(121, 22);
            this.cb_kh.TabIndex = 10;
            this.cb_kh.TextUpdate += new System.EventHandler(this.cb_kh_TextUpdate);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(621, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 31);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "查 询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(160, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "客户";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "关键字";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(54, 25);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(100, 20);
            this.txt_key.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(876, 282);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.shd_bh,
            this.shd_kh,
            this.shd_rq});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            // 
            // shd_bh
            // 
            this.shd_bh.Caption = "送货单编号";
            this.shd_bh.FieldName = "shd_bh";
            this.shd_bh.Name = "shd_bh";
            this.shd_bh.OptionsColumn.AllowEdit = false;
            this.shd_bh.Visible = true;
            this.shd_bh.VisibleIndex = 0;
            // 
            // shd_kh
            // 
            this.shd_kh.Caption = "客户";
            this.shd_kh.FieldName = "shd_kh";
            this.shd_kh.Name = "shd_kh";
            this.shd_kh.OptionsColumn.AllowEdit = false;
            this.shd_kh.Visible = true;
            this.shd_kh.VisibleIndex = 1;
            // 
            // shd_rq
            // 
            this.shd_rq.Caption = "日期";
            this.shd_rq.FieldName = "shd_rq";
            this.shd_rq.Name = "shd_rq";
            this.shd_rq.OptionsColumn.AllowEdit = false;
            this.shd_rq.Visible = true;
            this.shd_rq.VisibleIndex = 2;
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.SystemColors.Control;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(0, 282);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 20;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(876, 29);
            this.pagerControl1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_print
            // 
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.Location = new System.Drawing.Point(742, 20);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(98, 31);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "打 印";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // shd_cx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 403);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "shd_cx";
            this.Text = "shd_cx";
            this.Load += new System.EventHandler(this.shd_cx_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeed.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timest.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txt_timeed;
        private DevExpress.XtraEditors.DateEdit txt_timest;
        private System.Windows.Forms.ComboBox cb_kh;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_key;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevExpress.XtraGrid.Columns.GridColumn shd_bh;
        private DevExpress.XtraGrid.Columns.GridColumn shd_kh;
        private DevExpress.XtraGrid.Columns.GridColumn shd_rq;
        private TActionProject.PagerControl pagerControl1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
    }
}