/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


Console.Clear();

int M = GetNumberFromUser("Напишите сколько чисел вы хотите ввести? ", "Ошибка! Введите целое число.");

int[] array = GetArray(M);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество элементов больше нуля: {GetPositivSum(array)}");

int GetPositivSum(int[] massiv)
{
    int sum = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > 0)
            sum++;
    }
    return sum;
}


//
int[] GetArray(int M)
{
    int[] res = new int[M];
    for (int i = 0; i < M; i++)
    {
        res[i] = GetNumberFromUser($"Введите {i} элемент массива: ", "Ошибка! Введите целое число.");
    }
    return res;
}


//
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}