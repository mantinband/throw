namespace Throw;

/// <summary>
/// Extension methods for strings.
/// </summary>
public static partial class ValidatableExtensions
{
    /// <summary>
    /// Throws an exception if the string is white space only.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfWhiteSpace(this in Validatable<string> validatable)
    {
        Validator.ThrowIfWhiteSpace(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string is empty.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfEmpty(this in Validatable<string> validatable)
    {
        Validator.ThrowIfEmpty(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string is longer than <paramref name="length"/> characters.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfLongerThan(this in Validatable<string> validatable, int length)
    {
        Validator.ThrowIfLongerThan(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, length);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string is shortter than <paramref name="length"/> characters.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfShorterThan(this in Validatable<string> validatable, int length)
    {
        Validator.ThrowIfShorterThan(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, length);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string equals the given <paramref name="otherString"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="StringComparison"/> used is <see cref="StringComparison.Ordinal"/>.
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfEquals(this in Validatable<string> validatable, string otherString)
    {
        Validator.ThrowIfEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, otherString, StringComparison.Ordinal);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string equals the given <paramref name="otherString"/> using the given <paramref name="comparisonType"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfEquals(this in Validatable<string> validatable, string otherString, StringComparison comparisonType)
    {
        Validator.ThrowIfEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, otherString, comparisonType);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string does not equal the given <paramref name="otherString"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="StringComparison"/> used is <see cref="StringComparison.Ordinal"/>.
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfNotEquals(this in Validatable<string> validatable, string otherString)
    {
        Validator.ThrowIfNotEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, otherString, StringComparison.Ordinal);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string does not equal the <paramref name="otherString"/> using the given <paramref name="comparisonType"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfNotEquals(this in Validatable<string> validatable, string otherString, StringComparison comparisonType)
    {
        Validator.ThrowIfNotEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, otherString, comparisonType);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string equals the given <paramref name="otherString"/> (case insensitive).
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfEqualsIgnoreCase(this in Validatable<string> validatable, string otherString)
    {
        Validator.ThrowIfEqualsIgnoreCase(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, otherString);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string does not equal the given <paramref name="otherString"/> (case insensitive).
    /// </summary>
    /// <remarks>
    /// The <see cref="StringComparison"/> used is <see cref="StringComparison.OrdinalIgnoreCase"/>.
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfNotEqualsIgnoreCase(this in Validatable<string> validatable, string otherString)
    {
        Validator.ThrowIfNotEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, otherString, StringComparison.OrdinalIgnoreCase);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string length is equal to <paramref name="length"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfLengthEquals(this in Validatable<string> validatable, int length)
    {
        Validator.ThrowIfLengthEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, length);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string length is not equal to <paramref name="length"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfLengthNotEquals(this in Validatable<string> validatable, int length)
    {
        Validator.ThrowIfLengthNotEquals(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, length);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string ends with <paramref name="str"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfEndsWith(this in Validatable<string> validatable, string str)
    {
        Validator.ThrowIfEndsWith(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, str);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string does not end with <paramref name="str"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfNotEndsWith(this in Validatable<string> validatable, string str)
    {
        Validator.ThrowIfNotEndsWith(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, str);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string starts with <paramref name="str"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfStartsWith(this in Validatable<string> validatable, string str)
    {
        Validator.ThrowIfStartsWith(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, str);

        return ref validatable;
    }

    /// <summary>
    /// Throws an exception if the string does not start with <paramref name="str"/>.
    /// </summary>
    /// <remarks>
    /// The default exception thrown is an <see cref="ArgumentException"/>.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly Validatable<string> IfNotStartsWith(this in Validatable<string> validatable, string str)
    {
        Validator.ThrowIfNotStartsWith(validatable.Value, validatable.ParamName, validatable.ExceptionCustomizations, str);

        return ref validatable;
    }
}