namespace fabrika.face
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.log1 = new System.Windows.Forms.TextBox();
            this.log2 = new System.Windows.Forms.TextBox();
            this.but1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المستخدم :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "كلمة المرور:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 75);
            this.label3.TabIndex = 7;
            this.label3.Text = "فابريكا السلطان";
            // 
            // log1
            // 
            this.log1.AcceptsReturn = true;
            this.log1.AcceptsTab = true;
            this.log1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.log1.AllowDrop = true;
            this.log1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.log1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.log1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log1.Location = new System.Drawing.Point(200, 203);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(220, 25);
            this.log1.TabIndex = 8;
            this.log1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.log1_KeyDown);
            // 
            // log2
            // 
            this.log2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log2.Location = new System.Drawing.Point(200, 253);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(220, 25);
            this.log2.TabIndex = 9;
            this.log2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.log2_KeyDown);
            // 
            // but1
            // 
            this.but1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Appearance.Options.UseFont = true;
            this.but1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("but1.ImageOptions.Image")));
            this.but1.Location = new System.Drawing.Point(253, 303);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(111, 54);
            this.but1.TabIndex = 4;
            this.but1.Text = "دخول";
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // login
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(533, 396);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.log1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.InactiveGlowColor = System.Drawing.Color.Blue;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox log1;
        private System.Windows.Forms.TextBox log2;
        private DevExpress.XtraEditors.SimpleButton but1;
    }
}