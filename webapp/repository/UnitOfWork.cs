using domain;
using domain.SpeakerAggregate;
using domain.SessionAggregate;
using domain.AttendeeAggregate;

namespace webapp.repository;

    //Used from https://github.com/ahuimanu/CIDM4390/blob/5057d50a6fedc26fb249a1f87c2da9c3ff7edf97/Testing/repository/UnitOfWork.cs
    public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ISpeakerRepository Speakers { get; }

        public ISessionRepository Sessions { get; }
        
        public IAttendeeRepository Attendees {get; }

        public UnitOfWork(ApplicationDbContext applicationDbContext, 
                          ISpeakerRepository speakersRepository, 
                          ISessionRepository sessionsRepository,
                          IAttendeeRepository attendeesRepository)
        {
            this._context = applicationDbContext;
            this.Speakers = speakersRepository;
            this.Sessions = sessionsRepository;
            this.Attendees = attendeesRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }