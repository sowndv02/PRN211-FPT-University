using Lab3.Models;

namespace Lab3.Logic
{
    public class OrderManage
    {
        public static void InsertOrder(Order order)
        {
            using(var context = new NorthwindContext()) 
            {
                order.OrderDate = DateTime.Now; 
                context.Orders.Add(order);
                foreach(OrderDetail detail in order.OrderDetails)
                {
                    Product p = context.Products.Where(x => x.ProductId == detail.ProductId).FirstOrDefault();
                    p.UnitsInStock -= detail.Quantity;
                    p.UnitsOnOrder += detail.Quantity;

                }
                context.OrderDetails.AddRange(order.OrderDetails);
                context.SaveChanges();
            }
        }
    }
}
