using System.Text.RegularExpressions;

Console.WriteLine("Введите строку:");
string inputstring = Console.ReadLine();

string needstring = @"\b(\w+)\b(.*?)\b\1\b";

string resultstring = Regex.Replace(inputstring, needstring, @"<strong>$1</strong>$2<strong>$1</strong>");

Console.WriteLine(resultstring);