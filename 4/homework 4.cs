using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число N:");
        string input = Console.ReadLine();

        // Пытаемся преобразовать введенную строку в число
        if (int.TryParse(input, out int n) && n > 0)
        {
            Console.Write("Цифры числа через запятую: ");

            // Преобразуем число в строку, чтобы обращаться к его цифрам по отдельности
            string numberString = n.ToString();

            // Выводим цифры через запятую
            for (int i = 0; i < numberString.Length; i++)
            {
                Console.Write(numberString[i]);

                // Добавляем запятую, если не последняя цифра
                if (i < numberString.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Неверный формат числа или число не является натуральным!");
        }
    }
}
