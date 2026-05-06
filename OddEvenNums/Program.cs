using System;
using System.Linq; 

namespace OddEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串以逗號分隔的整數數字：");
            string input = Console.ReadLine();

            var numbers = input.Split(',').Select(s => int.Parse(s.Trim()));

            var oddResult = numbers.Where(n => n % 2 != 0).OrderBy(n => n);

            var evenResult = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            Console.WriteLine("奇數 : " + string.Join(",", oddResult));
            Console.WriteLine("偶數 : " + string.Join(",", evenResult));

            Console.ReadLine();
        }
    }
}