namespace ITTicketingSystem.Data.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<TicketAssignment> Assignments { get; set; }
        public ICollection<TicketUpdate> Updates { get; set; }
    }
}
