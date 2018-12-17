namespace food_Delivery_v_0._0
{
    partial class Cook_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cook_Menu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new GradientPanelDemo.GradientPanel();
            this.UpdateMenu_lbl = new System.Windows.Forms.Label();
            this.DeleteMeal_lbl = new System.Windows.Forms.Label();
            this.EditMeal_lbl = new System.Windows.Forms.Label();
            this.AddMeal_lbl = new System.Windows.Forms.Label();
            this.Panel_Menu = new GradientPanelDemo.GradientPanel();
            this.Menu_lbl = new System.Windows.Forms.Label();
            this.BackBt = new RoundButtonDemo.CircularButton();
            this.UpdateMeal_bt = new food_Delivery_v_0._0.CustomImageButton();
            this.Delete_bt = new food_Delivery_v_0._0.CustomImageButton();
            this.Edit_bt = new food_Delivery_v_0._0.CustomImageButton();
            this.Add_bt = new food_Delivery_v_0._0.CustomImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateMeal_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_bt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_bt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(15, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(885, 557);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Chocolate;
            this.gradientPanel1.ColorTop = System.Drawing.Color.SaddleBrown;
            this.gradientPanel1.Controls.Add(this.BackBt);
            this.gradientPanel1.Controls.Add(this.UpdateMenu_lbl);
            this.gradientPanel1.Controls.Add(this.UpdateMeal_bt);
            this.gradientPanel1.Controls.Add(this.DeleteMeal_lbl);
            this.gradientPanel1.Controls.Add(this.Delete_bt);
            this.gradientPanel1.Controls.Add(this.EditMeal_lbl);
            this.gradientPanel1.Controls.Add(this.Edit_bt);
            this.gradientPanel1.Controls.Add(this.AddMeal_lbl);
            this.gradientPanel1.Controls.Add(this.Add_bt);
            this.gradientPanel1.Location = new System.Drawing.Point(909, 58);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(314, 557);
            this.gradientPanel1.TabIndex = 23;
            // 
            // UpdateMenu_lbl
            // 
            this.UpdateMenu_lbl.AutoSize = true;
            this.UpdateMenu_lbl.BackColor = System.Drawing.Color.Transparent;
            this.UpdateMenu_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMenu_lbl.Location = new System.Drawing.Point(68, 18);
            this.UpdateMenu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateMenu_lbl.Name = "UpdateMenu_lbl";
            this.UpdateMenu_lbl.Size = new System.Drawing.Size(165, 27);
            this.UpdateMenu_lbl.TabIndex = 29;
            this.UpdateMenu_lbl.Text = "Update menu";
            this.UpdateMenu_lbl.Click += new System.EventHandler(this.UpdateMenu_lbl_Click);
            this.UpdateMenu_lbl.MouseEnter += new System.EventHandler(this.UpdateMenu_lbl_MouseEnter);
            this.UpdateMenu_lbl.MouseLeave += new System.EventHandler(this.UpdateMenu_lbl_MouseLeave);
            // 
            // DeleteMeal_lbl
            // 
            this.DeleteMeal_lbl.AutoSize = true;
            this.DeleteMeal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.DeleteMeal_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMeal_lbl.Location = new System.Drawing.Point(68, 212);
            this.DeleteMeal_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteMeal_lbl.Name = "DeleteMeal_lbl";
            this.DeleteMeal_lbl.Size = new System.Drawing.Size(150, 27);
            this.DeleteMeal_lbl.TabIndex = 27;
            this.DeleteMeal_lbl.Text = "Delete meal";
            this.DeleteMeal_lbl.Click += new System.EventHandler(this.DeleteMeal_lbl_Click);
            this.DeleteMeal_lbl.MouseEnter += new System.EventHandler(this.DeleteMeal_lbl_MouseEnter);
            this.DeleteMeal_lbl.MouseLeave += new System.EventHandler(this.DeleteMeal_lbl_MouseLeave);
            // 
            // EditMeal_lbl
            // 
            this.EditMeal_lbl.AutoSize = true;
            this.EditMeal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.EditMeal_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMeal_lbl.Location = new System.Drawing.Point(68, 148);
            this.EditMeal_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditMeal_lbl.Name = "EditMeal_lbl";
            this.EditMeal_lbl.Size = new System.Drawing.Size(116, 27);
            this.EditMeal_lbl.TabIndex = 25;
            this.EditMeal_lbl.Text = "Edit meal";
            this.EditMeal_lbl.Click += new System.EventHandler(this.EditMeal_lbl_Click);
            this.EditMeal_lbl.MouseEnter += new System.EventHandler(this.EditMeal_lbl_MouseEnter);
            this.EditMeal_lbl.MouseLeave += new System.EventHandler(this.EditMeal_lbl_MouseLeave);
            // 
            // AddMeal_lbl
            // 
            this.AddMeal_lbl.AutoSize = true;
            this.AddMeal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.AddMeal_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMeal_lbl.Location = new System.Drawing.Point(68, 83);
            this.AddMeal_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddMeal_lbl.Name = "AddMeal_lbl";
            this.AddMeal_lbl.Size = new System.Drawing.Size(123, 27);
            this.AddMeal_lbl.TabIndex = 23;
            this.AddMeal_lbl.Text = "Add meal";
            this.AddMeal_lbl.Click += new System.EventHandler(this.AddMeal_lbl_Click);
            this.AddMeal_lbl.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.AddMeal_lbl.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.ColorBottom = System.Drawing.Color.Chocolate;
            this.Panel_Menu.ColorTop = System.Drawing.Color.SaddleBrown;
            this.Panel_Menu.Controls.Add(this.Menu_lbl);
            this.Panel_Menu.Location = new System.Drawing.Point(15, 6);
            this.Panel_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(1208, 43);
            this.Panel_Menu.TabIndex = 21;
            // 
            // Menu_lbl
            // 
            this.Menu_lbl.AutoSize = true;
            this.Menu_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_lbl.Location = new System.Drawing.Point(14, 8);
            this.Menu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu_lbl.Name = "Menu_lbl";
            this.Menu_lbl.Size = new System.Drawing.Size(76, 27);
            this.Menu_lbl.TabIndex = 22;
            this.Menu_lbl.Text = "Menu";
            // 
            // BackBt
            // 
            this.BackBt.BackColor = System.Drawing.Color.Sienna;
            this.BackBt.FlatAppearance.BorderSize = 0;
            this.BackBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBt.Image = ((System.Drawing.Image)(resources.GetObject("BackBt.Image")));
            this.BackBt.Location = new System.Drawing.Point(226, 474);
            this.BackBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBt.Name = "BackBt";
            this.BackBt.Size = new System.Drawing.Size(75, 69);
            this.BackBt.TabIndex = 34;
            this.BackBt.UseVisualStyleBackColor = false;
            this.BackBt.Click += new System.EventHandler(this.BackBt_Click);
            // 
            // UpdateMeal_bt
            // 
            this.UpdateMeal_bt.BackColor = System.Drawing.Color.Transparent;
            this.UpdateMeal_bt.Image = ((System.Drawing.Image)(resources.GetObject("UpdateMeal_bt.Image")));
            this.UpdateMeal_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("UpdateMeal_bt.ImageHover")));
            this.UpdateMeal_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("UpdateMeal_bt.ImageNormal")));
            this.UpdateMeal_bt.Location = new System.Drawing.Point(4, 5);
            this.UpdateMeal_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateMeal_bt.Name = "UpdateMeal_bt";
            this.UpdateMeal_bt.Size = new System.Drawing.Size(54, 55);
            this.UpdateMeal_bt.TabIndex = 28;
            this.UpdateMeal_bt.TabStop = false;
            // 
            // Delete_bt
            // 
            this.Delete_bt.BackColor = System.Drawing.Color.Transparent;
            this.Delete_bt.Image = ((System.Drawing.Image)(resources.GetObject("Delete_bt.Image")));
            this.Delete_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Delete_bt.ImageHover")));
            this.Delete_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Delete_bt.ImageNormal")));
            this.Delete_bt.Location = new System.Drawing.Point(4, 198);
            this.Delete_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(54, 55);
            this.Delete_bt.TabIndex = 26;
            this.Delete_bt.TabStop = false;
            // 
            // Edit_bt
            // 
            this.Edit_bt.BackColor = System.Drawing.Color.Transparent;
            this.Edit_bt.Image = ((System.Drawing.Image)(resources.GetObject("Edit_bt.Image")));
            this.Edit_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Edit_bt.ImageHover")));
            this.Edit_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Edit_bt.ImageNormal")));
            this.Edit_bt.Location = new System.Drawing.Point(4, 134);
            this.Edit_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.Size = new System.Drawing.Size(54, 55);
            this.Edit_bt.TabIndex = 24;
            this.Edit_bt.TabStop = false;
            // 
            // Add_bt
            // 
            this.Add_bt.BackColor = System.Drawing.Color.Transparent;
            this.Add_bt.Image = ((System.Drawing.Image)(resources.GetObject("Add_bt.Image")));
            this.Add_bt.ImageHover = ((System.Drawing.Image)(resources.GetObject("Add_bt.ImageHover")));
            this.Add_bt.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Add_bt.ImageNormal")));
            this.Add_bt.Location = new System.Drawing.Point(4, 69);
            this.Add_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_bt.Name = "Add_bt";
            this.Add_bt.Size = new System.Drawing.Size(54, 55);
            this.Add_bt.TabIndex = 7;
            this.Add_bt.TabStop = false;
            // 
            // Cook_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.Panel_Menu);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cook_Menu";
            this.Size = new System.Drawing.Size(1227, 632);
            this.Load += new System.EventHandler(this.Cook_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateMeal_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_bt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_bt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanelDemo.GradientPanel Panel_Menu;
        private System.Windows.Forms.Label Menu_lbl;
        private GradientPanelDemo.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label AddMeal_lbl;
        private CustomImageButton Add_bt;
        private System.Windows.Forms.Label DeleteMeal_lbl;
        private CustomImageButton Delete_bt;
        private System.Windows.Forms.Label EditMeal_lbl;
        private CustomImageButton Edit_bt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UpdateMenu_lbl;
        private CustomImageButton UpdateMeal_bt;
        private RoundButtonDemo.CircularButton BackBt;
    }
}
