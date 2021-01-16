using System;

namespace Mask_Sensitive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a secret!");
            var secret = Console.ReadLine();
            var maskedSecret = secret.Substring(secret.Length - 4).PadLeft(secret.Length, '*');

            Console.WriteLine(maskedSecret);
        }
    }
}
