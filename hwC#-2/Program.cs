//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите любое число ");
        int Num = int.Parse(Console.ReadLine());
        while (Num > 999)
        {
            Num = Num / 10;
        }
        if (100 <= Num)
        {
            int Num3 = Num % 10;
            Console.WriteLine($"{Num3}");
        }
        else
            Console.WriteLine("третьей цифры нет");
    }
}