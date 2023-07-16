using Lab3.Logic;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ShoppingCartController : Controller
    {
        [HttpPost]
        public IActionResult AddToCart(int productId, int number)
        {
            List<ShoppingCartItem> cart = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            OrderDetail existingItem = cart.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += (short)number;
            }
            else
            {
                Product product = ProductManage.GetProductById(productId);

                if (product != null)
                {
                    ShoppingCartItem newItem = new ShoppingCartItem
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        UnitPrice = (decimal)product.UnitPrice,
                        Quantity = (short)number

                    };
                    newItem.TotalMoney = Convert.ToDouble(number * (float)product.UnitPrice - (float)product.UnitPrice * newItem.Discount * number);
                    cart.Add(newItem);
                }
            }

            HttpContext.Session.Set("Cart", cart);

            return RedirectToAction("Cart");
        }

        public IActionResult Cart()
        {
            List<ShoppingCartItem> cart = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
            return View(cart);
        }


        [HttpPost]
        public IActionResult Remove(int productId)
        {
            List<ShoppingCartItem> cart = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            ShoppingCartItem existingItem = cart.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                cart.Remove(existingItem);
            }

            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.Set("Cart", cart);
            }

            return RedirectToAction("Cart");
        }

        public IActionResult ConfirmInformation()
        {
            using (var context = new NorthwindContext())
            {
                ViewBag.employees = context.Employees.ToList();
                ViewBag.shippers = context.Shippers.ToList();
                List<ShoppingCartItem> cart = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
                return View(cart);
            }
        }

        public IActionResult CheckOut(Order order)
        {
            order.OrderDate = DateTime.Now;
            order.OrderDetails = new List<OrderDetail>();
            List<ShoppingCartItem> cart = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
            foreach (ShoppingCartItem item in cart)
            {
                order.OrderDetails.Add((OrderDetail)item);
            }
            OrderManage.InsertOrder(order);
            HttpContext.Session.Remove("Cart");
            return Redirect("/Product/List");
        }
    }
}
