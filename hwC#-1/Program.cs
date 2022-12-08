// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число ");
        int Num = int.Parse(Console.ReadLine());
        if (100 <= Num && Num <= 999)
        {
            int Num1 = Num % 100;
            int Num2 = Num % 10;
            int res = (Num1 - Num2) / 10;
            Console.WriteLine($"{res}");
        }
        else
            Console.WriteLine("Это не трехзначное число");
    }
}