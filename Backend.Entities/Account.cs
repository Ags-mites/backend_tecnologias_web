namespace Backend.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Status { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } 

        public int IdAccountType { get; set; }
        public AccountType AccountType { get; set; }
        
    }
}