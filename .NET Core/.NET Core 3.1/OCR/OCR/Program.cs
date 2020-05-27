using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace OCR
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach(var file in Directory.GetFiles(Path.Combine(GetExecutionPath,"feed", "inbound")))
            {

                Console.WriteLine(file);
                using (var pdfReader = new PdfReader(file))
                using (var pdfDocument = new PdfDocument(pdfReader))
                {
                    var stringBuilder = new StringBuilder();

                    for (var i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
                        stringBuilder.Append(PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i), new SimpleTextExtractionStrategy()));                     

                    File.WriteAllText($"{Path.GetFileName(file)}.txt", stringBuilder.ToString());
                    Console.WriteLine(stringBuilder.ToString());
                }
            }
                 
        }

        public static string GetExecutionPath
        {
            get
            {
                return Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            }
        }
    }
}
