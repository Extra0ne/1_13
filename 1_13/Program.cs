using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num >=0 && num <=99)
            {
                Console.WriteLine("Вы не ввели трехзначное число");
            }
            if (num >= 1000)
            {
                Console.WriteLine("Вы ввели больше чем трехзначное число");
            }
            else
            {
                if (((num / 100) % 10) == ((num / 10) % 10) || ((num / 10) % 10) == (num % 10) || ((num / 100) % 10) == (num % 10))
                {
                    Console.WriteLine("Есть одинаковые цифры");
                }
                else
                {
                    Console.WriteLine("Нету одинаковых цифр");
                }
            }


            Console.ReadLine();
        }
    }
}
