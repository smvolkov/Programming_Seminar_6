// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void PositiveNumbers(int m)
{
    int[] array = new int[m];
    int positiveCount = 0;

    for(int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите число №{i+1}");
        array[i] = int.Parse(Console.ReadLine());
        if (array[i] > 0) positiveCount += 1;
    }

    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine(positiveCount);
}

int QtyRequest()
{
    Console.WriteLine("Сколько чисел будете вводить?");
    int qty = int.Parse(Console.ReadLine());

    return qty;
}

PositiveNumbers(QtyRequest());