using System;
using PasswordLibarary2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordLibraryTests
{
    [TestClass]
    public class PasswordClassTests
    {
        /// <summary>
        /// Проверка с помощью функции подходит ли пароль нашим условиям
        /// </summary>
        [TestMethod]
        public void CheckPassword_StringEmpty_ReturnedFalse()
        {
            //Arrange
            string password = string.Empty;

            //Act
            PasswordClass c = new PasswordClass();
            bool actual = c.CheckPassword(password);

            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка слишком короткого пароля
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_ShortPassword_Returned0()
        {
            //Arrange
            string password = "123a";
            int excepted = 0;
            //Act

            int actual = PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// Проверка пустую строку
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_OnlyNumbers_Returned1()
        {
            //Arrange
            string password = "";
            int excepted = 0;
            //Act

            int actual = PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// Проверка на подходящий пароль(4 балла)
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_UpperLoewerAndNumber_Returned1()
        {
            //Arrange
            string password = "Passw0rd";
            int excepted = 4;
            //Act

            int actual = PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// Проверка только цифры
        /// </summary>
        [TestMethod]
        public void CheckPassword_OnlyLetters_ReturnedTrue()
        {
            //Arrange
            string password = "12341236401";

            //Act
            PasswordClass c = new PasswordClass();
            bool actual = c.CheckPassword(password);

            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка пустую строку
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_NormalPassword_Returned1()
        {
            //Arrange
            string password = "Passw0rd";
            int excepted = 4;
            //Act

            int actual = PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// Проверка пароля с символа
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_NormalPassword_ReturnedException()
        {
            //Arrange
            string password = "Vladislav2013*";

            int excepted = 5;
            //Act

            int actual = PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [TestMethod]
        public void PasswordStrengthCheker_ShortPass_ReturnedException()
        {
            //Arrange
            string password = "Vlad12";

            int excepted = 0;
            //Act

            int actual = PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.AreEqual(actual, excepted);
        }


    }
}
