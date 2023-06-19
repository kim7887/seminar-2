//  Задача 15: Напишите программу, которая принимает
// на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число ");
int input = Convert.ToInt32(Console.ReadLine());
if (input>=1 && input<6)
{
    Console.WriteLine("работаешь:"+input);
}
if (input>7 )
{
    Console.WriteLine("ты чо курил я тоже хочу:)");
}

else
{
    Console.WriteLine("кайфуешь отдыхаешь");
}