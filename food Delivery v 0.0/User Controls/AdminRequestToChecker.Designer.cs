namespace food_Delivery_v_0._0.User_Controls
{
    partial class AdminRequestToChecker
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
            this.menusButton = new System.Windows.Forms.Button();
            this.meal_id = new System.Windows.Forms.TextBox();
            this.request_txt = new System.Windows.Forms.TextBox();
            this.request_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkersButton = new System.Windows.Forms.Button();
            this.requestsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menusButton
            // 
            this.menusButton.BackColor = System.Drawing.Color.Wheat;
            this.menusButton.FlatAppearance.BorderSize = 0;
            this.menusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusButton.ForeColor = System.Drawing.Color.IndianRed;
            this.menusButton.Location = new System.Drawing.Point(3, 79);
            this.menusButton.Name = "menusButton";
            this.menusButton.Size = new System.Drawing.Size(153, 34);
            this.menusButton.TabIndex = 25;
            this.menusButton.Text = "Menus";
            this.menusButton.UseVisualStyleBackColor = false;
            this.menusButton.Click += new System.EventHandler(this.menusButton_Click);
            // 
            // meal_id
            // 
            this.meal_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meal_id.ForeColor = System.Drawing.Color.Silver;
            this.meal_id.Location = new System.Drawing.Point(646, 238);
            this.meal_id.Name = "meal_id";
            this.meal_id.Size = new System.Drawing.Size(159, 22);
            this.meal_id.TabIndex = 24;
            this.meal_id.Text = "meal ID";
            this.meal_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.meal_id.Enter += new System.EventHandler(this.meal_id_Enter);
            this.meal_id.Leave += new System.EventHandler(this.meal_id_Leave);
            // 
            // request_txt
            // 
            this.request_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_txt.ForeColor = System.Drawing.Color.Silver;
            this.request_txt.Location = new System.Drawing.Point(646, 210);
            this.request_txt.Name = "request_txt";
            this.request_txt.Size = new System.Drawing.Size(159, 22);
            this.request_txt.TabIndex = 23;
            this.request_txt.Text = "checker username";
            this.request_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.request_txt.Enter += new System.EventHandler(this.request_txt_Enter);
            this.request_txt.Leave += new System.EventHandler(this.request_txt_Leave);
            // 
            // request_btn
            // 
            this.request_btn.BackColor = System.Drawing.Color.Wheat;
            this.request_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.request_btn.Location = new System.Drawing.Point(658, 155);
            this.request_btn.Name = "request_btn";
            this.request_btn.Size = new System.Drawing.Size(123, 39);
            this.request_btn.TabIndex = 22;
            this.request_btn.Text = "Request checker";
            this.request_btn.UseVisualStyleBackColor = false;
            this.request_btn.Click += new System.EventHandler(this.request_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(51, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(589, 206);
            this.dataGridView1.TabIndex = 21;
            // 
            // adminsButton
            // 
            this.adminsButton.BackColor = System.Drawing.Color.Wheat;
            this.adminsButton.FlatAppearance.BorderSize = 0;
            this.adminsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsButton.ForeColor = System.Drawing.Color.IndianRed;
            this.adminsButton.Location = new System.Drawing.Point(-137, 78);
            this.adminsButton.Name = "adminsButton";
            this.adminsButton.Size = new System.Drawing.Size(75, 25);
            this.adminsButton.TabIndex = 16;
            this.adminsButton.Text = "Admins";
            this.adminsButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(257, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Checker Request";
            // 
            // checkersButton
            // 
            this.checkersButton.BackColor = System.Drawing.Color.Wheat;
            this.checkersButton.FlatAppearance.BorderSize = 0;
            this.checkersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkersButton.ForeColor = System.Drawing.Color.IndianRed;
            this.checkersButton.Location = new System.Drawing.Point(286, 79);
            this.checkersButton.Name = "checkersButton";
            this.checkersButton.Size = new System.Drawing.Size(153, 34);
            this.checkersButton.TabIndex = 26;
            this.checkersButton.Text = "Checkers";
            this.checkersButton.UseVisualStyleBackColor = false;
            this.checkersButton.Click += new System.EventHandler(this.checkersButton_Click);
            // 
            // requestsButton
            // 
            this.requestsButton.BackColor = System.Drawing.Color.Wheat;
            this.requestsButton.FlatAppearance.BorderSize = 0;
            this.requestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsButton.ForeColor = System.Drawing.Color.IndianRed;
            this.requestsButton.Location = new System.Drawing.Point(543, 79);
            this.requestsButton.Name = "requestsButton";
            this.requestsButton.Size = new System.Drawing.Size(153, 34);
            this.requestsButton.TabIndex = 27;
            this.requestsButton.Text = "Requests";
            this.requestsButton.UseVisualStyleBackColor = false;
            this.requestsButton.Click += new System.EventHandler(this.requestsButton_Click);
            // 
            // AdminRequestToChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestsButton);
            this.Controls.Add(this.checkersButton);
            this.Controls.Add(this.menusButton);
            this.Controls.Add(this.meal_id);
            this.Controls.Add(this.request_txt);
            this.Controls.Add(this.request_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminsButton);
            this.Controls.Add(this.label1);
            this.Name = "AdminRequestToChecker";
            this.Size = new System.Drawing.Size(826, 328);
            this.Load += new System.EventHandler(this.AdminRequestToChecker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menusButton;
        private System.Windows.Forms.TextBox meal_id;
        private System.Windows.Forms.TextBox request_txt;
        private System.Windows.Forms.Button request_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adminsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkersButton;
        private System.Windows.Forms.Button requestsButton;
    }
}
