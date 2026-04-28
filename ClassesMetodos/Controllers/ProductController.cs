using Microsoft.AspNetCore.Mvc;
using Repository;
using Model;
namespace ClassesMetodos.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _ProductRepository;

        public ProductController()
        {
            _ProductRepository = new ProductRepository();
        }
        public IActionResult Index()
        {
            Object objeto = new object();
            // var product = _ProductRepository.GetById(1);
            // var products = _ProductRepository.GetByName("Trembolona");

            var products = _ProductRepository.GetAll();

            // Products.Add(Product);
            // Products.Add((Product)objeto);


            return View(products);
        }

    }
}
