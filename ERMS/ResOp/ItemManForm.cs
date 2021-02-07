using FP_Group_27.ERMS.Data;
using FP_Group_27.ERMS.Model;
using FP_Group_27.IO;
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
    public partial class ItemManForm : Form
    {

        private ItemManager man;

        private int _itemId = 0;

        private bool _attInsert = true;

        public ItemManForm()
        {
            InitializeComponent();
            man = new ItemManager();
            cmbCatagory.SelectedIndex = 0;
        }

        private void ItemManForm_Load(object sender, EventArgs e)
        {
            fillGridItem();
        }

        private void fillGridItem()
        {
            dgvItem.DataSource = man.GetAll();
            dgvItem.Columns[0].Visible = false;
            dgvItem.Columns[1].Width = 220;
            dgvItem.Columns[2].Width = 140;
        }
        
        private void clearItemControls()
        {
            _itemId = 0;
            txtName.Clear();
            cmbCatagory.SelectedIndex = 0;
            btnItemInsert.Text = "Insert";
            btnItemDel.Enabled = false;
            btnAttInsert.Enabled = false;
        }

        private void btnItemInsert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();

                foreach (DataGridViewRow r in dgvAtt.Rows)
                {
                    dict[r.Cells[0].Value.ToString()] = r.Cells[1].Value.ToString();
                }

                man.Insert(_itemId, txtName.Text.Trim(), cmbCatagory.SelectedItem.ToString(), dict);
                fillGridItem();
            }
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            man.Delete(_itemId);
            clearItemControls();
            fillGridItem();
        }

        private void btnItemCancel_Click(object sender, EventArgs e)
        {
            clearItemControls();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = man.Search(txtSearch.Text.Trim());
            dgvItem.Columns[0].Visible = false;
            dgvItem.Columns[1].Width = 220;
            dgvItem.Columns[2].Width = 140;
        }

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItem.CurrentRow.Index != -1)
            {
                _itemId = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value.ToString());
                txtName.Text = dgvItem.CurrentRow.Cells[1].Value.ToString();
                cmbCatagory.SelectedItem = dgvItem.CurrentRow.Cells[2].Value.ToString();
                _itemId = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value.ToString());
                btnItemInsert.Text = "Update";
                btnItemDel.Enabled = true;
                btnAttInsert.Enabled = true;

                fillGridAtt(_itemId);
                clearAttControls();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                error.SetError(txtName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error.SetError(txtName, "");
            }
        }

        private void fillGridAtt(int iid)
        {
            dgvAtt.Rows.Clear();
            dgvAtt.Columns.Clear();

            DataTable dt = man.GetItemAttributes(iid);

            dgvAtt.Columns.Add("Attribute", "Attribute");
            dgvAtt.Columns.Add("Att_Val", "Value");

            foreach (DataRow r in dt.Rows)
            {
                dgvAtt.Rows.Add(r.ItemArray);
            }
            dgvAtt.Columns[0].Width = 186;
            dgvAtt.Columns[1].Width = 186;
        }

        private void dgvAtt_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAtt.CurrentRow.Index != -1)
            {
                txtAtt.Text = dgvAtt.CurrentRow.Cells[0].Value.ToString();
                txtVal.Text = dgvAtt.CurrentRow.Cells[1].Value.ToString();
                _attInsert = false;
                btnAttInsert.Text = "Update";
                btnAttDel.Enabled = true;               
            }
        }

        private void btnAttInsert_Click(object sender, EventArgs e)
        {
            if(_attInsert)
            {
                dgvAtt.Rows.Add(txtAtt.Text.Trim(), txtVal.Text.Trim());
            }
            else
            {
                dgvAtt.CurrentRow.Cells[0].Value = txtAtt.Text;
                dgvAtt.CurrentRow.Cells[1].Value = txtVal.Text;
            }
        }

        private void btnAttCancel_Click(object sender, EventArgs e)
        {
            clearAttControls();
        }

        private void btnAttDel_Click(object sender, EventArgs e)
        {
            dgvAtt.Rows.Remove(dgvAtt.CurrentRow);
            clearAttControls();
        }

        private void clearAttControls()
        {
            txtAtt.Clear();
            txtVal.Clear();
            _attInsert = true;
            btnAttInsert.Text = "Insert";
            btnAttDel.Enabled = false;
        }

        private void depotManageementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new DepotManForm());
        }

        private void ResourceManagementMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new ResMainForm());
        }

        private void depotOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new DepotOpForm());
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var context = ReadItemFactory.CreateContext(ofd.FileName);
                IList<Item> itemList;

                try
                {
                    itemList = context.Read();
                }
                catch
                {
                    MessageBox.Show("Operation Failed, \nThe structure of this file is not suitable for reading.", "Inserting Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    man.InsertAll(itemList);
                }
                catch (Exception)
                {
                    MessageBox.Show("Operation Failed, \nItems in this file has been inserted before.", "Inserting Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fillGridItem();
            }
        }
    }
}
