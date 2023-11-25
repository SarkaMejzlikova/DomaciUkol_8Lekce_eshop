using DomaciUkol_8Lekce_eshop;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

List<Clothes> clothes = new List<Clothes>();

//Shirts sA = new Shirts(300, 40, "bílá", 100, "krátký", true);
//clothes.Add(sA);

//Trousers tA = new Trousers(1000, 40, "denim", 20, "krátké", "vysoký pas");
//clothes.Add(tA);

//Hats hA = new Hats(800, 36, "šedá", 100, false, "zima");
//clothes.Add(hA);

bool jeKonec = false;
while (!jeKonec)
{
    Console.WriteLine("\nJakou akci chcete provést \n1 - Výpis položek \n2 - Naskladnění \n3 - Vyskladnění \n4 - Přidání nového zboží \n0 - Konec");
    string answAct = Console.ReadLine();
    bool tryAgainAct = true;

    while (tryAgainAct)
    {
        try
        {
            switch (Int32.Parse(answAct))
            {
                case (int)Action.end:
                    jeKonec = true;
                    break;

                case (int)Action.print:

                    Console.WriteLine("Obsah skladu:");
                    foreach (var item in clothes)
                    {
                        item.StockCalc();
                        if (item is Shirts)
                        {
                            Shirts s = (Shirts)item;
                            Console.WriteLine(s.Type + " - Cena: " + s.Price + ",- Kč, Velikost: " + s.Size + ", Barva: " + s.Color + ", Potisk: " + s.Printing + ", Délka rukávu: " + s.Sleeve + ", Počet kusů na skladě: " + s.Quantity + ", Hodnota zboží: " + s.StockPrice + ",- Kč;");
                        }
                        else if (item is Trousers)
                        {
                            Trousers t = (Trousers)item;
                            Console.WriteLine(t.Type + " - Cena: " + t.Price + ",- Kč, Velikost: " + t.Size + ", Barva: " + t.Color + ", Délka:" + t.Length + ", Výška pasu: " + t.Waist + ", Počet kusů na skladě: " + t.Quantity + ", Hodnota zboží: " + t.StockPrice + ",- Kč;");
                        }
                        else if (item is Hats)
                        {
                            Hats h = (Hats)item;
                            Console.WriteLine(h.Type + " - Cena: " + h.Price + ",- Kč, Velikost: " + h.Size + ", Barva: " + h.Color + ", Roční období:" + h.Season + ", Bambule: " + h.PomPom + ", Počet kusů na skladě: " + h.Quantity + ", Hodnota zboží: " + h.StockPrice + ",- Kč;");
                        }
                    }
                    break;

                case (int)Action.addQty:

                    Console.WriteLine("Jaký typ výrobku chcete naskladnit? \n1 - Tričko \n2 - Kalhoty \n3 - Čepici");
                    int answAdd = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Kolik kusů chcete naskladnit? ");
                    int answAddQty = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in clothes.Where(x => x.ID == answAdd))
                    {
                        item.AddQty(answAddQty);
                        Console.WriteLine("Nový stav zásob typu " + item.Type + " je: " + item.Quantity + " kusů.");
                        item.StockCalc();
                        Console.WriteLine("Nová hodnota zásob typu " + item.Type + " je " + item.StockPrice + ",- Kč.");
                    }
                    break;

                case (int)Action.returnQty:

                    Console.WriteLine("Jaký typ výrobku chcete vyskladnit? \n1 - Tričko \n2 - Kalhoty \n3 - Čepici");
                    int answRet = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Kolik kusů chcete vyskladnit? ");
                    int answRetQty = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in clothes.Where(x => x.ID == answRet))
                    {
                        if (item.Quantity - answRetQty >= 0)
                        {
                            item.ReturnQty(answRetQty);
                            Console.WriteLine("Nový stav zásob typu " + item.Type + " je: " + item.Quantity + " kusů.");
                            item.StockCalc();
                            Console.WriteLine("Nová hodnota zásob typu " + item.Type + " je " + item.StockPrice + ",- Kč.");
                        }
                        else
                        {
                            Console.WriteLine("Vyskladněním tohoto množstsví byste dostali sklad zásob do mínusu.\nPočet kusů na skladě je " + item.Quantity + ".");
                        }
                    }
                    break;

                case (int)Action.addNewItem:

                    Console.WriteLine("Jaký typ výrobku chcete zadat? \n1 - Tričko \n2 - Kalhoty \n3 - Čepici");
                    int answAddNewItem = Convert.ToInt32(Console.ReadLine());

                    switch(answAddNewItem)
                    {
                        case (int)Category.shirts:
                            Clothes a = new Shirts();
                            a.LoadParameters();
                            clothes.Add(a);
                            break;
                        case (int)Category.trousers: 
                            Clothes b = new Trousers();
                            b.LoadParameters();
                            clothes.Add(b);
                            break;
                        case (int)Category.hats:
                            Clothes c = new Hats();
                            c.LoadParameters();
                            clothes.Add(c);
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Zřejmě jste jako odpověď nezadali správné číslo, zkuste to znovu:");
                    answAct = Console.ReadLine();
                    break;
            }
            tryAgainAct = false;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Zřejmě jste jako odpověď nezadali správné číslo, zkuste to znovu:");
            answAct = Console.ReadLine();
        }
    }
}


enum Action
{
    end = 0,
    print = 1,
    addQty = 2,
    returnQty = 3,
    addNewItem = 4
}

enum Category
{
    shirts = 1,
    trousers = 2,
    hats = 3
}