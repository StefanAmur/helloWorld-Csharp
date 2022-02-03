// See https://aka.ms/new-console-template for more information
string helloText = "Hello, World! This is my first C# experience! Looks cool, ngl.";

Console.WriteLine(helloText);
Console.WriteLine("What is your name, if you don't mind me asking?");

var firstAnswer = Console.ReadLine();
var firstLow = firstAnswer?.ToLower();
firstLow = firstLow != null ? firstLow[0].ToString().ToUpper() + firstLow.Substring(1) : string.Empty;

if (firstLow == "Stefan" || firstLow == "Brebre")
{
    Console.WriteLine($"Oh, hi there, sexy and beautiful {firstLow}");
}
else
{
    Console.WriteLine(value: $"Hello, {firstLow}!");
}

Console.WriteLine("How was your day?");

var secondAnswer = Console.ReadLine();

if(secondAnswer == "good")
{
    Console.WriteLine(value: $"Glad to hear you had a {secondAnswer} day.");
}
else
{
    Console.WriteLine(value: $"Copy that, your day was {secondAnswer}");
}