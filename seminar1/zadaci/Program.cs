Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите корень первго числа");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
    {
    Console.WriteLine("да");
    }
else
    {
    Console.WriteLine("нет");
    }
