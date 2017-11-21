namespace DXApplication4
{
    partial class pfgl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pfgl));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_yf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_yf_sl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_kh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_ys = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_jz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_sbbh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_jsrq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_sqrq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_jg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cb_kh = new System.Windows.Forms.ComboBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_key = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pagerControl1 = new TActionProject.PagerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sid,
            this.pf_yf_bh,
            this.pf_yf_sl});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // sid
            // 
            this.sid.Caption = "id";
            this.sid.FieldName = "id";
            this.sid.Name = "sid";
            this.sid.OptionsColumn.AllowEdit = false;
            // 
            // pf_yf_bh
            // 
            this.pf_yf_bh.Caption = "原粉编号";
            this.pf_yf_bh.FieldName = "pf_yf_bh";
            this.pf_yf_bh.Name = "pf_yf_bh";
            this.pf_yf_bh.OptionsColumn.AllowEdit = false;
            this.pf_yf_bh.Visible = true;
            this.pf_yf_bh.VisibleIndex = 0;
            // 
            // pf_yf_sl
            // 
            this.pf_yf_sl.Caption = "原粉数量(Kg)";
            this.pf_yf_sl.FieldName = "pf_yf_sl";
            this.pf_yf_sl.Name = "pf_yf_sl";
            this.pf_yf_sl.OptionsColumn.AllowEdit = false;
            this.pf_yf_sl.Visible = true;
            this.pf_yf_sl.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(805, 301);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.pf_bh,
            this.pf_kh,
            this.pf_ys,
            this.pf_jz,
            this.pf_sbbh,
            this.pf_jsrq,
            this.pf_sqrq,
            this.pf_jg});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            // 
            // pf_bh
            // 
            this.pf_bh.Caption = "配方编号";
            this.pf_bh.FieldName = "pf_bh";
            this.pf_bh.MinWidth = 10;
            this.pf_bh.Name = "pf_bh";
            this.pf_bh.OptionsColumn.AllowEdit = false;
            this.pf_bh.Visible = true;
            this.pf_bh.VisibleIndex = 0;
            // 
            // pf_kh
            // 
            this.pf_kh.Caption = "客户";
            this.pf_kh.FieldName = "pf_kh";
            this.pf_kh.MinWidth = 10;
            this.pf_kh.Name = "pf_kh";
            this.pf_kh.OptionsColumn.AllowEdit = false;
            this.pf_kh.Visible = true;
            this.pf_kh.VisibleIndex = 1;
            // 
            // pf_ys
            // 
            this.pf_ys.Caption = "配方颜色";
            this.pf_ys.FieldName = "pf_ys";
            this.pf_ys.Name = "pf_ys";
            this.pf_ys.OptionsColumn.AllowEdit = false;
            this.pf_ys.Visible = true;
            this.pf_ys.VisibleIndex = 2;
            // 
            // pf_jz
            // 
            this.pf_jz.Caption = "胶质";
            this.pf_jz.FieldName = "pf_jz";
            this.pf_jz.Name = "pf_jz";
            this.pf_jz.OptionsColumn.AllowEdit = false;
            this.pf_jz.Visible = true;
            this.pf_jz.VisibleIndex = 5;
            // 
            // pf_sbbh
            // 
            this.pf_sbbh.Caption = "什辨编号";
            this.pf_sbbh.FieldName = "pf_sbbh";
            this.pf_sbbh.Name = "pf_sbbh";
            this.pf_sbbh.OptionsColumn.AllowEdit = false;
            this.pf_sbbh.Visible = true;
            this.pf_sbbh.VisibleIndex = 3;
            // 
            // pf_jsrq
            // 
            this.pf_jsrq.Caption = "较色日期";
            this.pf_jsrq.FieldName = "pf_jsrq";
            this.pf_jsrq.Name = "pf_jsrq";
            this.pf_jsrq.OptionsColumn.AllowEdit = false;
            this.pf_jsrq.Visible = true;
            this.pf_jsrq.VisibleIndex = 4;
            // 
            // pf_sqrq
            // 
            this.pf_sqrq.Caption = "首取日期";
            this.pf_sqrq.FieldName = "pf_sqrq";
            this.pf_sqrq.Name = "pf_sqrq";
            this.pf_sqrq.OptionsColumn.AllowEdit = false;
            this.pf_sqrq.Visible = true;
            this.pf_sqrq.VisibleIndex = 6;
            // 
            // pf_jg
            // 
            this.pf_jg.Caption = "价格";
            this.pf_jg.FieldName = "pf_jg";
            this.pf_jg.Name = "pf_jg";
            this.pf_jg.OptionsColumn.AllowEdit = false;
            this.pf_jg.Visible = true;
            this.pf_jg.VisibleIndex = 7;
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
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.cb_kh);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.txt_key);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.pagerControl1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(805, 428);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(689, 18);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(110, 35);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "删除配方";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(573, 18);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(110, 35);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "修改配方";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(457, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 35);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "新增配方";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cb_kh
            // 
            this.cb_kh.FormattingEnabled = true;
            this.cb_kh.Location = new System.Drawing.Point(219, 25);
            this.cb_kh.Name = "cb_kh";
            this.cb_kh.Size = new System.Drawing.Size(121, 22);
            this.cb_kh.TabIndex = 4;
            this.cb_kh.TextUpdate += new System.EventHandler(this.cb_kh_TextUpdate);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(361, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(63, 25);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(100, 20);
            this.txt_key.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(176, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "客户";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "关键字";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.SystemColors.Control;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(0, 301);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 100;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(805, 29);
            this.pagerControl1.TabIndex = 2;
            // 
            // pfgl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 428);
            this.Controls.Add(this.splitContainer1);
            this.Name = "pfgl";
            this.Text = "pfgl";
            this.Load += new System.EventHandler(this.pfgl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_key.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn sid;
        private DevExpress.XtraGrid.Columns.GridColumn pf_yf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn pf_yf_sl;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn pf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn pf_kh;
        private DevExpress.XtraGrid.Columns.GridColumn pf_ys;
        private DevExpress.XtraGrid.Columns.GridColumn pf_jz;
        private DevExpress.XtraGrid.Columns.GridColumn pf_sbbh;
        private DevExpress.XtraGrid.Columns.GridColumn pf_jsrq;
        private DevExpress.XtraGrid.Columns.GridColumn pf_sqrq;
        private DevExpress.XtraGrid.Columns.GridColumn pf_jg;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.TextEdit txt_key;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cb_kh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private TActionProject.PagerControl pagerControl1;

    }
}