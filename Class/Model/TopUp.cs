public class TopUp : IId
{
    public int Id { get; set; }
    public int studentId { get; set; }
    public DateTime paymentTime { get; set; }
    public int price { get; set; }
}