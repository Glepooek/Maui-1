﻿using System.Globalization;
using CommunityToolkit.Maui.Core.Extensions;

namespace CommunityToolkit.Maui.Converters;

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="byte"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToByteAlphaConverter : BaseConverterOneWay<Color, byte>
{
	/// <inheritdoc/>
	public override byte DefaultConvertReturnValue { get; set; } = default;

	/// <inheritdoc/>
	public override byte ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetByteAlpha();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="byte"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToByteRedConverter : BaseConverterOneWay<Color, byte>
{
	/// <inheritdoc/>
	public override byte DefaultConvertReturnValue { get; set; } = default;

	/// <inheritdoc/>
	public override byte ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetByteRed();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="byte"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToByteGreenConverter : BaseConverterOneWay<Color, byte>
{
	/// <inheritdoc/>
	public override byte DefaultConvertReturnValue { get; set; } = default;

	/// <inheritdoc/>
	public override byte ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetByteGreen();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="byte"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToByteBlueConverter : BaseConverterOneWay<Color, byte>
{
	/// <inheritdoc/>
	public override byte DefaultConvertReturnValue { get; set; } = default;

	/// <inheritdoc/>
	public override byte ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetByteBlue();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="double"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToPercentCyanConverter : BaseConverterOneWay<Color, double>
{
	/// <inheritdoc/>
	public override double DefaultConvertReturnValue { get; set; } = 0.0d;

	/// <inheritdoc/>
	public override double ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetPercentCyan();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="double"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToPercentMagentaConverter : BaseConverterOneWay<Color, double>
{
	/// <inheritdoc/>
	public override double DefaultConvertReturnValue { get; set; } = 0.0d;

	/// <inheritdoc/>
	public override double ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetPercentMagenta();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="double"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToPercentYellowConverter : BaseConverterOneWay<Color, double>
{
	/// <inheritdoc/>
	public override double DefaultConvertReturnValue { get; set; } = 0.0d;

	/// <inheritdoc/>
	public override double ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetPercentYellow();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="double"/>.
/// </summary>
[AcceptEmptyServiceProvider]
public partial class ColorToPercentBlackKeyConverter : BaseConverterOneWay<Color, double>
{
	/// <inheritdoc/>
	public override double DefaultConvertReturnValue { get; set; } = 0.0d;

	/// <inheritdoc/>
	public override double ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetPercentBlackKey();
	}
}

/// <summary>
/// Converts the incoming value from <see cref="Color"/> and returns the object of a type <see cref="double"/>.
/// </summary>
// Hue is a degree on the color wheel from 0 to 360. 0 is red, 120 is green, 240 is blue.
[AcceptEmptyServiceProvider]
public partial class ColorToDegreeHueConverter : BaseConverterOneWay<Color, double>
{
	/// <inheritdoc/>
	public override double DefaultConvertReturnValue { get; set; } = 0.0d;

	/// <inheritdoc/>
	public override double ConvertFrom(Color value, CultureInfo? culture = null)
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.GetDegreeHue();
	}
}