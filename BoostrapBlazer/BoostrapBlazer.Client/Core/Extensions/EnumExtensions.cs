using System;

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

	public static string ToColorsName(this Colors colors) =>
		colors switch
		{
			Colors.Primary => "primary",
			Colors.Success => "success",
			Colors.Danger => "danger",
			Colors.Warning => "warning",
			Colors.Info => "info",
			Colors.Light => "light",
			Colors.Dark => "dark",
			_ => "primary"
		};

	public static string ToTableStripedNameCssClass(this TableStriped tableStriped) =>
		tableStriped switch
		{
			TableStriped.Rows => "table-striped",
			TableStriped.Columns => "table-striped-columns",
			_ => ""
		};

	public static string ToTableResponsiveNameCssClass(this TableResponsive tableResponsive)
	{
		const string prefixCssClass = "table-responsive";

		return tableResponsive switch
		{
			TableResponsive.Allways => prefixCssClass,
			TableResponsive.SM => prefixCssClass + "-sm",
			TableResponsive.MD => prefixCssClass + "-md",
			TableResponsive.LG => prefixCssClass + "-lg",
			TableResponsive.XL => prefixCssClass + "-xl",
			TableResponsive.XXL => prefixCssClass + "-xxl",
			_ => ""
		};
	}

}



