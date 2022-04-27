using domain.SpeakerAggregate;
using domain.SessionAggregate;
using domain.AttendeeAggregate;

namespace domain;

public interface IUnitOfWork : IDisposable
{
    ISpeakerHelper Helper {get;}
    IAttendeeRepository Attendees {get;}
    ISessionRepository Sessions {get;}
    ISpeakerRepository Speakers {get;}
    int Complete();
}