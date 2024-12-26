namespace Domain.WorkingSessions.Models;

public class FinishedWorkingSession : AbstractWorkingSession
{
    public required DateTime StartTime { get; set; }
    public required DateTime EndTime { get; set; }
    public TimeSpan BreakDuration { get; set; }

    private FinishedWorkingSession() { }

    public static FinishedWorkingSession CreateFromPending(PendingWorkingSession pendingWorkingSession) => new()
    {
        Id = pendingWorkingSession.Id,
        StartTime = pendingWorkingSession.StartTime,
        EndTime = DateTime.Now,
        BreakDuration = TimeSpan.Zero,
        Description = pendingWorkingSession.Description,
    };

    public override TimeSpan WorkingDuration => (EndTime - StartTime) - BreakDuration;
}
