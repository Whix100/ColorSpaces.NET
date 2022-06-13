namespace ColorSpaces.Colors;

public struct RGBColor : IColor
{
    public bool IsNormalized
        => true;

    public uint Hex
        => ColorSpaceConverter.ConvertRGBToHexadecimal(R, G, B);

    public double Alpha
    {
        get;
    }

    /// <summary>
    /// Red value of the current color.
    /// </summary>
    public byte R
    {
        get;
    }

    /// <summary>
    /// Green value of the current color.
    /// </summary>
    public byte G
    {
        get;
    }

    /// <summary>
    /// Blue value of the current color.
    /// </summary>
    public byte B
    {
        get;
    }

    /// <summary>
    /// Initializes a new RGBColor from red, green, and blue. The alpha value is implicitly 255 for full opacity.
    /// </summary>
    /// <param name="red">The red value for the color.</param>
    /// <param name="green">The green value for the color.</param>
    /// <param name="blue">The blue value for the color.</param>
    /// <param name="alpha">The alpha transparency value for the color.</param>
    public RGBColor(int red, int green, int blue, double alpha = 1)
    {
        ErrorUtils.CheckForArgumentOutOfRangeException(red, 0, 0xFF, nameof(red));
        ErrorUtils.CheckForArgumentOutOfRangeException(green, 0, 0xFF, nameof(green));
        ErrorUtils.CheckForArgumentOutOfRangeException(blue, 0, 0xFF, nameof(blue));

        R = (byte)red;
        G = (byte)green;
        B = (byte)blue;
        Alpha = alpha;
    }

    public IColor Normalize()
        => this;

    public RGBColor ConvertToRGBColor()
        => this;

    public override int GetHashCode()
        => (int)Hex;

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        if (obj is Color)
            return Equals((Color)obj);

        if (obj is KnownColor)
            return Equals((KnownColor)obj);

        if (obj is IColor)
            return Equals((IColor)obj);

        return false;
    }

    public bool Equals(Color other)
        => other.R == this.R && other.G == this.G && other.B == this.B;

    public bool Equals(KnownColor other)
    {
        Color other_color = Color.FromKnownColor(other);

        return other_color.R == this.R && other_color.G == this.G && other_color.B == this.B;
    }

    public bool Equals(IColor? other)
    {
        if (other is null)
            return false;

        if (other.GetType() == typeof(RGBColor))
        {
            RGBColor rgb = (RGBColor)other;

            return rgb.R == this.R && rgb.G == this.G && rgb.B == this.B;
        }

        return false;
    }

    public static bool operator ==(RGBColor a, IColor? b)
        => Equals(a, b);

    public static bool operator ==(RGBColor a, Color b)
        => Equals(a, b);

    public static bool operator ==(RGBColor a, KnownColor b)
        => Equals(a, b);

    public static bool operator !=(RGBColor a, IColor? b)
        => !Equals(a, b);

    public static bool operator !=(RGBColor a, Color b)
        => !Equals(a, b);

    public static bool operator !=(RGBColor a, KnownColor b)
        => !Equals(a, b);
}
