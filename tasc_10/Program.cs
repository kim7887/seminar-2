// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёх значное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = (numberA%100) / 10;

if (numberA<1000 && numberA>99)
{
    Console.WriteLine("ответ:"+numberB);
}
else
{
    Console.WriteLine("ошибка вы ввели не трёх значное число");
}