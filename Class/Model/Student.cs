public class Student : Person 
{
    public void copy(Student another)
    {
        this.date = another.date;
        this.password = another.password;
        this.login = another.login;
        this.isMale = another.isMale;
        this.fullName = another.fullName;   
        this.typePerson = another.typePerson;
    }
}