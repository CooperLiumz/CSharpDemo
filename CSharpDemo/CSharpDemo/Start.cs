using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    class Start
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("开始");

            //string input = "LEETCODEISHIRING";
            //ZChange _change = new ZChange ();            
            //Console.WriteLine (_change.convert (input , 3));
            //Console.WriteLine (_change.convert (input , 4));

            GreedyCookie _cookie = new GreedyCookie ();
            _cookie.Execute ();

            Console.WriteLine ("结束");
            Console.ReadKey ();
        }

    }
}
