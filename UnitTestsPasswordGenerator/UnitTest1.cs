using HomeWork__PasswordGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.IO;
using System;
using System.Windows.Forms;
using System.Xml;

namespace UnitTestsPasswordGenerator
{
    [TestClass]
    public class PasswordGeneratorTests
    {
        [TestMethod]
        public void TestGeneratePassword_Length10_Characters_az()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(10, "abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void TestGeneratePassword_Length10_Characters_AZ()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(10, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Assert.AreEqual(10, password.Length);
        }

        [TestMethod]
        public void TestGeneratePassword_Length10_Characters_09()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(10, "0123456789");
            Assert.AreEqual(10, password.Length);
        }


        [TestMethod]
        public void TestGeneratePassword_Length100_Characters_azAZ09()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(100, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            Assert.AreEqual(100, password.Length);
        }

       [TestMethod]
        public void TestGeneratePassword_Length1_Characters_a()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(1, "a");
            Assert.AreEqual(1, password.Length);
        }

       
        [TestMethod]
        public void Test_RemoveAmbiguousCharacters_InputWithParentheses_RemovesParentheses()
        {
            // Arrange
            string input = "This is a (test) string.";

            // Act
            string result = MainForm.RemoveAmbiguousCharacters(input);

            // Assert
            Assert.AreEqual("This is a test string", result);
        }

        [TestMethod]
        public void Test_RemoveAmbiguousCharacters_InputWithForwardSlashes_RemovesForwardSlashes()
        {
            // Arrange
            string input = "This is a test/ string.";

            // Act
            string result = MainForm.RemoveAmbiguousCharacters(input);

            // Assert
            Assert.AreEqual("This is a test string", result);
        }

        [TestMethod]
        public void Test_RemoveAmbiguousCharacters_InputWithColon_RemovesColon()
        {
            // Arrange
            string input = "This is a test: string.";

            // Act
            string result = MainForm.RemoveAmbiguousCharacters(input);

            // Assert
            Assert.AreEqual("This is a test string", result);
        }

        [TestMethod]
        public void Test_RemoveAmbiguousCharacters_InputWithDoubleQuotes_RemovesDoubleQuotes()
        {
            // Arrange
            string input = "This is a \"test\" string.";

            // Act
            string result = MainForm.RemoveAmbiguousCharacters(input);

            // Assert
            Assert.AreEqual("This is a test string", result);
        }

        [TestMethod]
        public void TestGeneratePassword_Length1_Characters_A()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(1, "A");
            Assert.AreEqual(1, password.Length);
        }

        [TestMethod]
        public void TestGeneratePassword_Length1_Characters_0()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(1, "0");
            Assert.AreEqual(1, password.Length);
        }

        public void TestGeneratePassword_OverLenght()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(1, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Assert.AreEqual(10000, password.Length);
        }

        [TestMethod]
        public void TestGeneratePassword_Length10_Characters_абвгдеёжзийклмнопрстуфхцчшщъыьэюя()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(10, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Assert.AreEqual(10, password.Length);
        }
        [TestMethod]
        public void EmptyFields_RegistrationFailed()
        {
            // Arrange
            var form = new MainForm();
            form.newUserLoginBox.Text = String.Empty;
            form.newUserPasswordBox.Text = "password";

            // Act
            form.registrateBtn_Click(null, null);

            // Assert
            Assert.AreEqual(false, form.generarionForNewUserBtn.Visible);
        }

        [TestMethod]
        public void EmptyFields_RegistrationFailed_BothFieldsEmpty()
        {
            // Arrange
            var form = new MainForm();
            form.newUserLoginBox.Text = String.Empty;
            form.newUserPasswordBox.Text = String.Empty;
            // Act
            form.registrateBtn_Click(null, null);
            // Assert
            Assert.AreEqual(false, form.generarionForNewUserBtn.Visible);
        }

        [TestMethod]
        public void CapsFields_RegistrationFailed()
        {
            // Arrange
            var form = new MainForm();
            form.newUserLoginBox.Text = "USER1";
            form.newUserPasswordBox.Text = "password";

            // Act
            form.registrateBtn_Click(null, null);

            // Assert
            Assert.AreEqual(false, form.generarionForNewUserBtn.Visible);
        }
        [TestMethod]
        public void TestGeneratePassword_Length5_Characters_azAZ09()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(5, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            Assert.AreEqual(5, password.Length);
        }


        [TestMethod]
        public void TestGeneratePassword_Length6_Characters_Hex()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(6, "0123456789ABCDEF");
            Assert.AreEqual(6, password.Length);
        }

        [TestMethod]
        public void TestGeneratePassword_Length10_Characters_azAZ09_Symbols()
        {
            MainForm generator = new MainForm();
            string password = generator.GeneratePassword(10, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+");
            Assert.AreEqual(10, password.Length);
        }
    }
}

