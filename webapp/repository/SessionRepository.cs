using Microsoft.EntityFrameworkCore;
using domain;
using domain.SessionAggregate;

namespace webapp.repository;

public class SessionRepository : GenericRepository<Session>, ISessionRepository
{
    public SessionRepository(ApplicationDbContext context)
        : base(context)
        {
        }

    public async Task<IEnumerable<Session>> GetSessions()
    {
        return await _context.Set<Session>().ToListAsync();
    }

    public async Task<Session> GetSessionById(int id)
    {
        return await _context.Set<Session>().FindAsync(id);
    }

    public async Task AddSession(Session session)
    {
        await _context.Set<Session>().AddAsync(session);
    }

    public void DeleteSession(Session session)
    {
        _context.Set<Session>().Remove(session);
    }

    public void UpdateSession(Session session)
    {
        _context.Set<Session>().Update(session);    
    }
}