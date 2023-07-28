using MyLib;

// Урок 5. Функции и одномерные массивы

void Task34()
{
    // Задача 34. 
    // Задайте массив заполненный случайными положительными трёхзначными числами.
    // Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = MyLibClass.Input("Введите размер массива: ");

    int[] numbers = new int[size];

    MyLibClass.FillArray(numbers, 100, 999);
    MyLibClass.PrintArray(numbers);

    Console.WriteLine($"Количество чётных чисел в массиве = {MyLibClass.AmountEvenNum(numbers)}");

}

void Task36()
{
    // Задача 36. 
    // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

    int size = MyLibClass.Input("Введите размер массива: ");

    int[] numbers = new int[size];

    MyLibClass.FillArray(numbers);
    MyLibClass.PrintArray(numbers);

    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2) sum += numbers[i];

    Console.WriteLine($"Cумма элементов с нечётными индексами равна: {sum}");


}

void Task38()
{
    // Задача 38.
    // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

    int size = MyLibClass.Input("Введите размер массива: ");

    double[] numbers = new double[size];

    MyLibClass.FillArray(numbers);
    MyLibClass.PrintArray(numbers);

    double max = numbers[0];
    double min = numbers[0];
    double diff = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
        else if (numbers[i] < min) min = numbers[i];
    }
    diff = max - min;

    Console.WriteLine($"Максимальный элемент массива: {max}");
    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(diff, 2)}");

}

Task38();


