public class SupportMessage : IId
{
    public int Id { get; set; }
    public int personId { get; set; }
    public string? typeMessage { get; set; }
    public string? message { get; set; }
    public bool isSolved { get; set; } 
}