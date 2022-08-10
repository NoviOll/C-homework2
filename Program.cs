// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число:");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
if (stringNumber.Length == 3)
{
    Console.WriteLine("Вторая цифра этого числа " + stringNumber[1]);
}
else 
{
    Console.WriteLine("Число не является трёхзначным");
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
if (stringNumber.Length > 2)
{
    Console.WriteLine("Третья цифра этого числа " + stringNumber[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}


//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 5)
{
    Console.WriteLine("Это выходной день");
}
else 
{
    Console.WriteLine("Это не выходной день");
}
