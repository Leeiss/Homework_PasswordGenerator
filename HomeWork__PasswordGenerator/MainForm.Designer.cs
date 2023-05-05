namespace HomeWork__PasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generate_btn = new System.Windows.Forms.Button();
            this.generate_panel = new System.Windows.Forms.Panel();
            this.copyLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.alphanumCheckBox = new System.Windows.Forms.CheckBox();
            this.ambiguousCheckBox = new System.Windows.Forms.CheckBox();
            this.similarCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.show_btn = new System.Windows.Forms.PictureBox();
            this.copy_btn = new System.Windows.Forms.PictureBox();
            this.save_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.generate_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1591, 19);
            this.panel1.TabIndex = 1;
            // 
            // generate_btn
            // 
            this.generate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.generate_btn.Font = new System.Drawing.Font("Script MT Bold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.Location = new System.Drawing.Point(526, 614);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(437, 125);
            this.generate_btn.TabIndex = 2;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // generate_panel
            // 
            this.generate_panel.Controls.Add(this.save_btn);
            this.generate_panel.Controls.Add(this.copy_btn);
            this.generate_panel.Controls.Add(this.panel2);
            this.generate_panel.Controls.Add(this.copyLabel);
            this.generate_panel.Controls.Add(this.generateBtn);
            this.generate_panel.Controls.Add(this.numberCheckBox);
            this.generate_panel.Controls.Add(this.alphanumCheckBox);
            this.generate_panel.Controls.Add(this.ambiguousCheckBox);
            this.generate_panel.Controls.Add(this.similarCheckBox);
            this.generate_panel.Controls.Add(this.lowerCheckBox);
            this.generate_panel.Controls.Add(this.upperCheckBox);
            this.generate_panel.Controls.Add(this.lengthLabel);
            this.generate_panel.Controls.Add(this.lengthUpDown);
            this.generate_panel.Controls.Add(this.passwordBox);
            this.generate_panel.Controls.Add(this.show_btn);
            this.generate_panel.Location = new System.Drawing.Point(0, 409);
            this.generate_panel.Name = "generate_panel";
            this.generate_panel.Size = new System.Drawing.Size(1524, 856);
            this.generate_panel.TabIndex = 3;
            this.generate_panel.Visible = false;
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Font = new System.Drawing.Font("XO Thames", 9F);
            this.copyLabel.ForeColor = System.Drawing.Color.Green;
            this.copyLabel.Location = new System.Drawing.Point(675, 705);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(157, 27);
            this.copyLabel.TabIndex = 35;
            this.copyLabel.Text = "Скопировано!";
            this.copyLabel.Visible = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(394, 639);
            this.passwordBox.MaxLength = 1000;
            this.passwordBox.MinimumSize = new System.Drawing.Size(365, 29);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(698, 44);
            this.passwordBox.TabIndex = 34;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.Visible = false;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Transparent;
            this.generateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generateBtn.BackgroundImage")));
            this.generateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("XO Courser", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.generateBtn.Location = new System.Drawing.Point(581, 577);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(365, 46);
            this.generateBtn.TabIndex = 33;
            this.generateBtn.Text = "Сгенерировать ";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberCheckBox.Location = new System.Drawing.Point(416, 310);
            this.numberCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Size = new System.Drawing.Size(271, 40);
            this.numberCheckBox.TabIndex = 32;
            this.numberCheckBox.Text = "Включить числа";
            this.numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // alphanumCheckBox
            // 
            this.alphanumCheckBox.AutoSize = true;
            this.alphanumCheckBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphanumCheckBox.Location = new System.Drawing.Point(416, 246);
            this.alphanumCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.alphanumCheckBox.Name = "alphanumCheckBox";
            this.alphanumCheckBox.Size = new System.Drawing.Size(637, 40);
            this.alphanumCheckBox.TabIndex = 31;
            this.alphanumCheckBox.Text = "Включить не буквенно-цифровые символы";
            this.alphanumCheckBox.UseVisualStyleBackColor = true;
            // 
            // ambiguousCheckBox
            // 
            this.ambiguousCheckBox.AutoSize = true;
            this.ambiguousCheckBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambiguousCheckBox.Location = new System.Drawing.Point(416, 440);
            this.ambiguousCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ambiguousCheckBox.Name = "ambiguousCheckBox";
            this.ambiguousCheckBox.Size = new System.Drawing.Size(547, 76);
            this.ambiguousCheckBox.TabIndex = 30;
            this.ambiguousCheckBox.Text = "Исключить неоднозначные символы\r\n( { } [ ] ( ) / \\ \' \" \' ~ , ; : . < > )";
            this.ambiguousCheckBox.UseVisualStyleBackColor = true;
            // 
            // similarCheckBox
            // 
            this.similarCheckBox.AutoSize = true;
            this.similarCheckBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.similarCheckBox.Location = new System.Drawing.Point(416, 377);
            this.similarCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.similarCheckBox.Name = "similarCheckBox";
            this.similarCheckBox.Size = new System.Drawing.Size(707, 40);
            this.similarCheckBox.TabIndex = 29;
            this.similarCheckBox.Text = "Исключить подобные символы (i, l, 1, L, o, 0, O)\r\n";
            this.similarCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowerCheckBox
            // 
            this.lowerCheckBox.AutoSize = true;
            this.lowerCheckBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowerCheckBox.Location = new System.Drawing.Point(416, 184);
            this.lowerCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowerCheckBox.Name = "lowerCheckBox";
            this.lowerCheckBox.Size = new System.Drawing.Size(416, 40);
            this.lowerCheckBox.TabIndex = 28;
            this.lowerCheckBox.Text = "Включить строчные буквы";
            this.lowerCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCheckBox
            // 
            this.upperCheckBox.AutoSize = true;
            this.upperCheckBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upperCheckBox.Location = new System.Drawing.Point(416, 130);
            this.upperCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.upperCheckBox.Name = "upperCheckBox";
            this.upperCheckBox.Size = new System.Drawing.Size(437, 40);
            this.upperCheckBox.TabIndex = 27;
            this.upperCheckBox.Text = "Включить прописные буквы";
            this.upperCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.Location = new System.Drawing.Point(451, 71);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(110, 36);
            this.lengthLabel.TabIndex = 26;
            this.lengthLabel.Text = "Длина:";
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthUpDown.Location = new System.Drawing.Point(603, 69);
            this.lengthUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.lengthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lengthUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(173, 44);
            this.lengthUpDown.TabIndex = 25;
            this.lengthUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(379, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 445);
            this.panel2.TabIndex = 2;
            // 
            // show_btn
            // 
            this.show_btn.Image = ((System.Drawing.Image)(resources.GetObject("show_btn.Image")));
            this.show_btn.Location = new System.Drawing.Point(1098, 635);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(63, 54);
            this.show_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_btn.TabIndex = 36;
            this.show_btn.TabStop = false;
            this.show_btn.Visible = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.Image = ((System.Drawing.Image)(resources.GetObject("copy_btn.Image")));
            this.copy_btn.Location = new System.Drawing.Point(351, 639);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(37, 45);
            this.copy_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copy_btn.TabIndex = 37;
            this.copy_btn.TabStop = false;
            this.copy_btn.Visible = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.Location = new System.Drawing.Point(1167, 639);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(53, 44);
            this.save_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save_btn.TabIndex = 38;
            this.save_btn.TabStop = false;
            this.save_btn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1523, 1259);
            this.Controls.Add(this.generate_panel);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.generate_panel.ResumeLayout(false);
            this.generate_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Panel generate_panel;
        private System.Windows.Forms.Label copyLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.CheckBox alphanumCheckBox;
        private System.Windows.Forms.CheckBox ambiguousCheckBox;
        private System.Windows.Forms.CheckBox similarCheckBox;
        private System.Windows.Forms.CheckBox lowerCheckBox;
        private System.Windows.Forms.CheckBox upperCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox save_btn;
        private System.Windows.Forms.PictureBox copy_btn;
        private System.Windows.Forms.PictureBox show_btn;
    }
}

