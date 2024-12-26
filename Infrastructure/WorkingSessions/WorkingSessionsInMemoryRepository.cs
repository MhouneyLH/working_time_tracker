using Domain.WorkingSessions;
using Domain.WorkingSessions.Model;

namespace Infrastructure.WorkingSessions;

public class WorkingSessionsInMemoryRepository : IWorkingSessionsRepository
{
    private readonly List<AbstractWorkingSession> _workingSessions = [];

    public Task AddAsync(AbstractWorkingSession workingSession)
    {
        _workingSessions.Add(workingSession);
        return Task.CompletedTask;
    }

    public Task<AbstractWorkingSession> GetByIdAsync(WorkingSessionId id)
    {
        var workingSession = _workingSessions.FirstOrDefault(ws => ws.Id == id);
        return Task.FromResult(workingSession);
    }

    public Task UpdateAsync(AbstractWorkingSession workingSession)
    {
        var index = _workingSessions.FindIndex(ws => ws.Id == workingSession.Id);
        _workingSessions[index] = workingSession;
        return Task.CompletedTask;
    }
}
