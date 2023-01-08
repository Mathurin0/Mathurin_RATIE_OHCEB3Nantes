using OHCE;
using OHCE.Console.Adapters;

var ohce = new Ohce(SystemLangueAdapter.LangueActuelle, SystemTimeDayPeriodAdapter.ActualPeriod);

Console.WriteLine(ohce.DireBonjour());

Console.WriteLine(ohce.Palindrome("laval"));

Console.WriteLine(ohce.DireAurevoir());