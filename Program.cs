using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumRenklerContext renklerContext =new EnumRenklerContext();
            renklerContext.WriteMessage(EnumRenkler.Kirmizi,"Deneme Kırmızı");
            renklerContext.WriteMessage(EnumRenkler.Mavi,"Deneme Mavi");
            Console.ReadKey();
        }
    }
}
