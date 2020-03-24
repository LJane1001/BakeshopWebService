using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productsubsystem.Concrete;
using Productsubsystem.Interface;
using Productsubsystem.Model;

namespace BakeshopService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BakeshopController : ControllerBase
    {
        IProductProvider _productProvider;

        public BakeshopController()
        {
            _productProvider = new ProductProvider();
        }

        [HttpGet("{isAuthenticated}", Name = "AuthenticateUser")]
        public bool AuthenticateUser(bool isAuthenticated)
        {
            return !isAuthenticated;
        }

        [HttpGet(Name = "GetProducts")]
        public List<ProductModel> GetProducts()
        {
            return _productProvider.GetProducts();
        }

        // POST: api/Bakeshop
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Bakeshop/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
