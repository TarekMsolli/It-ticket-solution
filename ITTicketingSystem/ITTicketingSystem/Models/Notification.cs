namespace ITTicketingSystem.Data.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
