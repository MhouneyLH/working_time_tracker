using Microsoft.AspNetCore.Components;

namespace WorkingTimeTracker.WebApp.Components;

public partial class CircleButton : ComponentBase
{
    public string _currentText { get; private set; } = "Go";
    private bool _isTracking = false;

    public void ToggleState()
    {
        _isTracking = !_isTracking;
        _currentText = _isTracking ? "Stop" : "Go";
    }
}
