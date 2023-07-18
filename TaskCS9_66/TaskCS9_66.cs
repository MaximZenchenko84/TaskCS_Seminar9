// Урок 9. Задача 66. Задайте значения M и N.
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

using System;

namespace TaskCS9_66
{
    class TaskCS9_66
    {
        // функция нахождения суммы натуральных элементов от inputM до inputN
        static int outputSum(int inputM, int inputN)
        {
            if (inputM == inputN) return inputM;
            int temp = inputN + outputSum(inputM, inputN - 1);//
            return temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число M = ");
            int M = int.Parse(Console.ReadLine());
            if (M <= 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            Console.Write("Введите целое положительное число N, N > M ");
            int N = int.Parse(Console.ReadLine());
            if ( (N <= 0) || (N<=M) )
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            int sumOtMdoN = outputSum(M, N);
            Console.WriteLine("Сумма всех натуральных элементов от " + M + " до " + N + " равна " + sumOtMdoN);
        }
    }
}
