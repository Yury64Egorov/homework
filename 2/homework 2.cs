using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату X:");
        string inputX = Console.ReadLine();

        Console.WriteLine("Введите координату Y:");
        string inputY = Console.ReadLine();

        // Пытаемся преобразовать введенные строки в числа
        if (double.TryParse(inputX, out double x) && double.TryParse(inputY, out double y))
        {
            // Проверяем, в какой координатной четверти находится точка
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в первой координатной четверти.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во второй координатной четверти.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в третьей координатной четверти.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в четвертой координатной четверти.");
            }
            else
            {
                Console.WriteLine("Точка лежит на одной из координатных осей.");
            }
        }
        else
        {
            Console.WriteLine("Неверный формат координат!");
        }
    }
}
