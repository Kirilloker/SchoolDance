namespace SchoolDance.Class.DB
{
    public static class DB_Controller
    {
        public static bool AddEntity<T>(T entity, Func<T, bool> predicate) where T : class
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    bool isEntityExisting = db.Set<T>().Any(predicate);

                    if (isEntityExisting == false)
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
                catch
                {
                    return false;
                }
            }
        }
        public static bool Update<T>(T entity) where T : class, IId
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

                    return true;
                }
                catch
                {
                    return false;
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
                    return new List<T>();
                }
            }
        }
        public static T Get<T>(int id) where T : class, IId
        {
            using (DB_Context db = new DB_Context())
            {
                try
                {
                    return db.Set<T>().Find(id);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
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


        public static bool Add<T>(T entity) where T : class
        {
            if (addFunctions.TryGetValue(typeof(T), out var addFunction))
                return (bool)addFunction.DynamicInvoke(entity);
            else
                throw new ArgumentException("Такой объект не поддерживается");
        }

        private static readonly Dictionary<Type, Delegate> addFunctions = new Dictionary<Type, Delegate>
        {
            { typeof(DanceStyle), new Func<DanceStyle, bool>(e => AddEntity(e, b => b.name == e.name)) },
            { typeof(DanceHall), new Func<DanceHall, bool>(e => AddEntity(e, b => b.roomNumber == e.roomNumber)) },
            { typeof(Student), new Func<Student, bool>(e => AddEntity(e, b => b.login == e.login)) },
            { typeof(Coach), new Func<Coach, bool>(e => AddEntity(e, b => b.login == e.login)) },
            { typeof(Administrator), new Func<Administrator, bool>(e => AddEntity(e, b => b.login == e.login)) },
            { typeof(Lesson), new Func<Lesson, bool>(e => AddEntity(e, b => b.Id == -1)) },
            { typeof(TopUp), new Func<TopUp, bool>(e => AddEntity(e, b => b.Id == -1)) },
            { typeof(Payment), new Func<Payment, bool>(e => AddEntity(e, b => b.Id == -1)) },
            { typeof(EventDance), new Func<EventDance, bool>(e => AddEntity(e, b => b.Id == -1)) },
            { typeof(SupportMessage), new Func<SupportMessage, bool>(e => AddEntity(e, b => b.personName == e.personName && b.message == e.message)) }
        };

    }
}