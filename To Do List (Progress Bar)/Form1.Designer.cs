namespace To_Do_List__Progress_Bar_
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Go To Gym");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Eat Food");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Drink Water");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Prush Your Teeth");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sleep");
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.txtWriteTasks = new System.Windows.Forms.TextBox();
            this.btnRemoveAllTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(476, 584);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 50);
            this.progressBar1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(504, 89);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Go To Gym";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Eat Food";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Drink Water";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Prush Your Teeth";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Sleep";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(398, 458);
            this.treeView1.TabIndex = 1;
            this.treeView1.TabStop = false;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(583, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Do List";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(24, 523);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(159, 45);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTask.Location = new System.Drawing.Point(243, 523);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(159, 45);
            this.btnDeleteTask.TabIndex = 4;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // txtWriteTasks
            // 
            this.txtWriteTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteTasks.Location = new System.Drawing.Point(24, 409);
            this.txtWriteTasks.Multiline = true;
            this.txtWriteTasks.Name = "txtWriteTasks";
            this.txtWriteTasks.Size = new System.Drawing.Size(378, 72);
            this.txtWriteTasks.TabIndex = 5;
            // 
            // btnRemoveAllTask
            // 
            this.btnRemoveAllTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveAllTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllTask.Location = new System.Drawing.Point(76, 601);
            this.btnRemoveAllTask.Name = "btnRemoveAllTask";
            this.btnRemoveAllTask.Size = new System.Drawing.Size(250, 62);
            this.btnRemoveAllTask.TabIndex = 6;
            this.btnRemoveAllTask.Text = "Remove All Tasks";
            this.btnRemoveAllTask.UseVisualStyleBackColor = false;
            this.btnRemoveAllTask.Click += new System.EventHandler(this.btnRemoveAllTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 268);
            this.label2.TabIndex = 7;
            this.label2.Text = "\r\nDo Somthing\r\n    Usefull\r\n\r\n";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.ForeColor = System.Drawing.Color.Orange;
            this.lblTasks.Location = new System.Drawing.Point(965, 582);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(87, 52);
            this.lblTasks.TabIndex = 8;
            this.lblTasks.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 686);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveAllTask);
            this.Controls.Add(this.txtWriteTasks);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.TextBox txtWriteTasks;
        private System.Windows.Forms.Button btnRemoveAllTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTasks;
    }
}

