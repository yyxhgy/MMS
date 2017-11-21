namespace DXApplication4
{
    partial class rk_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rk_add));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_rev = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_yfsl = new DevExpress.XtraEditors.TextEdit();
            this.txt_yfbh = new DevExpress.XtraEditors.TextEdit();
            this.txt_rkbh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_yf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_yf_sl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rk_rq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.rk_yf_jg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_yfjg = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfsl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfbh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rkbh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfjg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_rev);
            this.splitContainer1.Panel1.Controls.Add(this.btn_del);
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_save);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_yfjg);
            this.splitContainer1.Panel1.Controls.Add(this.txt_yfsl);
            this.splitContainer1.Panel1.Controls.Add(this.txt_yfbh);
            this.splitContainer1.Panel1.Controls.Add(this.txt_rkbh);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(637, 373);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_rev
            // 
            this.btn_rev.Image = ((System.Drawing.Image)(resources.GetObject("btn_rev.Image")));
            this.btn_rev.Location = new System.Drawing.Point(516, 61);
            this.btn_rev.Name = "btn_rev";
            this.btn_rev.Size = new System.Drawing.Size(108, 33);
            this.btn_rev.TabIndex = 4;
            this.btn_rev.Text = "撤销该单";
            this.btn_rev.Click += new System.EventHandler(this.btn_rev_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.Location = new System.Drawing.Point(398, 61);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(85, 33);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "删 除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(516, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 33);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "添加新项";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(398, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 33);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保 存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(269, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "(单位：KG)";
            // 
            // txt_yfsl
            // 
            this.txt_yfsl.Location = new System.Drawing.Point(97, 74);
            this.txt_yfsl.Name = "txt_yfsl";
            this.txt_yfsl.Size = new System.Drawing.Size(166, 20);
            this.txt_yfsl.TabIndex = 2;
            // 
            // txt_yfbh
            // 
            this.txt_yfbh.Location = new System.Drawing.Point(97, 41);
            this.txt_yfbh.Name = "txt_yfbh";
            this.txt_yfbh.Size = new System.Drawing.Size(166, 20);
            this.txt_yfbh.TabIndex = 1;
            // 
            // txt_rkbh
            // 
            this.txt_rkbh.Enabled = false;
            this.txt_rkbh.Location = new System.Drawing.Point(97, 8);
            this.txt_rkbh.Name = "txt_rkbh";
            this.txt_rkbh.Size = new System.Drawing.Size(123, 20);
            this.txt_rkbh.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "原粉数量";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "原粉编号";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
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
            this.gridControl1.Size = new System.Drawing.Size(635, 217);
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            // 
            // rk_bh
            // 
            this.rk_bh.Caption = "入库单编号";
            this.rk_bh.FieldName = "rk_bh";
            this.rk_bh.Name = "rk_bh";
            this.rk_bh.OptionsColumn.AllowEdit = false;
            this.rk_bh.OptionsFilter.AllowFilter = false;
            this.rk_bh.Visible = true;
            this.rk_bh.VisibleIndex = 0;
            // 
            // rk_yf_bh
            // 
            this.rk_yf_bh.Caption = "原粉编号";
            this.rk_yf_bh.FieldName = "rk_yf_bh";
            this.rk_yf_bh.Name = "rk_yf_bh";
            this.rk_yf_bh.OptionsColumn.AllowEdit = false;
            this.rk_yf_bh.OptionsFilter.AllowFilter = false;
            this.rk_yf_bh.Visible = true;
            this.rk_yf_bh.VisibleIndex = 1;
            // 
            // rk_yf_sl
            // 
            this.rk_yf_sl.Caption = "原粉数量(Kg)";
            this.rk_yf_sl.FieldName = "rk_yf_sl";
            this.rk_yf_sl.Name = "rk_yf_sl";
            this.rk_yf_sl.OptionsColumn.AllowEdit = false;
            this.rk_yf_sl.OptionsFilter.AllowFilter = false;
            this.rk_yf_sl.Visible = true;
            this.rk_yf_sl.VisibleIndex = 2;
            // 
            // rk_rq
            // 
            this.rk_rq.Caption = "入库单时间";
            this.rk_rq.FieldName = "rk_rq";
            this.rk_rq.Name = "rk_rq";
            this.rk_rq.OptionsColumn.AllowEdit = false;
            this.rk_rq.OptionsFilter.AllowFilter = false;
            this.rk_rq.Visible = true;
            this.rk_rq.VisibleIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 217);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(635, 22);
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
            // rk_yf_jg
            // 
            this.rk_yf_jg.Caption = "原粉价格(元/KG)";
            this.rk_yf_jg.FieldName = "rk_yf_jg";
            this.rk_yf_jg.Name = "rk_yf_jg";
            this.rk_yf_jg.OptionsColumn.AllowEdit = false;
            this.rk_yf_jg.Visible = true;
            this.rk_yf_jg.VisibleIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "原粉价格";
            // 
            // txt_yfjg
            // 
            this.txt_yfjg.Location = new System.Drawing.Point(97, 100);
            this.txt_yfjg.Name = "txt_yfjg";
            this.txt_yfjg.Size = new System.Drawing.Size(87, 20);
            this.txt_yfjg.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(202, 103);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 14);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "(单位：元/KG)";
            // 
            // rk_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 373);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rk_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "rk_add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.rk_add_FormClosed);
            this.Load += new System.EventHandler(this.rk_add_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfsl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfbh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rkbh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfjg.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_rkbh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_yfsl;
        private DevExpress.XtraEditors.TextEdit txt_yfbh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_rev;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraGrid.Columns.GridColumn rk_bh;
        private DevExpress.XtraGrid.Columns.GridColumn rk_yf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn rk_yf_sl;
        private DevExpress.XtraGrid.Columns.GridColumn rk_rq;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn rk_yf_jg;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_yfjg;
    }
}