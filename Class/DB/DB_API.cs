
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
                    Person person = db.students.FirstOrDefault(b => b.login == login);

                    if (person == null)
                        person = db.coaches.FirstOrDefault(b => b.login == login);

                    if (person == null)
                        person = db.administrators.FirstOrDefault(b => b.login == login);

                    return person;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static int GetStudentId(string fullName)
        {
            using (DB_Context db = new DB_Context())
            {
                int studentId = db.students
                    .Where(s => s.fullName == fullName)
                    .Select(s => s.Id)
                    .FirstOrDefault();

                return studentId;
            }
        }

        public static SupportMessage? GetSupportMessage(int id)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.supportMessages.Where(s => s.Id == id).FirstOrDefault();
            }
        }

        public static bool AddStudent(string log, string pas, string FIO, bool _isMale, DateTime birth)
        {
            Student student = new Student { login = log, password = pas, fullName = FIO, gender = _isMale == true ? "Male" : "Female", date = birth, typePerson = TypePerson.Student };
            return AddStudent(student);
        }

        public static bool AddDanceStyle(DanceStyle entity)
        {
            return AddEntity<DanceStyle>(entity, b => b.name == entity.name);
        }

        public static bool AddDanceHall(DanceHall entity)
        {
            return AddEntity<DanceHall>(entity, b => b.roomNumber == entity.roomNumber);
        }

        public static bool AddStudent(Student entity)
        {
            return AddEntity<Student>(entity, b => b.login == entity.login);
        }

        public static bool AddCoach(Coach entity)
        {
            return AddEntity<Coach>(entity, b => b.login == entity.login);
        }

        public static bool AddAdministrator(Administrator entity)
        {
            return AddEntity<Administrator>(entity, b => b.login == entity.login);
        }

        public static bool AddGroup(Group entity)
        {
            return AddEntity<Group>(entity, b => b.nameGroup == entity.nameGroup);
        }

        public static bool AddLesson(Lesson entity)
        {
            return AddEntity<Lesson>(entity, b => b.className == entity.className && b.groupId == entity.groupId
                                    && b.danceStylesId == entity.danceStylesId);
        }

        public static bool AddPayment(Payment entity)
        {
            return AddEntity<Payment>(entity, b => b.paymentTime == entity.paymentTime);
        }

        public static bool AddEventDance(EventDance entity)
        {
            return AddEntity<EventDance>(entity, b => b.Id == -1);
        }

        public static bool AddSupportMessage(SupportMessage entity)
        {
            return AddEntity<SupportMessage>(entity, b => b.personName == entity.personName 
                                            && b.message == entity.message);
        }

        public static bool AddEntity<T>(T entity, Func<T, bool> predicate) where T : class
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    bool isEntityExisting = db.Set<T>().Any(predicate);

                    if (!isEntityExisting)
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