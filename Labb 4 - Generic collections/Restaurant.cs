namespace Labb_4___Generic_collections
{
    internal class Restaurant
    {
        private List<MenuItem> _menu = new List<MenuItem>();
        private Queue<Order> _orders = new Queue<Order>();

        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn.");
        }
        public void ShowMenu()
        {
            // Visar menyn
            Console.WriteLine("Meny: ");
            for (int i = 0; i < _menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_menu[i].Name} - {_menu[i].Price:C}"); // skriver ut menyval med siffra och pris
            }
        }
        public void CreateOrder(Order order)
        {
            // skapar ordern
            _orders.Enqueue(order);
            Console.WriteLine($"Beställning nr {order._orderId} har lagts till");
        }
        public void HandleOrder()
        {
            // tar bort efter att en meny har skrivits ut
            Order order = _orders.Dequeue();
            Console.WriteLine($"Order {order._orderId} färdig.");
        }
        // visar order som inte är färdiga
        public void ShowOrders()
        {
            Console.WriteLine("Aktuella beställningar:");
            foreach (var order in _orders)
            {
                Console.WriteLine(order);
                Console.WriteLine();
            }
        }
        // visar nästa order som är i kön
        public void ShowNextOrder()
        {
            //Order order = _orders.Peek();
            Console.WriteLine($"Nästa order i kön:\n{_orders.Peek()}");
        }
        // skriver ut hur många order som är i kön
        public void ShowOrderCount()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine($"Det finns inga ordrar i kön. ");
            }
            else if (_orders.Count == 1)
            {
                Console.WriteLine($"Det är {_orders.Count} order i kön. ");
            }
            else if (_orders.Count > 1)
            {
                Console.WriteLine($"Det är {_orders.Count} ordrar i kön. ");
            }
        }
    }
}
