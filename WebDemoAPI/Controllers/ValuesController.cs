using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;

namespace WebDemoAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/values")]
    public class ValuesController : ApiController
    {
        Product[] products = new Product[]
          {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
          };
        // GET api/values
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException("");
            //return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        //public string Get(int id) { return "value"; }
        // POST api/values
        public void Post([FromBody] string value) { }
        // PUT api/values/5
        public void Put(int id, [FromBody] string value) { }
        // DELETE api/values/5
        public void Delete(int id) { }


        [Route("api/GetAllProducts/{id}/{Name}")]
        public IEnumerable<Product> GetAllProducts(int id)
        {
            return products.Where(a => a.Id.Equals(id));
        }
        [HttpPost]
        [Route("api/AddProducts")]
        //[Route("api/books/{id:int}")]
        public IEnumerable<Product> AddProducts(Product Product)
        {

            return products;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
