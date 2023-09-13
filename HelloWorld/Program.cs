// super mario

internal class Program
{
    private static void Main(string[] args)
    {
        haltCheckForOddNumbers();
    }

    private static void superMario()
    {
        Console.Write("Height? ");
        var input = Console.ReadLine();
        int height = Convert.ToInt32(input);

        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    private static void listCars()
    {
        string[] cars = { "Ford", "Ferrari", "Bugati", "Lamghogini", "Porche" };
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static void checkForEvenNumber()
    {
        int[] numbers = { 1, 3, 4, 10 };
        int countEvenNumbers = 0;

        foreach(int i in numbers)
        {
            if (i % 2 == 0)
            {
                countEvenNumbers++;
            }
        }

        var message = $"There are {countEvenNumbers} even numbers";
        Console.WriteLine(message);
    }

    private static void haltCheckForOddNumbers()
    {
        int[] numbers = { 2, 4, 5, 3, 9 };
        int checkedNumbers = 0;

        foreach(int i in numbers)
        {
            checkedNumbers++;
            if (i % 2 != 0)
            {
                break;
            }
        }

        var message = "Odd number detected.\nHalting program\nDone\n";
        var message2 = $"Total checked numbers: {checkedNumbers}\nTotal number: {numbers.Length}";
        Console.WriteLine(message);
        Console.WriteLine(message2);
    } 
}