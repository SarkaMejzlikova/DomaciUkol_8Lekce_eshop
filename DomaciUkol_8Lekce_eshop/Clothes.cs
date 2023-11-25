using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_eshop
{
    public abstract class Clothes // change to abstract class
    {
        // properties
        public int ID;
        public string Type;
        public int Price;
        public int Size;
        public string Color;
        public int Quantity;
        public int StockPrice;

        // constructor
        //public Clothes(int ID, string type, int price, int size, string color, int quantity)
        //{
        //    this.ID = ID;
        //    Type = type;
        //    Price = price;
        //    Size = size;
        //    Color = color;
        //    Quantity = quantity;
        //    StockPrice = Price * Quantity;
        //}

        // methods
        public int AddQty(int add)
        {
            Quantity = Quantity + add;
            return Quantity;
        }

        public int ReturnQty(int ret)
        {
            Quantity = Quantity - ret;
            return Quantity;
        }

        public int StockCalc()
        {
            StockPrice = Price * Quantity;
            return StockPrice;
        }

        public abstract void LoadParameters(); // add abstract method
    }
}