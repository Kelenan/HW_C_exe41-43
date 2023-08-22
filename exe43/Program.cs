/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

double k1 = GetNumberFromUser("Напишите число: ", "Ошибка! Введите целое число.");
double b1 = GetNumberFromUser("Напишите число: ", "Ошибка! Введите целое число.");
double k2 = GetNumberFromUser("Напишите число: ", "Ошибка! Введите целое число.");
double b2 = GetNumberFromUser("Напишите число: ", "Ошибка! Введите целое число.");

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"х = {x}, y = {y}");


double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}