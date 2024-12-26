namespace Domain.Models.WorkingSessions;

public abstract class AbstractWorkingSession
{
    public required WorkingSessionId Id { get; set; }
    public required string Description { get; set; }

    public abstract TimeSpan WorkingDuration { get; }
}
