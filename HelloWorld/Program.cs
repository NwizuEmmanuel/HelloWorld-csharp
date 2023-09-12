Console.WriteLine("Is it raining?");
bool question = Convert.ToBoolean(Console.ReadLine());

var isRainyDay = (question == true) ? "Yes, It's Rainy" : "No, It's Sunny";


if (question == true)
{
    Console.WriteLine($"{isRainyDay}\n");
    Console.WriteLine("Enter amount of rain gauged(cm) :");
    int rainGauged = Convert.ToInt32(Console.ReadLine());

    // to checked gauged rain
    // if 0 - 60 is normal rainfall
    // 61 - 80 is heavy rainfall
    // 81 and above is thurnderstorm

    if (rainGauged <= 60)
    {
        Console.WriteLine("It's a normal rainfall.");
    }else if (rainGauged <= 80)
    {
        Console.WriteLine("Ooh no, it's a heavy rainfall");
    }else if (rainGauged > 81)
    {
        Console.WriteLine("You can't go outside. stay put it's a Thurnderstorm.");
    }
}else
{
    Console.WriteLine("Enjoy your day.");
}