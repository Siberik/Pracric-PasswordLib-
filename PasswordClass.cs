using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLibarary2
{
    public class PasswordClass
    {
        /// <summary>
        /// Проверка на сложность пароля
        /// </summary>
        /// <param name="password">
        /// Является паролем
        /// </param>
        /// <returns>
        /// Возвращает сложность пароля
        /// </returns>
        public static int PasswordStrengthCheker(string password)
        {
            var count = 0;

            //метод, проверящий сложность пароля от 7 символов и более
            if (password == @".{7,}")
            {
                count = count + 1;

                //метод, проверяющий наличие в пароле нижнего регистра
                if (password == @"(?=.*[a-z])")
                {
                    count = count + 1;
                }
                //метод, проверящий наличие в пароле верхнего регистра 
                if (password == @"(?=.*[A-Z])")
                {
                    count = count + 1;
                }
                //метод, проверяющий наличие в пароле цифр
                if (password == @"(?=.*\d)")
                {
                    count = count + 1;
                }
                //метод, проверяющий наличие Кириллицы в пароле
                if (password == @"(?=.*[А-Я])||(?=.*[а-я])")
                {
                    throw new Exception("Кириллические символы запрещены при вводе пароля");
                }
                //метод, проверяющий наличие спец символов
                if (password == @"[\!\@\\\*\(\)]")
                {
                    count = count + 1;
                }
            }





            return count;
        }
        /// <summary>
        /// Проверка правильности формирования пароля
        /// </summary>
        /// <param name="password">
        /// Пароль
        /// </param>
        /// <returns>
        /// Выводит, истина или ложь(подходит ли нам пароль или нет)
        /// </returns>
        public bool CheckPassword(string password)
        {
            if (password == @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})")
            {
                if (password == @"[\!\@\\\*\(\)\^\$\]")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            return false;
        }
    }
}
