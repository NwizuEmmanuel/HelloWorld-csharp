class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Addition: {AddNumbers(50, 40)}");
    }

    static void SayHello()
    {
        Console.WriteLine("Hello, world.");
    }

    static void GreetPerson(string firstname)
    {
        Console.WriteLine($"Hello, {firstname}");
    }

    static void DisplayUserInfo(string firstname, string lastname, int age)
    {
        Console.WriteLine($"Fullname: {firstname} {lastname}\nAge: {age}");
    }

    static void WelcomeMessage(string name = "John Doe")
    {
        Console.WriteLine($"Welcome to PizzaHut, {name}");
    }

    static int AreaOfSquare(int width, int height)
    {
        return width * height;
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static double AddNumbers(double a, double b)
    {
        return a + b;
    }
}