using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal = 5;
            int price = 20;
            int crystalBuy;
            bool quantityCrystal;


            Console.Write("Введите количество золота:");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("У меня есть " + crystal + " кристалов, по цене " + price + "за штуку. Сколько берешь?");
            crystalBuy = Convert.ToInt32(Console.ReadLine());
            quantityCrystal = crystal >= crystalBuy;
            crystalBuy *= Convert.ToInt32(quantityCrystal);
            gold = gold - crystalBuy * price;
            Console.Write("Куплено " + crystalBuy + " кристалов, остаток золота " + gold);


        }
    }
}
