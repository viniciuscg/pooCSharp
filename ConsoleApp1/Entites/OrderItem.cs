using System.Diagnostics;
using System.Globalization;

namespace ConsoleApp4.Entites
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem() { }
        public OrderItem(int quantity, double price, Product product)
        {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }
        public double SubTotal()
        {
            return quantity * price;
        }
        public override string ToString()
        {
            return product.name
            + ", $"
                + price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}