namespace ColorSpaces.Colors;

public struct HSVColor : IColor
{
    public bool IsNormalized
    {
        get
        {
            HSVColor norm = (HSVColor)Normalize();

            return norm.H == H && norm.S == S && norm.V == V;
        }
    }

    public uint Hex
        => throw new NotImplementedException();

    public double Alpha
    {
        get;
    }

    /// <summary>
    /// Hue value of the current color.
    /// </summary>
    public double H
    {
        get;
    }

    /// <summary>
    /// Saturation value of the current color.
    /// </summary>
    public double S
    {
        get;
    }

    /// <summary>
    /// Brightness value of the current color.
    /// </summary>
    public double V
    {
        get;
    }

    /// <summary>
    /// Initializes a new HSVColor from hue, saturation, and value. The alpha value is implicitly 1 for full opacity.
    /// </summary>
    /// <param name="hue">The hue value for the color. (0 to 1)</param>
    /// <param name="saturation">The saturation value for the color. (0 to 1)</param>
    /// <param name="value">The brightness value for the color. (0 to 1)</param>
    /// <param name="alpha">The alpha transparency value for the color. (0 to 1)</param>
    public HSVColor(double hue, double saturation, double value, double alpha = 1)
    {
        ErrorUtils.CheckForArgumentOutOfRangeException(saturation, 0, 1, nameof(saturation));
        ErrorUtils.CheckForArgumentOutOfRangeException(value, 0, 1, nameof(value));
        ErrorUtils.CheckForArgumentOutOfRangeException(alpha, 0, 1, nameof(alpha));

        H = hue;
        S = saturation;
        V = value;
        Alpha = alpha;
    }

    public RGBColor ConvertToRGBColor()
        => throw new NotImplementedException();

    public bool Equals(Color other)
        => throw new NotImplementedException();

    public bool Equals(KnownColor other)
        => throw new NotImplementedException();

    public bool Equals(IColor? other)
        => throw new NotImplementedException();

    public IColor Normalize()
    {
        double hue = H % 360;

        if (hue < 0)
            hue += 360;

        return new HSVColor(hue, V == 0 ? 0 : S, V, Alpha);
    }
}
