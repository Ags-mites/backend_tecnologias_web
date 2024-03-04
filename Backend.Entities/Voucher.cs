namespace Backend.Entities
{
    public class Voucher
    {
        public int Id { get; set; }
        public int Numeration { get; set; }
        public required string CodeVoucher { get; set; }
        public string? DescriptionVoucher { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int IdVoucherType { get; set; }
        public int IdMovement { get; set; }
        public VoucherType VoucherTypes { get; set; }
        public Movement Movements { get; set; }
    }
}