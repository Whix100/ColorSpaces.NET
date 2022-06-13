namespace ColorSpaces;

internal static class ColorSpaceConverter
{
    /// <summary>
    /// Converts the 8-bit red, green, and blue values to a hexadecimal unsigned integer color code.
    /// </summary>
    /// <param name="red">The red value of the color.</param>
    /// <param name="green">The green value of the color.</param>
    /// <param name="blue">The blue value of the color.</param>
    /// <returns>
    /// A uint hexadecimal value of the color calculated from <c>red</c>, <c>green</c>, and <c>blue</c>.
    /// </returns>
    internal static uint ConvertRGBToHexadecimal(byte red, byte green, byte blue)
        => (uint)((red << 16) | (green << 8) | blue);

    /// <summary>
    /// Converts the unsigned integer hexadecimal color code to 8-bit red, green, and blue values.
    /// </summary>
    /// <param name="hex">The hexadecimal color code of the color.</param>
    /// <returns>
    /// A byte[] containing the red, green, and blue values of the color calculated from <c>hex</c>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the value of <c>hex</c> is outside the range of 0x000000 to 0xffffff.
    /// </exception>
    internal static byte[] HexadecimalToRGB(uint hex)
    {
        ErrorUtils.CheckForArgumentOutOfRangeException(hex, 0, 0xFFFFFF, nameof(hex));

        return new byte[] { (byte)((hex >> 16) & 0xFF), (byte)((hex >> 8) & 0xFF), (byte)(hex & 0xFF) };
    }
}
