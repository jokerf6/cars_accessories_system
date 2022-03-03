namespace fabrika.form
{
    partial class masrr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masrr));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.but3 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.Enabled = false;
            this.dgv1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv1.Location = new System.Drawing.Point(44, 132);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.ShowCellErrors = false;
            this.dgv1.ShowEditingIcon = false;
            this.dgv1.ShowRowErrors = false;
            this.dgv1.Size = new System.Drawing.Size(491, 254);
            this.dgv1.TabIndex = 0;
            // 
            // but3
            // 
            this.but3.Appearance.BackColor = System.Drawing.Color.Linen;
            this.but3.Appearance.BackColor2 = System.Drawing.Color.White;
            this.but3.Appearance.BorderColor = System.Drawing.Color.White;
            this.but3.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.but3.Appearance.Options.UseBackColor = true;
            this.but3.Appearance.Options.UseBorderColor = true;
            this.but3.Appearance.Options.UseFont = true;
            this.but3.Appearance.Options.UseForeColor = true;
            this.but3.AppearanceDisabled.BackColor = System.Drawing.Color.Linen;
            this.but3.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.but3.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.AppearanceDisabled.Options.UseBackColor = true;
            this.but3.AppearanceDisabled.Options.UseFont = true;
            this.but3.AppearanceHovered.BackColor = System.Drawing.Color.Linen;
            this.but3.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.but3.AppearanceHovered.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.but3.AppearanceHovered.Options.UseBackColor = true;
            this.but3.AppearanceHovered.Options.UseFont = true;
            this.but3.AppearanceHovered.Options.UseForeColor = true;
            this.but3.AppearancePressed.BackColor = System.Drawing.Color.Linen;
            this.but3.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.but3.AppearancePressed.Options.UseBackColor = true;
            this.but3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("but3.ImageOptions.Image")));
            this.but3.Location = new System.Drawing.Point(415, 443);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(111, 54);
            this.but3.TabIndex = 15;
            this.but3.Text = "رجوع";
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(205, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "مصروفات اليوم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "0";
            // 
            // masrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.dgv1);
            this.Name = "masrr";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المصروفات";
            this.Load += new System.EventHandler(this.masr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private DevExpress.XtraEditors.SimpleButton but3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}