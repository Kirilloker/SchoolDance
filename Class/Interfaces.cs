public interface IId
{
    int Id { get; set; }
}

public interface ILogin
{
    string? login { get; set; }
}

public enum TypePerson
{
    None,
    Student,
    Coach,
    Administrator
}