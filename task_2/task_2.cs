using System;
using System.Collections;

namespace task_2
{
    #region *** Балеев Владимир * Задание №2 ***
    /* а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран;
    Используя tryParse;
     * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    При возникновении ошибки вывести сообщение. Напишите соответствующую функцию
    */
    #endregion
    class task_2
    {
        static void Main(string[] args)
        {
            countingNumbers.metod();
        }
    }

    class countingNumbers
    {
        public static void metod()
        {
            int number;
            int summ = 0;
            Queue queue = new Queue();

            Console.Write(String.Format("С клавиатуры вводите числа, пока не будет введен \"0\".\n"));
            do
            {
                number = tryInput();
                if (number > 0 & number % 2 != 0) { summ += number; queue.Enqueue(number); }
            } while (number != 0);
            Console.Write(String.Format($"Нечетные положительные чисела: "));
            printValues(queue);
            Console.WriteLine(String.Format($"\nСумма всех нечетных положительных чисел  равна: {summ}"));
            Console.ReadLine();
        }

         static void printValues(IEnumerable myCollection)
        {
            try
            {
                foreach (Object obj in myCollection)
                    Console.Write($" {obj},");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Программа не может вывести список нечетных положительных чисел.");
                Console.WriteLine(ex.Message);
            }
            
        }
        static int tryInput()
        {
            Console.Write(String.Format("Введите число: "));
            int number;
            if (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введенно не число.");
            }
            return number;
        }
    }
}
