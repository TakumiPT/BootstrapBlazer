using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
namespace Core;

public partial class Tooltip : ComponentBase, IAsyncDisposable
{
	private bool isFirstRenderComplete = false;
	private string? title;


	[Parameter]
	public string? ElementId { get; set; }

	public ElementReference ElementRef { get; set; }

	[Inject] protected IJSRuntime JS { get; set; } = default!;

	[Parameter]
	public RenderFragment ChildContent { get; set; } = default!;
	private string placement => Placement.ToTooltipPlacementName();

	[Parameter]
	public TooltipPlacement Placement { get; set; } = TooltipPlacement.Top;

	[Parameter]
	[EditorRequired]
	public string Title { get; set; } = default!;


	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		title = Title;

		await JS.InvokeVoidAsync("window.blazorBootstrap.tooltip.initialize", ElementRef);

		await base.OnAfterRenderAsync(firstRender);
	}



	public async ValueTask DisposeAsync()
	{

		await JS.InvokeVoidAsync("window.blazorBootstrap.tooltip.dispose", ElementRef);
	}
}