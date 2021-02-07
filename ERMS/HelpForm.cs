using FP_Group_27.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS
{
    public partial class Helpform : Form
    {
        public Helpform()
        {
            InitializeComponent();
            ResourceManager rm = Resources.ResourceManager;
            for (int i = 0; i < 5; i++)
            {
                images.Add((Image)rm.GetObject("h" + i));
            }
        }

        List<Image> images = new List<Image>();

        int count = 0;
        private void Helpform_Load(object sender, EventArgs e)
        {
            pctBox.Image = images[0];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (count == images.Count - 1)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = true;

            }

            else
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
                count++;
            }


            lblind.Text = (count).ToString();
            pctBox.Image = images[count];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
            }

            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                count--;

            }


            lblind.Text = (count).ToString();
            pctBox.Image = images[count];
        }
    }
}
