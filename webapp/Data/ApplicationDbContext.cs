using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using domain.SpeakerAggregate;
using domain.AttendeeAggregate;
using domain.SessionAggregate;

namespace webapp;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Speaker>? Speakers {get; set;}
    public DbSet<Attendee>? Attendees {get; set;}
    public DbSet<Session>? Sessions {get; set;}
}
