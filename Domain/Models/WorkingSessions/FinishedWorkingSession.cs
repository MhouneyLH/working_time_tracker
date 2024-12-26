namespace Domain.Models.WorkingSessions;

public class FinishedWorkingSession : AbstractWorkingSession
{
    public required DateTime StartTime { get; set; }
    public required DateTime EndTime { get; set; }
    public TimeSpan BreakDuration { get; set; }

    public override TimeSpan WorkingDuration => (EndTime - StartTime) - BreakDuration;
}
