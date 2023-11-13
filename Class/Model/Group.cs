public class Group : IId
{
    public int Id { get; set; }
    public string? nameGroup { get; set; }
    public int maxNumberStudent { get; set; }
    public List<int>? studentId { get; set; }  
}