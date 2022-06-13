namespace ColorSpaces;

internal static class ErrorUtils
{
    /// <summary>
    /// Checks whether an IComparable is out of a range and throws an exception if it is.
    /// </summary>
    /// <param name="argument">The value to check.</param>
    /// <param name="min_value">The minimum value of the range.</param>
    /// <param name="max_value">The maximum value of the range.</param>
    /// <param name="name">The name of the variable <c>argument</c> get's its value from.</param>
    /// <param name="inclusive">Whether the range to check is inclusive or exclusive.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the value of <c>argument</c> is outside the range determined by <c>min_value</c> and 
    /// <c>max_value</c>.
    /// </exception>
    internal static void CheckForArgumentOutOfRangeException(IComparable argument, IComparable min_value,
        IComparable max_value, string name, bool inclusive = true)
    {
        if (inclusive && (min_value.CompareTo(argument) < 1 || max_value.CompareTo(argument) > -1))
            throw new ArgumentOutOfRangeException(name, argument, $"{name} must be a value greater than or equal to " +
                $"{min_value} and less than or equal to {max_value}.");
        else if (!inclusive && (min_value.CompareTo(argument) < 0 || max_value.CompareTo(argument) > 0))
            throw new ArgumentOutOfRangeException(name, argument, $"{name} must be a value greater than {min_value} " +
                $"and less than {max_value}.");
    }
}
