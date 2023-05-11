using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Runtime.CompilerServices;

namespace HomeWork__PasswordGenerator
{
    public partial class MainForm : Form
    {
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Numbers = "0123456789";
        private string login;
        private const string SpecialCharacters = "!@#$%^&*()_+-=[]{}|;:,./?><";
        private List<string> charLists = new List<string>();
        private readonly RandomNumberGenerator Rng = RandomNumberGenerator.Create();
        private string[] _wordList;
        private string rockyou_path = @".\..\..\rockyou.txt";
        private string usersXmlFile = @".\..\..\Users.xml";

        public MainForm()
        {
            InitializeComponent();
            _wordList = ReadWordListFromFile(rockyou_path)
               .Select(word => word.ToLower())
               .ToArray();
        }
       
        private void generate_btn_Click(object sender, EventArgs e)
        {
            login  = loginBox.Text;
            
            XDocument xDoc = XDocument.Load(usersXmlFile);

            var user = xDoc.Root.Elements("User")
                .SingleOrDefault(u => u.Element("login").Value == loginBox.Text &&
                                      u.Element("password").Value == passwordUserBox.Text);

            if (user != null)
            {
                var dateOfChangeStr = user.Element("dateOfChange").Value;
                var dateOfChange = DateTime.ParseExact(dateOfChangeStr, "dd.MM.yyyy H:mm:ss", null);
                var monthAgo = DateTime.Now.AddMonths(-1);
                if (dateOfChange < monthAgo)
                {
                    MessageBox.Show($"Добро пожаловать в приложение \"Генератор безопасных парлей\"! Вы меняли пароль более месяца назад. \nНеобходимо сменить пароль!");
                    login = loginBox.Text;
                    generate_panel.Visible = true;
                    back_btn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Добро пожаловать в приложение \"Генератор безопасных парлей\"!");
                    login = loginBox.Text;
                    generate_panel.Visible = true;
                    back_btn.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
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

            List<Control> elementsChangeLocation = new List<Control>
            { 
                newUserLoginBox,
                newUserPasswordBox,
                labelLogin1,
                registrateBtn,
                generarionForNewUserBtn,
                logo_picture,
                registartionBtn,
                passwordUserBox,
                loginBox,
                labelLogin,
                labelPassword,
                generate_btn
            };
           foreach (Control control in elementsChangeLocation)
            {
                control.Location = new Point(((this.ClientSize.Width - control.Width) / 2), control.Location.Y);

            }


        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            charLists.Clear();
            

            var length = (int)lengthUpDown.Value;
            var includeLowercase = lowerCheckBox.Checked;
            var includeUppercase = upperCheckBox.Checked;
            var includeNumbers = numberCheckBox.Checked;
            var includeSpecialCharacters = alphanumCheckBox.Checked;

            var characterPool = string.Empty;

            if (includeLowercase)
            {
                characterPool += LowercaseLetters;
                charLists.Add(LowercaseLetters);
            }   
            if (includeUppercase)
            {
                characterPool += UppercaseLetters;
                charLists.Add(UppercaseLetters);
            }    
            if (includeNumbers)
            {
                characterPool += Numbers;
                charLists.Add(Numbers);
            }  
            if (includeSpecialCharacters)
            {
                characterPool += SpecialCharacters;
                charLists.Add(SpecialCharacters);
            }
            if (similarCheckBox.Checked)
            {
                characterPool = RemoveSimilarCharacters(characterPool);
            }
            if (ambiguousCheckBox.Checked)
            {
                characterPool = RemoveAmbiguousCharacters(characterPool);
            }
           
            if (charLists.Count!= 0)
            {
                hide_btn.Visible = true;
                copy_btn.Visible = true;
                labelHint.Visible = true;
                hintBox.Visible = true;
                if (!registrateBtn.Visible)
                {
                    save_btn.Visible = true;
                    save_password_btn.Visible = false;
                }
                else
                {
                    save_btn.Visible = false;
                    save_password_btn.Visible = true;
                }
                passwordBox.Visible = true;

                var password = GeneratePassword(length, characterPool);
                while (_wordList.Contains(password))
                    password = GeneratePassword(length, characterPool);
                passwordBox.Text = password;
                hintBox.Text = GetHint(password);
            }
            else
            {
                MessageBox.Show("Выберите характеристику/характеристики для пароля");
            }
            
        }

        private string[] ReadWordListFromFile(string fileName)
        {
            return File.ReadAllLines(rockyou_path);
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
            bool containsAll = false;
            string password = string.Empty;

            do
            {
                password = string.Empty;
                var bytes = new byte[length];
                Rng.GetBytes(bytes);

                for (var i = 0; i < length; i++)
                {
                    var characterIndex = bytes[i] % characterPool.Length;
                    password += characterPool[characterIndex];
                }

                containsAll = true;
                foreach (string list in charLists)
                {
                    if (string.IsNullOrEmpty(list))
                    {
                        continue;
                    }

                    bool containsAtLeastOne = false;
                    foreach (char c in list)
                    {
                        if (password.Contains(c.ToString()))
                        {
                            containsAtLeastOne = true;
                            break;
                        }
                    }

                    if (!containsAtLeastOne)
                    {
                        containsAll = false;
                        break;
                    }
                }

                // Проверка на совпадение с паролями из файла
                string[] filePasswords = File.ReadAllLines(rockyou_path);
                if (filePasswords.Contains(password))
                {
                    containsAll = false;
                }

            } while (!containsAll);

            return password;
        }


        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordBox.Text);
            copyLabel.Visible = true;
            var timer = new Timer { Interval = 500 };
            timer.Tick += (s, args) =>
            {
                copyLabel.Visible = false;
                timer.Stop();
            };
            timer.Start();
            

        }

        private void generarionForNewUserBtn_MouseEnter(object sender, EventArgs e)
        {
            generarionForNewUserBtn.ForeColor = Color.FromArgb(69, 61, 198);
        }

        private void generarionForNewUserBtn_MouseLeave(object sender, EventArgs e)
        {
            generarionForNewUserBtn.ForeColor = Color.DarkGray;
        }

        private void registartionBtn_MouseEnter(object sender, EventArgs e)
        {
            registartionBtn.ForeColor = Color.FromArgb(69, 61, 198);
        }

        private void registartionBtn_MouseLeave(object sender, EventArgs e)
        {
            registartionBtn.ForeColor = Color.DarkGray;
        }

        private void save_password_btn_Click(object sender, EventArgs e)
        {
            hide_btn.Visible = true;
            copy_btn.Visible = true;
            if (!registrateBtn.Visible)
            {
                save_btn.Visible = true;
                save_password_btn.Visible = false;
            }
            else
            {
                save_btn.Visible = false;
                save_password_btn.Visible = true;
            }
            passwordBox.Visible = true;
            registrateBtn.Visible = false;
            newUserPasswordBox.Text = passwordBox.Text;
            generate_panel.Visible = false;
            passwordBox.Text = string.Empty;

        }

        private void registartionBtn_Click(object sender, EventArgs e)
        {
            back_btn1.Visible = true;
            generate_btn.Visible = false;
            registrateBtn.Visible = true;
            loginBox.Visible = false;
            passwordUserBox.Visible = false;
            newUserLoginBox.Visible = true;
            newUserPasswordBox.Visible = true;
            registartionBtn.Visible = false;
            generarionForNewUserBtn.Visible = true;
            labelPassword.Visible = false;
            labelLogin.Visible = false;
            labelLogin1.Visible = true;
        }
        private string GetHint(string password)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>
            {
                { '!', "EXCLAMATION" }, { '@', "AT" }, { '#', "NUMBER" }, { '$', "DOLLAR" }, { '%', "PERCENT" },
                { '^', "CARET" }, { '&', "AND" }, { '*', "ASTERISK" }, { '(', "OPEN_PAREN" }, { ')', "CLOSE_PAREN" },
                { '-', "DASH" }, { '_', "UNDERSCORE" }, { '=', "EQUALS" }, { '+', "PLUS" }, { '[', "OPEN_BRACKET" },
                { ']', "CLOSE_BRACKET" }, { '{', "OPEN_BRACE" }, { '}', "CLOSE_BRACE" }, { ':', "COLON" },
                { ';', "SEMICOLON" }, { '<', "LESS_THAN" }, { '>', "GREATER_THAN" }, { '?', "QUESTION" },
                { '/', "SLASH" }, { '\\', "BACKSLASH" }, { '|', "PIPE" }, { '\'', "APOSTROPHE" }, {'"', "QUOTE" },
                { '0', "ZERO" }, { '1', "ONE" }, { '2', "TWO" }, { '3', "THREE" }, { '4', "FOUR" },
                { '5', "FIVE" }, { '6', "SIX" }, { '7', "SEVEN" }, { '8', "EIGHT" }, { '9', "NINE" },
                { 'a', "apple" }, { 'b', "banana" }, { 'c', "computer" }, { 'd', "dog" }, { 'e', "elephant" },
                { 'f', "fire" }, { 'g', "guitar" }, { 'h', "house" }, { 'i', "internet" }, { 'j', "jacket" },
                { 'k', "kangaroo" }, { 'l', "lemon" }, { 'm', "monkey" }, { 'n', "notebook" }, { 'o', "octopus" },
                { 'p', "pizza" }, { 'q', "queen" }, { 'r', "rainbow" }, { 's', "sun" }, { 't', "train" },
                { 'u', "unicorn" }, { 'v', "volcano" }, { 'w', "waterfall" }, { 'x', "xylophone" }, { 'y', "yellow" },
                { 'z', "zebra" }, { 'A', "APPLE" }, { 'B', "BESTBUY" }, { 'C', "CANDY" }, { 'D', "DOG" }, { 'E', "EGG" },
                { 'F', "FRUIT" }, { 'G', "GROCERY" }, { 'H', "HOTEL" }, { 'I', "INDIA" }, { 'J', "JAM" },
                { 'K', "KIWI" }, { 'L', "LEMON" }, { 'M', "MUSIC" }, { 'N', "NOODLE" }, { 'O', "ORANGE" },
                { 'P', "PIZZA" }, { 'Q', "QUEBEC" }, { 'R', "RED" }, { 'S', "SKYPE" }, { 'T', "TAXI" },
                { 'U', "UMBRELLA" }, { 'V', "VIOLIN" }, { 'W', "WALMART" }, { 'X', "XBOX" }, { 'Y', "YELLOW" },
                { 'Z', "ZOMBIE" }
            };

            string hint = "";
            bool upperNext = false;
            foreach (char c in password)
            {
                string word;
                if (dictionary.TryGetValue(c, out string rawWord))
                {
                    word = upperNext ? rawWord.ToUpper() : rawWord;
                    upperNext = char.IsUpper(c);
                }
                else
                {
                    word = c.ToString();
                }

                hint += word + " ";
            }

            return hint.Trim();
        }


        private void registrateBtn_Click(object sender, EventArgs e)
        {
            if (!newUserLoginBox.Text.Equals(String.Empty) && !newUserPasswordBox.Text.Equals(String.Empty))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(usersXmlFile);

                XmlNodeList users = xmlDoc.SelectNodes("//User/login");

                foreach (XmlNode user in users)
                {
                    if (user.InnerText.Equals(newUserLoginBox.Text))
                    {
                        MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                        return;
                    }
                }

                XmlElement newUser = xmlDoc.CreateElement("User");
                XmlElement login = xmlDoc.CreateElement("login");
                login.InnerText = newUserLoginBox.Text;
                newUser.AppendChild(login);
                XmlElement password = xmlDoc.CreateElement("password");
                password.InnerText = newUserPasswordBox.Text;
                newUser.AppendChild(password);
                XmlElement dateOfChange = xmlDoc.CreateElement("dateOfChange");
                dateOfChange.InnerText = DateTime.Now.ToString();
                newUser.AppendChild(dateOfChange);
                XmlNode root = xmlDoc.SelectSingleNode("UsersInSystem");
                root.AppendChild(newUser);
                xmlDoc.Save(usersXmlFile);
                registrateBtn.Visible = false;
                generate_btn.Visible = true;
                registrateBtn.Visible = false;
                loginBox.Visible = true;
                passwordUserBox.Visible = true;
                newUserLoginBox.Visible = false;
                newUserPasswordBox.Visible = false;
                registartionBtn.Visible = true;
                generarionForNewUserBtn.Visible = false;
                labelPassword.Visible = true;
                labelLogin.Visible = true;
                labelLogin1.Visible = false;
                MessageBox.Show("Вы успешно зарегистрированы");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

        }

        private void generarionForNewUserBtn_Click(object sender, EventArgs e)
        {
            generate_panel.Visible = true;
        }

        private void newUserPasswordBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сгенерируйте пароль");
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(usersXmlFile);

            XmlNode userNode = xmlDoc.SelectSingleNode($"/UsersInSystem/User[login/text()='{login}']");

            if (userNode != null)
            {
                string oldPassword = userNode.SelectSingleNode("password").InnerText;
                
                if (passwordBox.Text == oldPassword)
                {
                    MessageBox.Show("Новый пароль совпадает со старым\nПопробуйте сгенерировать снова");
                }
                else if (passwordBox.Text.Contains(oldPassword))
                {
                    MessageBox.Show("Новый пароль содержит старый\nПопробуйте сгенерировать снова");
                }
                else
                {
                    userNode.SelectSingleNode("password").InnerText = passwordBox.Text;
                    userNode.SelectSingleNode("dateOfChange").InnerText = DateTime.Now.ToString("dd.MM.yyyy H:mm:ss");

                    xmlDoc.Save(usersXmlFile);
                    MessageBox.Show("Пароль успешно изменен.");
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            generate_panel.Visible = false;
            back_btn.Visible = false;
        }

        private void back_btn_MouseEnter(object sender, EventArgs e)
        {
             back_btn.BorderStyle = BorderStyle.Fixed3D;
        }

        private void back_btn_MouseLeave(object sender, EventArgs e)
        {
            back_btn.BorderStyle = BorderStyle.None;
        }

        private void show_btn_Click_1(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            show_btn.Visible = false;
            hide_btn.Visible = true;
        }

        private void hide_btn_Click_1(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
            show_btn.Visible = true;
            hide_btn.Visible = false;
        }

        private void show_btn1_Click(object sender, EventArgs e)
        {
            newUserPasswordBox.UseSystemPasswordChar = true;
            passwordUserBox.UseSystemPasswordChar = true;
            show_btn1.Visible = false;
            hide_btn1.Visible = true;
        }

        private void hide_btn1_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
            passwordUserBox.UseSystemPasswordChar = false;
            show_btn1.Visible = true;
            hide_btn1.Visible = false;
        }

        private void back_btn1_Click(object sender, EventArgs e)
        {
            back_btn1.Visible = false;
            generate_btn.Visible = true;
            registrateBtn.Visible = false;
            loginBox.Visible = true;
            passwordUserBox.Visible = true;
            newUserLoginBox.Visible = false;
            newUserPasswordBox.Visible = false;
            registartionBtn.Visible = true;
            generarionForNewUserBtn.Visible = false;
            labelPassword.Visible = true;
            labelLogin.Visible = true;
            labelLogin1.Visible = false;
        }
    }
}
