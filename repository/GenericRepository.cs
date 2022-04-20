// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using domain;
// using webapp;

// namespace repository
// {
//     //Used from https://github.com/ahuimanu/CIDM4390/blob/5057d50a6fedc26fb249a1f87c2da9c3ff7edf97/Testing/repository/GenericRepository.cs
//     public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
//     {
//         protected readonly ApplicationDbContext _context;

//         protected GenericRepository(ApplicationDbContext context)
//         {
//             _context = context;
//         }

//         public async Task<T> GetById(object id)
//         {
//             return await _context.Set<T>().FindAsync(id);
//         }

//         public async Task<IEnumerable<T>> GetAll()
//         {
//             return await _context.Set<T>().ToListAsync();
//         }

//         public async Task Add(T entity)
//         {
//             await _context.Set<T>().AddAsync(entity);
//         }

//         public void Delete(T entity)
//         {
//             _context.Set<T>().Remove(entity);
//         }

//         public void Update(T entity)
//         {
//             _context.Set<T>().Update(entity);
//         }
//     }
// }