// super mario

internal class Program
{
    private static void Main(string[] args)
    {
        listCars();
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
}