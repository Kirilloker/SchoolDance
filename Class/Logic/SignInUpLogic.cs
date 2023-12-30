using SchoolDance.Class.DB;

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
            Person? person = DB_Controller.GetPerson(login);

            if (person != null && person.password == EncodeStringToBase64(password)) return true;
            else return false;
        }


        // Возвращает True, если регистрация студента прошла успешно
        public static bool signUpNewStudent(string login, string password, string first_name,
            string second_name, string patronymic, bool isMale, DateTime birth)
        {
            Student student = new Student
            {
                login = login,
                password = EncodeStringToBase64(password),
                fullName = first_name + " " + second_name + " " + patronymic,
                gender = isMale == true ? "Male" : "Female",
                date = birth,
                typePerson = TypePerson.Student
            };
            return DB_Controller.AddStudent(student);
        }
    }
}
