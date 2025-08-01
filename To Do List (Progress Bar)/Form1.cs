using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List__Progress_Bar_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CreateTreeView(TreeNode Node, Boolean isChecked)
        {
          
            progressBar1.Maximum = treeView1.Nodes.Count * 10;

            if (isChecked)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value += 10;
                    lblTasks.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                }
                return;            
            }

            if (!isChecked)
            {
                if (progressBar1.Value != 0)
                {
                    progressBar1.Value -= 10;
                    lblTasks.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                }  
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CreateTreeView(e.Node, e.Node.Checked);
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Check if the input is empty
            if (txtWriteTasks.Text == "")
            {
                MessageBox.Show("Please enter a task.");
                return;
            }

            // Check if the task already exists
            foreach (TreeNode N in treeView1.Nodes)
            {
                if (txtWriteTasks.Text.ToLower() != N.Text.ToLower())
                    continue;

                else
                {
                    MessageBox.Show("This task already exists.");
                    return;
                }

            }

            // Add the task to the TreeView
            treeView1.Nodes.Add(txtWriteTasks.Text);

         
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                MessageBox.Show("There is not any Tasks!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void btnRemoveAllTask_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

    }
}
