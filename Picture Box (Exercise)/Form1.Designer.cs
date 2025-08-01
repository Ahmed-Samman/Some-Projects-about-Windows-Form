namespace Picture_Box__Exercise_
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbtnBoy = new System.Windows.Forms.RadioButton();
            this.rbtnGirl = new System.Windows.Forms.RadioButton();
            this.rbtnBook = new System.Windows.Forms.RadioButton();
            this.rbtnPen = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(354, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "TITLE";
            // 
            // rbtnBoy
            // 
            this.rbtnBoy.AutoSize = true;
            this.rbtnBoy.Checked = true;
            this.rbtnBoy.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnBoy.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBoy.Location = new System.Drawing.Point(158, 477);
            this.rbtnBoy.Name = "rbtnBoy";
            this.rbtnBoy.Size = new System.Drawing.Size(74, 28);
            this.rbtnBoy.TabIndex = 0;
            this.rbtnBoy.TabStop = true;
            this.rbtnBoy.Tag = "Boy";
            this.rbtnBoy.Text = "Boy";
            this.rbtnBoy.UseVisualStyleBackColor = true;
            this.rbtnBoy.CheckedChanged += new System.EventHandler(this.rbtnBoy_CheckedChanged);
            // 
            // rbtnGirl
            // 
            this.rbtnGirl.AutoSize = true;
            this.rbtnGirl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGirl.Location = new System.Drawing.Point(315, 477);
            this.rbtnGirl.Name = "rbtnGirl";
            this.rbtnGirl.Size = new System.Drawing.Size(73, 28);
            this.rbtnGirl.TabIndex = 3;
            this.rbtnGirl.Tag = "Girl";
            this.rbtnGirl.Text = "Girl";
            this.rbtnGirl.UseVisualStyleBackColor = true;
            this.rbtnGirl.CheckedChanged += new System.EventHandler(this.rbtnGirl_CheckedChanged);
            // 
            // rbtnBook
            // 
            this.rbtnBook.AutoSize = true;
            this.rbtnBook.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBook.Location = new System.Drawing.Point(480, 477);
            this.rbtnBook.Name = "rbtnBook";
            this.rbtnBook.Size = new System.Drawing.Size(87, 28);
            this.rbtnBook.TabIndex = 4;
            this.rbtnBook.Tag = "Book";
            this.rbtnBook.Text = "Book";
            this.rbtnBook.UseVisualStyleBackColor = true;
            this.rbtnBook.CheckedChanged += new System.EventHandler(this.rbtnBook_CheckedChanged);
            // 
            // rbtnPen
            // 
            this.rbtnPen.AutoSize = true;
            this.rbtnPen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPen.Location = new System.Drawing.Point(646, 477);
            this.rbtnPen.Name = "rbtnPen";
            this.rbtnPen.Size = new System.Drawing.Size(77, 28);
            this.rbtnPen.TabIndex = 5;
            this.rbtnPen.Tag = "Pen";
            this.rbtnPen.Text = "Pen";
            this.rbtnPen.UseVisualStyleBackColor = true;
            this.rbtnPen.CheckedChanged += new System.EventHandler(this.rbtnPen_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Picture_Box__Exercise_.Properties.Resources.Boy;
            this.pictureBox1.Location = new System.Drawing.Point(106, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 594);
            this.Controls.Add(this.rbtnPen);
            this.Controls.Add(this.rbtnBook);
            this.Controls.Add(this.rbtnGirl);
            this.Controls.Add(this.rbtnBoy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnBoy;
        private System.Windows.Forms.RadioButton rbtnGirl;
        private System.Windows.Forms.RadioButton rbtnBook;
        private System.Windows.Forms.RadioButton rbtnPen;
    }
}

