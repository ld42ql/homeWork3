using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    #region *** Балеев Владимир * Задание №1 ***
    /*  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
    Продемонстрировать работу структуры;
     * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
    */
    #endregion
    class task_1
    {
        static void Main(string[] args)
        {
            Complex cm1 = new Complex();
            Complex cm2 = new Complex();
            Complex cmResult = new Complex();

            cm1.im = 8;
            cm1.re = 10;
            cm2.re = 7;
            cm2.im = 2;

            Console.WriteLine($"Первое комплексное число: {cm1.ToString(cm1)}");
            Console.WriteLine($"Второе комплексное число: {cm2.ToString(cm2)}");
            cmResult =  cm1.Plus(cm2);
            Console.WriteLine($"Сумма комплексных чисел: {cmResult.ToString(cmResult)}");
            cmResult = cm1.Dif(cm2);
            Console.WriteLine($"Вычетание комплексных чисел: {cmResult.ToString(cmResult)}");
            cmResult = cm1.Multi(cm2);
            Console.WriteLine($"Произведение комплексных чисел: {cmResult.ToString(cmResult)}");

            Console.ReadKey();
        }
    }
    struct Complex
    {
        public double im;
        public double re;
        

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Complex Plus(Complex value)
        {
            Complex tempSum = new Complex();
            tempSum.im = im + value.im;
            tempSum.re = re + value.re;
            return tempSum;
        }
        /// <summary>
        /// /Вычетание
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Complex Dif(Complex value)
        {
            Complex tempDif = new Complex();
            tempDif.im = im - value.im;
            tempDif.re = re - value.re;
            return tempDif;
        }
        
        /// <summary>
        /// Произведение
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Complex Multi(Complex value)
        {
            Complex tempMult = new Complex();
            tempMult.im = im * value.im + re * value.im;
            tempMult.re = re * value.im - im * value.re;
            return tempMult;
        }
        /// <summary>
        /// Ввывод на экран
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ToString(Complex value)
        {
            return  re + "+" + im + "i";
        }
    }
}
