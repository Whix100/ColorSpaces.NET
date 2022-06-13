namespace ColorSpaces.Colors;

public interface IColor : IEquatable<Color>, IEquatable<KnownColor>, IEquatable<IColor>
{
    /// <summary>
    /// <c>true</c> if the current color is in it's normal form, <c>false</c> otherwise.
    /// </summary>
    public bool IsNormalized
    {
        get;
    }

    /// <summary>
    /// Hexadecimal color code for the current color.
    /// </summary>
    public uint Hex
    {
        get;
    }

    /// <summary>
    /// Alpha transparency value for the current color.
    /// </summary>
    public double Alpha
    {
        get;
    }
}
