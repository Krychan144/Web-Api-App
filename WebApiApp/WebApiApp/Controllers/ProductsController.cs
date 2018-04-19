using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class ProductsController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product{Id = 1, Name = "Ketchup", Catergory = "Groceries", Price = 1},
            new Product{Id = 2, Name = "Yo-Yo", Catergory = "Toys", Price = 3.4M},
            new Product{Id = 3, Name = "Hammer", Catergory = "Hardware", Price = 19.99M}
        };

        // GET: api/Products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // GET: api/Products/5
        public IHttpActionResult GetProfuct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}