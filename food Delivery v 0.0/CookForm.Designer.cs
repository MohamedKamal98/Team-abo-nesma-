namespace food_Delivery_v_0._0
{
    partial class CookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookForm));
            this.TopHeader = new GradientPanelDemo.GradientPanel();
            this.footerBottom = new GradientPanelDemo.GradientPanel();
            this.Header = new System.Windows.Forms.Panel();
            this.customImageButton1 = new food_Delivery_v_0._0.CustomImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customImageButton2 = new food_Delivery_v_0._0.CustomImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.dragControl2 = new DragControlDemo.DragControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.ShowMenu_bt = new RoundButtonDemo.CircularButton();
            this.ShowReq_bt = new RoundButtonDemo.CircularButton();
            this.cook_Menu1 = new food_Delivery_v_0._0.Cook_Menu();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopHeader
            // 
            this.TopHeader.ColorBottom = System.Drawing.Color.Chocolate;
            this.TopHeader.ColorTop = System.Drawing.Color.SaddleBrown;
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.Size = new System.Drawing.Size(824, 17);
            this.TopHeader.TabIndex = 6;
            // 
            // footerBottom
            // 
            this.footerBottom.ColorBottom = System.Drawing.Color.Chocolate;
            this.footerBottom.ColorTop = System.Drawing.Color.SaddleBrown;
            this.footerBottom.Location = new System.Drawing.Point(0, 547);
            this.footerBottom.Name = "footerBottom";
            this.footerBottom.Size = new System.Drawing.Size(837, 18);
            this.footerBottom.TabIndex = 7;
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
            this.Header.Size = new System.Drawing.Size(837, 98);
            this.Header.TabIndex = 8;
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
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.TopHeader;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Header;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 100;
            this.elipseControl1.TargetControl = this;
            // 
            // ShowMenu_bt
            // 
            this.ShowMenu_bt.BackColor = System.Drawing.Color.Sienna;
            this.ShowMenu_bt.FlatAppearance.BorderSize = 0;
            this.ShowMenu_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMenu_bt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMenu_bt.Location = new System.Drawing.Point(132, 218);
            this.ShowMenu_bt.Name = "ShowMenu_bt";
            this.ShowMenu_bt.Size = new System.Drawing.Size(191, 167);
            this.ShowMenu_bt.TabIndex = 34;
            this.ShowMenu_bt.Text = "Show Menu";
            this.ShowMenu_bt.UseVisualStyleBackColor = false;
            this.ShowMenu_bt.Click += new System.EventHandler(this.BackBt_Click);
            // 
            // ShowReq_bt
            // 
            this.ShowReq_bt.BackColor = System.Drawing.Color.Sienna;
            this.ShowReq_bt.FlatAppearance.BorderSize = 0;
            this.ShowReq_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowReq_bt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReq_bt.Location = new System.Drawing.Point(499, 218);
            this.ShowReq_bt.Name = "ShowReq_bt";
            this.ShowReq_bt.Size = new System.Drawing.Size(191, 167);
            this.ShowReq_bt.TabIndex = 35;
            this.ShowReq_bt.Text = "Show Requests";
            this.ShowReq_bt.UseVisualStyleBackColor = false;
            // 
            // cook_Menu1
            // 
            this.cook_Menu1.BackColor = System.Drawing.Color.Transparent;
            this.cook_Menu1.Location = new System.Drawing.Point(7, 127);
            this.cook_Menu1.Name = "cook_Menu1";
            this.cook_Menu1.Size = new System.Drawing.Size(819, 411);
            this.cook_Menu1.TabIndex = 36;
            // 
            // CookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::food_Delivery_v_0._0.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 565);
            this.Controls.Add(this.cook_Menu1);
            this.Controls.Add(this.ShowReq_bt);
            this.Controls.Add(this.ShowMenu_bt);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.footerBottom);
            this.Controls.Add(this.TopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CookForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private DragControlDemo.DragControl dragControl1;
        private DragControlDemo.DragControl dragControl2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private RoundButtonDemo.CircularButton ShowReq_bt;
        private RoundButtonDemo.CircularButton ShowMenu_bt;
        private Cook_Menu cook_Menu1;
    }
}