public class Person : IId, ILogin
{
    public int Id { get; set; }
    public string? fullName { get; set; }
    public DateTime date { get; set; }
    public string gender { get; set; }
    public TypePerson typePerson { get; set; }
    public string? login { get; set; }
    public string? password { get; set; }
}

public enum TypePerson
{
    None,
    Student,
    Coach,
    Administrator
}