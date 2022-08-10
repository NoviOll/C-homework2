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
