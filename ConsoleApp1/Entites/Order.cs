using ConsoleApp4.Entites.Enum;
using System.Globalization;
using System.Text;

namespace ConsoleApp4.Entites
{
    class Order
    {
        public DateTime date { get; set; }
        public OrderStatus status { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public Order() {}
        public Order(DateTime date, OrderStatus status, Client client)
        {
            this.date = date;
            this.status = status;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + date);
            sb.AppendLine("Order status: " + status);
            sb.AppendLine("Client: " + client.name + " " + client.birthDate + " - " + client.email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}