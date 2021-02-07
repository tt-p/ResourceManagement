namespace FP_Group_27.ERMS.ResOp
{
    partial class DepotOpForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotOpForm));
            this.tabCnt = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.rItem = new System.Windows.Forms.RadioButton();
            this.rDepot = new System.Windows.Forms.RadioButton();
            this.cmbFilterDepot = new System.Windows.Forms.ComboBox();
            this.cmbFilterItem = new System.Windows.Forms.ComboBox();
            this.groupStock = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbDepot = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblDepotName = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.tvDepots = new System.Windows.Forms.TreeView();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.pTop = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResourceManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotManageementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBar = new FP_Group_27.ERMS.UI_Components.TopBar();
            this.btnStockInsert = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.tabCnt.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.groupStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.pTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCnt
            // 
            this.tabCnt.Controls.Add(this.tabStock);
            this.tabCnt.Controls.Add(this.tabLog);
            this.tabCnt.Location = new System.Drawing.Point(12, 60);
            this.tabCnt.Name = "tabCnt";
            this.tabCnt.SelectedIndex = 0;
            this.tabCnt.Size = new System.Drawing.Size(876, 428);
            this.tabCnt.TabIndex = 1;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.groupFilter);
            this.tabStock.Controls.Add(this.groupStock);
            this.tabStock.Controls.Add(this.dgvStock);
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(868, 402);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stocks";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.rAll);
            this.groupFilter.Controls.Add(this.rItem);
            this.groupFilter.Controls.Add(this.rDepot);
            this.groupFilter.Controls.Add(this.cmbFilterDepot);
            this.groupFilter.Controls.Add(this.cmbFilterItem);
            this.groupFilter.Location = new System.Drawing.Point(8, 15);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(363, 158);
            this.groupFilter.TabIndex = 32;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // rAll
            // 
            this.rAll.AutoSize = true;
            this.rAll.Checked = true;
            this.rAll.Location = new System.Drawing.Point(40, 29);
            this.rAll.Name = "rAll";
            this.rAll.Size = new System.Drawing.Size(36, 17);
            this.rAll.TabIndex = 42;
            this.rAll.TabStop = true;
            this.rAll.Text = "All";
            this.rAll.UseVisualStyleBackColor = true;
            this.rAll.CheckedChanged += new System.EventHandler(this.rAll_CheckedChanged);
            // 
            // rItem
            // 
            this.rItem.AutoSize = true;
            this.rItem.Location = new System.Drawing.Point(41, 117);
            this.rItem.Name = "rItem";
            this.rItem.Size = new System.Drawing.Size(45, 17);
            this.rItem.TabIndex = 41;
            this.rItem.Text = "Item";
            this.rItem.UseVisualStyleBackColor = true;
            this.rItem.CheckedChanged += new System.EventHandler(this.rItem_CheckedChanged);
            // 
            // rDepot
            // 
            this.rDepot.AutoSize = true;
            this.rDepot.Location = new System.Drawing.Point(40, 72);
            this.rDepot.Name = "rDepot";
            this.rDepot.Size = new System.Drawing.Size(54, 17);
            this.rDepot.TabIndex = 40;
            this.rDepot.Text = "Depot";
            this.rDepot.UseVisualStyleBackColor = true;
            this.rDepot.CheckedChanged += new System.EventHandler(this.rDepot_CheckedChanged);
            // 
            // cmbFilterDepot
            // 
            this.cmbFilterDepot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDepot.Enabled = false;
            this.cmbFilterDepot.Location = new System.Drawing.Point(101, 71);
            this.cmbFilterDepot.Name = "cmbFilterDepot";
            this.cmbFilterDepot.Size = new System.Drawing.Size(220, 21);
            this.cmbFilterDepot.TabIndex = 39;
            this.cmbFilterDepot.Tag = "";
            this.cmbFilterDepot.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDepot_SelectedIndexChanged);
            // 
            // cmbFilterItem
            // 
            this.cmbFilterItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterItem.Enabled = false;
            this.cmbFilterItem.Location = new System.Drawing.Point(101, 116);
            this.cmbFilterItem.Name = "cmbFilterItem";
            this.cmbFilterItem.Size = new System.Drawing.Size(220, 21);
            this.cmbFilterItem.TabIndex = 38;
            this.cmbFilterItem.Tag = "";
            this.cmbFilterItem.SelectedIndexChanged += new System.EventHandler(this.cmbFilterItem_SelectedIndexChanged);
            // 
            // groupStock
            // 
            this.groupStock.Controls.Add(this.lblQuantity);
            this.groupStock.Controls.Add(this.nudQuantity);
            this.groupStock.Controls.Add(this.btnStockInsert);
            this.groupStock.Controls.Add(this.cmbDepot);
            this.groupStock.Controls.Add(this.cmbItem);
            this.groupStock.Controls.Add(this.lblItemName);
            this.groupStock.Controls.Add(this.lblDepotName);
            this.groupStock.Location = new System.Drawing.Point(6, 183);
            this.groupStock.Name = "groupStock";
            this.groupStock.Size = new System.Drawing.Size(366, 196);
            this.groupStock.TabIndex = 31;
            this.groupStock.TabStop = false;
            this.groupStock.Text = "Stock";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(60, 121);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 31;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(112, 119);
            this.nudQuantity.Maximum = new decimal(new int[] {
            -94967296,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(220, 20);
            this.nudQuantity.TabIndex = 30;
            this.nudQuantity.ThousandsSeparator = true;
            // 
            // cmbDepot
            // 
            this.cmbDepot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepot.Location = new System.Drawing.Point(112, 30);
            this.cmbDepot.Name = "cmbDepot";
            this.cmbDepot.Size = new System.Drawing.Size(220, 21);
            this.cmbDepot.TabIndex = 29;
            this.cmbDepot.Tag = "";
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.Location = new System.Drawing.Point(112, 75);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(220, 21);
            this.cmbItem.TabIndex = 25;
            this.cmbItem.Tag = "";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(48, 78);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 24;
            this.lblItemName.Text = "Item Name";
            // 
            // lblDepotName
            // 
            this.lblDepotName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepotName.AutoSize = true;
            this.lblDepotName.Location = new System.Drawing.Point(39, 33);
            this.lblDepotName.Name = "lblDepotName";
            this.lblDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblDepotName.TabIndex = 23;
            this.lblDepotName.Text = "Depot Name";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(395, 23);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(20);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.ShowEditingIcon = false;
            this.dgvStock.Size = new System.Drawing.Size(450, 356);
            this.dgvStock.TabIndex = 16;
            this.dgvStock.DoubleClick += new System.EventHandler(this.dgvStock_DoubleClick);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.btnUpdate);
            this.tabLog.Controls.Add(this.lblDesc);
            this.tabLog.Controls.Add(this.txtDesc);
            this.tabLog.Controls.Add(this.tvDepots);
            this.tabLog.Controls.Add(this.dgvLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(868, 402);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Logs";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(23, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 24);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 220);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(23, 236);
            this.txtDesc.MaxLength = 256;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(179, 104);
            this.txtDesc.TabIndex = 19;
            this.txtDesc.Text = "";
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // tvDepots
            // 
            this.tvDepots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tvDepots.ItemHeight = 20;
            this.tvDepots.Location = new System.Drawing.Point(23, 20);
            this.tvDepots.Margin = new System.Windows.Forms.Padding(20);
            this.tvDepots.Name = "tvDepots";
            this.tvDepots.Size = new System.Drawing.Size(180, 180);
            this.tvDepots.TabIndex = 18;
            this.tvDepots.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDepots_AfterSelect);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeColumns = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(243, 23);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(20);
            this.dgvLog.MultiSelect = false;
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLog.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLog.RowTemplate.Height = 44;
            this.dgvLog.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.ShowEditingIcon = false;
            this.dgvLog.Size = new System.Drawing.Size(602, 356);
            this.dgvLog.TabIndex = 17;
            this.dgvLog.DoubleClick += new System.EventHandler(this.dgvLog_DoubleClick);
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.menuStrip);
            this.pTop.Controls.Add(this.tBar);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(900, 54);
            this.pTop.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(116)))), ((int)(((byte)(108)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 30);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.TabIndex = 33;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResourceManagementMenuItem,
            this.toolStripSeparator1,
            this.itemManagementToolStripMenuItem,
            this.depotManageementToolStripMenuItem,
            this.depotOperationsToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem.Text = "Menu";
            // 
            // ResourceManagementMenuItem
            // 
            this.ResourceManagementMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.ResourceManagementMenuItem.Name = "ResourceManagementMenuItem";
            this.ResourceManagementMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ResourceManagementMenuItem.Text = "Resource Management";
            this.ResourceManagementMenuItem.Click += new System.EventHandler(this.ResourceManagementMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // itemManagementToolStripMenuItem
            // 
            this.itemManagementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.itemManagementToolStripMenuItem.Name = "itemManagementToolStripMenuItem";
            this.itemManagementToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.itemManagementToolStripMenuItem.Text = "Manage Items";
            this.itemManagementToolStripMenuItem.Click += new System.EventHandler(this.itemManagementToolStripMenuItem_Click);
            // 
            // depotManageementToolStripMenuItem
            // 
            this.depotManageementToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.depotManageementToolStripMenuItem.Name = "depotManageementToolStripMenuItem";
            this.depotManageementToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.depotManageementToolStripMenuItem.Text = "Manage Depots";
            this.depotManageementToolStripMenuItem.Click += new System.EventHandler(this.depotManageementToolStripMenuItem_Click);
            // 
            // depotOperationsToolStripMenuItem
            // 
            this.depotOperationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.depotOperationsToolStripMenuItem.Checked = true;
            this.depotOperationsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.depotOperationsToolStripMenuItem.Enabled = false;
            this.depotOperationsToolStripMenuItem.Name = "depotOperationsToolStripMenuItem";
            this.depotOperationsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.depotOperationsToolStripMenuItem.Text = "Depot Operations";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // tBar
            // 
            this.tBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tBar.Color = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBar.form = this;
            this.tBar.Location = new System.Drawing.Point(0, 0);
            this.tBar.MinBtn = true;
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(900, 30);
            this.tBar.TabIndex = 0;
            this.tBar.TextColor = System.Drawing.Color.White;
            // 
            // btnStockInsert
            // 
            this.btnStockInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockInsert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnStockInsert.ButtonColor = System.Drawing.Color.White;
            this.btnStockInsert.FlatAppearance.BorderSize = 0;
            this.btnStockInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStockInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStockInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockInsert.Location = new System.Drawing.Point(252, 155);
            this.btnStockInsert.Name = "btnStockInsert";
            this.btnStockInsert.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnStockInsert.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnStockInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStockInsert.Size = new System.Drawing.Size(80, 26);
            this.btnStockInsert.TabIndex = 26;
            this.btnStockInsert.Text = "Insert";
            this.btnStockInsert.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnStockInsert.UseVisualStyleBackColor = true;
            this.btnStockInsert.Click += new System.EventHandler(this.btnStockInsert_Click);
            // 
            // DepotOpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.tabCnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepotOpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Depot Operations";
            this.Load += new System.EventHandler(this.DepotOpForm_Load);
            this.tabCnt.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.groupStock.ResumeLayout(false);
            this.groupStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI_Components.TopBar tBar;
        private System.Windows.Forms.TabControl tabCnt;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResourceManagementMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotManageementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotOperationsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.TreeView tvDepots;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupStock;
        private UI_Components.PrimBtn btnStockInsert;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDepotName;
        private System.Windows.Forms.ComboBox cmbDepot;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.RadioButton rItem;
        private System.Windows.Forms.RadioButton rDepot;
        private System.Windows.Forms.ComboBox cmbFilterDepot;
        private System.Windows.Forms.ComboBox cmbFilterItem;
        private System.Windows.Forms.RadioButton rAll;
    }
}