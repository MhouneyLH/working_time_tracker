using Domain.WorkingSessions.Models;

namespace Domain.WorkingSessions;

public class WorkingSessionService : IWorkingSessionService
{
    private readonly List<PendingWorkingSession> _pendingSessions = [];
    private readonly List<FinishedWorkingSession> _finishedSessions = [];

    public async Task<PendingWorkingSession> StartWorkingSessionAsync()
    {
        var session = PendingWorkingSession.Create();
        _pendingSessions.Add(session);

        return await Task.FromResult(session);
    }

    public async Task StopWorkingSessionAsync(WorkingSessionId id)
    {
        var pendingSession = _pendingSessions.FirstOrDefault(s => s.Id == id);
        if (pendingSession == null)
        {
            throw new InvalidOperationException("Pending session not found.");
        }
        _pendingSessions.Remove(pendingSession);

        var finishedSession = FinishedWorkingSession.CreateFromPending(pendingSession);
        _finishedSessions.Add(finishedSession);

        await Task.CompletedTask;
    }

    public async Task<IEnumerable<FinishedWorkingSession>> GetAllFinishedWorkingSessionsAsync() => await Task.FromResult(_finishedSessions);
}
