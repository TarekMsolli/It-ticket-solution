namespace ITTicketingSystem.Data.Models
{
    public class TicketAssignment
    {
        public int AssignmentId { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int AssignedTo { get; set; }
        public User AssignedUser { get; set; }
        public int AssignedBy { get; set; }
        public User AssignedByUser { get; set; }
        public DateTime AssignedAt { get; set; }
    }
}
