public class Payment : IId
{
    public int Id { get; set; }
    public int studentId { get; set; }
    public DateTime paymentTime { get; set; }
    public DateTime endDatePayment { get; set; }
}