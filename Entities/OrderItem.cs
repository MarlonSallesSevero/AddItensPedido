using System.Text;
using System.Globalization;
namespace ExercicioProposto.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public OrderItem()
        {

        }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public double SubTotal()
        {
            return Total = Product.Price * Quantity;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Product.Name}, ${Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantity}, subtotal = {Total.ToString("F2", CultureInfo.InvariantCulture)}\n");
            return sb.ToString();
        }
    }
}
