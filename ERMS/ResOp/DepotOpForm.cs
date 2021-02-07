using FP_Group_27.ERMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.ResOp
{
    public partial class DepotOpForm : Form
    {

        private DepotOpManager man;
        private Dictionary<string, int> depotNameId = new Dictionary<string, int>();
        private Dictionary<string, int> itemNameId = new Dictionary<string, int>();

        private int _logId;

        public DepotOpForm()
        {
            InitializeComponent();
            man = new DepotOpManager();
        }

        private void DepotOpForm_Load(object sender, EventArgs e)
        {
            initDicts();
            initCmbBoxes();
            initTvDepots();
            fillGridStock();
        }

        private void initDicts()
        {
            foreach (DataRow row in man.GetAllDepotNames().Rows)
            {
                depotNameId[row[1].ToString()] = Convert.ToInt32(row[0].ToString());
            }
            foreach (DataRow row in man.GetAllItemNames().Rows)
            {
                itemNameId[row[1].ToString()] = Convert.ToInt32(row[0].ToString());
            }
        }

        private void initCmbBoxes()
        {
            cmbDepot.Items.AddRange(depotNameId.Keys.ToArray());
            cmbDepot.SelectedIndex = 0;
            cmbFilterDepot.Items.AddRange(depotNameId.Keys.ToArray());
            cmbFilterDepot.SelectedIndex = 0;

            cmbItem.Items.AddRange(itemNameId.Keys.ToArray());
            cmbItem.SelectedIndex = 0;
            cmbFilterItem.Items.AddRange(itemNameId.Keys.ToArray());
            cmbFilterItem.SelectedIndex = 0;
        }

        private void initTvDepots()
        {
            List<TreeNode> nodes = new List<TreeNode>();

            depotNameId.Keys.ToList().ForEach(delegate (string str)
            {
                nodes.Add(new TreeNode(str));
            });

            tvDepots.Nodes.Add(new TreeNode("Depots", nodes.ToArray()));
        }

        private void fillGridStock()
        {
            DataTable dt;

            if (rAll.Checked)
            {
                dt = man.GetAllStocks();
            }
            else if (rDepot.Checked)
            {
                dt = man.GetStocksByDepotId(depotNameId[cmbFilterDepot.SelectedItem.ToString()]);
            }
            else
            {
                dt = man.GetStocksByItemId(itemNameId[cmbFilterItem.SelectedItem.ToString()]);
            }

            dgvStock.DataSource = dt;
            dgvStock.Columns[0].Width = 180;
            dgvStock.Columns[1].Width = 180;
            dgvStock.Columns[2].Width = 80;
        }

        private void dgvStock_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow.Index != -1)
            {
                cmbDepot.SelectedItem = dgvStock.CurrentRow.Cells[0].Value.ToString();
                cmbItem.SelectedItem = dgvStock.CurrentRow.Cells[1].Value.ToString();
                nudQuantity.Value = Convert.ToInt32(dgvStock.CurrentRow.Cells[2].Value.ToString());
            }
        }

        private void btnStockInsert_Click(object sender, EventArgs e)
        {
            int depotId = depotNameId[cmbDepot.SelectedItem.ToString()];
            int itemId = itemNameId[cmbItem.SelectedItem.ToString()];
            int newQ = Convert.ToInt32(nudQuantity.Value);
            int oldQ = 0;

            foreach (DataRow r in man.GetStocksByDepotId(depotId).Rows)
            {
                if (itemNameId[r[1].ToString()] == itemId)
                    oldQ = Convert.ToInt32(r[2].ToString());
            }

            string type = "Entry";

            if (oldQ - newQ > 0)
                type = "Exit";

            man.InsertOrUpdateStock(depotId, itemId, newQ);
            man.InsertDepotLog(depotId, itemId, type, Math.Abs(oldQ - newQ));

            fillGridStock();
        }

        private void rAll_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void rDepot_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void rItem_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void checkChanged()
        {
            cmbFilterDepot.Enabled = rDepot.Checked;
            cmbFilterItem.Enabled = rItem.Checked;
            fillGridStock();
        }

        private void cmbFilterDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGridStock();
        }

        private void cmbFilterItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGridStock();
        }

        private void fillGridLogs(string depotName)
        {
            if (depotName == "Depots")
            {
                DataTable dt = man.GetAllDepotLogs();
                dgvLog.DataSource = dt;
            }
            else
            {
                DataTable dt = man.GetDepotLogsByDepotId(depotNameId[depotName]);
                dgvLog.DataSource = dt;
            }
            dgvLog.Columns[0].Visible = false;
            dgvLog.Columns[1].Visible = false;
            dgvLog.Columns[2].Visible = false;
            dgvLog.Columns[3].Width = 150;
            dgvLog.Columns[4].Width = 150;
            dgvLog.Columns[5].Width = 55;
            dgvLog.Columns[6].Width = 50;
            dgvLog.Columns[7].Width = 55;
            dgvLog.Columns[8].Width = 122;
        }

        private void dgvLog_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLog.CurrentRow.Index != -1)
            {
                _logId = Convert.ToInt32(dgvLog.CurrentRow.Cells[0].Value.ToString());
                txtDesc.Text = dgvLog.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                man.UpdateDepotLog(_logId, txtDesc.Text);
                fillGridLogs(tvDepots.SelectedNode.Text);
            }
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                e.Cancel = true;
                txtDesc.Focus();
                error.SetError(txtDesc, "Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error.SetError(txtDesc, "");
            }
        }

        private void tvDepots_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fillGridLogs(tvDepots.SelectedNode.Text);
        }

        private void ResourceManagementMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new ResMainForm());
        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new ItemManForm());
        }

        private void depotManageementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new DepotManForm());
        }

    }
}
