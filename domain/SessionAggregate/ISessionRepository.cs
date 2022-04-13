namespace domain.SessionAggregate;

public interface ISessionRepository : IGenericRepository<Session>
{
    Task<Session> GetSessionById(int id);
    Task<IEnumerable<Session>> GetSessions();
    Task AddSession(Session session);
    void DeleteSession(Session session);
    void UpdateSession(Session session);
}