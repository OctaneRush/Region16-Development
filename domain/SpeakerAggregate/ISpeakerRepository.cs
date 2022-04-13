namespace domain.SpeakerAggregate;

public interface ISpeakerRepository : IGenericRepository<Speaker>
{
    Task<Speaker> GetSpeakerById(int id);
    Task<IEnumerable<Speaker>> GetSpeakers();
    Task AddSpeaker(Speaker speaker);
    void DeleteSpeaker(Speaker speaker);
    void UpdateSpeaker(Speaker speaker);
            
}