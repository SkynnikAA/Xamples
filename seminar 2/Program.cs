//1. 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


//int num = new Random().Next(100 , 1000) ;
//int num1  = num % 10 ;
//int num2  = num / 100 ;
//int num3  = num2 * 10 + num1 ;
// int num4  = num3 + num1 ;
//Console.WriteLine(num);
        //Console.WriteLine(num1);
        //Console.WriteLine(num2);
//Console.WriteLine(num3);
        //Console.WriteLine(num4);

//12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

//Convert.
//Console.ReadLine()
int R(int number1, int number2 )
{
    int result = number1%number2;

    Console.WriteLine(number1+" , "+number2+" -> ");


}