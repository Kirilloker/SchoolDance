
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;

namespace SchoolDance.Class.DB
{
    public static class DB_API
    {
        
        public static Person? GetPerson(string login)
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    Person person = db.students.Where(b => b.login == login ).ToList()[0];

                    if (person == null)
                        person = db.coaches.Where(b => b.login == login).ToList()[0];
                    
                    if (person == null)
                        person = db.administrators.Where(b => b.login == login).ToList()[0];

                    return person;
                }
                catch 
                {
                    return null;
                }
            }
        }


        public static bool AddStudent(string log, string pas, string FIO, bool _isMale, DateTime birth)
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    List<string?> students = db.students
                        .Where(b => b.login == log)
                        .Select(b => b.login)
                        .ToList();


                    if (students.Count == 0)
                    {
                        Student student = new Student { login = log, password = pas, fullName = FIO, isMale = _isMale, date = birth, typePerson = TypePerson.Student };

                        db.students.Add(student);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public static void UpdateStudent(Student student)
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    Student user = db.students.Where(b => b.Id == student.Id).ToList()[0];
                    user.copy(student);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }

    }
}
