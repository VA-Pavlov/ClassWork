using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Задание 1
                Выведите на экран надпись «Fall seven times and stand up eight» на разных строках. Пример вывода:

                Fall seven times
                and
                stand up eight
            
            Console.WriteLine("Fall seven times\nand\nstand up eight");
             */
            /*Задание 1*
              Выведите на экран надпись "Your time is limited, so don’t waste it living someone else’s life" Steve Jobs на разных строках. Пример вывода:

              “Your time is limited,
                    so don’t waste it
                        living someone else’s life”
                            Steve Jobs
             
            Console.WriteLine("\"Your time is limited,\n\tso don’t waste it\n\t\tliving someone else’s life\"\n\t\t\tSteve Jobs");
            */

            /*Задание 2
              Пользователь вводит с клавиатуры два числа. Необходимо найти сумму чисел, разницу чисел, произведение числе. 
              Результат вычислений вывести на экран.
            
            Console.WriteLine("Введите 1-ое число:");
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int summ = value1 + value2;
            int minus = value1 - value2;
            int multiply = value1 * value2;

            Console.WriteLine("Сумма: " + summ + "\nРазность: " + minus + "\nПроизведение: " + multiply);
             */
            /*Задание 3
              Пользователь с клавиатуры вводит четырёхзначное число. Необходимо перевернуть число и отобразить результат. 
              Например, если введено 4512, результат 2154.
            
            Console.WriteLine("Введите число, которое хотите перевернуть: ");
            int value = int.Parse(Console.ReadLine());
            int one = value / 1000;
            int two = value / 100%10;
            int tree = value % 100 / 10;
            int four = value % 10;
            int newValue = four*1000 + tree*100 + two*10 + one;
            Console.WriteLine("Перевернутое число: " + newValue);
             */
            /*Задание 2*
             * Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, 
             * который необходимо посчитать. Например, мы ввели с клавиатуры 50 и 10. Требуется вывести на 
             * экран 10 процентов от 50. Результат: 5
             
            Console.WriteLine("Введите число:");
            double value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент:");
            double procent = int.Parse(Console.ReadLine());
            double ansver = value1 / 100 * procent;
            Console.WriteLine("Результат: "+ansver);
            */
            /*Задание 3*
              Пользователь вводит с клавиатуры три цифры. Необходимо создать число, содержащее эти цифры. 
              Например,если с клавиатуры введено 7, 3, 8, тогда нужно сформировать число 738.
             
            Console.WriteLine("Введите цифру:");
            double value = int.Parse(Console.ReadLine())*100;
            Console.WriteLine("Введите цифру:");
            value += int.Parse(Console.ReadLine()) * 10;
            Console.WriteLine("Введите цифру:");
            value += int.Parse(Console.ReadLine());
            Console.WriteLine(value);
            */
            /*Задание 4
             * Пользователь с клавиатуры вводит количество часов. Если полученное значение находится в 
             * диапазоне от 0 до 6 нужно вывести надпись «Good Night», если в диапазоне от 6 до 13 
             * «Good Morning», если в диапазоне от 13 до 17 «Good Day», если в диапазоне от 17 до 0 
             * «Good Evening». Верхняя граница диапазона не включается. Например,число 6 относится к 
             * 6 до 13.
             
            Console.WriteLine("Введите количество часов:");
            int valueHours = int.Parse(Console.ReadLine());
            if (valueHours >= 0 && valueHours < 6)
            {
                Console.WriteLine("Good Night");
            } else if (valueHours >= 6 && valueHours < 13)
            {
                Console.WriteLine("Good Morning");
            } else if (valueHours >= 13 && valueHours < 17)
            {
                Console.WriteLine("Good Day");
            } else if (valueHours >=17 && valueHours < 24)
            {
                Console.WriteLine("Good Evening");
            }
            */

            /*Задание 5
             * Пользователь вводит с клавиатуры целое шестизначное число. Написать программу, которая 
             * определяет, является ли введенное число — счастливым (Счастливым считается шестизначное 
             * число, у которого сумма первых 3 цифр равна сумме вторых трех цифр). Например, 123321 — 
             * счастливое число, так как 1+2+3 = 3+2+1. С другой стороны 378423 — несчастливое число, так как 
             * 3+7+8 != 4+2+3. Если пользователь ввел не шестизначное число требуется вывести сообщение 
             * об ошибке.
            
            Console.WriteLine("Введите целое шестизначное число:");
            int value = int.Parse(Console.ReadLine());
            if (value > 99999 && value < 1000000)
            {
                int value1 = value / 1000;
                int value2 = value % 1000;
                value1 = value1 / 100 + value1 / 10 % 10 + value1 % 10;
                value2 = value2 / 100 + value2 / 10 % 10 + value2 % 10;
                Console.WriteLine(value1 == value2 ? "Число - счастливое" : "Число - несчастливое");
            }
            else
            {
                Console.WriteLine("Ошибка! Число не шестизначное.");
            }
            */
        }
    }
}
