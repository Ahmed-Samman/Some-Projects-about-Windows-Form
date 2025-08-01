namespace MaskedTextBox
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
            this.maskTxtName = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskTxtName
            // 
            this.maskTxtName.BeepOnError = true;
            this.maskTxtName.Location = new System.Drawing.Point(231, 199);
            this.maskTxtName.Mask = "???????????????????????????";
            this.maskTxtName.Name = "maskTxtName";
            this.maskTxtName.Size = new System.Drawing.Size(424, 26);
            this.maskTxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Your Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Birth Date:";
            // 
            // maskedTxtBirthDate
            // 
            this.maskedTxtBirthDate.BeepOnError = true;
            this.maskedTxtBirthDate.Location = new System.Drawing.Point(231, 303);
            this.maskedTxtBirthDate.Mask = "00/00/0000";
            this.maskedTxtBirthDate.Name = "maskedTxtBirthDate";
            this.maskedTxtBirthDate.Size = new System.Drawing.Size(424, 26);
            this.maskedTxtBirthDate.TabIndex = 4;
            this.maskedTxtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Zip Code:";
            // 
            // maskedTxtPhoneNumber
            // 
            this.maskedTxtPhoneNumber.BeepOnError = true;
            this.maskedTxtPhoneNumber.Location = new System.Drawing.Point(231, 411);
            this.maskedTxtPhoneNumber.Mask = "(999) 0000-0000";
            this.maskedTxtPhoneNumber.Name = "maskedTxtPhoneNumber";
            this.maskedTxtPhoneNumber.Size = new System.Drawing.Size(424, 26);
            this.maskedTxtPhoneNumber.TabIndex = 7;
            // 
            // maskedTxtZipCode
            // 
            this.maskedTxtZipCode.BeepOnError = true;
            this.maskedTxtZipCode.Location = new System.Drawing.Point(231, 511);
            this.maskedTxtZipCode.Mask = "00000-9999";
            this.maskedTxtZipCode.Name = "maskedTxtZipCode";
            this.maskedTxtZipCode.Size = new System.Drawing.Size(424, 26);
            this.maskedTxtZipCode.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(452, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTxtZipCode);
            this.Controls.Add(this.maskedTxtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTxtBirthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskTxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskTxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTxtBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTxtPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTxtZipCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

