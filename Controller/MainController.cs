using SchoolDance.Class.DB;

namespace SchoolDance.Controller
{
    public class MainController<DataType> where DataType : class, IId
    {
        public delegate void UpdateView(object newDataSource);
        public delegate object GetDateSource();
        public event UpdateView Update;
        public event GetDateSource GetDate;

        public void FillDate() 
        {
            Update(GetDateFromDB());
        }

        public bool Add(DataType entity) 
        {
            object DataSource = GetDate();

            if (AddFromDB(entity) == false)
                return false;

            if (AddView(ref DataSource, entity) == false)
                return false;

            Update(DataSource);
            return true;
        }


        public void Change(int ID_Change) 
        {
            object DataSource = GetDate();
            DataType changeEntity = ((List<DataType>)DataSource)[ID_Change];
            ChangeFromDB(changeEntity);
            Update(DataSource);
        }

        public bool Delete(string ID_Delete)
        {
            object DataSource = GetDate();
            int id_del;

            if (!int.TryParse(ID_Delete, out id_del))
                return false;

            if (!DeleteFromDB(id_del))
                return false;

            if (!DeleteView(ref DataSource, id_del))
                return false;

            Update(DataSource);
            return true;
        }

        private bool DeleteView(ref object DataSource, int id)
        {
            var listData = (List<DataType>)DataSource;
            var objectToRemove = listData?.FirstOrDefault(s => s?.GetType().GetProperty("Id")?.GetValue(s).Equals(id) ?? false);

            if (objectToRemove != null && listData != null)
            {
                listData.Remove(objectToRemove);
                DataSource = listData;
                return true;
            }
            else
                return false;
        }

        private bool AddView(ref object DataSource, DataType entity) 
        {
            var listData = (List<DataType>)DataSource;

            if (entity != null && listData != null)
            {
                listData.Add(entity);
                DataSource = listData;
                return true;
            }
            else
                return false;
        }

        public bool AddFromDB(DataType entity) 
        {
            return DB_Controller.Add(entity);
        }

        public bool DeleteFromDB(int id)
        {
            return DB_Controller.Delete<DataType>(id);
        }

        public bool ChangeFromDB(DataType entity) 
        {
            return DB_Controller.Update(entity);
        }

        public List<DataType> GetDateFromDB()
        {
            return DB_Controller.GetAll<DataType>();
        }

        public DataType GetEntityByID(int id) 
        {
            return DB_Controller.Get<DataType>(id);
        }
    }
}
