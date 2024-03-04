namespace Backend.Entities
{
    public class Movement
    {
        public int Id { get; set; }
        public int IdAccount { get; set; }
        public int IdAccountType { get; set; }
        public string? Contact { get; set; }
        public string? DescriptionVoucher { get; set; }
        public required double Debit { get; set; }
        public required double Credit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}