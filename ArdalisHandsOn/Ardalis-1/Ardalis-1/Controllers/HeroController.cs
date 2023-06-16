using Ardalis_1.Data;
using Ardalis_1.Models;
using Ardalis_1.Repositories;
using Ardalis_1.Repositories.Interfaces;
using Ardalis_1.Repositories.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace Ardalis_1.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class HeroController : ControllerBase
        {
            private readonly DataContext dataContext;
            private readonly IConfiguration _configuration;
        private readonly IHeroRepository repository;

        public HeroController(DataContext dataContext, IConfiguration configuration, IHeroRepository repository)
            {
                this.dataContext = dataContext;
                _configuration = configuration;
            this.repository = repository;

        }
        [HttpGet]
        public List<Hero> GetHeroes( bool isAlive, bool isAvenger)
            {
                var specification = new HeroByIsAliveAndIsAvengerSpec(isAlive, isAvenger);

                return repository.GetAllHeroes(specification);
            }


         }
}
