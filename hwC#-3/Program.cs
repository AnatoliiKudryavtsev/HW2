//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число от 1 до 7: ");
        int Num = int.Parse(Console.ReadLine());
        if (Num <= 5)
        {
            Console.WriteLine("Рабочий день");
        }
        else if (Num >= 6 && Num <= 7)
        {
            Console.WriteLine("Выходной");
        }
        else
            Console.WriteLine("Не является числом от 1 до 7");
    }
}