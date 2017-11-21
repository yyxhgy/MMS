namespace DXApplication4
{
    partial class selectpf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectpf));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lab_kh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_key = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_ys = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_jz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_sbbh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_jsrq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_sqrq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pf_jg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lab_kh);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.txt_key);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(547, 422);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // lab_kh
            // 
            this.lab_kh.Location = new System.Drawing.Point(60, 16);
            this.lab_kh.Name = "lab_kh";
            this.lab_kh.Size = new System.Drawing.Size(0, 14);
            this.lab_kh.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(18, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "客户：";
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(187, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 31);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(60, 45);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(121, 20);
            this.txt_key.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "关键字";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(547, 300);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pf_bh,
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
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // pf_bh
            // 
            this.pf_bh.Caption = "配方编号";
            this.pf_bh.FieldName = "pf_bh";
            this.pf_bh.Name = "pf_bh";
            this.pf_bh.OptionsColumn.AllowEdit = false;
            this.pf_bh.Visible = true;
            this.pf_bh.VisibleIndex = 0;
            // 
            // pf_ys
            // 
            this.pf_ys.Caption = "配方颜色";
            this.pf_ys.FieldName = "pf_ys";
            this.pf_ys.Name = "pf_ys";
            this.pf_ys.OptionsColumn.AllowEdit = false;
            this.pf_ys.Visible = true;
            this.pf_ys.VisibleIndex = 1;
            // 
            // pf_jz
            // 
            this.pf_jz.Caption = "配方胶质";
            this.pf_jz.FieldName = "pf_jz";
            this.pf_jz.Name = "pf_jz";
            this.pf_jz.OptionsColumn.AllowEdit = false;
            this.pf_jz.Visible = true;
            this.pf_jz.VisibleIndex = 2;
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
            this.pf_sqrq.VisibleIndex = 5;
            // 
            // pf_jg
            // 
            this.pf_jg.Caption = "配方价格";
            this.pf_jg.FieldName = "pf_jg";
            this.pf_jg.Name = "pf_jg";
            this.pf_jg.OptionsColumn.AllowEdit = false;
            this.pf_jg.Visible = true;
            this.pf_jg.VisibleIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // selectpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 422);
            this.Controls.Add(this.splitContainer1);
            this.Name = "selectpf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "selectpf";
            this.Load += new System.EventHandler(this.selectpf_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.TextEdit txt_key;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn pf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn pf_ys;
        private DevExpress.XtraGrid.Columns.GridColumn pf_jz;
        private DevExpress.XtraGrid.Columns.GridColumn pf_sbbh;
        private DevExpress.XtraGrid.Columns.GridColumn pf_jsrq;
        private DevExpress.XtraGrid.Columns.GridColumn pf_sqrq;
        private DevExpress.XtraGrid.Columns.GridColumn pf_jg;
        private DevExpress.XtraEditors.LabelControl lab_kh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}