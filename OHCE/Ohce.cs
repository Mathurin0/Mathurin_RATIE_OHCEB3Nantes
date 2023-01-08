using System.Text;

namespace OHCE;

public class Ohce
{

	private readonly ILangue _langue;
	private readonly DayPeriod _périodeJournée;

	public Ohce(ILangue langue, DayPeriod périodeJournée)
	{
		_langue = langue;
		_périodeJournée = périodeJournée;
	}

	public string Palindrome(string input)
	{
		var reversed = new string(
			input.Reverse().ToArray()
		);

		var stringBuilder = new StringBuilder(reversed + "\n");

		if (reversed.Equals(input))
			stringBuilder.Append(_langue.BienDit);

		return stringBuilder.ToString();
	}

	public string DireBonjour()
	{
		var stringBuilder = new StringBuilder(_langue.Bonjour(_périodeJournée));

		return stringBuilder.ToString();
	}

	public string DireAurevoir()
	{
		var stringBuilder = new StringBuilder(_langue.AuRevoir);

		return stringBuilder.ToString();
	}
}