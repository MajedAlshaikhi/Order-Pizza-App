namespace Pizza
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraCheeze = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(177, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Lucida Bright", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbSize.ForeColor = System.Drawing.Color.Black;
            this.gbSize.Location = new System.Drawing.Point(12, 101);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(147, 154);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.ForeColor = System.Drawing.Color.Black;
            this.rbLarge.Location = new System.Drawing.Point(15, 101);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(69, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ForeColor = System.Drawing.Color.Black;
            this.rbMedium.Location = new System.Drawing.Point(15, 70);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(89, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.ForeColor = System.Drawing.Color.Black;
            this.rbSmall.Location = new System.Drawing.Point(15, 39);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(68, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Lucida Bright", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbCrust.ForeColor = System.Drawing.Color.Black;
            this.gbCrust.Location = new System.Drawing.Point(12, 292);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(204, 116);
            this.gbCrust.TabIndex = 2;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.ForeColor = System.Drawing.Color.Black;
            this.rbThick.Location = new System.Drawing.Point(15, 82);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(75, 24);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = " Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.ForeColor = System.Drawing.Color.Black;
            this.rbThin.Location = new System.Drawing.Point(15, 39);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(60, 24);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraCheeze);
            this.gbToppings.Font = new System.Drawing.Font("Lucida Bright", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbToppings.ForeColor = System.Drawing.Color.Black;
            this.gbToppings.Location = new System.Drawing.Point(199, 101);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(327, 154);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.ForeColor = System.Drawing.Color.Black;
            this.chkGreenPeppers.Location = new System.Drawing.Point(165, 103);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(139, 24);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.ForeColor = System.Drawing.Color.Black;
            this.chkTomatoes.Location = new System.Drawing.Point(165, 72);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(103, 24);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.ForeColor = System.Drawing.Color.Black;
            this.chkMushrooms.Location = new System.Drawing.Point(165, 39);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(116, 24);
            this.chkMushrooms.TabIndex = 3;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.ForeColor = System.Drawing.Color.Black;
            this.chkOlives.Location = new System.Drawing.Point(15, 103);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(75, 24);
            this.chkOlives.TabIndex = 2;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.Color.Black;
            this.chkOnion.Location = new System.Drawing.Point(15, 72);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(74, 24);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraCheeze
            // 
            this.chkExtraCheeze.AutoSize = true;
            this.chkExtraCheeze.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheeze.ForeColor = System.Drawing.Color.Black;
            this.chkExtraCheeze.Location = new System.Drawing.Point(15, 39);
            this.chkExtraCheeze.Name = "chkExtraCheeze";
            this.chkExtraCheeze.Size = new System.Drawing.Size(128, 24);
            this.chkExtraCheeze.TabIndex = 0;
            this.chkExtraCheeze.Tag = "5";
            this.chkExtraCheeze.Text = "Extra Cheeze";
            this.chkExtraCheeze.UseVisualStyleBackColor = true;
            this.chkExtraCheeze.CheckedChanged += new System.EventHandler(this.chkExtraCheeze_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Lucida Bright", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.gbWhereToEat.Location = new System.Drawing.Point(343, 292);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(183, 116);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.ForeColor = System.Drawing.Color.Black;
            this.rbTakeOut.Location = new System.Drawing.Point(15, 82);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(99, 24);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.ForeColor = System.Drawing.Color.Black;
            this.rbEatIn.Location = new System.Drawing.Point(15, 34);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(70, 24);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(71, 42);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Small";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crust Type:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(141, 222);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(42, 20);
            this.lblCrustType.TabIndex = 5;
            this.lblCrustType.Text = "Thin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Where To Eat:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(144, 278);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(52, 20);
            this.lblWhereToEat.TabIndex = 7;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(239, 376);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(42, 28);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "$0";
            // 
            // gbSummary
            // 
            this.gbSummary.AutoSize = true;
            this.gbSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.lblToppings);
            this.gbSummary.Controls.Add(this.numericUpDown1);
            this.gbSummary.Controls.Add(this.lblTotalPrice);
            this.gbSummary.Controls.Add(this.label7);
            this.gbSummary.Controls.Add(this.lblWhereToEat);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.lblCrustType);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.lblSize);
            this.gbSummary.Font = new System.Drawing.Font("Lucida Bright", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbSummary.ForeColor = System.Drawing.Color.Black;
            this.gbSummary.Location = new System.Drawing.Point(589, 110);
            this.gbSummary.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(369, 436);
            this.gbSummary.TabIndex = 5;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = " Order Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // lblToppings
            // 
            this.lblToppings.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(103, 90);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblToppings.Size = new System.Drawing.Size(249, 110);
            this.lblToppings.TabIndex = 10;
            this.lblToppings.Text = "No Toppoings";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(21, 372);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 33);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Lime;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnOrderPizza.FlatAppearance.BorderSize = 3;
            this.btnOrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(137, 452);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(123, 45);
            this.btnOrderPizza.TabIndex = 6;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Red;
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnResetForm.FlatAppearance.BorderSize = 3;
            this.btnResetForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnResetForm.Location = new System.Drawing.Point(301, 452);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(136, 45);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Order";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(981, 588);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraCheeze;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}

