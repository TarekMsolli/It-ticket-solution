using ITTicketingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketAssignment> TicketAssignments { get; set; }
    public DbSet<TicketUpdate> TicketUpdates { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.User)
            .WithMany(u => u.Tickets)
            .HasForeignKey(t => t.UserId);

        modelBuilder.Entity<TicketAssignment>()
            .HasOne(ta => ta.Ticket)
            .WithMany(t => t.Assignments)
            .HasForeignKey(ta => ta.TicketId);

        modelBuilder.Entity<TicketAssignment>()
            .HasOne(ta => ta.AssignedUser)
            .WithMany(u => u.AssignedTickets)
            .HasForeignKey(ta => ta.AssignedTo);

        modelBuilder.Entity<TicketAssignment>()
            .HasOne(ta => ta.AssignedByUser)
            .WithMany()
            .HasForeignKey(ta => ta.AssignedBy);

        modelBuilder.Entity<TicketUpdate>()
            .HasOne(tu => tu.Ticket)
            .WithMany(t => t.Updates)
            .HasForeignKey(tu => tu.TicketId);

        modelBuilder.Entity<TicketUpdate>()
            .HasOne(tu => tu.User)
            .WithMany(u => u.TicketUpdates)
            .HasForeignKey(tu => tu.UserId);

        modelBuilder.Entity<Notification>()
            .HasOne(n => n.User)
            .WithMany(u => u.Notifications)
            .HasForeignKey(n => n.UserId);

        modelBuilder.Entity<Notification>()
            .HasOne(n => n.Ticket)
            .WithMany()
            .HasForeignKey(n => n.TicketId);

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.User)
            .WithMany()
            .HasForeignKey(ur => ur.UserId);

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.Role)
            .WithMany()
            .HasForeignKey(ur => ur.RoleId);
    }
}
