using SchoolDance.Class.DB;
using System;

namespace SchoolDance.Class.Logic
{
    public static class SignInUpLogic
    {
        // Зашифровывает строку в base64
        public static string EncodeStringToBase64(string text)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }


        // Возвращает True, если такой пользователь существует в БД
        public static bool correctSignIn(string login, string password) 
        {
            Person? person = DB_API.GetPerson(login);

            if (person != null && person.password == EncodeStringToBase64(password)) return true;
            else return false;
        }

        public static TypePerson getTypePerson(string login) 
        {
            return DB_API.GetPerson(login).typePerson;
        }

        // Возвращает True, если регистрация студента прошла успешно
        public static bool signUpNewStudent(string login, string password, string first_name,
            string second_name, string patronymic, bool isMale, DateTime birth)
        {
            return DB_API.AddStudent(login, EncodeStringToBase64(password),
                first_name + " " + second_name + " " + patronymic,
                isMale, birth);
        }
    }
}
