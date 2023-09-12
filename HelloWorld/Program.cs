Console.WriteLine("Is it raining?");
bool question = Convert.ToBoolean(Console.ReadLine());

var isRainyDay = (question == true) ? "Yes, It's Rainy" : "No, It's Sunny";

int rainGauged = 0;

if (question == true)
{
    Console.WriteLine("Enter amount of rain gauged(cm) :");
    rainGauged = Convert.ToInt32(Console.ReadLine());

    // to checked gauged rain
    // if above 60 is normal rainfall
    // above 80 is heavy rainfall
    // above 100 is thurnderstorm

    if (rainGauged < 60)
    {
        Console.WriteLine("It's a normal rainfall.");
    }else if (rainGauged )
    {

    }
}else
{
    Console.WriteLine("Enjoy your day.");
}