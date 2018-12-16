namespace food_Delivery_v_0._0
{
    partial class SignInControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminRadiobox = new System.Windows.Forms.RadioButton();
            this.checkerRadiobox = new System.Windows.Forms.RadioButton();
            this.cookRadiobox = new System.Windows.Forms.RadioButton();
            this.driverRadiobox = new System.Windows.Forms.RadioButton();
            this.customerRadiobox = new System.Windows.Forms.RadioButton();
            this.SignIn_bt = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sing In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(46, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.adminRadiobox);
            this.groupBox1.Controls.Add(this.checkerRadiobox);
            this.groupBox1.Controls.Add(this.cookRadiobox);
            this.groupBox1.Controls.Add(this.driverRadiobox);
            this.groupBox1.Controls.Add(this.customerRadiobox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(16, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In As:";
            // 
            // adminRadiobox
            // 
            this.adminRadiobox.AutoSize = true;
            this.adminRadiobox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadiobox.Location = new System.Drawing.Point(158, 10);
            this.adminRadiobox.Margin = new System.Windows.Forms.Padding(2);
            this.adminRadiobox.Name = "adminRadiobox";
            this.adminRadiobox.Size = new System.Drawing.Size(60, 20);
            this.adminRadiobox.TabIndex = 4;
            this.adminRadiobox.TabStop = true;
            this.adminRadiobox.Text = "Admin";
            this.adminRadiobox.UseVisualStyleBackColor = true;
            this.adminRadiobox.CheckedChanged += new System.EventHandler(this.adminRadiobox_CheckedChanged);
            // 
            // checkerRadiobox
            // 
            this.checkerRadiobox.AutoSize = true;
            this.checkerRadiobox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkerRadiobox.Location = new System.Drawing.Point(88, 33);
            this.checkerRadiobox.Margin = new System.Windows.Forms.Padding(2);
            this.checkerRadiobox.Name = "checkerRadiobox";
            this.checkerRadiobox.Size = new System.Drawing.Size(137, 20);
            this.checkerRadiobox.TabIndex = 3;
            this.checkerRadiobox.TabStop = true;
            this.checkerRadiobox.Text = "food quality checker";
            this.checkerRadiobox.UseVisualStyleBackColor = true;
            this.checkerRadiobox.CheckedChanged += new System.EventHandler(this.checkerRadiobox_CheckedChanged);
            // 
            // cookRadiobox
            // 
            this.cookRadiobox.AutoSize = true;
            this.cookRadiobox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookRadiobox.Location = new System.Drawing.Point(4, 33);
            this.cookRadiobox.Margin = new System.Windows.Forms.Padding(2);
            this.cookRadiobox.Name = "cookRadiobox";
            this.cookRadiobox.Size = new System.Drawing.Size(54, 20);
            this.cookRadiobox.TabIndex = 2;
            this.cookRadiobox.TabStop = true;
            this.cookRadiobox.Text = "Cook";
            this.cookRadiobox.UseVisualStyleBackColor = true;
            this.cookRadiobox.CheckedChanged += new System.EventHandler(this.cookRadiobox_CheckedChanged);
            // 
            // driverRadiobox
            // 
            this.driverRadiobox.AutoSize = true;
            this.driverRadiobox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRadiobox.Location = new System.Drawing.Point(88, 10);
            this.driverRadiobox.Margin = new System.Windows.Forms.Padding(2);
            this.driverRadiobox.Name = "driverRadiobox";
            this.driverRadiobox.Size = new System.Drawing.Size(57, 20);
            this.driverRadiobox.TabIndex = 1;
            this.driverRadiobox.TabStop = true;
            this.driverRadiobox.Text = "Driver";
            this.driverRadiobox.UseVisualStyleBackColor = true;
            this.driverRadiobox.CheckedChanged += new System.EventHandler(this.driverRadiobox_CheckedChanged);
            // 
            // customerRadiobox
            // 
            this.customerRadiobox.AutoSize = true;
            this.customerRadiobox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerRadiobox.Location = new System.Drawing.Point(5, 10);
            this.customerRadiobox.Margin = new System.Windows.Forms.Padding(2);
            this.customerRadiobox.Name = "customerRadiobox";
            this.customerRadiobox.Size = new System.Drawing.Size(77, 20);
            this.customerRadiobox.TabIndex = 0;
            this.customerRadiobox.TabStop = true;
            this.customerRadiobox.Text = "Customer";
            this.customerRadiobox.UseVisualStyleBackColor = true;
            this.customerRadiobox.CheckedChanged += new System.EventHandler(this.customerRadiobox_CheckedChanged);
            // 
            // SignIn_bt
            // 
            this.SignIn_bt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_bt.Location = new System.Drawing.Point(111, 139);
            this.SignIn_bt.Name = "SignIn_bt";
            this.SignIn_bt.Size = new System.Drawing.Size(75, 29);
            this.SignIn_bt.TabIndex = 31;
            this.SignIn_bt.Text = "Sign In";
            this.SignIn_bt.UseVisualStyleBackColor = true;
            this.SignIn_bt.Click += new System.EventHandler(this.SignIn_bt_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(150, 25);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(122, 29);
            this.usernametxt.TabIndex = 32;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(150, 50);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(122, 29);
            this.passwordtxt.TabIndex = 33;
            this.passwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordtxt_KeyDown);
            // 
            // SignInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.SignIn_bt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignInControl";
            this.Size = new System.Drawing.Size(300, 179);
            this.VisibleChanged += new System.EventHandler(this.SignInControl_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkerRadiobox;
        private System.Windows.Forms.RadioButton cookRadiobox;
        private System.Windows.Forms.RadioButton driverRadiobox;
        private System.Windows.Forms.RadioButton customerRadiobox;
        private System.Windows.Forms.Button SignIn_bt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.RadioButton adminRadiobox;
    }
}
