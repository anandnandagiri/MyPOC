using System;

namespace EncryptDecrypt
{
    class Program
    {
        private static string MyKey1 = "mYkey1*7^";
        private static string MyKey2 = "MyKey2op)*";

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Encrypt Decrypt With Salt & Pepper");
            Console.WriteLine();
            //Key1 is for Salt
            //Key2 is for Pepper
            //First Encrypt with Salt & Pepper to provide additional security

            string MyMessage = "This Value is Encrypted & Decrypted";

            //string saltpepper 
            string saltpepperKey = EncryptDecrypt.EncryptString(MyKey1, MyKey2);
            string enc = EncryptDecrypt.EncryptString(MyMessage, saltpepperKey);
            string dec = EncryptDecrypt.DecryptString(enc, saltpepperKey);


            Console.WriteLine($"Message           : {MyMessage}");
            Console.WriteLine($"Salt Pepper Key   : {saltpepperKey}");
            Console.WriteLine($"Encrypted Message : {enc}");
            Console.WriteLine($"Decrypted Message : {dec}");
            Console.WriteLine($"");





            Console.WriteLine("Press Any Key To Continue");
            Console.ReadLine();
        }
    }
}
