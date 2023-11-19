public class Student : Person 
{
    public int balance { get; set; }

    public void copy(Student another)
    {
        this.date = another.date;
        this.password = another.password;
        this.login = another.login;
        this.gender = another.gender;
        this.fullName = another.fullName;   
        this.typePerson = another.typePerson;
    }
}