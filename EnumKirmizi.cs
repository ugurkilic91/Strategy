using System;

namespace Strategy
{
    public class EnumKirmizi : IEnumRenkler
    {
        public void WriteMessage(string val)
        {
           Console.WriteLine($"Kırmızı Renk deger : {val}");
        }
    }

}