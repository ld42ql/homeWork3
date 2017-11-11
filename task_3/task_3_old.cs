using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    #region *** Балеев Владимир * Задание №3 ***
    /*  Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы
    сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы
    класса.
    ** Добавить упрощение дробей.
    */
    #endregion
    class task_3
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int operation = 0;
            while (flag)
            {
                try
                {
                    Console.Write("Введите числитель первой дроби: ");
                    fractionalOperation.A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите знаменатель первой дроби: ");
                    fractionalOperation.B = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите числитель второй дроби: ");
                    fractionalOperation.C = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите знаменатель второй дроби: ");
                    fractionalOperation.D = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(String.Format("Введены не числа. :("));
                    flag = true;
                }
            }

            Console.Write("Выберите операцию: \n1 - Сложение; \n2 - Вычетание; \n3 - Умножение; \n4 - Деление;\nНомер операции: ");

            if (!Int32.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Нет такой операции.");
            }

            fractionalOperation frOper = new fractionalOperation();

            switch (operation)
            {
                case 1:
                    frOper.Sum();
                    Console.Write("Сумма: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    frOper.simplFractions();
                    Console.Write("\nУпрощаение дроби: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    break;
                case 2:
                    frOper.Dif();
                    Console.Write("Разница: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    frOper.simplFractions();
                    Console.Write("\nУпрощаение дроби: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    break;
                case 3:
                    frOper.Mult();
                    Console.Write("Умножение: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    frOper.simplFractions();
                    Console.Write("\nУпрощаение дроби: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    break;
                case 4:
                    frOper.Div();
                    Console.Write("Деление: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    frOper.simplFractions();
                    Console.Write("\nУпрощаение дроби: ");
                    fractional.ViewFractional(frOper.frResult.num, frOper.frResult.den);
                    break;
                default:
                    Console.WriteLine("Нет такой операции.");
                    break;
            }


        }
    }

    /// <summary>
    /// Класс для дробей
    /// </summary>
    class fractional
    {
        public int num; // числитель 
        public int den; // знаменатель 

        /// <summary>
        /// Конструктор для дробей
        /// </summary>
        /// <param name="num">числитель дроби</param>
        /// <param name="den">знаменатель  дроби</param>
        public fractional(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public static void ViewFractional(int num, int den)
        {

            Console.Write(String.Format(Convert.ToString($" {num}/{den}")));
        }
    }


    class fractionalOperation
    {
        private static int a;
        private static int b;
        private static int c;
        private static int d;


        public static int A { set => a = value; }
        public static int B { set => b = value; }
        public static int C { set => c = value; }
        public static int D { set => d = value; }


        fractional fr1 = new fractional(a, b);
        fractional fr2 = new fractional(c, d);
        public fractional frResult = new fractional(0, 0);

        /// <summary>
        /// Приведение к общему знаменателю
        /// </summary>
        /// <returns>общей знаменатель</returns>
        int LCM()
        {
            return fr1.den * fr2.den;
        }

        /// <summary>
        /// Вычисление суммы
        /// </summary>
        public fractional Sum()
        {
            frResult.num = (fr1.num * (LCM() / fr1.den)) + (fr2.num * (LCM() / fr2.den));
            frResult.den = LCM();
            return frResult;
        }

        /// <summary>
        /// Вычисляем разницу
        /// </summary>
        public fractional Dif()
        {
            frResult.num = (fr1.num * (LCM() / fr1.den)) - (fr2.num * (LCM() / fr2.den));
            frResult.den = LCM();
            return frResult;
        }

        /// <summary>
        /// Умножение
        /// </summary>
        public fractional Mult()
        {
            frResult.num = fr1.num * fr2.num;
            frResult.den = fr1.den * fr2.den;
            return frResult;
        }

        /// <summary>
        /// Деление
        /// </summary>
        public fractional Div()
        {
            frResult.num = fr1.num * fr2.den;
            frResult.den = fr1.den *= fr2.num;
            return frResult;
        }
        /// <summary>
        /// Упрощение дробей
        /// </summary>
        public fractional simplFractions()
        {

            for (int i = 2; i <= frResult.den; i++)
            {
                if (frResult.num % i == 0 && frResult.den % i == 0)
                {
                    frResult.num /= i;
                    frResult.den /= i;
                    i = 1;
                }

            }
            return frResult;
        }
    }

}