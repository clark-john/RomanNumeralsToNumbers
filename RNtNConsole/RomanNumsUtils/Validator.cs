namespace RomanNumsUtils;

using static Errors;

/// <summary>
/// 	Class for roman numerals validation
/// </summary>

public class Validator 
{
	public string error = "";
	private string RomanNumeral;
	private string RomanNumeralLetters = "IVXLCDMivxlcdm";
	public Validator(string numeral)
	{
		RomanNumeral = numeral;
	}
	private bool IsRomanNumeral(string RomanNumeral)
	{	
		foreach (char x in RomanNumeral)
		{
			if (!(RomanNumeralLetters.Contains(x))) {
				error = InvalidRomanNumeral;
				return false;
			};	
		}	
		return true;
	}
	public bool Validate() => IsRomanNumeral(RomanNumeral) ? true : false;
}
