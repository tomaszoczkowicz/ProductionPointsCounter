namespace ProductionPointsCounterAPI.Models
{
    public class OrdersDto
    {
        public string? OrderName { get; set; }
        public string? Status { get; set; }
        public int Id { get; set; }
        public DateTime? ProductionDate { get; set; }
        public decimal? ProductionPoints { get; set; }
    }
}