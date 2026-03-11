Random rand = new Random();
int number = rand.Next(1, 11);
int guess;

Console.WriteLine("Guess a number between 1 and 10");
while (!int.TryParse(Console.ReadLine(), out guess))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
if (guess > number)
{
    Console.WriteLine("Too high");
}


else if (guess < number)
{
    Console.WriteLine("Too low");
}
else
{
    Console.WriteLine("Congratulations! You guessed the number.");
}
Console.WriteLine("Do you want to play again? (yes/no)");
    
