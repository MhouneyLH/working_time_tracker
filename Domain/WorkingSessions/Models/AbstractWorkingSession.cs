namespace Domain.WorkingSessions.Models;

public abstract class AbstractWorkingSession
{
    public WorkingSessionId Id { get; set; }
    public string Description { get; set; }

    public abstract TimeSpan WorkingDuration { get; }
}
