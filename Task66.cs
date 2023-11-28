using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
namespace Homework9Recursion
{
    internal class Task66
    {
        public void Start()
        {
            Console.Write("Введите минимальное число: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < M)
            {
                Console.WriteLine("Ошибка ввода данных");
                return;
            }

            Console.WriteLine(PrintSum(M,N));
        }

        private int PrintSum(int minNumber, int maxNumber)
        {
            if (minNumber == maxNumber)
                return minNumber;

            return minNumber + PrintSum(minNumber + 1, maxNumber);
        }
    }
}
