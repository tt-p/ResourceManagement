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
    public partial class DepotManForm : Form
    {

        private DepotManager man;

        private int _depotId = 0;

        public DepotManForm()
        {
            InitializeComponent();
            man = new DepotManager();
            sizeS.Checked = true;
        }

        private void DepotManForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            dgvDepot.DataSource = man.GetAll();
            dgvDepot.Columns[0].Visible = false;
            dgvDepot.Columns[1].Width = 140;
            dgvDepot.Columns[2].Width = 60;
            dgvDepot.Columns[3].Width = 70;
            dgvDepot.Columns[4].Width = 236;
        }

        private void clearControls()
        {
            _depotId = 0;
            txtName.Text = "";
            sizeS.Checked = true;
            tBarOc.Value = 0;
            lblOcVal.Text = "%0";
            txtAddress.Text = "";
            btnInsert.Text = "Insert";
            btnDel.Enabled = false;
        }

        private void tBarOc_Scroll(object sender, EventArgs e)
        {
            lblOcVal.Text = "%" + tBarOc.Value.ToString();
        }

        private void dgvDepot_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDepot.CurrentRow.Index != -1)
            {
                _depotId = Convert.ToInt32(dgvDepot.CurrentRow.Cells[0].Value.ToString());
                txtName.Text = dgvDepot.CurrentRow.Cells[1].Value.ToString();
                string temp = dgvDepot.CurrentRow.Cells[2].Value.ToString();

                switch(temp)
                {
                    case "SMALL":
                        sizeS.Checked = true;
                        break;
                    case "MEDIUM":
                        sizeM.Checked = true;
                        break;
                    case "LARGE":
                        sizeL.Checked = true;
                        break;
                }

                lblOcVal.Text = "%" + dgvDepot.CurrentRow.Cells[3].Value.ToString();
                tBarOc.Value = Convert.ToInt32(dgvDepot.CurrentRow.Cells[3].Value.ToString());
                txtAddress.Text = dgvDepot.CurrentRow.Cells[4].Value.ToString();

                btnInsert.Text = "Update";
                btnDel.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string size;

                if (sizeS.Checked)
                {
                    size = "SMALL";
                }
                else if (sizeM.Checked)
                {
                    size = "MEDIUM";
                }
                else
                {
                    size = "Large";
                }

                man.Insert(_depotId, txtName.Text, size, tBarOc.Value, txtAddress.Text.Trim());
                fillGrid();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            man.Delete(_depotId);
            clearControls();
            fillGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = man.Search(txtSearch.Text.Trim());
            dgvDepot.DataSource = dt;
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

        private void ResourceManagementMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new ResMainForm());
        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new ItemManForm());
        }

        private void depotOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.newForm(new DepotOpForm());
        }
    }
}
