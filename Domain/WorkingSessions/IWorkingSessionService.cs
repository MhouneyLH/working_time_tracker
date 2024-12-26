using Domain.WorkingSessions.Models;

namespace Domain.WorkingSessions;

public interface IWorkingSessionService
{
    Task<PendingWorkingSession> StartWorkingSessionAsync();
    Task StopWorkingSessionAsync(WorkingSessionId id);
    Task<IEnumerable<FinishedWorkingSession>> GetAllFinishedWorkingSessionsAsync();
}
