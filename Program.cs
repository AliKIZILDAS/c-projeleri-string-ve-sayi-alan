using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz ve ardından çıkarmak istediğiniz karakterin indeksini giriniz(Aralarında virgül kullanınız.");
            string s=Console.ReadLine();
            string[] a=s.Split(",");
            int b=Convert.ToInt32(a[1]);
            string c=a[0].Remove(b,1);
            Console.WriteLine(c);
        }

        
    }
}