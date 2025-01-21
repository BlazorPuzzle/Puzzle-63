using Microsoft.AspNetCore.Components;

namespace Puzzle63.Components;

public partial class MyCascadingComponent : ComponentBase
{
	[Parameter]
	public RenderFragment ChildContent { get; set; }

	[Parameter]
	public EventCallback<string> MyEventCallback { get; set; }

	private Timer Timer { get; set; }

	protected override void OnAfterRender(bool firstRender)
	{
		if (firstRender)
		{
			Timer = new Timer(OnTimerElapsed, null, 1000, 1000);
		}
	}

	private void OnTimerElapsed(object state)
	{
		InvokeAsync(() => MyEventCallback.InvokeAsync(DateTime.Now.ToString("T")));
	}

}