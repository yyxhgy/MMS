namespace DXApplication4
{
    partial class kc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_yfbh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kc_yf_bh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kc_yf_sl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_editjg = new DevExpress.XtraEditors.SimpleButton();
            this.yf_jg = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfbh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_editjg);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_yfbh);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(811, 400);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(204, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查 询";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_yfbh
            // 
            this.txt_yfbh.Location = new System.Drawing.Point(76, 28);
            this.txt_yfbh.Name = "txt_yfbh";
            this.txt_yfbh.Size = new System.Drawing.Size(111, 20);
            this.txt_yfbh.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "原粉编号";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 317);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.kc_yf_bh,
            this.kc_yf_sl,
            this.yf_jg});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            // 
            // kc_yf_bh
            // 
            this.kc_yf_bh.Caption = "原粉编号";
            this.kc_yf_bh.FieldName = "kc_yf_bh";
            this.kc_yf_bh.Name = "kc_yf_bh";
            this.kc_yf_bh.OptionsColumn.AllowEdit = false;
            this.kc_yf_bh.Visible = true;
            this.kc_yf_bh.VisibleIndex = 0;
            // 
            // kc_yf_sl
            // 
            this.kc_yf_sl.Caption = "原粉数量(Kg)";
            this.kc_yf_sl.FieldName = "kc_yf_sl";
            this.kc_yf_sl.Name = "kc_yf_sl";
            this.kc_yf_sl.OptionsColumn.AllowEdit = false;
            this.kc_yf_sl.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kc_yf_sl", "合计：{0:0.##}Kg")});
            this.kc_yf_sl.Visible = true;
            this.kc_yf_sl.VisibleIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(322, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "原粉最新价格(元/KG)";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(442, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(111, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // btn_editjg
            // 
            this.btn_editjg.Image = ((System.Drawing.Image)(resources.GetObject("btn_editjg.Image")));
            this.btn_editjg.Location = new System.Drawing.Point(559, 27);
            this.btn_editjg.Name = "btn_editjg";
            this.btn_editjg.Size = new System.Drawing.Size(87, 23);
            this.btn_editjg.TabIndex = 3;
            this.btn_editjg.Text = "保存价格";
            this.btn_editjg.Click += new System.EventHandler(this.btn_editjg_Click);
            // 
            // yf_jg
            // 
            this.yf_jg.Caption = "原粉最新价格(元/KG)";
            this.yf_jg.FieldName = "yf_jg";
            this.yf_jg.Name = "yf_jg";
            this.yf_jg.Visible = true;
            this.yf_jg.VisibleIndex = 2;
            // 
            // kc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 400);
            this.Controls.Add(this.splitContainer1);
            this.Name = "kc";
            this.Text = "kc";
            this.Load += new System.EventHandler(this.kc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_yfbh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.TextEdit txt_yfbh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn kc_yf_bh;
        private DevExpress.XtraGrid.Columns.GridColumn kc_yf_sl;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_editjg;
        private DevExpress.XtraGrid.Columns.GridColumn yf_jg;
    }
}