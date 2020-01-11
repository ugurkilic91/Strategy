using System;

namespace Strategy
{
    public class EnumMavi : IEnumRenkler
    {
        public void WriteMessage(string val)
        {
           Console.WriteLine($"Mavi Renk deger : {val}");
        }
    }

}