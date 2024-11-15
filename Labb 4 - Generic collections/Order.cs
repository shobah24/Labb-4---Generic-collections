namespace Labb_4___Generic_collections
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        public int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
        public void Add(MenuItem menuItem)
        {
            _orderItems.Add(menuItem);
        }
        public override string ToString()
        {   
            // räknar ut totala summan för varje order
            decimal totalOrderCost = 0;
            foreach (var cost in _orderItems)
            {   
                totalOrderCost += cost.Price;
            }

            string totalItemInOrder = "";
            foreach (var totalItem in _orderItems)
            {
                totalItemInOrder += $"{totalItem.Name}\n";
            }
            string ItemsInOrder = string.Join("\n", _orderItems);
            return ($"Order {_orderId}:\n" +
                $"{totalItemInOrder}" +
                $"Summa: {totalOrderCost:C}\n" +
                $"Till bord nummer {_tableNumber}");
        }
    }
}
