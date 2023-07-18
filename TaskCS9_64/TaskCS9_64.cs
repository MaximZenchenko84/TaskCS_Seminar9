// Урок 9. Задача 64. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

using System;

namespace TaskCS9_64
{
    class TaskCS9_64
    {   
        // функция вывода чисел
        static int outputNumber(int current_number)
        {
            Console.Write(current_number + "  ");
            if (current_number == 1) return 1;
            int temp = outputNumber(current_number - 1) + 1;
            return temp;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число N = ");
            int N = int.Parse(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            int result = outputNumber(N);
            Console.WriteLine("\n");
        }
    }
}
