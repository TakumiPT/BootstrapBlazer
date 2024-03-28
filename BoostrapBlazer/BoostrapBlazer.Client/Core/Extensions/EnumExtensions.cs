namespace Core;

public static class EnumExtensions
{
	public static string ToTooltipPlacementName(this TooltipPlacement tooltipPlacement) =>
		tooltipPlacement switch
		{
			TooltipPlacement.Auto => "auto",
			TooltipPlacement.Right => "right",
			TooltipPlacement.Bottom => "bottom",
			TooltipPlacement.Left => "left",
			_ => "top"
		};
}