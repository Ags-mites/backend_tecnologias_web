namespace Backend.Entities
{
    public class PayrollDetail
    {
        public int Id { get; set; }
        public int Idreason { get; set; }
        public int IdPayroll { get; set; }
        public required double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}