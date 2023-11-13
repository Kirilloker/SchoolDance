
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
            Student student = new Student { login = log, password = pas, fullName = FIO, gender = _isMale == true ? "Male" : "Female", date = birth, typePerson = TypePerson.Student };
            return AddPerson<Student>(student);
        }

        public static bool AddPerson<T>(T entity) where T : class, ILogin
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    List<string?> existingEntity = db.Set<T>()
                        .Where(b => b.login == entity.login)
                        .Select(b => b.login)
                        .ToList();

                    if (existingEntity.Count == 0)
                    {
                        db.Set<T>().Add(entity);
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

        public static void Update<T>(T entity) where T : class, IId
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    T existingEntity = db.Set<T>().Find(entity.Id);
                    if (existingEntity != null)
                    {
                        db.Entry(existingEntity).CurrentValues.SetValues(entity);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }



        public static bool Delete<T>(int id) where T : class
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    var entity = db.Set<T>().Find(id);

                    if (entity != null)
                    {
                        db.Set<T>().Remove(entity);
                        db.SaveChanges();
                        return true;
                    }
                    else return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static List<T> GetAll<T>() where T : class
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    return db.Set<T>().ToList();
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
