namespace DXApplication4
{
    partial class zhd_cx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zhd_cx));
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
            this.zhd_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_rq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_kh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_pf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_pf_sl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_zhds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_bzgs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_pf_jg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_pf_jz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_pf_ys = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zhd_zj = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 483);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(477, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "—";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(317, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "制单时间";
            // 
            // txt_timeed
            // 
            this.txt_timeed.EditValue = null;
            this.txt_timeed.Location = new System.Drawing.Point(495, 27);
            this.txt_timeed.Name = "txt_timeed";
            this.txt_timeed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeed.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeed.Size = new System.Drawing.Size(100, 20);
            this.txt_timeed.TabIndex = 4;
            // 
            // txt_timest
            // 
            this.txt_timest.EditValue = null;
            this.txt_timest.Location = new System.Drawing.Point(371, 27);
            this.txt_timest.Name = "txt_timest";
            this.txt_timest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timest.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timest.Size = new System.Drawing.Size(100, 20);
            this.txt_timest.TabIndex = 4;
            // 
            // cb_kh
            // 
            this.cb_kh.FormattingEnabled = true;
            this.cb_kh.Location = new System.Drawing.Point(190, 27);
            this.cb_kh.Name = "cb_kh";
            this.cb_kh.Size = new System.Drawing.Size(121, 22);
            this.cb_kh.TabIndex = 3;
            this.cb_kh.TextUpdate += new System.EventHandler(this.cb_kh_TextUpdate);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(621, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 31);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查 询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(160, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "客户";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "关键字";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(54, 27);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(100, 20);
            this.txt_key.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(847, 359);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.zhd_bh,
            this.zhd_rq,
            this.zhd_kh,
            this.zhd_pf_bh,
            this.zhd_pf_sl,
            this.zhd_zhds,
            this.zhd_bzgs,
            this.zhd_pf_jg,
            this.zhd_pf_jz,
            this.zhd_pf_ys,
            this.zhd_zj});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            // 
            // zhd_bh
            // 
            this.zhd_bh.Caption = "做货单编号";
            this.zhd_bh.FieldName = "zhd_bh";
            this.zhd_bh.Name = "zhd_bh";
            this.zhd_bh.OptionsColumn.AllowEdit = false;
            this.zhd_bh.Visible = true;
            this.zhd_bh.VisibleIndex = 0;
            // 
            // zhd_rq
            // 
            this.zhd_rq.Caption = "做货单日期";
            this.zhd_rq.FieldName = "zhd_rq";
            this.zhd_rq.Name = "zhd_rq";
            this.zhd_rq.OptionsColumn.AllowEdit = false;
            this.zhd_rq.Visible = true;
            this.zhd_rq.VisibleIndex = 1;
            // 
            // zhd_kh
            // 
            this.zhd_kh.Caption = "客户";
            this.zhd_kh.FieldName = "zhd_kh";
            this.zhd_kh.Name = "zhd_kh";
            this.zhd_kh.OptionsColumn.AllowEdit = false;
            this.zhd_kh.Visible = true;
            this.zhd_kh.VisibleIndex = 2;
            // 
            // zhd_pf_bh
            // 
            this.zhd_pf_bh.Caption = "配方编号";
            this.zhd_pf_bh.FieldName = "zhd_pf_bh";
            this.zhd_pf_bh.Name = "zhd_pf_bh";
            this.zhd_pf_bh.OptionsColumn.AllowEdit = false;
            this.zhd_pf_bh.Visible = true;
            this.zhd_pf_bh.VisibleIndex = 3;
            // 
            // zhd_pf_sl
            // 
            this.zhd_pf_sl.Caption = "配方数量(份)";
            this.zhd_pf_sl.FieldName = "zhd_pf_sl";
            this.zhd_pf_sl.Name = "zhd_pf_sl";
            this.zhd_pf_sl.OptionsColumn.AllowEdit = false;
            this.zhd_pf_sl.Visible = true;
            this.zhd_pf_sl.VisibleIndex = 4;
            // 
            // zhd_zhds
            // 
            this.zhd_zhds.Caption = "制货袋数";
            this.zhd_zhds.FieldName = "zhd_zhds";
            this.zhd_zhds.Name = "zhd_zhds";
            this.zhd_zhds.OptionsColumn.AllowEdit = false;
            this.zhd_zhds.Visible = true;
            this.zhd_zhds.VisibleIndex = 5;
            // 
            // zhd_bzgs
            // 
            this.zhd_bzgs.Caption = "包装格式";
            this.zhd_bzgs.FieldName = "zhd_bzgs";
            this.zhd_bzgs.Name = "zhd_bzgs";
            this.zhd_bzgs.OptionsColumn.AllowEdit = false;
            this.zhd_bzgs.Visible = true;
            this.zhd_bzgs.VisibleIndex = 6;
            // 
            // zhd_pf_jg
            // 
            this.zhd_pf_jg.Caption = "配方价格";
            this.zhd_pf_jg.FieldName = "zhd_pf_jg";
            this.zhd_pf_jg.Name = "zhd_pf_jg";
            this.zhd_pf_jg.OptionsColumn.AllowEdit = false;
            this.zhd_pf_jg.Visible = true;
            this.zhd_pf_jg.VisibleIndex = 7;
            // 
            // zhd_pf_jz
            // 
            this.zhd_pf_jz.Caption = "配方胶质";
            this.zhd_pf_jz.FieldName = "zhd_pf_jz";
            this.zhd_pf_jz.Name = "zhd_pf_jz";
            this.zhd_pf_jz.OptionsColumn.AllowEdit = false;
            this.zhd_pf_jz.Visible = true;
            this.zhd_pf_jz.VisibleIndex = 8;
            // 
            // zhd_pf_ys
            // 
            this.zhd_pf_ys.Caption = "配方颜色";
            this.zhd_pf_ys.FieldName = "zhd_pf_ys";
            this.zhd_pf_ys.Name = "zhd_pf_ys";
            this.zhd_pf_ys.OptionsColumn.AllowEdit = false;
            this.zhd_pf_ys.Visible = true;
            this.zhd_pf_ys.VisibleIndex = 9;
            // 
            // zhd_zj
            // 
            this.zhd_zj.Caption = "做货单总价";
            this.zhd_zj.FieldName = "zhd_zj";
            this.zhd_zj.Name = "zhd_zj";
            this.zhd_zj.OptionsColumn.AllowEdit = false;
            this.zhd_zj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "zhd_zj", "总计：{0:0.##}")});
            this.zhd_zj.Visible = true;
            this.zhd_zj.VisibleIndex = 10;
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.SystemColors.Control;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(0, 359);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 20;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(847, 29);
            this.pagerControl1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
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
            this.btn_print.Location = new System.Drawing.Point(737, 22);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(98, 31);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "打 印";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // zhd_cx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "zhd_cx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "zhd_cx";
            this.Load += new System.EventHandler(this.zhd_cx_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
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

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_bh;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_rq;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_kh;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_pf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_pf_sl;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_zhds;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_bzgs;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_pf_jg;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_pf_jz;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_pf_ys;
        private DevExpress.XtraGrid.Columns.GridColumn zhd_zj;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_key;
        private System.Windows.Forms.ComboBox cb_kh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txt_timeed;
        private DevExpress.XtraEditors.DateEdit txt_timest;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private TActionProject.PagerControl pagerControl1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
    }
}