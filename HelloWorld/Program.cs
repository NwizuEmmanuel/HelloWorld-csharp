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