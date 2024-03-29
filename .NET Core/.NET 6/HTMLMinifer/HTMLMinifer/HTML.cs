﻿using System.Text;
using System.Text.RegularExpressions;

namespace HTMLMinifer
{
    public static class HTML
    {
        public static void Init(string fext)
        {
            Console.WriteLine("Minifier for HTML files...");
            Console.WriteLine("");
            Console.WriteLine($"Current Working Directory.. {Directory.GetCurrentDirectory()}");
            Console.WriteLine("");
            int btfi = 0; int affi = 0;
            foreach (var f in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.html", SearchOption.AllDirectories))
            {
                //Console.WriteLine(f.ToString());
                StringBuilder Sb = new StringBuilder();
                Sb.Append(System.IO.File.ReadAllText(f.ToString()));
                FileInfo fi = new FileInfo(f.ToString());
                int bfi = Convert.ToInt32($"{fi.Length / 1024}");

                //Remove Spaces between HTML Elements
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @">\s+<", "><"));

                //Remove Comments
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"<!--.*?-->", ""));

                //Remove Tab
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"[\t]", ""));

                //Remove New Line
                //Sb.Replace(Environment.NewLine, "");
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"[\r\n]", ""));

                File.WriteAllText($"{f.ToString()}{fext}", Sb.ToString());
                fi = new FileInfo($"{f.ToString()}{fext}");
                int afi = Convert.ToInt32($"{fi.Length / 1024}");
                Console.WriteLine($"{fi.Name.ToString()} ... {bfi} KB: {afi} KB");
                btfi = btfi + bfi;
                affi = affi + afi;
                //Console.WriteLine(Regex.Replace(Sb.ToString(), @">\s+<", "><"));   
            }
            Console.WriteLine("");
            Console.WriteLine($" Total Before File Size {btfi} KB");
            Console.WriteLine($" Total After File Size {affi} KB");
            Console.WriteLine($" Total Minified {btfi - affi} KB");

            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
