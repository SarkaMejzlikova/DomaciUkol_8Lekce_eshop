using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_eshop
{
    public class Trousers : Clothes
    {
        // properties
        public string Length;
        public string Waist;

        // constructor
        //public Trousers(int price, int size, string color, int quantity, string length, string waist) : base(2, "Kalhoty", price, size, color, quantity)
        //{
        //    Length = length;
        //    Waist = waist;
        //}

        // methods
        public override void LoadParameters()
        {
            ID = 2;
            Type = "Kalhoty";
            Console.Write("Zadejte cenu: ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte velikost: ");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte barvu: ");
            Color = Console.ReadLine();
            Console.Write("Zadejte množství: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jaká je délka kalhot? ");
            Length = Console.ReadLine();
            Console.Write("Jak vysoký pas mají kalhoty? ");
            Waist = Console.ReadLine();
        }
    }
}