void ThirdNumber(string num)
{
   if(num.Length < 3)
    Console.WriteLine("No third number");
    else Console.WriteLine(num[2]);
}

Console.WriteLine("input your number");
int number = Convert.ToInt32(Console.ReadLine());
string InputNumber = Convert.ToString(number);

ThirdNumber(InputNumber);
