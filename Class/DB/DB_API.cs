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
            return AddEntity<Lesson>(entity, b => b.Id == -1);
        }

        public static bool AddTopUp(TopUp entity)
        {
            return AddEntity<TopUp>(entity, b => b.paymentTime == entity.paymentTime);
        }

        public static bool AddPayment(Payment entity) 
        {
            return AddEntity<Payment>(entity, b => (b.studentId == entity.studentId) && 
            (b.lessonId == entity.lessonId));
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
                catch 
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
                catch 
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

        //public static DataTable ExecuteQuery(string sqlQuery)
        //{

        //    using (DB_Context db = new DB_Context())
        //    {
        //        try
        //        {
        //            return db.ExecuteQuery(sqlQuery);
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }
        //    }
        //}
    }
}