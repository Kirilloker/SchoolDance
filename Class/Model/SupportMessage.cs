public class SupportMessage : IId
{
    public int Id { get; set; }
    public string personName { get; set; }
    public string? typeMessage { get; set; }
    public string? message { get; set; }
    public bool isSolved { get; set; }
    public DateTime? date { get; set; }
}