namespace Domain.WorkingSessions.Models;

public class PendingWorkingSession : AbstractWorkingSession
{
    public DateTime StartTime { get; set; }

    private PendingWorkingSession()
    {
        Id = WorkingSessionId.CreateNew();
        StartTime = DateTime.Now;
        Description = string.Empty;
    }

    public static PendingWorkingSession Create() => new();

    public override TimeSpan WorkingDuration => DateTime.Now - StartTime;
}
