using Lab3.Logic;
using Lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using Microsoft.AspNetCore.Http;


//Request.Form["Name"];


namespace Lab3.Controllers
{
    public class ProductController : Controller
    {

        private readonly IConfiguration configuration;
        public ProductController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public IActionResult Index(int id, int page)
        {
            using (var context = new NorthwindContext())
            {
                ViewBag.categories = CategoryManage.GetAllCategories();

                if (page <= 0) page = 1;
                int PageSize = Convert.ToInt32(configuration.GetValue<string>("AppSettings:PageSize"));
                List<Product> products = ProductManage.GetProductByCategory(id, (page - 1) * PageSize + 1, PageSize);
                int totalProducts = ProductManage.GetTotalProductsInCategory(id);
                int totalPage = totalProducts / PageSize;
                if (totalProducts % PageSize != 0) totalPage++;

                ViewData["totalPage"] = totalPage;
                ViewData["currentCateId"] = id;
                ViewData["currentPage"] = page;

                return View(products);
            }
        }

        public IActionResult List(int id, int page)
        {
            using(var context = new NorthwindContext())
            {
                ViewBag.categories = CategoryManage.GetAllCategories();

                if (page <= 0) page = 1;
                int PageSize = Convert.ToInt32(configuration.GetValue<string>("AppSettings:PageSize"));
                List<Product> products = ProductManage.GetProductByCategory(id, (page - 1) * PageSize + 1, PageSize);
                int totalProducts = ProductManage.GetTotalProductsInCategory(id);
                int totalPage = totalProducts / PageSize;
                if (totalProducts % PageSize != 0) totalPage++;

                ViewData["totalPage"] = totalPage;
                ViewData["currentCateId"] = id;
                ViewData["currentPage"] = page;

                return View(products);
            }
        }
    }
}
