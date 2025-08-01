using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListView__Employee_Management_System__English__.Properties;

namespace ListView__Employee_Management_System__English__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.Details;
        }
        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.SmallIcon;
        }
        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.LargeIcon;
        }
        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.Tile;
        }
        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.List;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtDepartment.Text) || string.IsNullOrEmpty(txtJob.Text) 
             || string.IsNullOrEmpty(txtSalary.Text) || !mtxtHireDate.MaskFull || !mtxtxPhoneNumber.MaskFull)
                return;
            
            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            if (rbtnMale.Checked)
            {
                item.ImageIndex = 0;
                item.SubItems.Add(rbtnMale.Text.Trim());

                pictureBox1.Image = Resources.Man;
                item.Tag = pictureBox1.Image;
            }
            else
            {
                item.ImageIndex = 1;
                item.SubItems.Add((rbtnFemale.Text.Trim()));

                pictureBox1.Image = Resources.Woman;
                item.Tag = pictureBox1.Image;
            }


            // 
            item.SubItems.Add(txtFullName.Text.Trim());
            item.SubItems.Add(txtDepartment.Text.Trim());
            item.SubItems.Add(txtJob.Text.Trim());
            item.SubItems.Add("$ " + txtSalary.Text.Trim());
            item.SubItems.Add(mtxtHireDate.Text.Trim());
            item.SubItems.Add(mtxtxPhoneNumber.Text.Trim());
            listView1.Items.Add(item);


            // 
            txtID.Clear();
            txtFullName.Clear();
            txtDepartment.Clear();
            txtJob.Clear();
            txtSalary.Clear();
            mtxtHireDate.Clear();
            mtxtxPhoneNumber.Clear();

            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int IndexToDelete = listView1.SelectedIndices.Count > 0 ? 
                listView1.SelectedIndices[0] : listView1.Items.Count - 1;

            listView1.Items.RemoveAt(IndexToDelete);
        }
   
        private void btnClear_Click(object sender, EventArgs e)
        {
            while (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
               return;
            


        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                var img = selectedItem.Tag as Image;

                if (img != null)
                    pictureBox1.Image = img;
            }
           
        }


        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                e.Cancel = true;
                txtID.Focus();
                errorProvider1.SetError(txtID, "ID should have a value!");
            }
            else
            { 
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
