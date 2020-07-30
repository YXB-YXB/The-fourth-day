using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01If语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //if语句的写法：

            //经典写法
            if (true)
            {
                Console.WriteLine("这是IF语句的经典样式");
            }

            //直接写在一行
            if (true)
            {Console.WriteLine("这是缩在一起写");}

            //缩写
            if(true)
                Console.WriteLine("缩写");

            int intMine=0;

            if (intMine>120)
            {
                Console.WriteLine("休息一下");
            }

            int intYes = 0;
            if ((intYes%400==0)||(intYes%4==0 && intYes%100!=0))
            {
                Console.WriteLine("是闰年！");
            }
            else
            {
                Console.WriteLine("不是闰年");
            }
        }
    }
}
