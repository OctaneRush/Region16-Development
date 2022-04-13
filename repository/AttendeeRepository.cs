using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using domain;
using domain.AttendeeAggregate;
using webapp;

namespace repository;

public class AttendeeRepository : GenericRepository<Attendee>, IAttendeeRepository
{
    public AttendeeRepository(ApplicationDbContext context)
        : base(context)
        {
        }

    public async Task<IEnumerable<Attendee>> GetAttendees()
    {
        return await _context.Set<Attendee>().ToListAsync();
    }

    public async Task<Attendee> GetAttendeeById(int id)
    {
        return await _context.Set<Attendee>().FindAsync(id);
    }

    public async Task AddAttendee(Attendee attendee)
    {
        await _context.Set<Attendee>().AddAsync(attendee);
    }

    public void DeleteAttendee(Attendee attendee)
    {
        _context.Set<Attendee>().Remove(attendee);
    }

    public void UpdateAttendee(Attendee attendee)
    {
        _context.Set<Attendee>().Update(attendee);    
    }
}