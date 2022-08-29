namespace RNtNConsole;

using RomanNumsUtils;
using static RomanNumsUtils.ConsoleUtils;
using static System.Console;

/// <summary>
/// 	Main runnable class
/// </summary>

internal class Program
{
	static void Main(string[] args)
	{
		Write("Enter roman numeral: ");
		string? RomanNumeralInput = ReadLine() ?? "";

		Validator validator = new Validator(RomanNumeralInput);
		Parser parser = new Parser(RomanNumeralInput);
		if (validator.Validate()) {
			WriteLine(parser.Parse());
		} else {
			WriteColor(validator.error, ConsoleColor.Red);
		}
	}
}
