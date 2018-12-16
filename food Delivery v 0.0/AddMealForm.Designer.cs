namespace food_Delivery_v_0._0
{
    partial class AddMealForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CookUsername_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MealPrice_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MealName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MealID_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_bt = new System.Windows.Forms.Button();
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.MealDetails_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.dragControl2 = new DragControlDemo.DragControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.MealDetails_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CookUsername_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MealPrice_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MealName_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MealID_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal information";
            // 
            // CookUsername_txt
            // 
            this.CookUsername_txt.Location = new System.Drawing.Point(100, 162);
            this.CookUsername_txt.Name = "CookUsername_txt";
            this.CookUsername_txt.Size = new System.Drawing.Size(119, 21);
            this.CookUsername_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cook Username";
            // 
            // MealPrice_txt
            // 
            this.MealPrice_txt.Location = new System.Drawing.Point(76, 134);
            this.MealPrice_txt.Name = "MealPrice_txt";
            this.MealPrice_txt.Size = new System.Drawing.Size(49, 21);
            this.MealPrice_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meal Price";
            // 
            // MealName_txt
            // 
            this.MealName_txt.Location = new System.Drawing.Point(76, 54);
            this.MealName_txt.Name = "MealName_txt";
            this.MealName_txt.Size = new System.Drawing.Size(143, 21);
            this.MealName_txt.TabIndex = 3;
            this.MealName_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meal Name";
            // 
            // MealID_txt
            // 
            this.MealID_txt.Location = new System.Drawing.Point(58, 25);
            this.MealID_txt.Name = "MealID_txt";
            this.MealID_txt.Size = new System.Drawing.Size(100, 21);
            this.MealID_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meal ID";
            // 
            // Add_bt
            // 
            this.Add_bt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_bt.Location = new System.Drawing.Point(208, 210);
            this.Add_bt.Name = "Add_bt";
            this.Add_bt.Size = new System.Drawing.Size(75, 31);
            this.Add_bt.TabIndex = 1;
            this.Add_bt.Text = "Add";
            this.Add_bt.UseVisualStyleBackColor = true;
            this.Add_bt.Click += new System.EventHandler(this.Add_bt_Click);
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_bt.Location = new System.Drawing.Point(289, 210);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(75, 31);
            this.Cancel_bt.TabIndex = 2;
            this.Cancel_bt.Text = "Cancel";
            this.Cancel_bt.UseVisualStyleBackColor = true;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // MealDetails_txt
            // 
            this.MealDetails_txt.Location = new System.Drawing.Point(76, 81);
            this.MealDetails_txt.Multiline = true;
            this.MealDetails_txt.Name = "MealDetails_txt";
            this.MealDetails_txt.Size = new System.Drawing.Size(143, 47);
            this.MealDetails_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Meal Details";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.groupBox1;
            // 
            // AddMealForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::food_Delivery_v_0._0.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(376, 249);
            this.Controls.Add(this.Cancel_bt);
            this.Controls.Add(this.Add_bt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new meal";
            this.Load += new System.EventHandler(this.AddMealForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MealPrice_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MealName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MealID_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CookUsername_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_bt;
        private System.Windows.Forms.Button Cancel_bt;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.TextBox MealDetails_txt;
        private System.Windows.Forms.Label label5;
        private DragControlDemo.DragControl dragControl2;
    }
}