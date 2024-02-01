// See https://aka.ms/new-console-template for more information
int diceSides = 0;
string userChoice = "";
do
{
    Console.WriteLine("Welcome to the Dice Roller Game");
    Console.WriteLine("How many sides would you like for your dice? Please enter a number");

    try
    {
        diceSides = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a number!");
        continue;
    }
    Console.WriteLine("Click 'Enter' to roll the dice.");
    Console.ReadKey();
    Random diceRandom = new Random();
    int diceNum1 = diceRandom.Next(1, diceSides + 1);
    int diceNum2 = diceRandom.Next(1, diceSides + 1);
    if (diceSides != 6)
    {
        Console.WriteLine($"You got {diceNum1} and {diceNum2}. The total is {diceNum1 + diceNum2}");
    }
    else
    {
        Console.WriteLine(twoDice(diceNum1, diceNum2));
        Console.WriteLine(twoDiceSides(diceNum1, diceNum2)); 
        
    }
    Console.WriteLine("Would you like to play again? (Y/N)");
    userChoice = Console.ReadLine();
    if (userChoice.ToLower() != "y") { Console.WriteLine("Thank you for playing. Goodbye!"); break; }
} while (userChoice.ToLower() == "y");

Console.Read();
static string twoDice (int num1, int num2)
{
    if (num1 == 1 && num2 == 1) { return "Snake Eyes"; }
    else if (num1 == 1 && num2 ==2 || num1 ==2 && num2 == 1) { return "Ace Deuce"; }
    else if (num1 == 6 && num2 == 6) { return "Box Cars"; }
    else { return ""; }
}
static string twoDiceSides (int num1, int num2)
{
    if (num1 + num2 == 7 || num1 + num2 == 11) { return "Win"; }
    else if (num1 + num2 == 2 || num1 + num2 == 3 || num1 + num2 == 12) { return "Craps"; }
    else { return ""; }
}