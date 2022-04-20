using Microsoft.EntityFrameworkCore;
using domain;
using domain.SpeakerAggregate;

namespace webapp.repository;

public class SpeakerRepository : GenericRepository<Speaker>, ISpeakerRepository
{
    protected readonly ApplicationDbContext _context;
    public SpeakerRepository(ApplicationDbContext context)
        : base(context)
        {
            _context = context;
        }

    public async Task<IEnumerable<Speaker>> GetSpeakers()
    {
        return await _context.Set<Speaker>().ToListAsync();
    }

    public async Task<Speaker> GetSpeakerById(int id)
    {
        return await _context.Set<Speaker>().FindAsync(id);
    }

    public async Task AddSpeaker(Speaker speaker)
    {
        await _context.Set<Speaker>().AddAsync(speaker);
    }

    public void DeleteSpeaker(Speaker speaker)
    {
        _context.Set<Speaker>().Remove(speaker);
    }

    public void UpdateSpeaker(Speaker speaker)
    {
        _context.Set<Speaker>().Update(speaker);    
    }
}