using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.ResOp
{
    public partial class ResMainForm : Form
    {
        public ResMainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new ItemManForm());
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResMainForm));
            this.btnDepotOp = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.btnDepot = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.timerCirclePanel = new System.Windows.Forms.Timer(this.components);
            this.tBar = new FP_Group_27.ERMS.UI_Components.TopBar();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.circlePanel = new FP_Group_27.ERMS.UI_Components.CirclePanel();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.circlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepotOp
            // 
            this.btnDepotOp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDepotOp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnDepotOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(78)))), ((int)(((byte)(76)))));
            this.btnDepotOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.btnDepotOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepotOp.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnDepotOp.ImageIndex = 2;
            this.btnDepotOp.ImageList = this.images;
            this.btnDepotOp.Location = new System.Drawing.Point(453, 10);
            this.btnDepotOp.Name = "btnDepotOp";
            this.btnDepotOp.Size = new System.Drawing.Size(110, 110);
            this.btnDepotOp.TabIndex = 5;
            this.btnDepotOp.Text = "Depot Operations";
            this.btnDepotOp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainToolTip.SetToolTip(this.btnDepotOp, "Form for viewing, updating, inserting and deleting stocks and logs.");
            this.btnDepotOp.UseVisualStyleBackColor = true;
            this.btnDepotOp.Click += new System.EventHandler(this.btnDepotOp_Click);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "itemW.png");
            this.images.Images.SetKeyName(1, "depotW.png");
            this.images.Images.SetKeyName(2, "depotOpW.png");
            this.images.Images.SetKeyName(3, "logoutW.png");
            // 
            // btnDepot
            // 
            this.btnDepot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDepot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnDepot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(78)))), ((int)(((byte)(76)))));
            this.btnDepot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.btnDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepot.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnDepot.ImageIndex = 1;
            this.btnDepot.ImageList = this.images;
            this.btnDepot.Location = new System.Drawing.Point(337, 10);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(110, 110);
            this.btnDepot.TabIndex = 4;
            this.btnDepot.Text = "Manage Depots";
            this.btnDepot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainToolTip.SetToolTip(this.btnDepot, "Form for viewing, updating, inserting and deleting depots.");
            this.btnDepot.UseVisualStyleBackColor = true;
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // btnItem
            // 
            this.btnItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(78)))), ((int)(((byte)(76)))));
            this.btnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnItem.ImageIndex = 0;
            this.btnItem.ImageList = this.images;
            this.btnItem.Location = new System.Drawing.Point(221, 10);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(110, 110);
            this.btnItem.TabIndex = 3;
            this.btnItem.Text = "Manage Items";
            this.btnItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainToolTip.SetToolTip(this.btnItem, "Form for viewing, updating, inserting and deleting items.");
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // timerCirclePanel
            // 
            this.timerCirclePanel.Enabled = true;
            this.timerCirclePanel.Interval = 50;
            this.timerCirclePanel.Tick += new System.EventHandler(this.timerCirclePanel_Tick);
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
            this.tBar.TabIndex = 2;
            this.tBar.TextColor = System.Drawing.Color.White;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(78)))), ((int)(((byte)(76)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnLogOut.ImageIndex = 3;
            this.btnLogOut.ImageList = this.images;
            this.btnLogOut.Location = new System.Drawing.Point(569, 10);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(110, 110);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainToolTip.SetToolTip(this.btnLogOut, "Log out of your account.");
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDepotOp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogOut, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDepot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnItem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 370);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(218, 0, 218, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 130);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // circlePanel
            // 
            this.circlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.circlePanel.CircleColor = System.Drawing.Color.LightGreen;
            this.circlePanel.Controls.Add(this.lblMan);
            this.circlePanel.Controls.Add(this.lblRes);
            this.circlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circlePanel.Location = new System.Drawing.Point(0, 30);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.RandomCircleColor = false;
            this.circlePanel.Size = new System.Drawing.Size(900, 340);
            this.circlePanel.TabIndex = 8;
            // 
            // lblMan
            // 
            this.lblMan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMan.AutoSize = true;
            this.lblMan.BackColor = System.Drawing.Color.Transparent;
            this.lblMan.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMan.Location = new System.Drawing.Point(16, 136);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(319, 56);
            this.lblMan.TabIndex = 5;
            this.lblMan.Text = "Management";
            // 
            // lblRes
            // 
            this.lblRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRes.ForeColor = System.Drawing.Color.White;
            this.lblRes.Location = new System.Drawing.Point(3, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(554, 136);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Resource";
            // 
            // ResMainForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.circlePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.circlePanel.ResumeLayout(false);
            this.circlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void timerCirclePanel_Tick(object sender, EventArgs e)
        {
            circlePanel.Invalidate();
        }

        private void btnItem_Click_1(object sender, EventArgs e)
        {
            Program.newForm(new ItemManForm());
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Program.newForm(new DepotManForm());
        }

        private void btnDepotOp_Click(object sender, EventArgs e)
        {
            Program.newForm(new DepotOpForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.newForm(new LoginForm());
        }
    }
}
