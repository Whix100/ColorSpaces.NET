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

    /// <summary>
    /// Calculates the normalized values for the current color.
    /// </summary>
    /// <returns>
    /// An IColor representing the normalized version of the current color.
    /// </returns>
    public IColor Normalize();

    /// <summary>
    /// Converts the current color to it's equivalent RGBColor struct.
    /// </summary>
    /// <returns>
    /// A RGBColor struct equivalent to the current color.
    /// </returns>
    public RGBColor ConvertToRGBColor();
}
