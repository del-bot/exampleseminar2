void ThreeDigitalNumber(int number)
{
    int num = number % 100;
    int result = num / 10;
    Console.WriteLine(result);
}

Console.WriteLine("input your three digital number ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

ThreeDigitalNumber(inputNumber);
