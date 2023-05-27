using System;
using static System.Text.Unicode.UnicodeRanges;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace tp_4Lab
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            var myChangePath = new changePath();
            var paths = new string[]
            {
                "C:\\Users\\HP\\Desktop\\Новая папка(0)\\discord.txt",
                "C:\\Users\\HP\\Desktop\\Новая папка(0)\\osu.txt",
                "C:\\downloads_for_diff_stuff\\osu!install.exe",
                "C:\\masm32\\text\\comment0.txt",
                "C:\\masm32\\tproc.txt",
                "C:\\Users\\HP\\Desktop\\Новая папка(0)\\вов.txt",
                "C:\\Users\\HP\\Desktop\\Новая папка(0)\\близзы.txt",
                "C:\\Users\\HP\\Desktop\\Новая папка(0)\\твич.txt",
                "C:\\Rider for cpp and cs\\prjects\\tp_4Lab\\ЗАгЛАВныё.txt",
                "C:\\Rider for cpp and cs\\prjects\\tp_4Lab\\tp_4Lab\\_234.txt",
                "C:\\Rider for cpp and cs\\prjects\\tp_4Lab\\tp_4Lab\\фаiлЫ1234.txt",
                "C:\\Users\\HP\\Desktop\\Новая папка(0)\\БольШиеБуквы235.txt"
            };

            var newPaths = new List<string>();
            foreach(var i in paths)
            {
                var tempStr = myChangePath.GetString(i);
                if(tempStr == String.Empty) continue;
                newPaths.Add(tempStr);
                Console.Write($"The old path is: {i}{Environment.NewLine}");
            }

            foreach (var i in newPaths)
            {
                Console.Write($"The new path is: {i}{Environment.NewLine}");
            }
        }
    }
}