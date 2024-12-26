namespace Domain.WorkingSessions.Models;

public record WorkingSessionId
{
    public Guid Value { get; init; }

    private WorkingSessionId(Guid id) => Value = id;

    public static WorkingSessionId CreateNew() => new(Guid.NewGuid());
}
