namespace PersonSerializerWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.age_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.add_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.41079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.58921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 787F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Controls.Add(this.age_label, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.name_label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.surname_label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.name_textBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.surname_textBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.load_button, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.profile_pictureBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.age_numericUpDown, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.51546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.48454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 881F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1333, 1342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.age_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age_label.Location = new System.Drawing.Point(331, 193);
            this.age_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(169, 102);
            this.age_label.TabIndex = 7;
            this.age_label.Text = "Age";
            this.age_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(331, 49);
            this.name_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(169, 73);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surname_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surname_label.Location = new System.Drawing.Point(331, 122);
            this.surname_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(169, 71);
            this.surname_label.TabIndex = 1;
            this.surname_label.Text = "Surname";
            this.surname_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_textBox
            // 
            this.name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textBox.Location = new System.Drawing.Point(512, 62);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(6);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name_textBox.Size = new System.Drawing.Size(775, 46);
            this.name_textBox.TabIndex = 8;
            // 
            // surname_textBox
            // 
            this.surname_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surname_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname_textBox.Location = new System.Drawing.Point(512, 134);
            this.surname_textBox.Margin = new System.Windows.Forms.Padding(6);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(775, 46);
            this.surname_textBox.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.94041F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.05959F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Controls.Add(this.add_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.reset_button, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(506, 338);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 122);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // add_button
            // 
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(6, 6);
            this.add_button.Margin = new System.Windows.Forms.Padding(6);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(381, 110);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_button_MouseClick);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_button.Location = new System.Drawing.Point(399, 6);
            this.reset_button.Margin = new System.Windows.Forms.Padding(6);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(382, 110);
            this.reset_button.TabIndex = 1;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset_button_MouseClick);
            // 
            // load_button
            // 
            this.load_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_button.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.load_button.Location = new System.Drawing.Point(93, 344);
            this.load_button.Margin = new System.Windows.Forms.Padding(56, 6, 56, 26);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(176, 70);
            this.load_button.TabIndex = 13;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.load_button_MouseClick);
            // 
            // profile_pictureBox
            // 
            this.profile_pictureBox.AccessibleName = "";
            this.profile_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_pictureBox.BackgroundImage")));
            this.profile_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profile_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("profile_pictureBox.InitialImage")));
            this.profile_pictureBox.Location = new System.Drawing.Point(43, 55);
            this.profile_pictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.profile_pictureBox.Name = "profile_pictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.profile_pictureBox, 3);
            this.profile_pictureBox.Size = new System.Drawing.Size(276, 234);
            this.profile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pictureBox.TabIndex = 14;
            this.profile_pictureBox.TabStop = false;
            this.profile_pictureBox.Tag = "";
            // 
            // age_numericUpDown
            // 
            this.age_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.age_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age_numericUpDown.Location = new System.Drawing.Point(512, 226);
            this.age_numericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.age_numericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.age_numericUpDown.Name = "age_numericUpDown";
            this.age_numericUpDown.Size = new System.Drawing.Size(775, 35);
            this.age_numericUpDown.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1333, 1342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1278, 1413);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label name_label;
        private Label age_label;
        private Label surname_label;
        private TextBox name_textBox;
        private TextBox surname_textBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button add_button;
        private Button reset_button;
        private Button load_button;
        private PictureBox profile_pictureBox;
        private NumericUpDown age_numericUpDown;
    }
}