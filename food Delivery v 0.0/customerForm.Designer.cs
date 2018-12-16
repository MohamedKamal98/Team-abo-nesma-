namespace food_Delivery_v_0._0
{
    partial class customerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
            this.TopHeader = new GradientPanelDemo.GradientPanel();
            this.footerBottom = new GradientPanelDemo.GradientPanel();
            this.Header = new System.Windows.Forms.Panel();
            this.customImageButton1 = new food_Delivery_v_0._0.CustomImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customImageButton2 = new food_Delivery_v_0._0.CustomImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.OrderButton = new System.Windows.Forms.Button();
            this.TrackButton = new System.Windows.Forms.Button();
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
            this.TopHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.Size = new System.Drawing.Size(1236, 26);
            this.TopHeader.TabIndex = 6;
            // 
            // footerBottom
            // 
            this.footerBottom.ColorBottom = System.Drawing.Color.Chocolate;
            this.footerBottom.ColorTop = System.Drawing.Color.SaddleBrown;
            this.footerBottom.Location = new System.Drawing.Point(0, 842);
            this.footerBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footerBottom.Name = "footerBottom";
            this.footerBottom.Size = new System.Drawing.Size(1256, 28);
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
            this.Header.Location = new System.Drawing.Point(0, 25);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1256, 151);
            this.Header.TabIndex = 8;
            // 
            // customImageButton1
            // 
            this.customImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.customImageButton1.Image = global::food_Delivery_v_0._0.Properties.Resources.Logout_512;
            this.customImageButton1.ImageHover = global::food_Delivery_v_0._0.Properties.Resources.download;
            this.customImageButton1.ImageNormal = global::food_Delivery_v_0._0.Properties.Resources.Logout_512;
            this.customImageButton1.Location = new System.Drawing.Point(999, 17);
            this.customImageButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(98, 88);
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
            this.label2.Location = new System.Drawing.Point(999, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Log out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1160, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Exit";
            // 
            // customImageButton2
            // 
            this.customImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.customImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton2.Image")));
            this.customImageButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageHover")));
            this.customImageButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageNormal")));
            this.customImageButton2.Location = new System.Drawing.Point(1138, 17);
            this.customImageButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(98, 88);
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
            this.pictureBox1.Location = new System.Drawing.Point(10, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 100;
            this.elipseControl1.TargetControl = this;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(173, 339);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(221, 76);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Make Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // TrackButton
            // 
            this.TrackButton.Location = new System.Drawing.Point(742, 339);
            this.TrackButton.Name = "TrackButton";
            this.TrackButton.Size = new System.Drawing.Size(221, 76);
            this.TrackButton.TabIndex = 10;
            this.TrackButton.Text = "Track Order";
            this.TrackButton.UseVisualStyleBackColor = true;
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::food_Delivery_v_0._0.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 869);
            this.Controls.Add(this.TrackButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.footerBottom);
            this.Controls.Add(this.TopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "customerForm";
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
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Button TrackButton;
        private System.Windows.Forms.Button OrderButton;
    }
}