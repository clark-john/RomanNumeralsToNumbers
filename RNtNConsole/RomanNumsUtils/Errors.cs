namespace RomanNumsUtils;

/// <summary>
/// 	Static class for holding strings of errors
/// </summary>

public static class Errors
{
	public static string InvalidRomanNumeral = "Invalid roman numeral.";
	public static string InvalidNumeralVerbosity(string numeral, int verbosity) => $"{numeral} cannot have more than ${verbosity} numerals.";
	public static string InvalidNumeralOrder = "Invalid roman numeral order.";
}
