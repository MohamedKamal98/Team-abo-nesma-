namespace food_Delivery_v_0._0
{
    partial class MakeorderUsercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chiefsCombobox = new System.Windows.Forms.ComboBox();
            this.menuListbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.MealDiscriptionLabel = new System.Windows.Forms.Label();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chiefsCombobox
            // 
            this.chiefsCombobox.FormattingEnabled = true;
            this.chiefsCombobox.Location = new System.Drawing.Point(20, 22);
            this.chiefsCombobox.Name = "chiefsCombobox";
            this.chiefsCombobox.Size = new System.Drawing.Size(204, 28);
            this.chiefsCombobox.TabIndex = 0;
            this.chiefsCombobox.Text = "Chiefs";
            this.chiefsCombobox.SelectionChangeCommitted += new System.EventHandler(this.chiefsCombobox_SelectionChangeCommitted);
            // 
            // menuListbox
            // 
            this.menuListbox.FormattingEnabled = true;
            this.menuListbox.ItemHeight = 20;
            this.menuListbox.Location = new System.Drawing.Point(20, 67);
            this.menuListbox.Name = "menuListbox";
            this.menuListbox.Size = new System.Drawing.Size(204, 344);
            this.menuListbox.TabIndex = 1;
            this.menuListbox.SelectedIndexChanged += new System.EventHandler(this.menuListbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rateLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.MealDiscriptionLabel);
            this.groupBox1.Controls.Add(this.mealNameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(289, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(193, 151);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 43);
            this.priceLabel.TabIndex = 5;
            // 
            // MealDiscriptionLabel
            // 
            this.MealDiscriptionLabel.AutoSize = true;
            this.MealDiscriptionLabel.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealDiscriptionLabel.Location = new System.Drawing.Point(193, 65);
            this.MealDiscriptionLabel.Name = "MealDiscriptionLabel";
            this.MealDiscriptionLabel.Size = new System.Drawing.Size(0, 43);
            this.MealDiscriptionLabel.TabIndex = 4;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameLabel.Location = new System.Drawing.Point(193, 22);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(0, 43);
            this.mealNameLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meal Name:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 436);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 44);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rate:";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(193, 108);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(0, 43);
            this.rateLabel.TabIndex = 7;
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.AllowUserToDeleteRows = false;
            this.OrderDataGridView.AllowUserToResizeColumns = false;
            this.OrderDataGridView.AllowUserToResizeRows = false;
            this.OrderDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderDataGridView.Location = new System.Drawing.Point(289, 228);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowTemplate.Height = 28;
            this.OrderDataGridView.Size = new System.Drawing.Size(680, 184);
            this.OrderDataGridView.TabIndex = 4;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(173, 445);
            this.quantityTextbox.MaxLength = 99;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(41, 26);
            this.quantityTextbox.TabIndex = 5;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(289, 436);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(147, 44);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(682, 436);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(147, 44);
            this.checkoutButton.TabIndex = 7;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Visible = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(841, 445);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(128, 32);
            this.totalCost.TabIndex = 8;
            this.totalCost.Text = "totalCost";
            this.totalCost.Visible = false;
            // 
            // MakeorderUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.OrderDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuListbox);
            this.Controls.Add(this.chiefsCombobox);
            this.Name = "MakeorderUsercontrol";
            this.Size = new System.Drawing.Size(1050, 500);
            this.Load += new System.EventHandler(this.MakeorderUsercontrol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chiefsCombobox;
        private System.Windows.Forms.ListBox menuListbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label MealDiscriptionLabel;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label totalCost;
    }
}
