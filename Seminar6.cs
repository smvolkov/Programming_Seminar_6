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

//PositiveNumbers(QtyRequest());

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void LinesCross(double b1, double k1, double b2, double k2)
{
    double x0 = (b2 - b1) / (k1 - k2);
    double y0 = k1 * x0 + b1;

    Console.WriteLine($"({x0}; {y0})");
}

double Coefficients(string coeffName)
{
    Console.WriteLine($"Введите коеффициент {coeffName}: ");
    double coeff = double.Parse(Console.ReadLine());

    return coeff;
}

LinesCross(Coefficients("b1"), Coefficients("k1"), Coefficients("b2"), Coefficients("k2"));