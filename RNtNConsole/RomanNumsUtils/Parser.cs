namespace RomanNumsUtils;

/// <summary>
/// 	Class for parsing roman numerals into hindu-arabic numerals (0-9)
/// </summary>

public class Parser
{
	private readonly Dictionary<char, int> RomanNumeralValues = 
	new Dictionary<char, int>() 
	{
		{ 'M', 1000 },
		{ 'D', 500 },
		{ 'C', 100 },
		{ 'L', 50 },
		{ 'X', 10 },
		{ 'V', 5 },
		{ 'I', 1 },
		{ ' ', 0 }
	};
	private Numeral numeral;
	public Parser(string num)
	{
		numeral = new Numeral(num);
	}
	private char ToNonNullCharAndUpper(char? c) => Char.ToUpper(Convert.ToChar(c ?? ' '));
	private bool IsNextNumeralLarger(int first, int? next) => first < next && next != null ? true : false;
	public int Parse()
	{
		int result = 0;
		for (int x = 0; x < numeral.Length; x++) 
		{
			int PreviousValue = RomanNumeralValues[ToNonNullCharAndUpper(numeral[x])];
			int NextValue = RomanNumeralValues[ToNonNullCharAndUpper(numeral[x + 1])];
			
			if (IsNextNumeralLarger(PreviousValue, NextValue)) {
				result += (NextValue - PreviousValue) - NextValue;
			} else {	
				result += PreviousValue;
			}
		}	
		return result;
	}
}
