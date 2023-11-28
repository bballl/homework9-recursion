using System;

//Задача 64: Задайте значения M и N.Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"
namespace Homework9Recursion
{
    internal class Task64
    {
        public void Start()
        {
            Console.Write("Введите минимальное число последовательности: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число максимальное число последовательности: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < M)
            {
                Console.WriteLine("Ошибка ввода данных");
                return;
            }
            
            Console.WriteLine(PrintNumbers(M,N));
        }

        private string PrintNumbers(int minNumber, int maxNumber)
        {
            if(minNumber == maxNumber)
                return minNumber.ToString();

            return minNumber + "\t" + PrintNumbers(minNumber + 1, maxNumber);  
        }
    }
}
