// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, select your gender (m/f):!");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("enter your last name:");
string userlastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userlastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userlastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userlastname}");
}