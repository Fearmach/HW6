// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (0, 7, 8, -2, -2 -> 2;    1, -7, 567, 89, 223-> 3)


void PrintArray(string arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int Num(string text)
{
    Console.Write(text);
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int numb = Num("Введите элементы(через пробел): ");
PrintArray($"Кол-во элементов > 0: {numb}");
