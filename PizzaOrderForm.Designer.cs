namespace MyFirstWindowsForm
{
    partial class PizzaOrderForm
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
            this.Pnl_PizzaSize = new System.Windows.Forms.Panel();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.rb_MediumSize = new System.Windows.Forms.RadioButton();
            this.rb_LargeSize = new System.Windows.Forms.RadioButton();
            this.rb_SmalSize = new System.Windows.Forms.RadioButton();
            this.pnl_CrustType = new System.Windows.Forms.Panel();
            this.lbl_PizzaCrustType = new System.Windows.Forms.Label();
            this.rb_ThickCrust = new System.Windows.Forms.RadioButton();
            this.rb_ThinCrust = new System.Windows.Forms.RadioButton();
            this.pnl_Toppings = new System.Windows.Forms.Panel();
            this.cbx_GreenPaper = new System.Windows.Forms.CheckBox();
            this.cbx_Tomatoes = new System.Windows.Forms.CheckBox();
            this.cbx_Olives = new System.Windows.Forms.CheckBox();
            this.cbx_Mushrooms = new System.Windows.Forms.CheckBox();
            this.cbx_Onion = new System.Windows.Forms.CheckBox();
            this.cbx_ExtraCheese = new System.Windows.Forms.CheckBox();
            this.lbl_PizzaToppings = new System.Windows.Forms.Label();
            this.pnl_WhereToEat = new System.Windows.Forms.Panel();
            this.rb_TakeOut = new System.Windows.Forms.RadioButton();
            this.rb_EatIn = new System.Windows.Forms.RadioButton();
            this.lbl_WhereToEat = new System.Windows.Forms.Label();
            this.btn_ResetOrder = new System.Windows.Forms.Button();
            this.btn_OrderPizza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_PizzaSizeSummery = new System.Windows.Forms.Label();
            this.lbl_Collon = new System.Windows.Forms.Label();
            this.lbl_SizeResult = new System.Windows.Forms.Label();
            this.lbl_PizzaToppingsSummery = new System.Windows.Forms.Label();
            this.lbl_Comma2 = new System.Windows.Forms.Label();
            this.lbl_ToppingsResult = new System.Windows.Forms.Label();
            this.lbl_PizzaCrustTypeSummery = new System.Windows.Forms.Label();
            this.lbl_Comma3 = new System.Windows.Forms.Label();
            this.lbl_CrustTypeResult = new System.Windows.Forms.Label();
            this.lbl_Comma4 = new System.Windows.Forms.Label();
            this.lbl_WhereToEatSummery = new System.Windows.Forms.Label();
            this.lbl_WhereToEatResult = new System.Windows.Forms.Label();
            this.lbl_Comma5 = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.lbl_TotalPriceResult = new System.Windows.Forms.Label();
            this.pnl_Summery = new System.Windows.Forms.Panel();
            this.Pnl_PizzaSize.SuspendLayout();
            this.pnl_CrustType.SuspendLayout();
            this.pnl_Toppings.SuspendLayout();
            this.pnl_WhereToEat.SuspendLayout();
            this.pnl_Summery.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fontdiner Swanky", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // Pnl_PizzaSize
            // 
            this.Pnl_PizzaSize.Controls.Add(this.lbl_Size);
            this.Pnl_PizzaSize.Controls.Add(this.rb_MediumSize);
            this.Pnl_PizzaSize.Controls.Add(this.rb_LargeSize);
            this.Pnl_PizzaSize.Controls.Add(this.rb_SmalSize);
            this.Pnl_PizzaSize.Location = new System.Drawing.Point(46, 120);
            this.Pnl_PizzaSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pnl_PizzaSize.Name = "Pnl_PizzaSize";
            this.Pnl_PizzaSize.Size = new System.Drawing.Size(108, 151);
            this.Pnl_PizzaSize.TabIndex = 0;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(4, 0);
            this.lbl_Size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(37, 17);
            this.lbl_Size.TabIndex = 3;
            this.lbl_Size.Text = "Size";
            // 
            // rb_MediumSize
            // 
            this.rb_MediumSize.AutoSize = true;
            this.rb_MediumSize.Checked = true;
            this.rb_MediumSize.Location = new System.Drawing.Point(30, 79);
            this.rb_MediumSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_MediumSize.Name = "rb_MediumSize";
            this.rb_MediumSize.Size = new System.Drawing.Size(69, 19);
            this.rb_MediumSize.TabIndex = 1;
            this.rb_MediumSize.TabStop = true;
            this.rb_MediumSize.Tag = "30";
            this.rb_MediumSize.Text = "Medium";
            this.rb_MediumSize.UseVisualStyleBackColor = true;
            this.rb_MediumSize.CheckedChanged += new System.EventHandler(this.rb_MediumSize_CheckedChanged);
            // 
            // rb_LargeSize
            // 
            this.rb_LargeSize.AutoSize = true;
            this.rb_LargeSize.Location = new System.Drawing.Point(30, 124);
            this.rb_LargeSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_LargeSize.Name = "rb_LargeSize";
            this.rb_LargeSize.Size = new System.Drawing.Size(57, 19);
            this.rb_LargeSize.TabIndex = 2;
            this.rb_LargeSize.Tag = "40";
            this.rb_LargeSize.Text = "Large";
            this.rb_LargeSize.UseVisualStyleBackColor = true;
            this.rb_LargeSize.CheckedChanged += new System.EventHandler(this.rb_LargeSize_CheckedChanged);
            // 
            // rb_SmalSize
            // 
            this.rb_SmalSize.AutoSize = true;
            this.rb_SmalSize.Location = new System.Drawing.Point(30, 35);
            this.rb_SmalSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_SmalSize.Name = "rb_SmalSize";
            this.rb_SmalSize.Size = new System.Drawing.Size(57, 19);
            this.rb_SmalSize.TabIndex = 0;
            this.rb_SmalSize.Tag = "20";
            this.rb_SmalSize.Text = "Small";
            this.rb_SmalSize.UseVisualStyleBackColor = true;
            this.rb_SmalSize.CheckedChanged += new System.EventHandler(this.rb_SmalSize_CheckedChanged);
            // 
            // pnl_CrustType
            // 
            this.pnl_CrustType.Controls.Add(this.lbl_PizzaCrustType);
            this.pnl_CrustType.Controls.Add(this.rb_ThickCrust);
            this.pnl_CrustType.Controls.Add(this.rb_ThinCrust);
            this.pnl_CrustType.Location = new System.Drawing.Point(46, 341);
            this.pnl_CrustType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_CrustType.Name = "pnl_CrustType";
            this.pnl_CrustType.Size = new System.Drawing.Size(121, 94);
            this.pnl_CrustType.TabIndex = 2;
            // 
            // lbl_PizzaCrustType
            // 
            this.lbl_PizzaCrustType.AutoSize = true;
            this.lbl_PizzaCrustType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PizzaCrustType.Location = new System.Drawing.Point(4, 0);
            this.lbl_PizzaCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PizzaCrustType.Name = "lbl_PizzaCrustType";
            this.lbl_PizzaCrustType.Size = new System.Drawing.Size(44, 17);
            this.lbl_PizzaCrustType.TabIndex = 0;
            this.lbl_PizzaCrustType.Text = "Crust";
            // 
            // rb_ThickCrust
            // 
            this.rb_ThickCrust.AutoSize = true;
            this.rb_ThickCrust.Location = new System.Drawing.Point(21, 74);
            this.rb_ThickCrust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_ThickCrust.Name = "rb_ThickCrust";
            this.rb_ThickCrust.Size = new System.Drawing.Size(87, 19);
            this.rb_ThickCrust.TabIndex = 1;
            this.rb_ThickCrust.TabStop = true;
            this.rb_ThickCrust.Tag = "10";
            this.rb_ThickCrust.Text = "Thick Crust";
            this.rb_ThickCrust.UseVisualStyleBackColor = true;
            this.rb_ThickCrust.CheckedChanged += new System.EventHandler(this.rb_Thick_CheckedChanged);
            // 
            // rb_ThinCrust
            // 
            this.rb_ThinCrust.AutoSize = true;
            this.rb_ThinCrust.Checked = true;
            this.rb_ThinCrust.Location = new System.Drawing.Point(21, 36);
            this.rb_ThinCrust.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_ThinCrust.Name = "rb_ThinCrust";
            this.rb_ThinCrust.Size = new System.Drawing.Size(82, 19);
            this.rb_ThinCrust.TabIndex = 0;
            this.rb_ThinCrust.TabStop = true;
            this.rb_ThinCrust.Tag = "0";
            this.rb_ThinCrust.Text = "Thin Crust";
            this.rb_ThinCrust.UseVisualStyleBackColor = true;
            this.rb_ThinCrust.CheckedChanged += new System.EventHandler(this.rb_ThinCrust_CheckedChanged);
            // 
            // pnl_Toppings
            // 
            this.pnl_Toppings.Controls.Add(this.cbx_GreenPaper);
            this.pnl_Toppings.Controls.Add(this.cbx_Tomatoes);
            this.pnl_Toppings.Controls.Add(this.cbx_Olives);
            this.pnl_Toppings.Controls.Add(this.cbx_Mushrooms);
            this.pnl_Toppings.Controls.Add(this.cbx_Onion);
            this.pnl_Toppings.Controls.Add(this.cbx_ExtraCheese);
            this.pnl_Toppings.Controls.Add(this.lbl_PizzaToppings);
            this.pnl_Toppings.Location = new System.Drawing.Point(306, 120);
            this.pnl_Toppings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Toppings.Name = "pnl_Toppings";
            this.pnl_Toppings.Size = new System.Drawing.Size(251, 135);
            this.pnl_Toppings.TabIndex = 3;
            // 
            // cbx_GreenPaper
            // 
            this.cbx_GreenPaper.AutoSize = true;
            this.cbx_GreenPaper.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_GreenPaper.Location = new System.Drawing.Point(144, 108);
            this.cbx_GreenPaper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_GreenPaper.Name = "cbx_GreenPaper";
            this.cbx_GreenPaper.Size = new System.Drawing.Size(96, 19);
            this.cbx_GreenPaper.TabIndex = 6;
            this.cbx_GreenPaper.Tag = "5";
            this.cbx_GreenPaper.Text = "Green Paper";
            this.cbx_GreenPaper.UseVisualStyleBackColor = true;
            this.cbx_GreenPaper.CheckedChanged += new System.EventHandler(this.cbx_GreenPaper_CheckedChanged);
            // 
            // cbx_Tomatoes
            // 
            this.cbx_Tomatoes.AutoSize = true;
            this.cbx_Tomatoes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Tomatoes.Location = new System.Drawing.Point(7, 108);
            this.cbx_Tomatoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_Tomatoes.Name = "cbx_Tomatoes";
            this.cbx_Tomatoes.Size = new System.Drawing.Size(81, 19);
            this.cbx_Tomatoes.TabIndex = 5;
            this.cbx_Tomatoes.Tag = "5";
            this.cbx_Tomatoes.Text = "Totamoes";
            this.cbx_Tomatoes.UseVisualStyleBackColor = true;
            this.cbx_Tomatoes.CheckedChanged += new System.EventHandler(this.cbx_Tomatoes_CheckedChanged);
            // 
            // cbx_Olives
            // 
            this.cbx_Olives.AutoSize = true;
            this.cbx_Olives.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Olives.Location = new System.Drawing.Point(144, 73);
            this.cbx_Olives.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_Olives.Name = "cbx_Olives";
            this.cbx_Olives.Size = new System.Drawing.Size(60, 19);
            this.cbx_Olives.TabIndex = 4;
            this.cbx_Olives.Tag = "5";
            this.cbx_Olives.Text = "Olives";
            this.cbx_Olives.UseVisualStyleBackColor = true;
            this.cbx_Olives.CheckedChanged += new System.EventHandler(this.cbx_Olives_CheckedChanged);
            // 
            // cbx_Mushrooms
            // 
            this.cbx_Mushrooms.AutoSize = true;
            this.cbx_Mushrooms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Mushrooms.Location = new System.Drawing.Point(7, 73);
            this.cbx_Mushrooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_Mushrooms.Name = "cbx_Mushrooms";
            this.cbx_Mushrooms.Size = new System.Drawing.Size(92, 19);
            this.cbx_Mushrooms.TabIndex = 3;
            this.cbx_Mushrooms.Tag = "5";
            this.cbx_Mushrooms.Text = "Mushrooms";
            this.cbx_Mushrooms.UseVisualStyleBackColor = true;
            this.cbx_Mushrooms.CheckedChanged += new System.EventHandler(this.cbx_Mushrooms_CheckedChanged);
            // 
            // cbx_Onion
            // 
            this.cbx_Onion.AutoSize = true;
            this.cbx_Onion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Onion.Location = new System.Drawing.Point(144, 39);
            this.cbx_Onion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_Onion.Name = "cbx_Onion";
            this.cbx_Onion.Size = new System.Drawing.Size(59, 19);
            this.cbx_Onion.TabIndex = 2;
            this.cbx_Onion.Tag = "5";
            this.cbx_Onion.Text = "Onion";
            this.cbx_Onion.UseVisualStyleBackColor = true;
            this.cbx_Onion.CheckedChanged += new System.EventHandler(this.cbx_Onion_CheckedChanged);
            // 
            // cbx_ExtraCheese
            // 
            this.cbx_ExtraCheese.AutoSize = true;
            this.cbx_ExtraCheese.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ExtraCheese.Location = new System.Drawing.Point(7, 36);
            this.cbx_ExtraCheese.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_ExtraCheese.Name = "cbx_ExtraCheese";
            this.cbx_ExtraCheese.Size = new System.Drawing.Size(100, 19);
            this.cbx_ExtraCheese.TabIndex = 1;
            this.cbx_ExtraCheese.Tag = "5";
            this.cbx_ExtraCheese.Text = "Extra Cheese";
            this.cbx_ExtraCheese.UseVisualStyleBackColor = true;
            this.cbx_ExtraCheese.CheckedChanged += new System.EventHandler(this.cbx_ExtraCheese_CheckedChanged);
            // 
            // lbl_PizzaToppings
            // 
            this.lbl_PizzaToppings.AutoSize = true;
            this.lbl_PizzaToppings.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PizzaToppings.Location = new System.Drawing.Point(4, 0);
            this.lbl_PizzaToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PizzaToppings.Name = "lbl_PizzaToppings";
            this.lbl_PizzaToppings.Size = new System.Drawing.Size(66, 17);
            this.lbl_PizzaToppings.TabIndex = 0;
            this.lbl_PizzaToppings.Text = "Toppings";
            // 
            // pnl_WhereToEat
            // 
            this.pnl_WhereToEat.Controls.Add(this.rb_TakeOut);
            this.pnl_WhereToEat.Controls.Add(this.rb_EatIn);
            this.pnl_WhereToEat.Controls.Add(this.lbl_WhereToEat);
            this.pnl_WhereToEat.Location = new System.Drawing.Point(306, 341);
            this.pnl_WhereToEat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_WhereToEat.Name = "pnl_WhereToEat";
            this.pnl_WhereToEat.Size = new System.Drawing.Size(251, 75);
            this.pnl_WhereToEat.TabIndex = 4;
            // 
            // rb_TakeOut
            // 
            this.rb_TakeOut.AutoSize = true;
            this.rb_TakeOut.Location = new System.Drawing.Point(132, 36);
            this.rb_TakeOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_TakeOut.Name = "rb_TakeOut";
            this.rb_TakeOut.Size = new System.Drawing.Size(70, 19);
            this.rb_TakeOut.TabIndex = 8;
            this.rb_TakeOut.Text = "TakeOut";
            this.rb_TakeOut.UseVisualStyleBackColor = true;
            this.rb_TakeOut.CheckedChanged += new System.EventHandler(this.rb_TakeOut_CheckedChanged);
            // 
            // rb_EatIn
            // 
            this.rb_EatIn.AutoSize = true;
            this.rb_EatIn.Checked = true;
            this.rb_EatIn.Location = new System.Drawing.Point(9, 35);
            this.rb_EatIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_EatIn.Name = "rb_EatIn";
            this.rb_EatIn.Size = new System.Drawing.Size(56, 19);
            this.rb_EatIn.TabIndex = 7;
            this.rb_EatIn.TabStop = true;
            this.rb_EatIn.Text = "Eat In";
            this.rb_EatIn.UseVisualStyleBackColor = true;
            this.rb_EatIn.CheckedChanged += new System.EventHandler(this.rb_EatIn_CheckedChanged);
            // 
            // lbl_WhereToEat
            // 
            this.lbl_WhereToEat.AutoSize = true;
            this.lbl_WhereToEat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WhereToEat.Location = new System.Drawing.Point(4, 0);
            this.lbl_WhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_WhereToEat.Name = "lbl_WhereToEat";
            this.lbl_WhereToEat.Size = new System.Drawing.Size(97, 17);
            this.lbl_WhereToEat.TabIndex = 0;
            this.lbl_WhereToEat.Text = "Where To Eat";
            // 
            // btn_ResetOrder
            // 
            this.btn_ResetOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetOrder.Location = new System.Drawing.Point(469, 435);
            this.btn_ResetOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ResetOrder.Name = "btn_ResetOrder";
            this.btn_ResetOrder.Size = new System.Drawing.Size(106, 32);
            this.btn_ResetOrder.TabIndex = 10;
            this.btn_ResetOrder.Text = "Reset Order";
            this.btn_ResetOrder.UseVisualStyleBackColor = true;
            this.btn_ResetOrder.Click += new System.EventHandler(this.btn_ResetOrder_Click);
            // 
            // btn_OrderPizza
            // 
            this.btn_OrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_OrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderPizza.Location = new System.Drawing.Point(306, 435);
            this.btn_OrderPizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_OrderPizza.Name = "btn_OrderPizza";
            this.btn_OrderPizza.Size = new System.Drawing.Size(106, 32);
            this.btn_OrderPizza.TabIndex = 9;
            this.btn_OrderPizza.Text = "Order Pizza";
            this.btn_OrderPizza.UseVisualStyleBackColor = true;
            this.btn_OrderPizza.Click += new System.EventHandler(this.btn_OrderPizza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Summery";
            // 
            // lbl_PizzaSizeSummery
            // 
            this.lbl_PizzaSizeSummery.AutoSize = true;
            this.lbl_PizzaSizeSummery.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PizzaSizeSummery.Location = new System.Drawing.Point(18, 39);
            this.lbl_PizzaSizeSummery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PizzaSizeSummery.Name = "lbl_PizzaSizeSummery";
            this.lbl_PizzaSizeSummery.Size = new System.Drawing.Size(39, 18);
            this.lbl_PizzaSizeSummery.TabIndex = 8;
            this.lbl_PizzaSizeSummery.Text = "Size";
            // 
            // lbl_Collon
            // 
            this.lbl_Collon.AutoSize = true;
            this.lbl_Collon.Enabled = false;
            this.lbl_Collon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Collon.Location = new System.Drawing.Point(51, 40);
            this.lbl_Collon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Collon.Name = "lbl_Collon";
            this.lbl_Collon.Size = new System.Drawing.Size(10, 15);
            this.lbl_Collon.TabIndex = 9;
            this.lbl_Collon.Text = ":";
            // 
            // lbl_SizeResult
            // 
            this.lbl_SizeResult.AutoSize = true;
            this.lbl_SizeResult.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeResult.Location = new System.Drawing.Point(70, 40);
            this.lbl_SizeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SizeResult.Name = "lbl_SizeResult";
            this.lbl_SizeResult.Size = new System.Drawing.Size(59, 17);
            this.lbl_SizeResult.TabIndex = 10;
            this.lbl_SizeResult.Text = "Medium";
            // 
            // lbl_PizzaToppingsSummery
            // 
            this.lbl_PizzaToppingsSummery.AutoSize = true;
            this.lbl_PizzaToppingsSummery.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PizzaToppingsSummery.Location = new System.Drawing.Point(18, 73);
            this.lbl_PizzaToppingsSummery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PizzaToppingsSummery.Name = "lbl_PizzaToppingsSummery";
            this.lbl_PizzaToppingsSummery.Size = new System.Drawing.Size(74, 18);
            this.lbl_PizzaToppingsSummery.TabIndex = 11;
            this.lbl_PizzaToppingsSummery.Text = "Toppings";
            // 
            // lbl_Comma2
            // 
            this.lbl_Comma2.AutoSize = true;
            this.lbl_Comma2.Enabled = false;
            this.lbl_Comma2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comma2.Location = new System.Drawing.Point(89, 75);
            this.lbl_Comma2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Comma2.Name = "lbl_Comma2";
            this.lbl_Comma2.Size = new System.Drawing.Size(10, 15);
            this.lbl_Comma2.TabIndex = 12;
            this.lbl_Comma2.Text = ":";
            // 
            // lbl_ToppingsResult
            // 
            this.lbl_ToppingsResult.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToppingsResult.Location = new System.Drawing.Point(51, 97);
            this.lbl_ToppingsResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ToppingsResult.Name = "lbl_ToppingsResult";
            this.lbl_ToppingsResult.Size = new System.Drawing.Size(199, 38);
            this.lbl_ToppingsResult.TabIndex = 13;
            this.lbl_ToppingsResult.Text = "No Toppings";
            // 
            // lbl_PizzaCrustTypeSummery
            // 
            this.lbl_PizzaCrustTypeSummery.AutoSize = true;
            this.lbl_PizzaCrustTypeSummery.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PizzaCrustTypeSummery.Location = new System.Drawing.Point(18, 135);
            this.lbl_PizzaCrustTypeSummery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PizzaCrustTypeSummery.Name = "lbl_PizzaCrustTypeSummery";
            this.lbl_PizzaCrustTypeSummery.Size = new System.Drawing.Size(85, 18);
            this.lbl_PizzaCrustTypeSummery.TabIndex = 14;
            this.lbl_PizzaCrustTypeSummery.Text = "Crust Type";
            // 
            // lbl_Comma3
            // 
            this.lbl_Comma3.AutoSize = true;
            this.lbl_Comma3.Enabled = false;
            this.lbl_Comma3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comma3.Location = new System.Drawing.Point(97, 137);
            this.lbl_Comma3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Comma3.Name = "lbl_Comma3";
            this.lbl_Comma3.Size = new System.Drawing.Size(10, 15);
            this.lbl_Comma3.TabIndex = 15;
            this.lbl_Comma3.Text = ":";
            // 
            // lbl_CrustTypeResult
            // 
            this.lbl_CrustTypeResult.AutoSize = true;
            this.lbl_CrustTypeResult.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CrustTypeResult.Location = new System.Drawing.Point(115, 136);
            this.lbl_CrustTypeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CrustTypeResult.Name = "lbl_CrustTypeResult";
            this.lbl_CrustTypeResult.Size = new System.Drawing.Size(76, 17);
            this.lbl_CrustTypeResult.TabIndex = 16;
            this.lbl_CrustTypeResult.Text = "Thin Crust";
            // 
            // lbl_Comma4
            // 
            this.lbl_Comma4.AutoSize = true;
            this.lbl_Comma4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comma4.Enabled = false;
            this.lbl_Comma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Comma4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_Comma4.Location = new System.Drawing.Point(117, 164);
            this.lbl_Comma4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Comma4.Name = "lbl_Comma4";
            this.lbl_Comma4.Size = new System.Drawing.Size(10, 16);
            this.lbl_Comma4.TabIndex = 18;
            this.lbl_Comma4.Text = ":";
            // 
            // lbl_WhereToEatSummery
            // 
            this.lbl_WhereToEatSummery.AutoSize = true;
            this.lbl_WhereToEatSummery.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WhereToEatSummery.Location = new System.Drawing.Point(18, 163);
            this.lbl_WhereToEatSummery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_WhereToEatSummery.Name = "lbl_WhereToEatSummery";
            this.lbl_WhereToEatSummery.Size = new System.Drawing.Size(103, 18);
            this.lbl_WhereToEatSummery.TabIndex = 17;
            this.lbl_WhereToEatSummery.Text = "Where To Eat";
            // 
            // lbl_WhereToEatResult
            // 
            this.lbl_WhereToEatResult.AutoSize = true;
            this.lbl_WhereToEatResult.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WhereToEatResult.Location = new System.Drawing.Point(118, 194);
            this.lbl_WhereToEatResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_WhereToEatResult.Name = "lbl_WhereToEatResult";
            this.lbl_WhereToEatResult.Size = new System.Drawing.Size(45, 17);
            this.lbl_WhereToEatResult.TabIndex = 19;
            this.lbl_WhereToEatResult.Text = "Eat In";
            // 
            // lbl_Comma5
            // 
            this.lbl_Comma5.AutoSize = true;
            this.lbl_Comma5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comma5.Enabled = false;
            this.lbl_Comma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Comma5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_Comma5.Location = new System.Drawing.Point(111, 236);
            this.lbl_Comma5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Comma5.Name = "lbl_Comma5";
            this.lbl_Comma5.Size = new System.Drawing.Size(10, 16);
            this.lbl_Comma5.TabIndex = 21;
            this.lbl_Comma5.Text = ":";
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(18, 236);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(84, 18);
            this.lbl_TotalPrice.TabIndex = 20;
            this.lbl_TotalPrice.Text = "Total Price";
            // 
            // lbl_TotalPriceResult
            // 
            this.lbl_TotalPriceResult.AutoSize = true;
            this.lbl_TotalPriceResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalPriceResult.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPriceResult.ForeColor = System.Drawing.Color.Green;
            this.lbl_TotalPriceResult.Location = new System.Drawing.Point(120, 257);
            this.lbl_TotalPriceResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalPriceResult.Name = "lbl_TotalPriceResult";
            this.lbl_TotalPriceResult.Size = new System.Drawing.Size(61, 43);
            this.lbl_TotalPriceResult.TabIndex = 22;
            this.lbl_TotalPriceResult.Text = "$0";
            // 
            // pnl_Summery
            // 
            this.pnl_Summery.Controls.Add(this.lbl_TotalPriceResult);
            this.pnl_Summery.Controls.Add(this.lbl_TotalPrice);
            this.pnl_Summery.Controls.Add(this.lbl_Comma5);
            this.pnl_Summery.Controls.Add(this.lbl_WhereToEatResult);
            this.pnl_Summery.Controls.Add(this.lbl_WhereToEatSummery);
            this.pnl_Summery.Controls.Add(this.lbl_Comma4);
            this.pnl_Summery.Controls.Add(this.lbl_CrustTypeResult);
            this.pnl_Summery.Controls.Add(this.lbl_Comma3);
            this.pnl_Summery.Controls.Add(this.lbl_PizzaCrustTypeSummery);
            this.pnl_Summery.Controls.Add(this.lbl_ToppingsResult);
            this.pnl_Summery.Controls.Add(this.lbl_Comma2);
            this.pnl_Summery.Controls.Add(this.lbl_PizzaToppingsSummery);
            this.pnl_Summery.Controls.Add(this.lbl_SizeResult);
            this.pnl_Summery.Controls.Add(this.lbl_Collon);
            this.pnl_Summery.Controls.Add(this.lbl_PizzaSizeSummery);
            this.pnl_Summery.Controls.Add(this.label4);
            this.pnl_Summery.Location = new System.Drawing.Point(680, 120);
            this.pnl_Summery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_Summery.Name = "pnl_Summery";
            this.pnl_Summery.Size = new System.Drawing.Size(250, 332);
            this.pnl_Summery.TabIndex = 11;
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 504);
            this.Controls.Add(this.pnl_Summery);
            this.Controls.Add(this.btn_ResetOrder);
            this.Controls.Add(this.pnl_WhereToEat);
            this.Controls.Add(this.btn_OrderPizza);
            this.Controls.Add(this.pnl_Toppings);
            this.Controls.Add(this.pnl_CrustType);
            this.Controls.Add(this.Pnl_PizzaSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PizzaOrderForm";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            this.Pnl_PizzaSize.ResumeLayout(false);
            this.Pnl_PizzaSize.PerformLayout();
            this.pnl_CrustType.ResumeLayout(false);
            this.pnl_CrustType.PerformLayout();
            this.pnl_Toppings.ResumeLayout(false);
            this.pnl_Toppings.PerformLayout();
            this.pnl_WhereToEat.ResumeLayout(false);
            this.pnl_WhereToEat.PerformLayout();
            this.pnl_Summery.ResumeLayout(false);
            this.pnl_Summery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_PizzaSize;
        private System.Windows.Forms.RadioButton rb_MediumSize;
        private System.Windows.Forms.RadioButton rb_LargeSize;
        private System.Windows.Forms.RadioButton rb_SmalSize;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Panel pnl_CrustType;
        private System.Windows.Forms.Label lbl_PizzaCrustType;
        private System.Windows.Forms.RadioButton rb_ThickCrust;
        private System.Windows.Forms.RadioButton rb_ThinCrust;
        private System.Windows.Forms.Panel pnl_Toppings;
        private System.Windows.Forms.CheckBox cbx_Tomatoes;
        private System.Windows.Forms.CheckBox cbx_Olives;
        private System.Windows.Forms.CheckBox cbx_Mushrooms;
        private System.Windows.Forms.CheckBox cbx_Onion;
        private System.Windows.Forms.CheckBox cbx_ExtraCheese;
        private System.Windows.Forms.Label lbl_PizzaToppings;
        private System.Windows.Forms.CheckBox cbx_GreenPaper;
        private System.Windows.Forms.Panel pnl_WhereToEat;
        private System.Windows.Forms.RadioButton rb_EatIn;
        private System.Windows.Forms.Label lbl_WhereToEat;
        private System.Windows.Forms.Button btn_OrderPizza;
        private System.Windows.Forms.RadioButton rb_TakeOut;
        private System.Windows.Forms.Button btn_ResetOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_PizzaSizeSummery;
        private System.Windows.Forms.Label lbl_Collon;
        private System.Windows.Forms.Label lbl_SizeResult;
        private System.Windows.Forms.Label lbl_PizzaToppingsSummery;
        private System.Windows.Forms.Label lbl_Comma2;
        private System.Windows.Forms.Label lbl_ToppingsResult;
        private System.Windows.Forms.Label lbl_PizzaCrustTypeSummery;
        private System.Windows.Forms.Label lbl_Comma3;
        private System.Windows.Forms.Label lbl_CrustTypeResult;
        private System.Windows.Forms.Label lbl_Comma4;
        private System.Windows.Forms.Label lbl_WhereToEatSummery;
        private System.Windows.Forms.Label lbl_WhereToEatResult;
        private System.Windows.Forms.Label lbl_Comma5;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label lbl_TotalPriceResult;
        private System.Windows.Forms.Panel pnl_Summery;
    }
}