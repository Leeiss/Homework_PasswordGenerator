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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generate_btn = new System.Windows.Forms.Button();
            this.generate_panel = new System.Windows.Forms.Panel();
            this.show_btn = new System.Windows.Forms.PictureBox();
            this.save_password_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.PictureBox();
            this.copy_btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.copyLabel = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.alphanumCheckBox = new System.Windows.Forms.CheckBox();
            this.ambiguousCheckBox = new System.Windows.Forms.CheckBox();
            this.similarCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.hide_btn = new System.Windows.Forms.PictureBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordUserBox = new System.Windows.Forms.TextBox();
            this.registartionBtn = new System.Windows.Forms.Label();
            this.registrateBtn = new System.Windows.Forms.Button();
            this.newUserPasswordBox = new System.Windows.Forms.TextBox();
            this.labelLogin1 = new System.Windows.Forms.Label();
            this.newUserLoginBox = new System.Windows.Forms.TextBox();
            this.generarionForNewUserBtn = new System.Windows.Forms.Label();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.show_btn1 = new System.Windows.Forms.PictureBox();
            this.hide_btn1 = new System.Windows.Forms.PictureBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.hintBox = new System.Windows.Forms.RichTextBox();
            this.back_btn1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            this.generate_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_picture
            // 
            this.logo_picture.Image = ((System.Drawing.Image)(resources.GetObject("logo_picture.Image")));
            this.logo_picture.Location = new System.Drawing.Point(304, -32);
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.Size = new System.Drawing.Size(937, 553);
            this.logo_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_picture.TabIndex = 0;
            this.logo_picture.TabStop = false;
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
            this.generate_btn.Location = new System.Drawing.Point(524, 847);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(490, 125);
            this.generate_btn.TabIndex = 2;
            this.generate_btn.Text = "Go to generation";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // generate_panel
            // 
            this.generate_panel.Controls.Add(this.hintBox);
            this.generate_panel.Controls.Add(this.labelHint);
            this.generate_panel.Controls.Add(this.show_btn);
            this.generate_panel.Controls.Add(this.save_password_btn);
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
            this.generate_panel.Controls.Add(this.hide_btn);
            this.generate_panel.Location = new System.Drawing.Point(0, 410);
            this.generate_panel.Name = "generate_panel";
            this.generate_panel.Size = new System.Drawing.Size(1524, 930);
            this.generate_panel.TabIndex = 3;
            this.generate_panel.Visible = false;
            // 
            // show_btn
            // 
            this.show_btn.Image = global::HomeWork__PasswordGenerator.Properties.Resources.ракрыть;
            this.show_btn.Location = new System.Drawing.Point(1098, 635);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(63, 54);
            this.show_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_btn.TabIndex = 45;
            this.show_btn.TabStop = false;
            this.show_btn.Visible = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click_1);
            // 
            // save_password_btn
            // 
            this.save_password_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.save_password_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_password_btn.FlatAppearance.BorderSize = 0;
            this.save_password_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_password_btn.Font = new System.Drawing.Font("XO Courser", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_password_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save_password_btn.Location = new System.Drawing.Point(556, 840);
            this.save_password_btn.Name = "save_password_btn";
            this.save_password_btn.Size = new System.Drawing.Size(407, 63);
            this.save_password_btn.TabIndex = 44;
            this.save_password_btn.Text = "Использовать пароль";
            this.save_password_btn.UseVisualStyleBackColor = false;
            this.save_password_btn.Visible = false;
            this.save_password_btn.Click += new System.EventHandler(this.save_password_btn_Click);
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
            this.hints.SetToolTip(this.save_btn, "Сохранить пароль");
            this.save_btn.Visible = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
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
            this.hints.SetToolTip(this.copy_btn, "Скопировать");
            this.copy_btn.Visible = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(379, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 445);
            this.panel2.TabIndex = 2;
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Font = new System.Drawing.Font("XO Thames", 9F);
            this.copyLabel.ForeColor = System.Drawing.Color.Green;
            this.copyLabel.Location = new System.Drawing.Point(346, 596);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(157, 27);
            this.copyLabel.TabIndex = 35;
            this.copyLabel.Text = "Скопировано!";
            this.copyLabel.Visible = false;
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
            // hide_btn
            // 
            this.hide_btn.Image = global::HomeWork__PasswordGenerator.Properties.Resources.скрыть;
            this.hide_btn.Location = new System.Drawing.Point(1098, 635);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(63, 54);
            this.hide_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_btn.TabIndex = 36;
            this.hide_btn.TabStop = false;
            this.hide_btn.Visible = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click_1);
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.loginBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(489, 527);
            this.loginBox.MaxLength = 1000;
            this.loginBox.MinimumSize = new System.Drawing.Size(365, 29);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(588, 44);
            this.loginBox.TabIndex = 35;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("XO Thames", 10F);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelLogin.Location = new System.Drawing.Point(728, 586);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 31);
            this.labelLogin.TabIndex = 39;
            this.labelLogin.Text = "логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("XO Thames", 10F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelPassword.Location = new System.Drawing.Point(728, 698);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 31);
            this.labelPassword.TabIndex = 41;
            this.labelPassword.Text = "пароль";
            // 
            // passwordUserBox
            // 
            this.passwordUserBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordUserBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.passwordUserBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordUserBox.Location = new System.Drawing.Point(502, 640);
            this.passwordUserBox.MaxLength = 1000;
            this.passwordUserBox.MinimumSize = new System.Drawing.Size(365, 29);
            this.passwordUserBox.Name = "passwordUserBox";
            this.passwordUserBox.Size = new System.Drawing.Size(575, 44);
            this.passwordUserBox.TabIndex = 40;
            this.passwordUserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordUserBox.UseSystemPasswordChar = true;
            // 
            // registartionBtn
            // 
            this.registartionBtn.AutoSize = true;
            this.registartionBtn.Font = new System.Drawing.Font("XO Thames", 10.125F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registartionBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.registartionBtn.Location = new System.Drawing.Point(637, 975);
            this.registartionBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registartionBtn.Name = "registartionBtn";
            this.registartionBtn.Size = new System.Drawing.Size(244, 31);
            this.registartionBtn.TabIndex = 42;
            this.registartionBtn.Text = "Зарегистрироваться";
            this.registartionBtn.Click += new System.EventHandler(this.registartionBtn_Click);
            this.registartionBtn.MouseEnter += new System.EventHandler(this.registartionBtn_MouseEnter);
            this.registartionBtn.MouseLeave += new System.EventHandler(this.registartionBtn_MouseLeave);
            // 
            // registrateBtn
            // 
            this.registrateBtn.BackColor = System.Drawing.Color.Transparent;
            this.registrateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registrateBtn.BackgroundImage")));
            this.registrateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrateBtn.FlatAppearance.BorderSize = 0;
            this.registrateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrateBtn.Font = new System.Drawing.Font("XO Courser", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.registrateBtn.Location = new System.Drawing.Point(598, 757);
            this.registrateBtn.Name = "registrateBtn";
            this.registrateBtn.Size = new System.Drawing.Size(365, 46);
            this.registrateBtn.TabIndex = 43;
            this.registrateBtn.Text = "Зарегистрироваться ";
            this.registrateBtn.UseVisualStyleBackColor = false;
            this.registrateBtn.Visible = false;
            this.registrateBtn.Click += new System.EventHandler(this.registrateBtn_Click);
            // 
            // newUserPasswordBox
            // 
            this.newUserPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserPasswordBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.newUserPasswordBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserPasswordBox.Location = new System.Drawing.Point(502, 640);
            this.newUserPasswordBox.MaxLength = 1000;
            this.newUserPasswordBox.MinimumSize = new System.Drawing.Size(365, 29);
            this.newUserPasswordBox.Name = "newUserPasswordBox";
            this.newUserPasswordBox.ReadOnly = true;
            this.newUserPasswordBox.Size = new System.Drawing.Size(575, 44);
            this.newUserPasswordBox.TabIndex = 46;
            this.newUserPasswordBox.TabStop = false;
            this.newUserPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newUserPasswordBox.UseSystemPasswordChar = true;
            this.newUserPasswordBox.Visible = false;
            this.newUserPasswordBox.Click += new System.EventHandler(this.newUserPasswordBox_Click);
            // 
            // labelLogin1
            // 
            this.labelLogin1.AutoSize = true;
            this.labelLogin1.Font = new System.Drawing.Font("XO Thames", 10F);
            this.labelLogin1.ForeColor = System.Drawing.Color.DarkGray;
            this.labelLogin1.Location = new System.Drawing.Point(728, 586);
            this.labelLogin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin1.Name = "labelLogin1";
            this.labelLogin1.Size = new System.Drawing.Size(80, 31);
            this.labelLogin1.TabIndex = 45;
            this.labelLogin1.Text = "логин";
            this.labelLogin1.Visible = false;
            // 
            // newUserLoginBox
            // 
            this.newUserLoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserLoginBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.newUserLoginBox.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserLoginBox.Location = new System.Drawing.Point(489, 527);
            this.newUserLoginBox.MaxLength = 1000;
            this.newUserLoginBox.MinimumSize = new System.Drawing.Size(365, 29);
            this.newUserLoginBox.Name = "newUserLoginBox";
            this.newUserLoginBox.Size = new System.Drawing.Size(588, 44);
            this.newUserLoginBox.TabIndex = 44;
            this.newUserLoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newUserLoginBox.Visible = false;
            // 
            // generarionForNewUserBtn
            // 
            this.generarionForNewUserBtn.AutoSize = true;
            this.generarionForNewUserBtn.Font = new System.Drawing.Font("XO Thames", 10.125F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generarionForNewUserBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.generarionForNewUserBtn.Location = new System.Drawing.Point(637, 698);
            this.generarionForNewUserBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generarionForNewUserBtn.Name = "generarionForNewUserBtn";
            this.generarionForNewUserBtn.Size = new System.Drawing.Size(272, 31);
            this.generarionForNewUserBtn.TabIndex = 48;
            this.generarionForNewUserBtn.Text = "Сгенерировать пароль";
            this.generarionForNewUserBtn.Visible = false;
            this.generarionForNewUserBtn.Click += new System.EventHandler(this.generarionForNewUserBtn_Click);
            this.generarionForNewUserBtn.MouseEnter += new System.EventHandler(this.generarionForNewUserBtn_MouseEnter);
            this.generarionForNewUserBtn.MouseLeave += new System.EventHandler(this.generarionForNewUserBtn_MouseLeave);
            // 
            // back_btn
            // 
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(12, 37);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(62, 51);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 45;
            this.back_btn.TabStop = false;
            this.hints.SetToolTip(this.back_btn, "Выйти");
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            this.back_btn.MouseEnter += new System.EventHandler(this.back_btn_MouseEnter);
            this.back_btn.MouseLeave += new System.EventHandler(this.back_btn_MouseLeave);
            // 
            // show_btn1
            // 
            this.show_btn1.Image = global::HomeWork__PasswordGenerator.Properties.Resources.ракрыть;
            this.show_btn1.Location = new System.Drawing.Point(1098, 640);
            this.show_btn1.Name = "show_btn1";
            this.show_btn1.Size = new System.Drawing.Size(63, 54);
            this.show_btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_btn1.TabIndex = 50;
            this.show_btn1.TabStop = false;
            this.show_btn1.Visible = false;
            this.show_btn1.Click += new System.EventHandler(this.show_btn1_Click);
            // 
            // hide_btn1
            // 
            this.hide_btn1.Image = global::HomeWork__PasswordGenerator.Properties.Resources.скрыть;
            this.hide_btn1.Location = new System.Drawing.Point(1098, 640);
            this.hide_btn1.Name = "hide_btn1";
            this.hide_btn1.Size = new System.Drawing.Size(63, 54);
            this.hide_btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_btn1.TabIndex = 49;
            this.hide_btn1.TabStop = false;
            this.hide_btn1.Click += new System.EventHandler(this.hide_btn1_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("XO Thames", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHint.Location = new System.Drawing.Point(345, 698);
            this.labelHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(491, 36);
            this.labelHint.TabIndex = 46;
            this.labelHint.Text = "Подсказка для запомниная пароля:";
            this.labelHint.Visible = false;
            // 
            // hintBox
            // 
            this.hintBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hintBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintBox.Font = new System.Drawing.Font("XO Thames", 12F);
            this.hintBox.Location = new System.Drawing.Point(416, 737);
            this.hintBox.Name = "hintBox";
            this.hintBox.ReadOnly = true;
            this.hintBox.Size = new System.Drawing.Size(805, 86);
            this.hintBox.TabIndex = 47;
            this.hintBox.TabStop = false;
            this.hintBox.Text = "";
            this.hintBox.Visible = false;
            // 
            // back_btn1
            // 
            this.back_btn1.Image = ((System.Drawing.Image)(resources.GetObject("back_btn1.Image")));
            this.back_btn1.Location = new System.Drawing.Point(12, 37);
            this.back_btn1.Name = "back_btn1";
            this.back_btn1.Size = new System.Drawing.Size(62, 51);
            this.back_btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn1.TabIndex = 51;
            this.back_btn1.TabStop = false;
            this.hints.SetToolTip(this.back_btn1, "Выйти");
            this.back_btn1.Visible = false;
            this.back_btn1.Click += new System.EventHandler(this.back_btn1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1523, 1341);
            this.Controls.Add(this.back_btn1);
            this.Controls.Add(this.generate_panel);
            this.Controls.Add(this.show_btn1);
            this.Controls.Add(this.hide_btn1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newUserLoginBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.generarionForNewUserBtn);
            this.Controls.Add(this.labelLogin1);
            this.Controls.Add(this.registrateBtn);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.registartionBtn);
            this.Controls.Add(this.newUserPasswordBox);
            this.Controls.Add(this.passwordUserBox);
            this.Controls.Add(this.logo_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            this.generate_panel.ResumeLayout(false);
            this.generate_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_picture;
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
        private System.Windows.Forms.PictureBox hide_btn;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox passwordUserBox;
        private System.Windows.Forms.Label registartionBtn;
        private System.Windows.Forms.Button registrateBtn;
        private System.Windows.Forms.TextBox newUserPasswordBox;
        private System.Windows.Forms.Label labelLogin1;
        private System.Windows.Forms.TextBox newUserLoginBox;
        private System.Windows.Forms.Label generarionForNewUserBtn;
        private System.Windows.Forms.Button save_password_btn;
        private System.Windows.Forms.PictureBox copy_btn;
        private System.Windows.Forms.ToolTip hints;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox show_btn;
        private System.Windows.Forms.PictureBox show_btn1;
        private System.Windows.Forms.PictureBox hide_btn1;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.RichTextBox hintBox;
        private System.Windows.Forms.PictureBox back_btn1;
    }
}

