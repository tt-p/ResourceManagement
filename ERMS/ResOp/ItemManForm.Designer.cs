namespace FP_Group_27.ERMS.ResOp
{
    partial class ItemManForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManForm));
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResourceManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotManageementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupItem = new System.Windows.Forms.GroupBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pFill = new System.Windows.Forms.Panel();
            this.groupAtt = new System.Windows.Forms.GroupBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblAtt = new System.Windows.Forms.Label();
            this.dgvAtt = new System.Windows.Forms.DataGridView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnAttCancel = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnAttDel = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnAttInsert = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnSearch = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnAddFile = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnItemCancel = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnItemDel = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnItemInsert = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.topBar1 = new FP_Group_27.ERMS.UI_Components.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.topPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.pLeft.SuspendLayout();
            this.pFill.SuspendLayout();
            this.groupAtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuStrip);
            this.topPanel.Controls.Add(this.topBar1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(900, 57);
            this.topPanel.TabIndex = 12;
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
            this.menuStrip.TabIndex = 32;
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
            this.itemManagementToolStripMenuItem.Checked = true;
            this.itemManagementToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemManagementToolStripMenuItem.Enabled = false;
            this.itemManagementToolStripMenuItem.Name = "itemManagementToolStripMenuItem";
            this.itemManagementToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.itemManagementToolStripMenuItem.Text = "Manage Items";
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
            this.depotOperationsToolStripMenuItem.Name = "depotOperationsToolStripMenuItem";
            this.depotOperationsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.depotOperationsToolStripMenuItem.Text = "Depot Operations";
            this.depotOperationsToolStripMenuItem.Click += new System.EventHandler(this.depotOperationsToolStripMenuItem_Click);
            // 
            // groupItem
            // 
            this.groupItem.Controls.Add(this.btnAddFile);
            this.groupItem.Controls.Add(this.btnItemCancel);
            this.groupItem.Controls.Add(this.btnItemDel);
            this.groupItem.Controls.Add(this.btnItemInsert);
            this.groupItem.Controls.Add(this.cmbCatagory);
            this.groupItem.Controls.Add(this.txtName);
            this.groupItem.Controls.Add(this.lblCatagory);
            this.groupItem.Controls.Add(this.lblName);
            this.groupItem.Location = new System.Drawing.Point(12, 288);
            this.groupItem.Name = "groupItem";
            this.groupItem.Size = new System.Drawing.Size(380, 143);
            this.groupItem.TabIndex = 30;
            this.groupItem.TabStop = false;
            this.groupItem.Text = "Item";
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.Items.AddRange(new object[] {
            "UNSPECIFIED",
            "RAW_MATERIAL",
            "METAL",
            "WOOD",
            "PLASTIC",
            "TOOL",
            "SPARE",
            "EQUIPMENT",
            "MACHINE",
            "ELECTRONIC"});
            this.cmbCatagory.Location = new System.Drawing.Point(149, 54);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(197, 21);
            this.cmbCatagory.TabIndex = 25;
            this.cmbCatagory.Tag = "Catagory";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(149, 28);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 22;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblCatagory
            // 
            this.lblCatagory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(94, 62);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(49, 13);
            this.lblCatagory.TabIndex = 24;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(108, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 9);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 20);
            this.txtSearch.TabIndex = 32;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(12, 38);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.ShowEditingIcon = false;
            this.dgvItem.Size = new System.Drawing.Size(380, 244);
            this.dgvItem.TabIndex = 31;
            this.dgvItem.DoubleClick += new System.EventHandler(this.dgvItem_DoubleClick);
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.btnSearch);
            this.pLeft.Controls.Add(this.txtSearch);
            this.pLeft.Controls.Add(this.dgvItem);
            this.pLeft.Controls.Add(this.groupItem);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 57);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(450, 443);
            this.pLeft.TabIndex = 34;
            // 
            // pFill
            // 
            this.pFill.Controls.Add(this.groupAtt);
            this.pFill.Controls.Add(this.dgvAtt);
            this.pFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFill.Location = new System.Drawing.Point(450, 57);
            this.pFill.Name = "pFill";
            this.pFill.Size = new System.Drawing.Size(450, 443);
            this.pFill.TabIndex = 35;
            // 
            // groupAtt
            // 
            this.groupAtt.Controls.Add(this.txtVal);
            this.groupAtt.Controls.Add(this.btnAttCancel);
            this.groupAtt.Controls.Add(this.btnAttDel);
            this.groupAtt.Controls.Add(this.btnAttInsert);
            this.groupAtt.Controls.Add(this.txtAtt);
            this.groupAtt.Controls.Add(this.lblVal);
            this.groupAtt.Controls.Add(this.lblAtt);
            this.groupAtt.Location = new System.Drawing.Point(58, 288);
            this.groupAtt.Name = "groupAtt";
            this.groupAtt.Size = new System.Drawing.Size(380, 143);
            this.groupAtt.TabIndex = 33;
            this.groupAtt.TabStop = false;
            this.groupAtt.Text = "Item Attribute";
            // 
            // txtVal
            // 
            this.txtVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal.Location = new System.Drawing.Point(149, 59);
            this.txtVal.MaxLength = 30;
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(197, 20);
            this.txtVal.TabIndex = 29;
            // 
            // txtAtt
            // 
            this.txtAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtt.Location = new System.Drawing.Point(149, 28);
            this.txtAtt.MaxLength = 30;
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(197, 20);
            this.txtAtt.TabIndex = 22;
            // 
            // lblVal
            // 
            this.lblVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(109, 62);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(34, 13);
            this.lblVal.TabIndex = 24;
            this.lblVal.Text = "Value";
            // 
            // lblAtt
            // 
            this.lblAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtt.AutoSize = true;
            this.lblAtt.Location = new System.Drawing.Point(97, 35);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(46, 13);
            this.lblAtt.TabIndex = 23;
            this.lblAtt.Text = "Attribute";
            // 
            // dgvAtt
            // 
            this.dgvAtt.AllowUserToAddRows = false;
            this.dgvAtt.AllowUserToDeleteRows = false;
            this.dgvAtt.AllowUserToResizeColumns = false;
            this.dgvAtt.AllowUserToResizeRows = false;
            this.dgvAtt.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtt.Location = new System.Drawing.Point(58, 38);
            this.dgvAtt.MultiSelect = false;
            this.dgvAtt.Name = "dgvAtt";
            this.dgvAtt.ReadOnly = true;
            this.dgvAtt.RowHeadersVisible = false;
            this.dgvAtt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAtt.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAtt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtt.ShowEditingIcon = false;
            this.dgvAtt.Size = new System.Drawing.Size(380, 244);
            this.dgvAtt.TabIndex = 32;
            this.dgvAtt.DoubleClick += new System.EventHandler(this.dgvAtt_DoubleClick);
            // 
            // ofd
            // 
            this.ofd.Filter = "CSV Files (*.csv)|*.csv|TXT Files (*.txt)|*.txt";
            // 
            // btnAttCancel
            // 
            this.btnAttCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnAttCancel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnAttCancel.FlatAppearance.BorderSize = 0;
            this.btnAttCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttCancel.Location = new System.Drawing.Point(266, 93);
            this.btnAttCancel.Name = "btnAttCancel";
            this.btnAttCancel.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnAttCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnAttCancel.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnAttCancel.Size = new System.Drawing.Size(80, 26);
            this.btnAttCancel.TabIndex = 28;
            this.btnAttCancel.Text = "Cancel";
            this.btnAttCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnAttCancel.UseVisualStyleBackColor = true;
            this.btnAttCancel.Click += new System.EventHandler(this.btnAttCancel_Click);
            // 
            // btnAttDel
            // 
            this.btnAttDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnAttDel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnAttDel.Enabled = false;
            this.btnAttDel.FlatAppearance.BorderSize = 0;
            this.btnAttDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttDel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttDel.Location = new System.Drawing.Point(180, 93);
            this.btnAttDel.Name = "btnAttDel";
            this.btnAttDel.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnAttDel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnAttDel.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnAttDel.Size = new System.Drawing.Size(80, 26);
            this.btnAttDel.TabIndex = 27;
            this.btnAttDel.Text = "Delete";
            this.btnAttDel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnAttDel.UseVisualStyleBackColor = true;
            this.btnAttDel.Click += new System.EventHandler(this.btnAttDel_Click);
            // 
            // btnAttInsert
            // 
            this.btnAttInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttInsert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnAttInsert.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnAttInsert.Enabled = false;
            this.btnAttInsert.FlatAppearance.BorderSize = 0;
            this.btnAttInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttInsert.Location = new System.Drawing.Point(94, 93);
            this.btnAttInsert.Name = "btnAttInsert";
            this.btnAttInsert.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnAttInsert.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnAttInsert.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnAttInsert.Size = new System.Drawing.Size(80, 26);
            this.btnAttInsert.TabIndex = 26;
            this.btnAttInsert.Text = "Insert";
            this.btnAttInsert.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnAttInsert.UseVisualStyleBackColor = true;
            this.btnAttInsert.Click += new System.EventHandler(this.btnAttInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnSearch.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(312, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFile.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnAddFile.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnAddFile.FlatAppearance.BorderSize = 0;
            this.btnAddFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.Location = new System.Drawing.Point(8, 93);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnAddFile.OnHoverButtonColor = System.Drawing.Color.SlateBlue;
            this.btnAddFile.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnAddFile.Size = new System.Drawing.Size(80, 26);
            this.btnAddFile.TabIndex = 29;
            this.btnAddFile.Text = "Add File...";
            this.btnAddFile.TextColor = System.Drawing.Color.SlateBlue;
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnItemCancel
            // 
            this.btnItemCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnItemCancel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnItemCancel.FlatAppearance.BorderSize = 0;
            this.btnItemCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemCancel.Location = new System.Drawing.Point(266, 93);
            this.btnItemCancel.Name = "btnItemCancel";
            this.btnItemCancel.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnItemCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnItemCancel.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnItemCancel.Size = new System.Drawing.Size(80, 26);
            this.btnItemCancel.TabIndex = 28;
            this.btnItemCancel.Text = "Cancel";
            this.btnItemCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnItemCancel.UseVisualStyleBackColor = true;
            this.btnItemCancel.Click += new System.EventHandler(this.btnItemCancel_Click);
            // 
            // btnItemDel
            // 
            this.btnItemDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnItemDel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnItemDel.Enabled = false;
            this.btnItemDel.FlatAppearance.BorderSize = 0;
            this.btnItemDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDel.Location = new System.Drawing.Point(180, 93);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnItemDel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnItemDel.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnItemDel.Size = new System.Drawing.Size(80, 26);
            this.btnItemDel.TabIndex = 27;
            this.btnItemDel.Text = "Delete";
            this.btnItemDel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnItemDel.UseVisualStyleBackColor = true;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnItemInsert
            // 
            this.btnItemInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemInsert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnItemInsert.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnItemInsert.FlatAppearance.BorderSize = 0;
            this.btnItemInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemInsert.Location = new System.Drawing.Point(94, 93);
            this.btnItemInsert.Name = "btnItemInsert";
            this.btnItemInsert.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnItemInsert.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnItemInsert.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnItemInsert.Size = new System.Drawing.Size(80, 26);
            this.btnItemInsert.TabIndex = 26;
            this.btnItemInsert.Text = "Insert";
            this.btnItemInsert.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnItemInsert.UseVisualStyleBackColor = true;
            this.btnItemInsert.Click += new System.EventHandler(this.btnItemInsert_Click);
            // 
            // topBar1
            // 
            this.topBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.topBar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.form = this;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.MinBtn = true;
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(900, 30);
            this.topBar1.TabIndex = 0;
            this.topBar1.TextColor = System.Drawing.Color.White;
            // 
            // ItemManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pFill);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemManForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Items";
            this.Load += new System.EventHandler(this.ItemManForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupItem.ResumeLayout(false);
            this.groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.pFill.ResumeLayout(false);
            this.groupAtt.ResumeLayout(false);
            this.groupAtt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel topPanel;
        private UI_Components.TopBar topBar1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotManageementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResourceManagementMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pFill;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.TextBox txtSearch;
        private UI_Components.PrimBtn btnSearch;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.GroupBox groupItem;
        private UI_Components.PrimBtn btnItemCancel;
        private UI_Components.PrimBtn btnItemDel;
        private UI_Components.PrimBtn btnItemInsert;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvAtt;
        private System.Windows.Forms.GroupBox groupAtt;
        private System.Windows.Forms.TextBox txtVal;
        private UI_Components.PrimBtn btnAttCancel;
        private UI_Components.PrimBtn btnAttDel;
        private UI_Components.PrimBtn btnAttInsert;
        private System.Windows.Forms.TextBox txtAtt;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblAtt;
        private UI_Components.PrimBtn btnAddFile;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}