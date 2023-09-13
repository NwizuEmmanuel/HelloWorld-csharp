// countdown
Console.Write("Starting number? ");
var input = Console.ReadLine();
int numberOfSeconds = Convert.ToInt32(input);

do
{
    Console.Write(numberOfSeconds + " ");
    numberOfSeconds--;
} while (numberOfSeconds >= 1);