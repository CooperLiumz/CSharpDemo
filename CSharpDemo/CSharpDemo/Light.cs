using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace CSharpDemo
{
    class Light
    {
        //static void Main(string[] args)
        //{
        //    // 匹配
        //    string pattern = @"[^01]";

        //    string input = Console.ReadLine();

        //    if (Regex.IsMatch(input, pattern))
        //    {
        //        //Console.WriteLine ("输入错误， 请重新输入！");
        //    }
        //    else
        //    {
        //        CountOperation(input.ToArray());
        //    }


        //    Console.ReadKey();
        //}

        public static void CountOperation (char[] charArry)
        {
            int _lgh = charArry.Length;
            int _count = 0;
            for (int i = 1; i < _lgh; i++)
            {
                if (charArry[i] == charArry[i - 1])
                {

                }
                else
                {
                    _count += 1;
                }
            }
            if (charArry[0] == '1')
            {
                _count += 1;
            }

            Console.WriteLine (_count);
        }
    }
}
