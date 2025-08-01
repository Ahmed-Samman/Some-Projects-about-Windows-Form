namespace Pizza_Order_My_Solution_
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rbtnLargeSize = new System.Windows.Forms.RadioButton();
            this.rbtnMediumSize = new System.Windows.Forms.RadioButton();
            this.rbtnSmallSize = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.grbCrustType = new System.Windows.Forms.GroupBox();
            this.rbtnThickCrust = new System.Windows.Forms.RadioButton();
            this.rbtnThinCrust = new System.Windows.Forms.RadioButton();
            this.grbwhereToEat = new System.Windows.Forms.GroupBox();
            this.rbtnTakeOut = new System.Windows.Forms.RadioButton();
            this.rbtnEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSizePizza = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPizzaEnumerate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbSize.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbCrustType.SuspendLayout();
            this.grbwhereToEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // grbSize
            // 
            this.grbSize.AutoSize = true;
            this.grbSize.Controls.Add(this.rbtnLargeSize);
            this.grbSize.Controls.Add(this.rbtnMediumSize);
            this.grbSize.Controls.Add(this.rbtnSmallSize);
            this.grbSize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSize.ForeColor = System.Drawing.Color.Coral;
            this.grbSize.Location = new System.Drawing.Point(42, 150);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(268, 234);
            this.grbSize.TabIndex = 0;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rbtnLargeSize
            // 
            this.rbtnLargeSize.AutoSize = true;
            this.rbtnLargeSize.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLargeSize.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnLargeSize.Location = new System.Drawing.Point(35, 164);
            this.rbtnLargeSize.Name = "rbtnLargeSize";
            this.rbtnLargeSize.Size = new System.Drawing.Size(92, 33);
            this.rbtnLargeSize.TabIndex = 2;
            this.rbtnLargeSize.TabStop = true;
            this.rbtnLargeSize.Tag = "40";
            this.rbtnLargeSize.Text = "Large";
            this.rbtnLargeSize.UseVisualStyleBackColor = true;
            this.rbtnLargeSize.CheckedChanged += new System.EventHandler(this.rbtnLargeSize_CheckedChanged);
            // 
            // rbtnMediumSize
            // 
            this.rbtnMediumSize.AutoSize = true;
            this.rbtnMediumSize.Checked = true;
            this.rbtnMediumSize.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMediumSize.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnMediumSize.Location = new System.Drawing.Point(35, 112);
            this.rbtnMediumSize.Name = "rbtnMediumSize";
            this.rbtnMediumSize.Size = new System.Drawing.Size(119, 33);
            this.rbtnMediumSize.TabIndex = 1;
            this.rbtnMediumSize.TabStop = true;
            this.rbtnMediumSize.Tag = "30";
            this.rbtnMediumSize.Text = "Medium";
            this.rbtnMediumSize.UseVisualStyleBackColor = true;
            this.rbtnMediumSize.CheckedChanged += new System.EventHandler(this.rbtnMediumSize_CheckedChanged);
            // 
            // rbtnSmallSize
            // 
            this.rbtnSmallSize.AutoSize = true;
            this.rbtnSmallSize.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSmallSize.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnSmallSize.Location = new System.Drawing.Point(35, 61);
            this.rbtnSmallSize.Name = "rbtnSmallSize";
            this.rbtnSmallSize.Size = new System.Drawing.Size(90, 33);
            this.rbtnSmallSize.TabIndex = 0;
            this.rbtnSmallSize.TabStop = true;
            this.rbtnSmallSize.Tag = "20";
            this.rbtnSmallSize.Text = "Small";
            this.rbtnSmallSize.UseVisualStyleBackColor = true;
            this.rbtnSmallSize.CheckedChanged += new System.EventHandler(this.rbtnSmallSize_CheckedChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.AutoSize = true;
            this.grbToppings.Controls.Add(this.chkOlives);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkGreenPappers);
            this.grbToppings.Controls.Add(this.chkMashrooms);
            this.grbToppings.Controls.Add(this.chkExtraCheese);
            this.grbToppings.Controls.Add(this.chkTomatoes);
            this.grbToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.ForeColor = System.Drawing.Color.Coral;
            this.grbToppings.Location = new System.Drawing.Point(340, 150);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(515, 263);
            this.grbToppings.TabIndex = 2;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.ForeColor = System.Drawing.Color.DarkRed;
            this.chkOlives.Location = new System.Drawing.Point(277, 110);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(98, 33);
            this.chkOlives.TabIndex = 9;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.Color.DarkRed;
            this.chkOnion.Location = new System.Drawing.Point(277, 51);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(98, 33);
            this.chkOnion.TabIndex = 8;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPappers.ForeColor = System.Drawing.Color.DarkRed;
            this.chkGreenPappers.Location = new System.Drawing.Point(277, 164);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(182, 33);
            this.chkGreenPappers.TabIndex = 10;
            this.chkGreenPappers.Tag = "5";
            this.chkGreenPappers.Text = "Green Pappers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkGreenPappers_CheckedChanged);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMashrooms.ForeColor = System.Drawing.Color.DarkRed;
            this.chkMashrooms.Location = new System.Drawing.Point(62, 110);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(153, 33);
            this.chkMashrooms.TabIndex = 6;
            this.chkMashrooms.Tag = "5";
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.CheckedChanged += new System.EventHandler(this.chkMashrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.ForeColor = System.Drawing.Color.DarkRed;
            this.chkExtraCheese.Location = new System.Drawing.Point(62, 51);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(160, 33);
            this.chkExtraCheese.TabIndex = 5;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Chesse";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.ForeColor = System.Drawing.Color.DarkRed;
            this.chkTomatoes.Location = new System.Drawing.Point(62, 164);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(135, 33);
            this.chkTomatoes.TabIndex = 7;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // grbCrustType
            // 
            this.grbCrustType.AutoSize = true;
            this.grbCrustType.Controls.Add(this.rbtnThickCrust);
            this.grbCrustType.Controls.Add(this.rbtnThinCrust);
            this.grbCrustType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrustType.ForeColor = System.Drawing.Color.Coral;
            this.grbCrustType.Location = new System.Drawing.Point(42, 434);
            this.grbCrustType.Name = "grbCrustType";
            this.grbCrustType.Size = new System.Drawing.Size(268, 201);
            this.grbCrustType.TabIndex = 1;
            this.grbCrustType.TabStop = false;
            this.grbCrustType.Text = "Crust Type";
            // 
            // rbtnThickCrust
            // 
            this.rbtnThickCrust.AutoSize = true;
            this.rbtnThickCrust.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThickCrust.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnThickCrust.Location = new System.Drawing.Point(35, 131);
            this.rbtnThickCrust.Name = "rbtnThickCrust";
            this.rbtnThickCrust.Size = new System.Drawing.Size(144, 33);
            this.rbtnThickCrust.TabIndex = 4;
            this.rbtnThickCrust.TabStop = true;
            this.rbtnThickCrust.Tag = "10";
            this.rbtnThickCrust.Text = "Thick Crust";
            this.rbtnThickCrust.UseVisualStyleBackColor = true;
            this.rbtnThickCrust.CheckedChanged += new System.EventHandler(this.rbtnThickCrust_CheckedChanged);
            // 
            // rbtnThinCrust
            // 
            this.rbtnThinCrust.AutoSize = true;
            this.rbtnThinCrust.Checked = true;
            this.rbtnThinCrust.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThinCrust.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnThinCrust.Location = new System.Drawing.Point(35, 71);
            this.rbtnThinCrust.Name = "rbtnThinCrust";
            this.rbtnThinCrust.Size = new System.Drawing.Size(135, 33);
            this.rbtnThinCrust.TabIndex = 3;
            this.rbtnThinCrust.TabStop = true;
            this.rbtnThinCrust.Tag = "0";
            this.rbtnThinCrust.Text = "Thin Crust";
            this.rbtnThinCrust.UseVisualStyleBackColor = true;
            this.rbtnThinCrust.CheckedChanged += new System.EventHandler(this.rbtnThinCrust_CheckedChanged);
            // 
            // grbwhereToEat
            // 
            this.grbwhereToEat.AutoSize = true;
            this.grbwhereToEat.Controls.Add(this.rbtnTakeOut);
            this.grbwhereToEat.Controls.Add(this.rbtnEatIn);
            this.grbwhereToEat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbwhereToEat.ForeColor = System.Drawing.Color.Coral;
            this.grbwhereToEat.Location = new System.Drawing.Point(375, 434);
            this.grbwhereToEat.Name = "grbwhereToEat";
            this.grbwhereToEat.Size = new System.Drawing.Size(444, 147);
            this.grbwhereToEat.TabIndex = 3;
            this.grbwhereToEat.TabStop = false;
            this.grbwhereToEat.Text = "Where To Eat";
            // 
            // rbtnTakeOut
            // 
            this.rbtnTakeOut.AutoSize = true;
            this.rbtnTakeOut.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTakeOut.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnTakeOut.Location = new System.Drawing.Point(275, 77);
            this.rbtnTakeOut.Name = "rbtnTakeOut";
            this.rbtnTakeOut.Size = new System.Drawing.Size(126, 33);
            this.rbtnTakeOut.TabIndex = 12;
            this.rbtnTakeOut.TabStop = true;
            this.rbtnTakeOut.Text = "Take Out";
            this.rbtnTakeOut.UseVisualStyleBackColor = true;
            this.rbtnTakeOut.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnEatIn
            // 
            this.rbtnEatIn.AutoSize = true;
            this.rbtnEatIn.Checked = true;
            this.rbtnEatIn.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEatIn.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtnEatIn.Location = new System.Drawing.Point(89, 77);
            this.rbtnEatIn.Name = "rbtnEatIn";
            this.rbtnEatIn.Size = new System.Drawing.Size(91, 33);
            this.rbtnEatIn.TabIndex = 11;
            this.rbtnEatIn.TabStop = true;
            this.rbtnEatIn.Text = "Eat In";
            this.rbtnEatIn.UseVisualStyleBackColor = true;
            this.rbtnEatIn.CheckedChanged += new System.EventHandler(this.rbtnEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrderPizza.Location = new System.Drawing.Point(375, 601);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(155, 54);
            this.btnOrderPizza.TabIndex = 13;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResetForm.Location = new System.Drawing.Point(601, 601);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(155, 54);
            this.btnResetForm.TabIndex = 14;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(874, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Sammary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(912, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(912, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toppings: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(911, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "CrustType: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(911, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wher To Eat:";
            // 
            // labSizePizza
            // 
            this.labSizePizza.AutoSize = true;
            this.labSizePizza.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSizePizza.ForeColor = System.Drawing.Color.Olive;
            this.labSizePizza.Location = new System.Drawing.Point(980, 200);
            this.labSizePizza.Name = "labSizePizza";
            this.labSizePizza.Size = new System.Drawing.Size(97, 29);
            this.labSizePizza.TabIndex = 11;
            this.labSizePizza.Text = "Medium";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.ForeColor = System.Drawing.Color.Olive;
            this.labCrustType.Location = new System.Drawing.Point(1065, 377);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(113, 29);
            this.labCrustType.TabIndex = 13;
            this.labCrustType.Text = "Thin Crust";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.ForeColor = System.Drawing.Color.Olive;
            this.labWhereToEat.Location = new System.Drawing.Point(1082, 437);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(69, 29);
            this.labWhereToEat.TabIndex = 14;
            this.labWhereToEat.Text = "Eat In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(1203, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Price:";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.labTotalPrice.Location = new System.Drawing.Point(1286, 585);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(148, 117);
            this.labTotalPrice.TabIndex = 16;
            this.labTotalPrice.Text = "$0";
            // 
            // labToppings
            // 
            this.labToppings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.ForeColor = System.Drawing.Color.Olive;
            this.labToppings.Location = new System.Drawing.Point(949, 304);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(382, 70);
            this.labToppings.TabIndex = 17;
            this.labToppings.Text = "No Toppings";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Olive;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1022, 635);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(912, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pizza Enumerate:";
            // 
            // lblPizzaEnumerate
            // 
            this.lblPizzaEnumerate.AutoSize = true;
            this.lblPizzaEnumerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaEnumerate.ForeColor = System.Drawing.Color.Olive;
            this.lblPizzaEnumerate.Location = new System.Drawing.Point(1143, 502);
            this.lblPizzaEnumerate.Name = "lblPizzaEnumerate";
            this.lblPizzaEnumerate.Size = new System.Drawing.Size(25, 29);
            this.lblPizzaEnumerate.TabIndex = 20;
            this.lblPizzaEnumerate.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(863, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "How Many Pizza?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 711);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPizzaEnumerate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labToppings);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labWhereToEat);
            this.Controls.Add(this.labCrustType);
            this.Controls.Add(this.labSizePizza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grbwhereToEat);
            this.Controls.Add(this.grbCrustType);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbCrustType.ResumeLayout(false);
            this.grbCrustType.PerformLayout();
            this.grbwhereToEat.ResumeLayout(false);
            this.grbwhereToEat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.GroupBox grbCrustType;
        private System.Windows.Forms.GroupBox grbwhereToEat;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.RadioButton rbtnLargeSize;
        private System.Windows.Forms.RadioButton rbtnMediumSize;
        private System.Windows.Forms.RadioButton rbtnSmallSize;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.RadioButton rbtnThickCrust;
        private System.Windows.Forms.RadioButton rbtnThinCrust;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rbtnTakeOut;
        private System.Windows.Forms.RadioButton rbtnEatIn;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labSizePizza;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPizzaEnumerate;
        private System.Windows.Forms.Label label9;
    }
}

