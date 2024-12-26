using Microsoft.AspNetCore.Components;

namespace WebApp.Components;

public partial class CircleButton : ComponentBase
{
    [Parameter]
    public EventCallback<bool> WorkingToggled { get; set; }

    public string _currentText { get; private set; } = "Go";
    private bool _isTracking = false;

    public void ToggleState()
    {
        _isTracking = !_isTracking;

        WorkingToggled.InvokeAsync(_isTracking);
        _currentText = _isTracking ? "Stop" : "Go";
    }
}
