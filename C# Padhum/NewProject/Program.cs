using System;
//              Part 3 - Coin Flip Challenge
// Random coinFlip = new Random();
// int flipNum = coinFlip.Next(1,3);
// string flipResult = flipNum == 1 ? "Heads":"Tails";
// System.Console.WriteLine($"The result of coin flip is: {flipResult}");

string permission = "Admin|Manager";
int level = 53;
if (permission.Contains("Admin"))
{
    if (level > 55)
        System.Console.WriteLine("Welcome, Super Admin user.");
    else
        System.Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        System.Console.WriteLine("Contact an Admin for access.");
    else
        System.Console.WriteLine("You do not have sufficient privileges.");
}
else
    System.Console.WriteLine("You do not have sufficient privileges.");