class Program
{
    public static void Main(string[] args)
    {
        GreetPerson("John");
    }

    static void SayHello()
    {
        Console.WriteLine("Hello, world.");
    }

    static void GreetPerson(string firstname)
    {
        Console.WriteLine($"Hello, {firstname}");
    }
}