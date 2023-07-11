using Lab3.Models;

namespace Lab3.Logic
{
    public class ProductManage
    {
        public static List<Product> GetProductByCategory(int categoryId, int startInx, int pageSize)
        {
            var context = new NorthwindContext();
            if (categoryId == 0) return context.Products.Skip(startInx - 1).Take(pageSize).Where(x => x.UnitsInStock > 0).ToList();
            else
                return context.Products.Where(x => x.CategoryId == categoryId).Skip(startInx - 1).Take(pageSize).Where(x => x.UnitsInStock > 0).ToList();
        }

        public static int GetTotalProductsInCategory(int id)
        {
            var context = new NorthwindContext();
            if (id == 0) return context.Products.Count();
            else
                return context.Products.Where(x => x.CategoryId == id).Count();
        }

        public static Product GetProductById(int id)
        {
            var context = new NorthwindContext();
            return context.Products.Where(x => x.ProductId == id).FirstOrDefault();
        }
    }
}
