using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02if语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的考试成绩：");

            int intGrade = Convert.ToInt16(Console.ReadLine());

            if (intGrade<60)
            {
                Console.WriteLine("不及格，建议重修！");
            }

            else
            {
                if (intGrade>95)
                {
                    Console.WriteLine("牛逼");
                }
                Console.WriteLine("恭喜通过考试");
            }

            Console.ReadKey();
        }
    }
}
