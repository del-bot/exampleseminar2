void DayOfTheWeek(int day)
{
    if (day == 6 || day == 7)
        Console.WriteLine("It is a weekend");
    else Console.WriteLine("It is not a weekend, sorry");
}

Console.WriteLine("Input your day number");
int number = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek(number);
