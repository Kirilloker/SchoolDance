public class Payment : IId
{
    public int Id { get; set; }
    public int? studentId { get; set; }
    public int lessonId { get; set; }
    public DateTime date_end_subscription { get; set; }
}