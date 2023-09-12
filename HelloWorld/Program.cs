// I love milk tea service system
var message = @"
Welcome to I Love Milk Tea. Choose from our menu:
1. Choco Cheese
2. Biscoffino
3. Vanila
4. Chocolaty
5. Fruity
";
Console.WriteLine(message);

Console.Write("What's your choice? ");

var userInput = Console.ReadLine();
byte choice = Convert.ToByte(userInput);// user's choice number

Console.Write("What's your sugar level(in %)? ");
var sugarLevelInput = Console.ReadLine();
int sugarLevel = Convert.ToInt32(sugarLevelInput);// user's sugar level

var toppings = @"
I Love Milk Tea toppings:
1. Choco Bubbles
2. Jelly Bubbles
3. Caramel Bubbles
4. No toppings
";
Console.WriteLine(toppings);
Console.Write("What's your choice?");
var toppingInput = Console.ReadLine();
byte topping = Convert.ToByte(toppingInput);// user's topping
var toppingInWord = "";

// for toppings
switch (topping)
{
    case 1:
        toppingInWord = "Choco Bubbles";
        break;
    case 2:
        toppingInWord = "Jelly Bubbles";
        break;
    case 3:
        toppingInWord = "Caramel Bubbles";
        break;
    case 4:
        toppingInWord = "no";
        break;
    default:
        Console.WriteLine("Not avaliable");
        break;
}
var output = "";

// for menu choice
switch (choice)
{
    case 1:
        output = $"Choco Cheese Milk tea with {toppingInWord} toppings and {sugarLevel} percent sugar level.";
        break;
    case 2:
        output = $"Biscoffino Milk tea with {toppingInWord} toppings and {sugarLevel} percent sugar level.";
        break;
    case 3:
        output = $"Vanila Milk tea with {toppingInWord} toppings and {sugarLevel} percent sugar level.";
        break;
    case 4:
        output = $"Chocolaty Milk tea with {toppingInWord} toppings and {sugarLevel} percent sugar level.";
        break;
    case 5:
        output = $"Fruity Milk tea with {toppingInWord} toppings and {sugarLevel} percent sugar level.";
        break;


}
Console.WriteLine("\nYour milk tea:");
Console.WriteLine(output);