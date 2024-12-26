using Domain.WorkingSessions;
using Domain.WorkingSessions.Model;

using Infrastructure.WorkingSessions;

namespace Application.Features.WorkingSessions;

public interface IWorkingSessionService
{
    public void StartWorkingSession(PendingWorkingSession workingSession);
    public void StopWorkingSession(WorkingSessionId workingSessionId);
}

public class WorkingSessionsService : IWorkingSessionService
{
    private readonly IWorkingSessionsRepository repository;

    public WorkingSessionsService()
    {
        repository = new WorkingSessionsInMemoryRepository();
    }

    public void StartWorkingSession(PendingWorkingSession workingSession)
    {
        repository.AddAsync
    }

    public void StopWorkingSession(WorkingSessionId workingSessionId)
    {
        throw new NotImplementedException();
    }
}
