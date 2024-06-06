using System.Net.Sockets;

namespace ITTicketingSystem.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<TicketAssignment> AssignedTickets { get; set; }
        public ICollection<TicketUpdate> TicketUpdates { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
