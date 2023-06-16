using Ardalis.Specification.EntityFrameworkCore;
using Ardalis_2.Data;
using Ardalis_2.Models;
using Ardalis_2.specification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ardalis_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly DataContext dataContext;
        private readonly IConfiguration _configuration;

        public HeroController(DataContext dataContext, IConfiguration configuration)
        {
            this.dataContext = dataContext;
            _configuration = configuration;

        }
        [HttpGet]
        public List<Customers> GetCustomers(int id)
        {
            var specification = new FetchById(id);

            var customer = dataContext.Customers
                .WithSpecification(specification)
                .ToList();
            return customer;
        }


    }
}