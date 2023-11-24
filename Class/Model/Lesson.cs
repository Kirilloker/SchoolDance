public class Lesson : IId
{
    public int Id { get; set; }
    public string? className { get; set;}
    public string? weekdays { get; set; }
    public int danceHallId { get; set; }
    public int coachId { get; set; }
    public int danceStylesId { get; set; }
    public int price { get; set; }
    public string? description { get; set; }
    public string? time_start { get; set; }
    public string? studentId { get; set; }
}