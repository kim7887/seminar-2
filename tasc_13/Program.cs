// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры
// нет
// 32679 -> 6
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 0;
bool Flag = true;
int numberofdigitsrequired = 3;
int numberofdigits = numberA;
int index = 0;
string s = $"В числе меньше {numberofdigitsrequired} цифр";
while (numberofdigits != 0)
{
    numberofdigits = numberofdigits / 10;
    index++;
}
if (index == numberofdigitsrequired)
{
    Console.WriteLine(numberA%10);
    Environment.Exit(0);
}
else if (index < numberofdigitsrequired)
{
    Console.WriteLine(s);
    Environment.Exit(0);
}
while (numberA != 0)
{
    numberA = numberA / 10;
    ++i;
    if (i >= index - numberofdigitsrequired)
    {
        Console.WriteLine(numberA % 10);
        Flag = false;
        break;
    }
}
if (Flag)
    Console.WriteLine(s);