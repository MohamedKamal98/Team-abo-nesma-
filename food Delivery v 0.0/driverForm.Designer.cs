namespace food_Delivery_v_0._0
{
    partial class driverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driverForm));
            this.Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ordersCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.mealNameTxt = new System.Windows.Forms.TextBox();
            this.cookTxt = new System.Windows.Forms.TextBox();
            this.customerTxt = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.cookLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.deliverOrderButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.customerFullNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customImageButton1 = new food_Delivery_v_0._0.CustomImageButton();
            this.customImageButton2 = new food_Delivery_v_0._0.CustomImageButton();
            this.footerBottom = new GradientPanelDemo.GradientPanel();
            this.TopHeader = new GradientPanelDemo.GradientPanel();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header.BackgroundImage")));
            this.Header.Controls.Add(this.customImageButton1);
            this.Header.Controls.Add(this.label2);
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.customImageButton2);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Location = new System.Drawing.Point(0, 16);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(878, 98);
            this.Header.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Log out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ordersCombobox
            // 
            this.ordersCombobox.FormattingEnabled = true;
            this.ordersCombobox.Location = new System.Drawing.Point(121, 155);
            this.ordersCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.ordersCombobox.Name = "ordersCombobox";
            this.ordersCombobox.Size = new System.Drawing.Size(137, 21);
            this.ordersCombobox.TabIndex = 9;
            this.ordersCombobox.Text = "Orders";
            this.ordersCombobox.SelectionChangeCommitted += new System.EventHandler(this.ordersCombobox_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.quantityTxt);
            this.groupBox1.Controls.Add(this.mealNameTxt);
            this.groupBox1.Controls.Add(this.cookTxt);
            this.groupBox1.Controls.Add(this.customerTxt);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Controls.Add(this.mealNameLabel);
            this.groupBox1.Controls.Add(this.cookLabel);
            this.groupBox1.Controls.Add(this.customerLabel);
            this.groupBox1.Location = new System.Drawing.Point(40, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 177);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(139, 126);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(213, 20);
            this.quantityTxt.TabIndex = 9;
            // 
            // mealNameTxt
            // 
            this.mealNameTxt.Location = new System.Drawing.Point(139, 96);
            this.mealNameTxt.Name = "mealNameTxt";
            this.mealNameTxt.Size = new System.Drawing.Size(213, 20);
            this.mealNameTxt.TabIndex = 7;
            // 
            // cookTxt
            // 
            this.cookTxt.Location = new System.Drawing.Point(139, 62);
            this.cookTxt.Name = "cookTxt";
            this.cookTxt.Size = new System.Drawing.Size(213, 20);
            this.cookTxt.TabIndex = 6;
            // 
            // customerTxt
            // 
            this.customerTxt.Location = new System.Drawing.Point(139, 28);
            this.customerTxt.Name = "customerTxt";
            this.customerTxt.Size = new System.Drawing.Size(213, 20);
            this.customerTxt.TabIndex = 5;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(6, 121);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(83, 24);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity:";
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameLabel.Location = new System.Drawing.Point(6, 92);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(112, 24);
            this.mealNameLabel.TabIndex = 2;
            this.mealNameLabel.Text = "Meal Name:";
            // 
            // cookLabel
            // 
            this.cookLabel.AutoSize = true;
            this.cookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookLabel.Location = new System.Drawing.Point(6, 58);
            this.cookLabel.Name = "cookLabel";
            this.cookLabel.Size = new System.Drawing.Size(59, 24);
            this.cookLabel.TabIndex = 1;
            this.cookLabel.Text = "Cook:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(6, 25);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(96, 24);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Customer:";
            // 
            // deliverOrderButton
            // 
            this.deliverOrderButton.Location = new System.Drawing.Point(353, 472);
            this.deliverOrderButton.Name = "deliverOrderButton";
            this.deliverOrderButton.Size = new System.Drawing.Size(169, 51);
            this.deliverOrderButton.TabIndex = 11;
            this.deliverOrderButton.Text = "Deliver Order";
            this.deliverOrderButton.UseVisualStyleBackColor = true;
            this.deliverOrderButton.Click += new System.EventHandler(this.deliverOrderButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.addressTxt);
            this.groupBox2.Controls.Add(this.phoneTxt);
            this.groupBox2.Controls.Add(this.gendertxt);
            this.groupBox2.Controls.Add(this.customerFullNametxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(474, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(139, 128);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(213, 20);
            this.addressTxt.TabIndex = 8;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(139, 96);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(213, 20);
            this.phoneTxt.TabIndex = 7;
            // 
            // gendertxt
            // 
            this.gendertxt.Location = new System.Drawing.Point(139, 62);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(213, 20);
            this.gendertxt.TabIndex = 6;
            // 
            // customerFullNametxt
            // 
            this.customerFullNametxt.Location = new System.Drawing.Point(139, 28);
            this.customerFullNametxt.Name = "customerFullNametxt";
            this.customerFullNametxt.Size = new System.Drawing.Size(213, 20);
            this.customerFullNametxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // customImageButton1
            // 
            this.customImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.customImageButton1.Image = global::food_Delivery_v_0._0.Properties.Resources.Logout_512;
            this.customImageButton1.ImageHover = global::food_Delivery_v_0._0.Properties.Resources.download;
            this.customImageButton1.ImageNormal = global::food_Delivery_v_0._0.Properties.Resources.Logout_512;
            this.customImageButton1.Location = new System.Drawing.Point(666, 11);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(65, 57);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton1.TabIndex = 14;
            this.customImageButton1.TabStop = false;
            this.customImageButton1.Click += new System.EventHandler(this.customImageButton1_Click);
            // 
            // customImageButton2
            // 
            this.customImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.customImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton2.Image")));
            this.customImageButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageHover")));
            this.customImageButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageNormal")));
            this.customImageButton2.Location = new System.Drawing.Point(759, 11);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(65, 57);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton2.TabIndex = 10;
            this.customImageButton2.TabStop = false;
            this.customImageButton2.Click += new System.EventHandler(this.customImageButton2_Click);
            // 
            // footerBottom
            // 
            this.footerBottom.ColorBottom = System.Drawing.Color.Chocolate;
            this.footerBottom.ColorTop = System.Drawing.Color.SaddleBrown;
            this.footerBottom.Location = new System.Drawing.Point(12, 583);
            this.footerBottom.Name = "footerBottom";
            this.footerBottom.Size = new System.Drawing.Size(891, 26);
            this.footerBottom.TabIndex = 7;
            // 
            // TopHeader
            // 
            this.TopHeader.ColorBottom = System.Drawing.Color.Chocolate;
            this.TopHeader.ColorTop = System.Drawing.Color.SaddleBrown;
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.Size = new System.Drawing.Size(961, 21);
            this.TopHeader.TabIndex = 6;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 100;
            this.elipseControl1.TargetControl = this;
            // 
            // driverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::food_Delivery_v_0._0.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deliverOrderButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ordersCombobox);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.footerBottom);
            this.Controls.Add(this.TopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "driverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CookForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanelDemo.GradientPanel TopHeader;
        private GradientPanelDemo.GradientPanel footerBottom;
        private System.Windows.Forms.Panel Header;
        private CustomImageButton customImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomImageButton customImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.ComboBox ordersCombobox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox mealNameTxt;
        private System.Windows.Forms.TextBox cookTxt;
        private System.Windows.Forms.TextBox customerTxt;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.Label cookLabel;
        private System.Windows.Forms.Button deliverOrderButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.TextBox customerFullNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}