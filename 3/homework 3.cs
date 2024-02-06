 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число из отрезка [10, 99]:");
        string input = Console.ReadLine();

        // Пытаемся преобразовать введенную строку в число
        if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
        {
            int firstDigit = number / 10; // Получаем первую цифру
            int secondDigit = number % 10; // Получаем вторую цифру

            int maxDigit = Math.Max(firstDigit, secondDigit);

            Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}");
        }
        else
        {
            Console.WriteLine("Неверный формат числа или число не из отрезка [10, 99]!");
        }
    }
}
