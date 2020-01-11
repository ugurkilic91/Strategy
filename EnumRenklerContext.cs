using System.Collections.Generic;
namespace Strategy
{
    public class EnumRenklerContext
    {
        private static Dictionary<EnumRenkler, IEnumRenkler> renkler = new Dictionary<EnumRenkler, IEnumRenkler>();
        static EnumRenklerContext()
        {
            renkler.Add(EnumRenkler.Kirmizi, new EnumKirmizi());
            renkler.Add(EnumRenkler.Mavi, new EnumMavi());
            renkler.Add(EnumRenkler.Sari, new EnumSari());
        }
        public void WriteMessage(EnumRenkler direction, string message)
        {
            renkler[direction].WriteMessage(message);
        }
    }

}