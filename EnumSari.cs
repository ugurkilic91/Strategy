using System;

namespace Strategy
{
    public class EnumSari : IEnumRenkler
    {
        public void WriteMessage(string val)
        {
           Console.WriteLine($"Sarı Renk deger : {val}");
        }
    }

}