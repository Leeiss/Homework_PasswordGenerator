using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HomeWork__PasswordGenerator
{
    public partial class MainForm : Form
    {
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Numbers = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()_+-=[]{}|;:,./?><";
        private readonly RandomNumberGenerator Rng = RandomNumberGenerator.Create();

        private string[] _wordList;

        public MainForm()
        {
            InitializeComponent();
            _wordList = ReadWordListFromFile("C:\\Users\\farra\\source\\repos\\HomeWork__PasswordGenerator\\HomeWork__PasswordGenerator\\rockyou.txt")
               .Select(word => word.ToLower())
               .ToArray();
        }
       
        private void generate_btn_Click(object sender, EventArgs e)
        {
            generate_panel.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            int formWidth = generate_panel.Location.X + generate_panel.Width;
            int formHeight = generate_panel.Location.Y + generate_panel.Height; 
            this.ClientSize = new Size(formWidth, formHeight); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            show_btn.Visible = true;
            copy_btn.Visible = true;
            save_btn.Visible = true;
            passwordBox.Visible = true;

            var length = (int)lengthUpDown.Value;
            var includeLowercase = lowerCheckBox.Checked;
            var includeUppercase = upperCheckBox.Checked;
            var includeNumbers = numberCheckBox.Checked;
            var includeSpecialCharacters = alphanumCheckBox.Checked;

            var characterPool = string.Empty;

            if (includeLowercase)
                characterPool += LowercaseLetters;
            if (includeUppercase)
                characterPool += UppercaseLetters;
            if (includeNumbers)
                characterPool += Numbers;
            if (includeSpecialCharacters)
                characterPool += SpecialCharacters;

            if (similarCheckBox.Checked)
                characterPool = RemoveSimilarCharacters(characterPool);
            if (ambiguousCheckBox.Checked)
                characterPool = RemoveAmbiguousCharacters(characterPool);

            var password = GeneratePassword(length, characterPool);

            while (_wordList.Contains(password))
                password = GeneratePassword(length, characterPool);

            passwordBox.Text = password;
        }

        private string[] ReadWordListFromFile(string fileName)
        {
            return File.ReadAllLines(@"C:\Users\farra\source\repos\HomeWork__PasswordGenerator\HomeWork__PasswordGenerator\rockyou.txt");
        }

        private string RemoveSimilarCharacters(string input)
        {
            return new string(input
                .Where(c => !new[] { 'i', 'I', 'l', 'L', '1', 'o', 'O', '0' }.Contains(c))
                .ToArray());
        }

        private string RemoveAmbiguousCharacters(string input)
        {
            return new string(input
                .Where(c => !new[] { '{', '}', '[', ']', '(', ')', '/', '\\', '\'', '\"', '`', ',', ';', ':', '.', '<', '>' }.Contains(c))
                .ToArray());
        }

        private string GeneratePassword(int length, string characterPool)
        {
            var password = new char[length];
            var bytes = new byte[length];

            Rng.GetBytes(bytes);

            for (var i = 0; i < length; i++)
            {
                try
                {
                    var characterIndex = bytes[i] % characterPool.Length;
                    password[i] = characterPool[characterIndex];
                }
                catch
                {
                    MessageBox.Show("Выберите что-то помимо этой характеристики");
                }
            }

            return new string(password);
        }
    

    private void copy_btn_Click(object sender, EventArgs e)
        {
            copyLabel.Visible = true;
            var timer = new Timer { Interval = 500 };
            timer.Tick += (s, args) =>
            {
                copyLabel.Visible = false;
                timer.Stop();
            };
            timer.Start();
            

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
        }
    }
}
