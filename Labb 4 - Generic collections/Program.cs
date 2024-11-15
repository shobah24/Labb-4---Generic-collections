namespace Labb_4___Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Skapa ett nytt objekt av Restaurant-klassen.
            Restaurant Shh = new Restaurant();

            // 2.Lägg till fyra olika rätter i menyn.
            MenuItem Pizza = new MenuItem(1, "Pizza", 130m);
            MenuItem Burgare = new MenuItem(2, "Burgare", 110m);
            MenuItem FishAndChips = new MenuItem(3, "Fish and Chips", 115m);
            MenuItem Dricka = new MenuItem(4, "Dricka", 20m);

            Shh.AddtoMenu(Pizza);
            Shh.AddtoMenu(Burgare);
            Shh.AddtoMenu(FishAndChips);
            Shh.AddtoMenu(Dricka);

            Console.WriteLine("-------------------");
            // 3. skriver ut menyn:
            Shh.ShowMenu();
            
            // 4. skapa 3 ordrar:
            Console.WriteLine("-------------------");
            Order order1 = new Order(new List<MenuItem>(), 7);
            order1.Add(Pizza);
            order1.Add(FishAndChips);
            Shh.CreateOrder(order1);
            //Console.WriteLine("-------------------");

            Order order2 = new Order(new List<MenuItem>(), 22);
            order2.Add(Pizza);
            order2.Add(FishAndChips);
            order2.Add(Burgare);
            order2.Add(Dricka);
            Shh.CreateOrder(order2);
            //Console.WriteLine("-------------------");

            Order order3 = new Order(new List<MenuItem>(), 12);
            order3.Add(Pizza);
            order3.Add(Burgare);
            order3.Add(Dricka);
            Shh.CreateOrder(order3);


            Console.WriteLine("-------------------");
            //5. Visa alla aktuella ordrar
            Shh.ShowOrders();

            Console.WriteLine("-------------------");
            //6. Visa aktuella ordrar:
            Shh.ShowOrderCount();

            //7. visa nästa order:
            Console.WriteLine();
            Shh.ShowNextOrder();

            //8. Hantera en order:
            Console.WriteLine();
            Shh.HandleOrder();

            //9. Visa antalet ordrar i kön:
            Console.WriteLine();
            Shh.ShowOrderCount();

            Console.WriteLine("-------------------");
            //10. Lägg till en ny ordei kön:
            Order order4 = new Order(new List<MenuItem>(), 10);
            order4.Add(Pizza);
            order4.Add(Dricka);
            Shh.CreateOrder(order4);

            Console.WriteLine();
            //11. Visa antalet ordrar i kön:
            Shh.ShowOrderCount();

            Console.WriteLine();
            //12. Hantera två ordrar:
            Shh.HandleOrder();
            Shh.HandleOrder();

            Console.WriteLine();
            //13. Visa antalet ordrar i kön:
            Shh.ShowOrderCount();

            Console.WriteLine("-------------------");
            //14. Visa nästa order på kön:
            Shh.ShowNextOrder();

            Console.WriteLine();
            //15. Hantera en order:
            Shh.HandleOrder();

            Console.WriteLine();
            //16. visa antalet ordrar i kön:
            Shh.ShowOrderCount();
        }
    }
}
