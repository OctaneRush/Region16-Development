namespace domain.AttendeeAggregate;

public interface IAttendeeRepository : IGenericRepository<Attendee>
{
    Task<Attendee> GetAttendeeById(int id);
    Task<IEnumerable<Attendee>> GetAttendees();
    Task AddAttendee(Attendee attendee);
    void DeleteAttendee(Attendee attendee);
    void UpdateAttendee(Attendee attendee);
}