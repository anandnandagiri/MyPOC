using System.Text;
using System.Text.RegularExpressions;

namespace HTMLMinifer
{
    public static class CSS
    {
        public static void Init()
        {
            Console.WriteLine("");
            Console.WriteLine("Minifier for CSS files...");
            Console.WriteLine("");
            Console.WriteLine($"Current Working Directory.. {Directory.GetCurrentDirectory()}");
            Console.WriteLine("");
            int btfi = 0; int affi = 0;
            foreach (var f in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.css", SearchOption.AllDirectories))
            {
                //Console.WriteLine(f.ToString());
                StringBuilder Sb = new StringBuilder();
                Sb.Append(System.IO.File.ReadAllText(f.ToString(),Encoding.UTF8));
                FileInfo fi = new FileInfo(f.ToString());
                int bfi = Convert.ToInt32($"{fi.Length / 1024}");

                //Remove New Line
                //Sb.Replace(Environment.NewLine, "");
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"[\r\n]", " "));            
                //Sb.Replace("\\s", "");
                ////Remove Tab
                //Sb.Replace("\\t", "");
                //Sb.Replace("\\n", "");

                //Remove Comments                
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"/\*.*?\*/", ""));

                ////Remove Spaces
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"{\s+", "{"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+{", "{"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"}\s+", "}"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+}", "}"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @":\s+", ":"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @";\s+", ";"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+;", ";"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+,", ","));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @",\s+", ","));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"{\s+}", "{}"));

                File.WriteAllText($"{f.ToString()}", Sb.ToString());
                fi = new FileInfo($"{f.ToString()}");
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
