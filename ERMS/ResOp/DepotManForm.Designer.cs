namespace FP_Group_27.ERMS.ResOp
{
    partial class DepotManForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotManForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tBar = new FP_Group_27.ERMS.UI_Components.TopBar();
            this.pTop = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResourceManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotManageementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pFill = new System.Windows.Forms.Panel();
            this.btnSearch = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDepot = new System.Windows.Forms.DataGridView();
            this.pLeft = new System.Windows.Forms.Panel();
            this.groupDepot = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOcVal = new System.Windows.Forms.Label();
            this.tBarOc = new System.Windows.Forms.TrackBar();
            this.lblOc = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.sizeL = new System.Windows.Forms.RadioButton();
            this.sizeM = new System.Windows.Forms.RadioButton();
            this.sizeS = new System.Windows.Forms.RadioButton();
            this.btnCancel = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnDel = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.btnInsert = new FP_Group_27.ERMS.UI_Components.PrimBtn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.pTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepot)).BeginInit();
            this.pLeft.SuspendLayout();
            this.groupDepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarOc)).BeginInit();
            this.SuspendLayout();
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
            this.depotManageementToolStripMenuItem.Checked = true;
            this.depotManageementToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.depotManageementToolStripMenuItem.Enabled = false;
            this.depotManageementToolStripMenuItem.Name = "depotManageementToolStripMenuItem";
            this.depotManageementToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.depotManageementToolStripMenuItem.Text = "Manage Depots";
            // 
            // depotOperationsToolStripMenuItem
            // 
            this.depotOperationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.depotOperationsToolStripMenuItem.Name = "depotOperationsToolStripMenuItem";
            this.depotOperationsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.depotOperationsToolStripMenuItem.Text = "Depot Operations";
            this.depotOperationsToolStripMenuItem.Click += new System.EventHandler(this.depotOperationsToolStripMenuItem_Click);
            // 
            // pFill
            // 
            this.pFill.Controls.Add(this.btnSearch);
            this.pFill.Controls.Add(this.txtSearch);
            this.pFill.Controls.Add(this.dgvDepot);
            this.pFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFill.Location = new System.Drawing.Point(0, 54);
            this.pFill.Name = "pFill";
            this.pFill.Size = new System.Drawing.Size(900, 446);
            this.pFill.TabIndex = 13;
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
            this.btnSearch.Location = new System.Drawing.Point(792, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(398, 41);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(388, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // dgvDepot
            // 
            this.dgvDepot.AllowUserToAddRows = false;
            this.dgvDepot.AllowUserToDeleteRows = false;
            this.dgvDepot.AllowUserToResizeColumns = false;
            this.dgvDepot.AllowUserToResizeRows = false;
            this.dgvDepot.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvDepot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepot.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepot.Location = new System.Drawing.Point(398, 70);
            this.dgvDepot.MultiSelect = false;
            this.dgvDepot.Name = "dgvDepot";
            this.dgvDepot.ReadOnly = true;
            this.dgvDepot.RowHeadersVisible = false;
            this.dgvDepot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDepot.RowTemplate.Height = 44;
            this.dgvDepot.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDepot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepot.ShowEditingIcon = false;
            this.dgvDepot.Size = new System.Drawing.Size(474, 364);
            this.dgvDepot.TabIndex = 15;
            this.dgvDepot.DoubleClick += new System.EventHandler(this.dgvDepot_DoubleClick);
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.groupDepot);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 54);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(364, 446);
            this.pLeft.TabIndex = 14;
            // 
            // groupDepot
            // 
            this.groupDepot.Controls.Add(this.txtAddress);
            this.groupDepot.Controls.Add(this.lblAddress);
            this.groupDepot.Controls.Add(this.lblOcVal);
            this.groupDepot.Controls.Add(this.tBarOc);
            this.groupDepot.Controls.Add(this.lblOc);
            this.groupDepot.Controls.Add(this.lblSize);
            this.groupDepot.Controls.Add(this.sizeL);
            this.groupDepot.Controls.Add(this.sizeM);
            this.groupDepot.Controls.Add(this.sizeS);
            this.groupDepot.Controls.Add(this.btnCancel);
            this.groupDepot.Controls.Add(this.btnDel);
            this.groupDepot.Controls.Add(this.btnInsert);
            this.groupDepot.Controls.Add(this.txtName);
            this.groupDepot.Controls.Add(this.lblName);
            this.groupDepot.Location = new System.Drawing.Point(12, 6);
            this.groupDepot.Name = "groupDepot";
            this.groupDepot.Size = new System.Drawing.Size(315, 428);
            this.groupDepot.TabIndex = 31;
            this.groupDepot.TabStop = false;
            this.groupDepot.Text = "Depot";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(87, 219);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(197, 125);
            this.txtAddress.TabIndex = 36;
            this.txtAddress.Text = "";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 222);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Address :";
            // 
            // lblOcVal
            // 
            this.lblOcVal.AutoSize = true;
            this.lblOcVal.Location = new System.Drawing.Point(251, 153);
            this.lblOcVal.Name = "lblOcVal";
            this.lblOcVal.Size = new System.Drawing.Size(21, 13);
            this.lblOcVal.TabIndex = 35;
            this.lblOcVal.Text = "%0";
            // 
            // tBarOc
            // 
            this.tBarOc.LargeChange = 100;
            this.tBarOc.Location = new System.Drawing.Point(87, 153);
            this.tBarOc.Maximum = 100;
            this.tBarOc.Name = "tBarOc";
            this.tBarOc.Size = new System.Drawing.Size(158, 45);
            this.tBarOc.TabIndex = 34;
            this.tBarOc.TickFrequency = 0;
            this.tBarOc.Scroll += new System.EventHandler(this.tBarOc_Scroll);
            // 
            // lblOc
            // 
            this.lblOc.AutoSize = true;
            this.lblOc.Location = new System.Drawing.Point(12, 153);
            this.lblOc.Name = "lblOc";
            this.lblOc.Size = new System.Drawing.Size(68, 13);
            this.lblOc.TabIndex = 33;
            this.lblOc.Text = "Occupancy :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(47, 98);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 32;
            this.lblSize.Text = "Size :";
            // 
            // sizeL
            // 
            this.sizeL.AutoSize = true;
            this.sizeL.Location = new System.Drawing.Point(232, 96);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(52, 17);
            this.sizeL.TabIndex = 31;
            this.sizeL.TabStop = true;
            this.sizeL.Text = "Large";
            this.sizeL.UseVisualStyleBackColor = true;
            // 
            // sizeM
            // 
            this.sizeM.AutoSize = true;
            this.sizeM.Location = new System.Drawing.Point(155, 96);
            this.sizeM.Name = "sizeM";
            this.sizeM.Size = new System.Drawing.Size(62, 17);
            this.sizeM.TabIndex = 30;
            this.sizeM.TabStop = true;
            this.sizeM.Text = "Medium";
            this.sizeM.UseVisualStyleBackColor = true;
            // 
            // sizeS
            // 
            this.sizeS.AutoSize = true;
            this.sizeS.Location = new System.Drawing.Point(87, 96);
            this.sizeS.Name = "sizeS";
            this.sizeS.Size = new System.Drawing.Size(50, 17);
            this.sizeS.TabIndex = 29;
            this.sizeS.TabStop = true;
            this.sizeS.Text = "Small";
            this.sizeS.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnCancel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(203, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Size = new System.Drawing.Size(80, 26);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnDel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(117, 369);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnDel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnDel.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnDel.Size = new System.Drawing.Size(80, 26);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Delete";
            this.btnDel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(60)))));
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnInsert.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(31, 369);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnInsert.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Size = new System.Drawing.Size(80, 26);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(86, 35);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 22;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name :";
            // 
            // DepotManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pFill);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepotManForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Depots";
            this.Load += new System.EventHandler(this.DepotManForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pFill.ResumeLayout(false);
            this.pFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepot)).EndInit();
            this.pLeft.ResumeLayout(false);
            this.groupDepot.ResumeLayout(false);
            this.groupDepot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarOc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI_Components.TopBar tBar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.GroupBox groupDepot;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOcVal;
        private System.Windows.Forms.TrackBar tBarOc;
        private System.Windows.Forms.Label lblOc;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RadioButton sizeL;
        private System.Windows.Forms.RadioButton sizeM;
        private System.Windows.Forms.RadioButton sizeS;
        private UI_Components.PrimBtn btnCancel;
        private UI_Components.PrimBtn btnDel;
        private UI_Components.PrimBtn btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pFill;
        private UI_Components.PrimBtn btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDepot;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResourceManagementMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotManageementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotOperationsToolStripMenuItem;
    }
}