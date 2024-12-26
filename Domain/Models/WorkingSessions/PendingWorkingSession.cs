namespace Domain.Models.WorkingSessions;

public class PendingWorkingSession : AbstractWorkingSession
{
    public required DateTime StartTime { get; set; }

    public override TimeSpan WorkingDuration => DateTime.Now - StartTime;
}
