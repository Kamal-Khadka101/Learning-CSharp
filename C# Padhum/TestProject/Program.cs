//      First
// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);


//      Second
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // roll1 = 6;
// // roll2 = 6;
// // roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {

//     if ((roll1 == roll2) && (roll2 == roll3))
//     { // you might forget to write ==, just a single = doesn't work
//         Console.WriteLine("Congratulations! You rolled a triplets!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus in total.");
//         total += 2;
//     }
// }


// if (total >= 15)
// {
//     Console.WriteLine($"You win! Your total score is {total}."); // The {total} works only when you insert $" {total}" inside the console.
// }

// // if (total < 15) (First we did this)
// else
// { //this was done later after I found out about else
//     Console.WriteLine($"Sorry, You lose! Your total score is {total}.");
// }

// if (total >= 16)
// {
//     Console.WriteLine($"Anddddd, You've won a car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine($"But hey, You won a laptop!");
// }
// else if (total >= 7)
// {
//     Console.WriteLine($"But hey, You won a trip to Pashupatinath!");
// }
// else
// {
//     Console.WriteLine($"But hey, You won a kitten!");
// }

//      Third
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine($"Your subscription has expired. {daysUntilExpiration} days were left.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage += 20;
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.{Environment.NewLine} Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage += 10;
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.{Environment.NewLine} Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your subscription will expire soon. Renew now!{daysUntilExpiration} days left.");
}
