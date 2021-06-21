using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDemo
{
    class SavePrincess
    {
        //static void Main (string[] args)
        //{
        //    // 命令行数
        //    int lineCount = 0;

        //    // 输入数据
        //    string input = null;

        //    // 命令列表
        //    List<string> cmdList = new List<string> ();

        //    // 匹配
        //    string pattern = @"[^LRS]";

        //    //显示消息
        //    Console.WriteLine ("开始输入命令串数量");

        //    input = Console.ReadLine ();

        //    if (int.TryParse (input , out lineCount))
        //    {
        //        if (lineCount > 0 && lineCount < 51)
        //        {
        //            Console.WriteLine ("请输入命令串");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine ("输入错误， 请重新输入！");
        //    }

        //    while (cmdList.Count < lineCount)
        //    {
        //        input = Console.ReadLine ();

        //        if (Regex.IsMatch (input , pattern))
        //        {
        //            Console.WriteLine ("输入错误， 请重新输入！");
        //        }
        //        else
        //        {
        //            cmdList.Add (input);
        //        }
        //    }

        //    checkCmd (cmdList);

        //    Console.WriteLine ("输入完毕");

        //    Console.ReadKey ();
        //}

        public static string checkCmd (List<string> _cmdList)
        {
            // 初始角度 北 为 0
            int _angle = 0; 
            // 初始位置为0,0点
            int _beginX = 0;
            int _beginY = 0;
            int _endX = _beginX;
            int _endY = _beginY;

            foreach (string _cmd in _cmdList)
            {
                foreach (char _c in _cmd.ToCharArray ())
                {
                    //以左转为-90度
                    if (_c.Equals('L'))
                    {
                        _angle -= 90; 
                    }
                    //右转为+90度
                    else if (_c.Equals('R'))
                    {
                        _angle += 90; 
                    }
                    else if (_c.Equals('S'))
                    { 
                        int _mod = _angle % 360;
                        if (_mod == 0)
                        {
                            //往北走
                            _endY++; 
                        }
                        else if (_mod == -90 || _mod == 270)
                        {
                            //往西走
                            _endX--; 
                        }
                        else if (_mod == 180 || _mod == -180)
                        {
                            //往南走
                            _endY--; 
                        }
                        else if (_mod == -270 || _mod == 90)
                        {
                            //往东走
                            _endX++; 
                        }
                    }
                }
            }
            //如果方向不变位置改变,则正确
            if (_angle % 360 == 0 && ( _endX != _beginX || _endY != _beginY ))
            { 
                //Console.WriteLine (_angle + "===" + _endX + "===" + _endY);
                Console.WriteLine ("yes");
                return "yes";
            }
            else
            {
                //Console.WriteLine (_angle + "===" + _endX + "===" + _endY);
                Console.WriteLine ("no");
                return "no";
            }
        }

        public static string[] getRandomCmd (int uc)
        { //测试数据
            if (uc == 0)
            {
                return new string[] { "LLLLS" };
            }
            else if (uc == 1)
            {
                return new string[] { "SSSS" , "R" };
            }
            char[] chs = { 'L' , 'R' , 'S' };
            if (uc > 49)
            {
                uc = 49;
            }

            Random _radom = new Random ();

            int n = _radom.Next (0 , uc + 1) + 1;
            string[] cmd = new string[n];
            for (int i = 0; i < n; i++)
            {
                int len = _radom.Next (0 , uc + 1) + 1;
                StringBuilder buf = new StringBuilder ();
                for (int j = 0; j < len; j++)
                {
                    buf.Append (chs[_radom.Next (0 , 3)]);
                }
                cmd[i] = buf.ToString ();
            }
            return cmd;
        }
    }
}
