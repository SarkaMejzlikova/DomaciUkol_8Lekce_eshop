using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_eshop
{
    public class Hats : Clothes
    {
        //properties
        public bool PomPom;
        public string Season;

        // constructor
        //public Hats(int price, int size, string color, int quantity, bool pomPom, string season) : base(3, "Čepice", price, size, color, quantity)
        //{
        //    PomPom = pomPom;
        //    Season = season;
        //}
        
        //methods
        public override void LoadParameters()
        {
            ID = 3;
            Type = "Čepice";
            Console.Write("Zadejte cenu: ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte velikost: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte barvu: ");
            Color = Console.ReadLine();
            Console.Write("Zadejte množství: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Má čepice bambuli? (odpovězte ano/ne) ");
            PomPom = Console.ReadLine() == "ano" ? true : false;
            Console.Write("Zadejte sezónnost: ");
            Season = Console.ReadLine();
        }

    }
}