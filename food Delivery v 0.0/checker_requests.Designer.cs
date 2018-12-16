namespace food_Delivery_v_0._0
{
    partial class checker_requests
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
            this.mealname_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mealname_lbl
            // 
            this.mealname_lbl.AutoSize = true;
            this.mealname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealname_lbl.Location = new System.Drawing.Point(15, 0);
            this.mealname_lbl.Name = "mealname_lbl";
            this.mealname_lbl.Size = new System.Drawing.Size(93, 18);
            this.mealname_lbl.TabIndex = 0;
            this.mealname_lbl.Text = "Meal Name";
            this.mealname_lbl.Click += new System.EventHandler(this.mealname_lbl_Click);
            // 
            // checker_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mealname_lbl);
            this.Name = "checker_requests";
            this.Size = new System.Drawing.Size(153, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label mealname_lbl;
    }
}
