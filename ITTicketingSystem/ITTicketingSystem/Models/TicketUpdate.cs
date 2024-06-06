namespace ITTicketingSystem.Data.Models
{
    public class TicketUpdate
    {
        public int UpdateId { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }

    }
}