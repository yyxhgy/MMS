namespace DXApplication4
{
    partial class kh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kh));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_field = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kh_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kh_lxr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kh_lxr_sj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kh_lxr_mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kh_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kh_bz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pagerControl1 = new TActionProject.PagerControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_field.Properties)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_edt);
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.txt_field);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.pagerControl1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(725, 337);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.Location = new System.Drawing.Point(575, 19);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(84, 31);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edt
            // 
            this.btn_edt.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.Image")));
            this.btn_edt.Location = new System.Drawing.Point(485, 19);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(84, 31);
            this.btn_edt.TabIndex = 3;
            this.btn_edt.Text = "修改";
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(391, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 31);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "新增";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_field
            // 
            this.txt_field.Location = new System.Drawing.Point(73, 24);
            this.txt_field.Name = "txt_field";
            this.txt_field.Size = new System.Drawing.Size(116, 20);
            this.txt_field.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "关键字：";
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(195, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 31);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "查询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 214);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.kh_name,
            this.kh_lxr,
            this.kh_lxr_sj,
            this.kh_lxr_mail,
            this.kh_address,
            this.kh_bz});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            // 
            // kh_name
            // 
            this.kh_name.Caption = "客户单位名称";
            this.kh_name.FieldName = "kh_name";
            this.kh_name.Name = "kh_name";
            this.kh_name.OptionsColumn.AllowEdit = false;
            this.kh_name.Visible = true;
            this.kh_name.VisibleIndex = 0;
            // 
            // kh_lxr
            // 
            this.kh_lxr.Caption = "客户联系人";
            this.kh_lxr.FieldName = "kh_lxr";
            this.kh_lxr.Name = "kh_lxr";
            this.kh_lxr.OptionsColumn.AllowEdit = false;
            this.kh_lxr.Visible = true;
            this.kh_lxr.VisibleIndex = 1;
            // 
            // kh_lxr_sj
            // 
            this.kh_lxr_sj.Caption = "联系人手机";
            this.kh_lxr_sj.FieldName = "kh_lxr_sj";
            this.kh_lxr_sj.Name = "kh_lxr_sj";
            this.kh_lxr_sj.OptionsColumn.AllowEdit = false;
            this.kh_lxr_sj.Visible = true;
            this.kh_lxr_sj.VisibleIndex = 2;
            // 
            // kh_lxr_mail
            // 
            this.kh_lxr_mail.Caption = "联系人邮箱";
            this.kh_lxr_mail.FieldName = "kh_lxr_mail";
            this.kh_lxr_mail.Name = "kh_lxr_mail";
            this.kh_lxr_mail.OptionsColumn.AllowEdit = false;
            this.kh_lxr_mail.Visible = true;
            this.kh_lxr_mail.VisibleIndex = 3;
            // 
            // kh_address
            // 
            this.kh_address.Caption = "客户单位地址";
            this.kh_address.FieldName = "kh_address";
            this.kh_address.Name = "kh_address";
            this.kh_address.OptionsColumn.AllowEdit = false;
            this.kh_address.Visible = true;
            this.kh_address.VisibleIndex = 4;
            // 
            // kh_bz
            // 
            this.kh_bz.Caption = "备注";
            this.kh_bz.FieldName = "kh_bz";
            this.kh_bz.Name = "kh_bz";
            this.kh_bz.OptionsColumn.AllowEdit = false;
            this.kh_bz.Visible = true;
            this.kh_bz.VisibleIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
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
            this.pagerControl1.Location = new System.Drawing.Point(0, 214);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 20;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(723, 29);
            this.pagerControl1.TabIndex = 2;
            // 
            // kh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 337);
            this.Controls.Add(this.splitContainer1);
            this.Name = "kh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kh";
            this.Load += new System.EventHandler(this.kh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_field.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txt_field;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_edt;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn kh_name;
        private DevExpress.XtraGrid.Columns.GridColumn kh_lxr;
        private DevExpress.XtraGrid.Columns.GridColumn kh_lxr_sj;
        private DevExpress.XtraGrid.Columns.GridColumn kh_lxr_mail;
        private DevExpress.XtraGrid.Columns.GridColumn kh_address;
        private DevExpress.XtraGrid.Columns.GridColumn kh_bz;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private TActionProject.PagerControl pagerControl1;

    }
}