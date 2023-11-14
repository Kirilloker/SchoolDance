public class Lesson : IId
{
    public int Id { get; set; }
    public string? className { get; set;}
    // Example: "ВТ\ЧТ"
    public string? weekdays { get; set; }
    public int danceHallId { get; set; }
    public int groupId { get; set; }
    public int coachId { get; set; }
    public int? danceStylesId { get; set; }
}