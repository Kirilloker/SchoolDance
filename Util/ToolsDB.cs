using Microsoft.VisualBasic.Logging;
using SchoolDance.Class.DB;

namespace SchoolDance.Util
{
    public static class ToolsDB
    {
        public static string getName(string login)
        {
            Person person = DB_API.GetPerson(login);
            return person?.fullName ?? "";
        }
    }
}
