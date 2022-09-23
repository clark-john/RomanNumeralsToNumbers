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
	private string numeral;
	public Parser(string num)
	{
		numeral = num;
	}
	private char ToNonNullCharAndUpper(char? c) => Char.ToUpper(Convert.ToChar(c ?? ' '));
	public int Parse()
	{
		ConfigLoader l = new ConfigLoader();
		l.Load("./rntn.yml");
		int result = 0;
		if (!l.IsViceVersa) {
			int previousValue = 0;
			foreach (char x in numeral.Reverse().ToArray()) {
				int number = RomanNumeralValues[ToNonNullCharAndUpper(x)];
				result += number < previousValue ? -number : number; 
				previousValue = number;
			}				
		}
		return result;
	}
}
