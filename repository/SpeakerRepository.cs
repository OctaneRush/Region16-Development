// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using domain;
// using domain.SpeakerAggregate;
// using webapp;

// namespace repository;

// public class SpeakerRepository : GenericRepository<Speaker>, ISpeakerRepository
// {
//     public SpeakerRepository(ApplicationDbContext context)
//         : base(context)
//         {
//         }

//     public async Task<IEnumerable<Speaker>> GetSpeakers()
//     {
//         return await _context.Set<Speaker>().ToListAsync();
//     }

//     public async Task<Speaker> GetSpeakerById(int id)
//     {
//         return await _context.Set<Speaker>().FindAsync(id);
//     }

//     public async Task AddSpeaker(Speaker speaker)
//     {
//         await _context.Set<Speaker>().AddAsync(speaker);
//     }

//     public void DeleteSpeaker(Speaker speaker)
//     {
//         _context.Set<Speaker>().Remove(speaker);
//     }

//     public void UpdateSpeaker(Speaker speaker)
//     {
//         _context.Set<Speaker>().Update(speaker);    
//     }
// }