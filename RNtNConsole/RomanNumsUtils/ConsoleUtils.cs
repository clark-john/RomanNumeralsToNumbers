namespace RomanNumsUtils;

using static System.Console;

/// <summary>
/// 	Class for console utilities
/// </summary>

static class ConsoleUtils
{
	public static void WriteColor(
		string input, 
		ConsoleColor c,
		bool withNewLine = true
	)
	{
		ForegroundColor = c;
		Write("{0}{1}", input, withNewLine ? "\n" : "");
		ResetColor();
	}
}
