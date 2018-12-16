namespace food_Delivery_v_0._0.User_Controls
{
    partial class record_forall
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gen_lbl = new System.Windows.Forms.Label();
            this.ph_lbl = new System.Windows.Forms.Label();
            this.full_lbl = new System.Windows.Forms.Label();
            this.usern_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 14);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fire";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gen_lbl
            // 
            this.gen_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_lbl.Location = new System.Drawing.Point(573, 3);
            this.gen_lbl.Name = "gen_lbl";
            this.gen_lbl.Size = new System.Drawing.Size(100, 30);
            this.gen_lbl.TabIndex = 10;
            this.gen_lbl.Text = "Gender";
            this.gen_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ph_lbl
            // 
            this.ph_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph_lbl.Location = new System.Drawing.Point(456, 3);
            this.ph_lbl.Name = "ph_lbl";
            this.ph_lbl.Size = new System.Drawing.Size(110, 30);
            this.ph_lbl.TabIndex = 9;
            this.ph_lbl.Text = "phone";
            this.ph_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // full_lbl
            // 
            this.full_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_lbl.Location = new System.Drawing.Point(180, 3);
            this.full_lbl.Name = "full_lbl";
            this.full_lbl.Size = new System.Drawing.Size(270, 30);
            this.full_lbl.TabIndex = 8;
            this.full_lbl.Text = "Fullname";
            this.full_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usern_lbl
            // 
            this.usern_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usern_lbl.Location = new System.Drawing.Point(3, 3);
            this.usern_lbl.Name = "usern_lbl";
            this.usern_lbl.Size = new System.Drawing.Size(171, 30);
            this.usern_lbl.TabIndex = 7;
            this.usern_lbl.Text = "username";
            this.usern_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // record_forall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gen_lbl);
            this.Controls.Add(this.ph_lbl);
            this.Controls.Add(this.full_lbl);
            this.Controls.Add(this.usern_lbl);
            this.Name = "record_forall";
            this.Size = new System.Drawing.Size(823, 51);
            this.Load += new System.EventHandler(this.record_forall_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label gen_lbl;
        private System.Windows.Forms.Label ph_lbl;
        private System.Windows.Forms.Label full_lbl;
        private System.Windows.Forms.Label usern_lbl;
    }
}
