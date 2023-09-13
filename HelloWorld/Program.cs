// super mario

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