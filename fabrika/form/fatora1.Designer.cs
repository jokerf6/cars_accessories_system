namespace fabrika.face
{
    partial class fatora1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fatora1));
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dvg4 = new System.Windows.Forms.DataGridView();
            this.but3 = new DevExpress.XtraEditors.SimpleButton();
            this.f5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.f6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.f4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.TextBox();
            this.fk = new System.Windows.Forms.TextBox();
            this.start3 = new DevExpress.XtraEditors.SimpleButton();
            this.start4 = new DevExpress.XtraEditors.SimpleButton();
            this.start5 = new DevExpress.XtraEditors.SimpleButton();
            this.start2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(711, 63);
            this.date.Name = "date";
            this.date.Properties.Appearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Properties.Appearance.Options.UseFont = true;
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(255, 34);
            this.date.TabIndex = 0;
            this.date.EditValueChanged += new System.EventHandler(this.date_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "التاريخ :";
            // 
            // dvg4
            // 
            this.dvg4.AllowUserToAddRows = false;
            this.dvg4.AllowUserToDeleteRows = false;
            this.dvg4.AllowUserToResizeColumns = false;
            this.dvg4.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvg4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dvg4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg4.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dvg4.Location = new System.Drawing.Point(335, 122);
            this.dvg4.Name = "dvg4";
            this.dvg4.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg4.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg4.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg4.Size = new System.Drawing.Size(912, 386);
            this.dvg4.TabIndex = 4;
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
            this.but3.Location = new System.Drawing.Point(25, 620);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(111, 54);
            this.but3.TabIndex = 12;
            this.but3.Text = "رجوع";
            this.but3.Click += new System.EventHandler(this.but1_Click);
            // 
            // f5
            // 
            this.f5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5.Location = new System.Drawing.Point(470, 538);
            this.f5.Name = "f5";
            this.f5.ReadOnly = true;
            this.f5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f5.Size = new System.Drawing.Size(196, 30);
            this.f5.TabIndex = 106;
            this.f5.Text = "0";
            this.f5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(374, 539);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(93, 29);
            this.label11.TabIndex = 105;
            this.label11.Text = "الاجمالي :";
            // 
            // f6
            // 
            this.f6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f6.Location = new System.Drawing.Point(948, 540);
            this.f6.Name = "f6";
            this.f6.ReadOnly = true;
            this.f6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f6.Size = new System.Drawing.Size(196, 30);
            this.f6.TabIndex = 108;
            this.f6.Text = "0";
            this.f6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(860, 541);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 107;
            this.label2.Text = "الخصم :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.f2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.f4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.f3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.f1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 328);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ملخص اليوم ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(192, 122);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 116;
            this.label6.Text = "الخصم :";
            // 
            // f2
            // 
            this.f2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2.Location = new System.Drawing.Point(19, 119);
            this.f2.Name = "f2";
            this.f2.ReadOnly = true;
            this.f2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f2.Size = new System.Drawing.Size(167, 29);
            this.f2.TabIndex = 117;
            this.f2.Text = "0";
            this.f2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(195, 261);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 114;
            this.label5.Text = "الاجمالي :";
            // 
            // f4
            // 
            this.f4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4.Location = new System.Drawing.Point(19, 258);
            this.f4.Name = "f4";
            this.f4.ReadOnly = true;
            this.f4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f4.Size = new System.Drawing.Size(167, 29);
            this.f4.TabIndex = 115;
            this.f4.Text = "0";
            this.f4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(192, 192);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 112;
            this.label4.Text = "المصروفات :";
            // 
            // f3
            // 
            this.f3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3.Location = new System.Drawing.Point(19, 189);
            this.f3.Name = "f3";
            this.f3.ReadOnly = true;
            this.f3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f3.Size = new System.Drawing.Size(167, 29);
            this.f3.TabIndex = 113;
            this.f3.Text = "0";
            this.f3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(192, 51);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 110;
            this.label3.Text = "عدد الفواتير :";
            // 
            // f1
            // 
            this.f1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.Location = new System.Drawing.Point(19, 48);
            this.f1.Name = "f1";
            this.f1.ReadOnly = true;
            this.f1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f1.Size = new System.Drawing.Size(167, 29);
            this.f1.TabIndex = 111;
            this.f1.Text = "0";
            this.f1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fk
            // 
            this.fk.Enabled = false;
            this.fk.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fk.Location = new System.Drawing.Point(101, 503);
            this.fk.Name = "fk";
            this.fk.ReadOnly = true;
            this.fk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fk.Size = new System.Drawing.Size(196, 30);
            this.fk.TabIndex = 110;
            this.fk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fk.Visible = false;
            // 
            // start3
            // 
            this.start3.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start3.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start3.Appearance.Options.UseBackColor = true;
            this.start3.Appearance.Options.UseFont = true;
            this.start3.AppearanceDisabled.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start3.AppearanceDisabled.Options.UseBackColor = true;
            this.start3.AppearanceHovered.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start3.AppearanceHovered.Options.UseBackColor = true;
            this.start3.AppearancePressed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start3.AppearancePressed.Options.UseBackColor = true;
            this.start3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("start3.ImageOptions.Image")));
            this.start3.Location = new System.Drawing.Point(699, 601);
            this.start3.Name = "start3";
            this.start3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start3.Size = new System.Drawing.Size(95, 42);
            this.start3.TabIndex = 114;
            this.start3.Text = "زيادة";
            this.start3.Click += new System.EventHandler(this.start3_Click);
            // 
            // start4
            // 
            this.start4.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start4.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start4.Appearance.Options.UseBackColor = true;
            this.start4.Appearance.Options.UseFont = true;
            this.start4.AppearanceDisabled.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start4.AppearanceDisabled.Options.UseBackColor = true;
            this.start4.AppearanceHovered.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start4.AppearanceHovered.Options.UseBackColor = true;
            this.start4.AppearancePressed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start4.AppearancePressed.Options.UseBackColor = true;
            this.start4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("start4.ImageOptions.Image")));
            this.start4.Location = new System.Drawing.Point(800, 601);
            this.start4.Name = "start4";
            this.start4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start4.Size = new System.Drawing.Size(95, 42);
            this.start4.TabIndex = 113;
            this.start4.Text = "نقص";
            this.start4.Click += new System.EventHandler(this.start4_Click);
            // 
            // start5
            // 
            this.start5.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start5.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start5.Appearance.Options.UseBackColor = true;
            this.start5.Appearance.Options.UseFont = true;
            this.start5.AppearanceDisabled.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start5.AppearanceDisabled.Options.UseBackColor = true;
            this.start5.AppearanceHovered.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start5.AppearanceHovered.Options.UseBackColor = true;
            this.start5.AppearancePressed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start5.AppearancePressed.Options.UseBackColor = true;
            this.start5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("start5.ImageOptions.Image")));
            this.start5.Location = new System.Drawing.Point(901, 601);
            this.start5.Name = "start5";
            this.start5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start5.Size = new System.Drawing.Size(95, 42);
            this.start5.TabIndex = 112;
            this.start5.Text = "النهاية";
            this.start5.Click += new System.EventHandler(this.start5_Click);
            // 
            // start2
            // 
            this.start2.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start2.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start2.Appearance.Options.UseBackColor = true;
            this.start2.Appearance.Options.UseFont = true;
            this.start2.AppearanceDisabled.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start2.AppearanceDisabled.Options.UseBackColor = true;
            this.start2.AppearanceHovered.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start2.AppearanceHovered.Options.UseBackColor = true;
            this.start2.AppearancePressed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.start2.AppearancePressed.Options.UseBackColor = true;
            this.start2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("start2.ImageOptions.Image")));
            this.start2.Location = new System.Drawing.Point(598, 601);
            this.start2.Name = "start2";
            this.start2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start2.Size = new System.Drawing.Size(95, 42);
            this.start2.TabIndex = 111;
            this.start2.Text = "البداية";
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // fatora1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.start3);
            this.Controls.Add(this.start4);
            this.Controls.Add(this.start5);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.fk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.dvg4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fatora1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "بحث في الفواتير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fatora1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg4;
        private DevExpress.XtraEditors.SimpleButton but3;
        private System.Windows.Forms.TextBox f5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox f6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f3;
        private System.Windows.Forms.TextBox fk;
        private DevExpress.XtraEditors.SimpleButton start3;
        private DevExpress.XtraEditors.SimpleButton start4;
        private DevExpress.XtraEditors.SimpleButton start5;
        private DevExpress.XtraEditors.SimpleButton start2;
    }
}