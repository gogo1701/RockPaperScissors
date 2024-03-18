const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}
Console.WriteLine($"The computer chose {computerMove}.");

if(playerMove == "Rock")
{
    if(computerMove == "Rock")
    {
        Console.WriteLine("The game was a draw.");
    }
    if (computerMove == "Paper")
    {
        Console.WriteLine("You lose.");
    }
    if (computerMove == "Scissors")
    {
        Console.WriteLine("You win.");
    }
}
if (playerMove == "Paper")
{
    if (computerMove == "Rock")
    {
        Console.WriteLine("You win.");
    }
    if (computerMove == "Paper")
    {
        Console.WriteLine("The game was a draw.");
    }
    if (computerMove == "Scissors")
    {
        Console.WriteLine("You lose.");
    }
}
if (playerMove == "Scissors")
{
    if (computerMove == "Rock")
    {
        Console.WriteLine("You lose.");
    }
    if (computerMove == "Paper")
    {
        Console.WriteLine("You win.");
    }
    if (computerMove == "Scissors")
    {
        Console.WriteLine("The game was a draw.");
    }
}