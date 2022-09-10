// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your age");

int userage = Int32.Parse(Console.ReadLine());

if (userage >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram");
}