namespace DXApplication4
{
    partial class rk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rk));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timeED = new DevExpress.XtraEditors.DateEdit();
            this.txt_timeST = new DevExpress.XtraEditors.DateEdit();
            this.txt_rkbh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_yf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_yf_sl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_rq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_yf_jg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeED.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeED.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeST.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rkbh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_del);
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.txt_timeED);
            this.splitContainer1.Panel1.Controls.Add(this.txt_timeST);
            this.splitContainer1.Panel1.Controls.Add(this.txt_rkbh);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(825, 388);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.Location = new System.Drawing.Point(631, 19);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(95, 32);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "删 除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(496, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "入 库";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(193, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查 询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_timeED
            // 
            this.txt_timeED.EditValue = null;
            this.txt_timeED.Location = new System.Drawing.Point(193, 8);
            this.txt_timeED.Name = "txt_timeED";
            this.txt_timeED.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeED.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeED.Size = new System.Drawing.Size(100, 20);
            this.txt_timeED.TabIndex = 2;
            // 
            // txt_timeST
            // 
            this.txt_timeST.EditValue = null;
            this.txt_timeST.Location = new System.Drawing.Point(77, 8);
            this.txt_timeST.Name = "txt_timeST";
            this.txt_timeST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_timeST.Size = new System.Drawing.Size(100, 20);
            this.txt_timeST.TabIndex = 2;
            // 
            // txt_rkbh
            // 
            this.txt_rkbh.Location = new System.Drawing.Point(77, 34);
            this.txt_rkbh.Name = "txt_rkbh";
            this.txt_rkbh.Size = new System.Drawing.Size(100, 20);
            this.txt_rkbh.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(180, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "—";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "入库时间";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "入库单编号";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(823, 292);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.rk_bh,
            this.rk_yf_bh,
            this.rk_yf_sl,
            this.rk_rq,
            this.rk_yf_jg});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // rk_bh
            // 
            this.rk_bh.Caption = "入库单编号";
            this.rk_bh.FieldName = "rk_bh";
            this.rk_bh.Name = "rk_bh";
            this.rk_bh.OptionsColumn.AllowEdit = false;
            this.rk_bh.Visible = true;
            this.rk_bh.VisibleIndex = 0;
            // 
            // rk_yf_bh
            // 
            this.rk_yf_bh.Caption = "原粉编号";
            this.rk_yf_bh.FieldName = "rk_yf_bh";
            this.rk_yf_bh.Name = "rk_yf_bh";
            this.rk_yf_bh.OptionsColumn.AllowEdit = false;
            this.rk_yf_bh.Visible = true;
            this.rk_yf_bh.VisibleIndex = 1;
            // 
            // rk_yf_sl
            // 
            this.rk_yf_sl.Caption = "原粉数量(Kg)";
            this.rk_yf_sl.FieldName = "rk_yf_sl";
            this.rk_yf_sl.Name = "rk_yf_sl";
            this.rk_yf_sl.OptionsColumn.AllowEdit = false;
            this.rk_yf_sl.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "rk_yf_sl", "合计：{0:0.##}Kg")});
            this.rk_yf_sl.Visible = true;
            this.rk_yf_sl.VisibleIndex = 2;
            // 
            // rk_rq
            // 
            this.rk_rq.Caption = "入库日期";
            this.rk_rq.FieldName = "rk_rq";
            this.rk_rq.Name = "rk_rq";
            this.rk_rq.OptionsColumn.AllowEdit = false;
            this.rk_rq.Visible = true;
            this.rk_rq.VisibleIndex = 3;
            // 
            // rk_yf_jg
            // 
            this.rk_yf_jg.Caption = "原粉价格(元/KG)";
            this.rk_yf_jg.FieldName = "rk_yf_jg";
            this.rk_yf_jg.Name = "rk_yf_jg";
            this.rk_yf_jg.OptionsColumn.AllowEdit = false;
            this.rk_yf_jg.Visible = true;
            this.rk_yf_jg.VisibleIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // rk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 388);
            this.Controls.Add(this.splitContainer1);
            this.Name = "rk";
            this.Text = "rk";
            this.Load += new System.EventHandler(this.rk_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeED.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeED.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeST.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timeST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rkbh.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn rk_bh;
        private DevExpress.XtraGrid.Columns.GridColumn rk_yf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn rk_yf_sl;
        private DevExpress.XtraGrid.Columns.GridColumn rk_rq;
        private DevExpress.XtraEditors.DateEdit txt_timeED;
        private DevExpress.XtraEditors.DateEdit txt_timeST;
        private DevExpress.XtraEditors.TextEdit txt_rkbh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn rk_yf_jg;
    }
}