namespace RomanNumsUtils;

/// <summary>
///   Class for a single Roman Numeral with special props and its indexer
/// </summary>

class Numeral {
  public Numeral(string num) {
    numeral = num;
  }
  private string numeral;
  public char? this[int x]
  {
    get => x >= numeral.Length ? null : numeral[x];
  }
  public int Length { get => numeral.Length; }
  public string GetStringNumeral() => numeral;
}
