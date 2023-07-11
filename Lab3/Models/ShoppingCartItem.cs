namespace Lab3.Models
{
    public class ShoppingCartItem : OrderDetail
    {
        public string ProductName { get; set; }
        public double TotalMoney { get; set; }
    }
}
