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
            this.rateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.MealDiscriptionLabel = new System.Windows.Forms.Label();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
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
            this.chiefsCombobox.Location = new System.Drawing.Point(13, 14);
            this.chiefsCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chiefsCombobox.Name = "chiefsCombobox";
            this.chiefsCombobox.Size = new System.Drawing.Size(137, 21);
            this.chiefsCombobox.TabIndex = 0;
            this.chiefsCombobox.Text = "Chiefs";
            this.chiefsCombobox.SelectionChangeCommitted += new System.EventHandler(this.chiefsCombobox_SelectionChangeCommitted);
            // 
            // menuListbox
            // 
            this.menuListbox.FormattingEnabled = true;
            this.menuListbox.Location = new System.Drawing.Point(13, 44);
            this.menuListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuListbox.Name = "menuListbox";
            this.menuListbox.Size = new System.Drawing.Size(137, 225);
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
            this.groupBox1.Location = new System.Drawing.Point(193, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(483, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(129, 70);
            this.rateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(0, 26);
            this.rateLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rate:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(129, 98);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 26);
            this.priceLabel.TabIndex = 5;
            // 
            // MealDiscriptionLabel
            // 
            this.MealDiscriptionLabel.AutoSize = true;
            this.MealDiscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealDiscriptionLabel.Location = new System.Drawing.Point(129, 42);
            this.MealDiscriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MealDiscriptionLabel.Name = "MealDiscriptionLabel";
            this.MealDiscriptionLabel.Size = new System.Drawing.Size(0, 26);
            this.MealDiscriptionLabel.TabIndex = 4;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameLabel.Location = new System.Drawing.Point(129, 14);
            this.mealNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(0, 26);
            this.mealNameLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meal Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 283);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.OrderDataGridView.Location = new System.Drawing.Point(193, 159);
            this.OrderDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowTemplate.Height = 28;
            this.OrderDataGridView.Size = new System.Drawing.Size(453, 120);
            this.OrderDataGridView.TabIndex = 4;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(115, 289);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityTextbox.MaxLength = 99;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(29, 20);
            this.quantityTextbox.TabIndex = 5;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(193, 283);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(98, 29);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(455, 283);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(98, 29);
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
            this.totalCost.Location = new System.Drawing.Point(561, 289);
            this.totalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(80, 24);
            this.totalCost.TabIndex = 8;
            this.totalCost.Text = "totalCost";
            this.totalCost.Visible = false;
            // 
            // MakeorderUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MakeorderUsercontrol";
            this.Size = new System.Drawing.Size(700, 325);
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
