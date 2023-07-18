// Урок 9. Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

using System;

namespace TaskCS9_68
{
    class TaskCS9_68
    {
        // функция Аккермана от двух аргументов A(inputM, inputN)
        static int funcAkk(int inputM, int inputN)
        {
            if ((inputM != 0) && (inputN == 0)) return funcAkk(inputM - 1, 1);
            else
                if ((inputM > 0) && (inputN > 0))
                {
                    int temp = funcAkk(inputM, inputN - 1);
                    return (funcAkk(inputM - 1, temp));
                }
            return (inputN+1);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите целое неотрицательное число m = ");
            int m = int.Parse(Console.ReadLine());
            if (m < 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            Console.Write("Введите целое неотрицательное число n = ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }

            int resAkk = funcAkk(m, n);
            Console.WriteLine("Функция Аккермана A(" + m + "," + n + ") = " + resAkk);
        }
    }
}
