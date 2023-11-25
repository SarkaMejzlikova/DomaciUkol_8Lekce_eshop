using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_eshop
{
    public class Shirts : Clothes
    {
        // properties
        public string Sleeve;
        public bool Printing;

        // constructor
        //public Shirts(int price, int size, string color, int quantity, string sleeve, bool printing) : base(1, "Tričko", price, size, color, quantity)
        //{
        //    Sleeve = sleeve;
        //    Printing = printing;
        //}


        // methods
        public override void LoadParameters()
        {
            ID = 1;
            Type = "Tričko";
            Console.Write("Zadejte cenu: ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte velikost: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte barvu: ");
            Color = Console.ReadLine();
            Console.Write("Zadejte množství: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jaký rukáv má tričko? ");
            Sleeve = Console.ReadLine();
            Console.Write("Má tričko potisk? (odpovězte ano/ne) ");
            Printing = Console.ReadLine() == "ano" ? true : false;
        }
    }
}