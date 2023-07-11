using Lab3.Models;

namespace Lab3.Logic
{
    public class CategoryManage
    {
        public static List<Category> GetAllCategories()
        {
            var context = new NorthwindContext();
            return context.Categories.ToList();
        }
    }
}
