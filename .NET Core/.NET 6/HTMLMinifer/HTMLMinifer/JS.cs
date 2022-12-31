using System.Text;
using System.Text.RegularExpressions;

namespace HTMLMinifer
{
    public static class JS
    {
        public static void Init(string fext)
        {
            Console.WriteLine("");
            Console.WriteLine("Minifier for JS files...");
            Console.WriteLine("");
            Console.WriteLine($"Current Working Directory.. {Directory.GetCurrentDirectory()}");
            Console.WriteLine("");
            int btfi = 0; int affi = 0;
            foreach (var f in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.JS", SearchOption.AllDirectories))
            {
                //Console.WriteLine(f.ToString());
                StringBuilder Sb = new StringBuilder();
                Sb.Append(System.IO.File.ReadAllText(f.ToString(),Encoding.UTF8));
                FileInfo fi = new FileInfo(f.ToString());
                int bfi = Convert.ToInt32($"{fi.Length / 1024}");

                //Remove Comments                
                //This is tricky to handle // comments since https:// string may have issues
                //So check any space before it and then replace it.
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+//.*", ""));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"^//.*", ""));

                //Remove Console.log();
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"console.log\(.*\);", ""));

                //Remove New Line
                //Sb.Replace(Environment.NewLine, "");
                //This is tricky to handle newline. Below code should be before other comments and spaces
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"[\r\n]", " "));

                //Remove Tab
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"[\t]", ""));

                //Remove Comments                
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"/\*.*?\*/", ""));

                ////Remove Spaces
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"{\s+", "{"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+{", "{"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"}\s+", "}"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+}", "}"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @":\s+", ":"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+:", ":"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @";\s+", ";"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+;", ";"));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"\s+,", ","));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @",\s+", ","));
                Sb.Replace(Sb.ToString(), Regex.Replace(Sb.ToString(), @"{\s+}", "{}"));

                File.WriteAllText($"{f.ToString()}{fext}", Sb.ToString());
                fi = new FileInfo($"{f.ToString()}{fext}");
                int afi = Convert.ToInt32($"{fi.Length / 1024}");
                Console.WriteLine($"{fi.Name.ToString()} ... {bfi} KB: {afi} KB");
                btfi = btfi + bfi;
                affi = affi + afi;                
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
