﻿// Задача 41
// Пользователь вводит с клавиатуры М чисел. определить, сколько чисел больше 0 ввел пользователь
/*
int M = new Random().Next(1,10); // ограничения рандомного числа на свой выбор
Console.WriteLine($"Введите числа в количестве {M}");
int[] array = GetArray(M);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Пользователь ввел {String.Join(", ", FindNumber(array))} чисел больше 0");


int FindNumber(int[] array) // метод поиска чисел больше нуля
{
    int count = 0;
    foreach (int n in array)
    {
        if (n > 0) count ++;        
    }
    return count;
}  

int[] GetArray(int size) // метод для создания массива из введенных пользователем чисел
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        int n = int.Parse(Console.ReadLine()!);
        res[i] = n;
    }
    return res; 
}
*/

// Задача 43
// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1*x + b1, y = k2*x + b2
/*
Console.WriteLine("Введите значения b1, k1, b2, k2: ");
int b1 = int.Parse(Console.ReadLine()!);
int k1 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int k2 = int.Parse(Console.ReadLine()!);
Point(b1,k1,b2,k2);

void Point(double a,double b,double c,double d) // метод нахождения точки пересечения
{
    if (b == d) Console.WriteLine("Прямые параллельные");
    else
    {
    double x = (c-a)/(b-d); 
    double y = b*x + a;
    Console.WriteLine($"Координаты точки пересечения ({x},{y})"); 
    }
} 
*/

// Дополнительная задача.
// Найти произведение всех элементов массива целых чисел, меньших заданного числа.
// Размерность массива 10, заполнение массива случайными числами от 50 до 100
/*
Console.WriteLine("Введите число от 50 до 100 : ");
int number = int.Parse(Console.ReadLine()!);
int[] array = GetArray(10, 50, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Произведение чисел, меньших {number} равно {String.Join(", ", FindNumber(array, number))}");


int FindNumber(int[] array, int N) 
{
    int result = 1;
    foreach (int n in array)
    {
        if (n < N) result = result * n;        
    }
    return result;
}  

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res; 
}
*/