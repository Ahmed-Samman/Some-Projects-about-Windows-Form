namespace Pizza_Order_My_Solution_
{
    partial class UserClients
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
            this.txtUserCustomer = new System.Windows.Forms.TextBox();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserCustomer
            // 
            this.txtUserCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserCustomer.Location = new System.Drawing.Point(189, 103);
            this.txtUserCustomer.Name = "txtUserCustomer";
            this.txtUserCustomer.Size = new System.Drawing.Size(415, 39);
            this.txtUserCustomer.TabIndex = 0;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCustomerNumber.Location = new System.Drawing.Point(261, 207);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(343, 39);
            this.txtCustomerNumber.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(363, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDon
            // 
            this.btnDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDon.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDon.Location = new System.Drawing.Point(92, 312);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(133, 46);
            this.btnDon.TabIndex = 2;
            this.btnDon.Text = "Done";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number:";
            // 
            // UserClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCustomerNumber);
            this.Controls.Add(this.txtUserCustomer);
            this.Name = "UserClients";
            this.Text = "UserClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserCustomer;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}