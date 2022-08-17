namespace GlodonXML
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tvConstructProject = new System.Windows.Forms.TreeView();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.dgvAttributes = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcProjectList = new System.Windows.Forms.TabControl();
            this.tpSummary = new System.Windows.Forms.TabPage();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.tpNormTitle = new System.Windows.Forms.TabPage();
            this.dgvNormTitle = new System.Windows.Forms.DataGridView();
            this.tpNormItem = new System.Windows.Forms.TabPage();
            this.dgvNormItem = new System.Windows.Forms.DataGridView();
            this.tpMeasureTable = new System.Windows.Forms.TabPage();
            this.dgvMeasureTable = new System.Windows.Forms.DataGridView();
            this.tpResource = new System.Windows.Forms.TabPage();
            this.dgvResource = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).BeginInit();
            this.tcProjectList.SuspendLayout();
            this.tpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.tpNormTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormTitle)).BeginInit();
            this.tpNormItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormItem)).BeginInit();
            this.tpMeasureTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasureTable)).BeginInit();
            this.tpResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 25);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tvConstructProject);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(1516, 562);
            this.scMain.SplitterDistance = 248;
            this.scMain.TabIndex = 3;
            // 
            // tvConstructProject
            // 
            this.tvConstructProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvConstructProject.Location = new System.Drawing.Point(0, 0);
            this.tvConstructProject.Name = "tvConstructProject";
            this.tvConstructProject.Size = new System.Drawing.Size(248, 562);
            this.tvConstructProject.TabIndex = 5;
            this.tvConstructProject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvConstructProject_NodeMouseClick);
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.dgvAttributes);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.tcProjectList);
            this.scRight.Size = new System.Drawing.Size(1264, 562);
            this.scRight.SplitterDistance = 275;
            this.scRight.TabIndex = 0;
            // 
            // dgvAttributes
            // 
            this.dgvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKey,
            this.ColValue});
            this.dgvAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributes.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributes.Name = "dgvAttributes";
            this.dgvAttributes.RowTemplate.Height = 23;
            this.dgvAttributes.Size = new System.Drawing.Size(275, 562);
            this.dgvAttributes.TabIndex = 2;
            // 
            // ColKey
            // 
            this.ColKey.HeaderText = "Key";
            this.ColKey.Name = "ColKey";
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Value";
            this.ColValue.Name = "ColValue";
            // 
            // tcProjectList
            // 
            this.tcProjectList.Controls.Add(this.tpSummary);
            this.tcProjectList.Controls.Add(this.tpNormTitle);
            this.tcProjectList.Controls.Add(this.tpNormItem);
            this.tcProjectList.Controls.Add(this.tpMeasureTable);
            this.tcProjectList.Controls.Add(this.tpResource);
            this.tcProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProjectList.Location = new System.Drawing.Point(0, 0);
            this.tcProjectList.Name = "tcProjectList";
            this.tcProjectList.SelectedIndex = 0;
            this.tcProjectList.Size = new System.Drawing.Size(985, 562);
            this.tcProjectList.TabIndex = 3;
            // 
            // tpSummary
            // 
            this.tpSummary.Controls.Add(this.dgvSummary);
            this.tpSummary.Location = new System.Drawing.Point(4, 22);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tpSummary.Size = new System.Drawing.Size(977, 536);
            this.tpSummary.TabIndex = 0;
            this.tpSummary.Text = "费用表";
            this.tpSummary.UseVisualStyleBackColor = true;
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummary.Location = new System.Drawing.Point(3, 3);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowTemplate.Height = 23;
            this.dgvSummary.Size = new System.Drawing.Size(971, 530);
            this.dgvSummary.TabIndex = 0;
            this.dgvSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tpNormTitle
            // 
            this.tpNormTitle.Controls.Add(this.dgvNormTitle);
            this.tpNormTitle.Location = new System.Drawing.Point(4, 22);
            this.tpNormTitle.Name = "tpNormTitle";
            this.tpNormTitle.Padding = new System.Windows.Forms.Padding(3);
            this.tpNormTitle.Size = new System.Drawing.Size(977, 536);
            this.tpNormTitle.TabIndex = 4;
            this.tpNormTitle.Text = "分部";
            this.tpNormTitle.UseVisualStyleBackColor = true;
            // 
            // dgvNormTitle
            // 
            this.dgvNormTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNormTitle.Location = new System.Drawing.Point(3, 3);
            this.dgvNormTitle.Name = "dgvNormTitle";
            this.dgvNormTitle.RowTemplate.Height = 23;
            this.dgvNormTitle.Size = new System.Drawing.Size(971, 530);
            this.dgvNormTitle.TabIndex = 0;
            this.dgvNormTitle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tpNormItem
            // 
            this.tpNormItem.Controls.Add(this.dgvNormItem);
            this.tpNormItem.Location = new System.Drawing.Point(4, 22);
            this.tpNormItem.Name = "tpNormItem";
            this.tpNormItem.Padding = new System.Windows.Forms.Padding(3);
            this.tpNormItem.Size = new System.Drawing.Size(977, 536);
            this.tpNormItem.TabIndex = 1;
            this.tpNormItem.Text = "分项";
            this.tpNormItem.UseVisualStyleBackColor = true;
            // 
            // dgvNormItem
            // 
            this.dgvNormItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNormItem.Location = new System.Drawing.Point(3, 3);
            this.dgvNormItem.Name = "dgvNormItem";
            this.dgvNormItem.RowTemplate.Height = 23;
            this.dgvNormItem.Size = new System.Drawing.Size(971, 530);
            this.dgvNormItem.TabIndex = 0;
            this.dgvNormItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tpMeasureTable
            // 
            this.tpMeasureTable.Controls.Add(this.dgvMeasureTable);
            this.tpMeasureTable.Location = new System.Drawing.Point(4, 22);
            this.tpMeasureTable.Name = "tpMeasureTable";
            this.tpMeasureTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeasureTable.Size = new System.Drawing.Size(977, 536);
            this.tpMeasureTable.TabIndex = 2;
            this.tpMeasureTable.Text = "措施项目";
            this.tpMeasureTable.UseVisualStyleBackColor = true;
            // 
            // dgvMeasureTable
            // 
            this.dgvMeasureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasureTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasureTable.Location = new System.Drawing.Point(3, 3);
            this.dgvMeasureTable.Name = "dgvMeasureTable";
            this.dgvMeasureTable.RowTemplate.Height = 23;
            this.dgvMeasureTable.Size = new System.Drawing.Size(971, 530);
            this.dgvMeasureTable.TabIndex = 0;
            this.dgvMeasureTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tpResource
            // 
            this.tpResource.Controls.Add(this.dgvResource);
            this.tpResource.Location = new System.Drawing.Point(4, 22);
            this.tpResource.Name = "tpResource";
            this.tpResource.Padding = new System.Windows.Forms.Padding(3);
            this.tpResource.Size = new System.Drawing.Size(977, 536);
            this.tpResource.TabIndex = 3;
            this.tpResource.Text = "工料机";
            this.tpResource.UseVisualStyleBackColor = true;
            // 
            // dgvResource
            // 
            this.dgvResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResource.Location = new System.Drawing.Point(3, 3);
            this.dgvResource.Name = "dgvResource";
            this.dgvResource.RowTemplate.Height = 23;
            this.dgvResource.Size = new System.Drawing.Size(971, 530);
            this.dgvResource.TabIndex = 0;
            this.dgvResource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1516, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 21);
            this.tsmiFile.Text = "文件";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(100, 22);
            this.tsmiOpen.Text = "打开";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 587);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            this.scRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).EndInit();
            this.tcProjectList.ResumeLayout(false);
            this.tpSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.tpNormTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormTitle)).EndInit();
            this.tpNormItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormItem)).EndInit();
            this.tpMeasureTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasureTable)).EndInit();
            this.tpResource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TreeView tvConstructProject;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.DataGridView dgvAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.TabControl tcProjectList;
        private System.Windows.Forms.TabPage tpSummary;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.TabPage tpNormTitle;
        private System.Windows.Forms.DataGridView dgvNormTitle;
        private System.Windows.Forms.TabPage tpNormItem;
        private System.Windows.Forms.DataGridView dgvNormItem;
        private System.Windows.Forms.TabPage tpMeasureTable;
        private System.Windows.Forms.DataGridView dgvMeasureTable;
        private System.Windows.Forms.TabPage tpResource;
        private System.Windows.Forms.DataGridView dgvResource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
    }
}

