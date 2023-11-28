using System;

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 29
namespace Homework9Recursion
{
    internal class Task68
    {
        public void Start()
        {
            Console.Write("Введите первое неотрицательное число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе неотрицательное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m < 0 || n < 0)
            {
                Console.WriteLine("Ошибка ввода данных");
                return;
            }

            Console.WriteLine(Handler(m, n));
        }

        private int Handler(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
                return secondNumber + 1;

            if (secondNumber == 0)
                return Handler(firstNumber - 1, 1);

            return Handler(firstNumber - 1, Handler (firstNumber, secondNumber -1));
        }
    }
}
